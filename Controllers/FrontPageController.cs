using Microsoft.AspNetCore.Mvc;
using RelatudeFishingShop.Helpers;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.RelatudeFishingShop;

namespace RelatudeFishingShop.Controllers {
    public class FrontPageController : Controller {

        WAFNativeContext _ctx;
        public FrontPageController(WAFNativeContext ctx) {
            _ctx = ctx;
        }
        public IActionResult Index() {
            var model = new List<ModuleBase>();
            var page = _ctx.Request.GetContent<HierarchicalContent>();
            if (page is FrontPage) {
                model = ((FrontPage)page).Modules.Get();
            } else if (page is ModuleBase) {
                model.Add(page as ModuleBase);
            }

           // SiteHelper.SetViewBag(ViewBag, page);
            return View(model);
        }
    }
}
