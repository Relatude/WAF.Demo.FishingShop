using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;

namespace RelatudeFishingShop.Models.ViewModels
{
    public class SearchViewModel
    {
        public ArticleBase Page { get; set; }
        public List<HierarchicalContent> Result { get; set; }
        public int CurrentPage { get; set; }
        public int PageTotal { get; set; }
        public bool ShowNext { get; set; }
        public bool ShowPrev { get; set; }
        public string NextUrl { get; set; }
        public string PrevUrl { get; set; }
    }
}