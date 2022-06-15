using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Helpers;
using WAF.API.Web;
using WAF.Engine.Content.Native;

namespace RelatudeFishingShop.Controllers {
    public class ProductController : Controller {

        WAFNativeContext _ctx;
        public ProductController(WAFNativeContext ctx) {
            _ctx = ctx;
        }
        public IActionResult Index() {
            var model = _ctx.Request.GetContent<ProductBase>();
          //  SiteHelper.SetViewBag(ViewBag, model);
            return View(model);
        }
    }
}
