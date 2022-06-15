using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Models.ViewModels;
using WAF.API.Web;
using WAF.Common;
using WAF.Data;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.RelatudeFishingShop;

namespace RelatudeFishingShop.Controllers {
    public class ShoppingCartController : Controller {

        WAFNativeContext _ctx;
        public ShoppingCartController(WAFNativeContext ctx) {
            _ctx = ctx;
        }
        public IActionResult Index() {
            var order = WAFShopHelper.GetCurrentOrder(this.HttpContext,_ctx.Session);
            return View(order);
        }

        public ActionResult Checkout(string message = null) {
            //SiteHelper.SetViewBag(ViewBag, WAFContext.Request.GetContent<HierarchicalContent>());
            var page = _ctx.Request.GetContent<Article>();
            var shop = WAFShopHelper.GetCurrentShop(_ctx.Session);
            var order = WAFShopHelper.GetCurrentOrder(this.HttpContext,_ctx.Session);
            if (order == null) {
                return View(new CheckoutViewModel { Message = "Klarte ikke å finne ordren, vennligst legg til noe i handlekurven" });
            }

            // Add Shipping Methods
            var shippingMethods = new List<Tuple<int, string, double, bool>>();
            var orderHasShipping = order.ShippingMethod.IsSet();
            if (!orderHasShipping) {
                order.ShippingMethod.Set(shop.ShippingMethods.Get().First());
                order.UpdateChanges();
            }

            var selectedShippingId = order.ShippingMethod.GetId();

            foreach (var shippingMethod in shop.ShippingMethods.Get()) {
                var price = (shippingMethod.GetShippingCalculationProvider().GetShippingAmountExVat(order) * (100 + shop.DefaultTaxRate) / 100);
                shippingMethods.Add(new Tuple<int, string, double, bool>(shippingMethod.NodeId, shippingMethod.Name, price, (selectedShippingId == shippingMethod.NodeId)));
            }

            //Add Payment Methods
            var paymentMethods = new List<Tuple<int, string, bool>>();
            var orderHasPayment = order.PaymentMethod.IsSet();
            if (!orderHasPayment) {
                order.PaymentMethod.Set(shop.PaymentMethods.Get().First());
                order.UpdateChanges();
            }

            var selectedPaymentId = order.PaymentMethod.GetId();

            foreach (var paymentMethod in shop.PaymentMethods.Get()) {
                paymentMethods.Add(new Tuple<int, string, bool>(paymentMethod.NodeId, paymentMethod.Name, (selectedPaymentId == paymentMethod.NodeId)));
            }

            order.CalculateAndSaveAmounts();

            return View(new CheckoutViewModel {
                Page = page,
                Message = message,
                Order = order,
                ShippingMethods = shippingMethods,
                PaymentMethods = paymentMethods
            });
        }

        [HttpPost]
        public ActionResult Checkout(CheckoutViewModel model) {
            try {
                var order = WAFShopHelper.GetCurrentOrder(this.HttpContext,_ctx.Session);
                if (order == null) {
                    return View(new CheckoutViewModel { Message = "Klarte ikke å finne ordren, vennligst legg til noe i handlekurven" });
                }

                var shop = WAFShopHelper.GetCurrentShop(_ctx.Session);

                order.BillingForename = model.Name;
                order.Email = model.Email;
                order.BillingPhone = model.Phone;
                order.BillingAddress = model.Address;
                order.BillingCity = model.City;
                order.BillingZip = model.ZipCode;
                //order.BillingCountry = model.Country;
                order.DateOrdered = DateTime.Now;
                order.OrderStatus = OrderStatus.Ordered;
                order.Notes = model.Comment;

                if (model.Shipping > 0 && _ctx.Session.NodeExists(model.Shipping)) order.ShippingMethod.Set(_ctx.Session.GetContent<ShippingMethod>(model.Shipping));
                if (model.Payment > 0 && _ctx.Session.NodeExists(model.Payment)) order.PaymentMethod.Set(_ctx.Session.GetContent<PaymentMethod>(model.Payment));

                order.UpdateChanges();

                order.CalculateAndSaveAmounts();

                return Redirect(_ctx.GetUrl(shop.OrderReceivedPage.GetId()));
            } catch (Exception e) {
                WAFLog.Insert("ShoppingCart", e);
                return View(new CheckoutViewModel { Message = "Noe gikk galt" });
            }
        }
    }
}
