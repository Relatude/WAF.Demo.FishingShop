using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Helpers;
using WAF.API.Web;
using WAF.Engine.Content.Native;

namespace RelatudeFishingShop.Controllers {
    public class ProductCategoryController : Controller {

        WAFNativeContext _ctx;
        public ProductCategoryController(WAFNativeContext ctx) {
            _ctx = ctx;
        }

        public IActionResult Index() {
            var model = _ctx.Request.GetContent<ProductCategory>();
            
            return View(model);
        }
    }
}
