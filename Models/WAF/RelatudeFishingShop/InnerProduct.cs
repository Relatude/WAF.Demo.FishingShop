// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.RelatudeFishingShop;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.RelatudeFishingShop {
    [Serializable]
    public partial class InnerProduct: WAF.Engine.Content.InnerContentBase {
        NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Product> _product;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Product> Product{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Product>.GetPropValue(WAFID.GetDataValueId("41d81bd6-4739-4522-a6fa-61033374f4b9"), ref _product, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("2e34c7e4-41f5-4b43-93b3-2b7b5e5b163e");
            }
        }

        public static int PropertyIdProduct {
            get {
                return WAFID.GetPropertyId("bf6a064e-acf3-4c20-bb08-1d0a0f75b5d9");
            }
        }

        public static int DataValueIdProductProduct {
            get {
                return WAFID.GetDataValueId("41d81bd6-4739-4522-a6fa-61033374f4b9");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("bf6a064e-acf3-4c20-bb08-1d0a0f75b5d9")) {
                object init = Product;
                return _product;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _product = null;
            base.ResetPropertyValues();
        }
    }
}
