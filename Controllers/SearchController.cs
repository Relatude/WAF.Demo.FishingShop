using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Data;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.RelatudeFishingShop;

namespace RelatudeFishingShop.Controllers {
    public class SearchController : Controller {

        WAFNativeContext _ctx;
        public SearchController(WAFNativeContext ctx) {
            _ctx = ctx;
        }

        public IActionResult Index(string query, int page = 1, int pageSize = 8) {
            var model = new Models.ViewModels.SearchViewModel() {
                Result = GetSearchResultsVM(query, page, pageSize, out int pageCount),
                CurrentPage = page,
                PageTotal = pageCount,
                ShowNext = pageCount > page,
                ShowPrev = page > 1,
                NextUrl = "#",
                PrevUrl = "#"
            };

            if (model.ShowPrev) model.PrevUrl = Url.Action("Index", "Search", new { query, page = (page - 1) });
            if (model.ShowNext) model.NextUrl = Url.Action("Index", "Search", new { query, page = (page + 1) });

            var cp = _ctx.Session.GetContent<ControlPanel>();
            if (cp.SearchPage.IsSet()) model.Page = cp.SearchPage.Get();

            return View(model);
        }

        private List<HierarchicalContent> GetSearchResultsVM(string query, int page, int pageSize, out int pageCount) {
            var list = new List<HierarchicalContent>();
            query = query.Trim();
            pageCount = 0;

            if (query.Length == 0) return list;

            try {
                if (WAFRuntime.Installation.EnableTextIndex) {
                    var indexQuery = new IndexQuery<HierarchicalContent>();

                    indexQuery.AutoWildcards = true;
                    indexQuery.AutoWildcardsLeading = true;
                    indexQuery.AllowLeadingWildcard = true;
                    indexQuery.ProtectedContent = false;
                    indexQuery.IncludeDeletedVersions = false;
                    indexQuery.IncludeUnPublishedNodes = false;
                    indexQuery.IncludeDerivedVersions = false;
                    indexQuery.InheritedClasses = true;

                    indexQuery.ClassIds = new List<int> {
                        Product.ContentClassId,
                        Article.ContentClassId
                    };

                    indexQuery.BodySearch = query.Trim();

                    int pageIndex = 0;
                    if (page > 1) pageIndex = page - 1;
                    indexQuery.PageIndex = pageIndex;
                    indexQuery.PageSize = pageSize;

                    var result = _ctx.Session.Search(indexQuery, out pageCount, out int totalCount);
                    foreach (var r in result) list.Add(r.Content);

                    return list;
                } else WAFLog.Insert("SearchError", "Feil: Text index er skrudd av");

                return list;
            } catch {
                return list;
            }
        }

    }
}
