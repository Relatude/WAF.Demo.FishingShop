using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Helpers;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Common;

namespace RelatudeFishingShop.Controllers {
    public class ShopController : Controller {

        WAFNativeContext _ctx;
        public ShopController(WAFNativeContext ctx) {
            _ctx = ctx;
        }

        public IActionResult Index() {
            //SiteHelper.SetViewBag(ViewBag, _ctx.Request.GetContent<HierarchicalContent>());
            return View();
        }

        public JsonResult AddToCart(int nodeId, int quantity) {
            if (_ctx.Session.NodeExists(nodeId)) {
                if (quantity <= 0) {
                    quantity = 1;
                }

                Order order = WAFShopHelper.GetCurrentOrder(this.HttpContext,_ctx.Session);

                if (order == null) {
                    order = WAFShopHelper.CreateNewOrder(this.HttpContext, _ctx.Session);
                }

                WAFShopHelper.AddProductToCart(nodeId, quantity, order.OrderGuid, _ctx.Session.UserId,_ctx.Session);
                var itemsInCart = order.GetNumberOfItemsInCart();
                return Json(new { success = true, value = itemsInCart });
            }

            return Json(new { success = false, value = 0 });
        }

        public JsonResult UpdateQuantity(int nodeId, int quantity) {
            if (_ctx.Session.NodeExists(nodeId)) {
                Order order = WAFShopHelper.GetCurrentOrder(this.HttpContext, _ctx.Session);
                if (order == null) {
                    order = WAFShopHelper.CreateNewOrder(this.HttpContext, _ctx.Session);
                }

                if (quantity > 0) {
                    WAFShopHelper.UpdateCart(nodeId, quantity,_ctx.Session, this.HttpContext);
                } else {
                    return Json(new { success = false, value = 0 });
                }

                var itemsInCart = order.GetNumberOfItemsInCart();
                order = WAFShopHelper.GetCurrentOrder(this.HttpContext, _ctx.Session);
                var orderItem = order.OrderItems.Get().Where(m => m.NodeId == nodeId).First();
                var price = orderItem.GetItemTotalPriceIncVat(false, _ctx.Session);
                var totalPrice = order.GetCurrentCartPriceIncVat();
                return Json(new { success = true, value = itemsInCart, price, totalprice = totalPrice });
            }

            return Json(new { success = false, value = 0 });
        }

        public JsonResult RemoveFromCart(int nodeId) {
            if (_ctx.Session.NodeExists(nodeId)) {
                Order order = WAFShopHelper.GetCurrentOrder(this.HttpContext, _ctx.Session);
                if (order == null) {
                    order = WAFShopHelper.CreateNewOrder(this.HttpContext, _ctx.Session);
                }

                WAFShopHelper.RemoveFromCart(nodeId, _ctx.Session);
                var itemsInCart = order.GetNumberOfItemsInCart();
                var totalPrice = order.GetCurrentCartPriceIncVat();
                return Json(new { success = true, value = itemsInCart, totalprice = totalPrice });
            }

            return Json(new { success = false, value = 0 });
        }
    }
}
