﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.RelatudeFishingShop;
using WAF.Engine.Content.Native;
using WAF.Presentation.Web;

namespace RelatudeFishingShop.Helpers
{
    public static class SiteHelper
    {
        public static void SetViewBag(dynamic ViewBag, HierarchicalContent model)
        {
            if (!string.IsNullOrEmpty(model.MetaTitle))
            {
                ViewBag.Title = model.MetaTitle;
            }
            else
            {
                ViewBag.Title = model.Name;
            }

            if (!string.IsNullOrEmpty(model.MetaDescription))
            {
                ViewBag.Description = model.MetaDescription;
            }
            else
            {
                if (model is RelatudeFishingShopProductCategory)
                {
                    // Convert to Text
                    ViewBag.Description = ((RelatudeFishingShopProductCategory)model).AutoGeneratedMetaDescription;
                }
                else if (model is Product)
                {
                    ViewBag.Description = ((Product)model).AutoGeneratedMetaDescription;
                }
                else if (model is Article)
                {
                    var article = model as Article;
                    if (!string.IsNullOrEmpty(article.Ingress))
                    {
                        ViewBag.Description = article.Ingress;
                    }
                    else
                    {
                        ViewBag.Description = article.AutoGeneratedMetaDescription;
                    }
                }
            }
        }

        public static List<HierarchicalContent> GetParentList(HierarchicalContent content)
        {
            var parentList = new List<HierarchicalContent>();
            var frontPage = WAFContext.Session.GetSite().StartNode.Get();

            var nodeIds = new List<int>() { frontPage.NodeId };

            var cp = WAFContext.Session.GetContent<ControlPanel>();
            if (cp.CheckoutPage.IsSet()) nodeIds.Add(cp.CheckoutPage.GetId());
            if (cp.ShoppingCartPage.IsSet()) nodeIds.Add(cp.ShoppingCartPage.GetId());

            if (!nodeIds.Contains(content.NodeId))
            {
                var parentTraverser = content;

                while (parentTraverser != null)
                {
                    if (parentTraverser.NodeId == frontPage.NodeId) break;
                    if (parentTraverser.TemplateId > 1) parentList.Add(parentTraverser);
                    if (parentTraverser.Parent.IsSet())
                    {
                        var parent = parentTraverser.Parent.Get();
                        if (parent is Site) break;
                        parentTraverser = parent;
                    }
                    else parentTraverser = null;
                }

                parentList.Add(frontPage as HierarchicalContent);

                parentList.Reverse();
            }

            return parentList;
        }
    }
}