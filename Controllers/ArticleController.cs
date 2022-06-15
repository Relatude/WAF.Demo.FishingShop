using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Helpers;
using WAF.API.Web;
using WAF.Engine.Content.Native;

namespace RelatudeFishingShop.Controllers {
    public class ArticleController : Controller {
        WAFNativeContext _ctx;
        public ArticleController(WAFNativeContext ctx) {
            _ctx = ctx;
        }
        public IActionResult Index() {
            var model = _ctx.Request.GetContent<ArticleBase>();
            SiteHelper.SetViewBag(ViewBag, model);
            return View(model);
        }
    }
}
