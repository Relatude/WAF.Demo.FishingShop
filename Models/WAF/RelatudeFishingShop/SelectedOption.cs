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
    public partial class SelectedOption: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _categoryName;
        public virtual string CategoryName {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("c796ab5b-e43f-4e58-b1b6-fc157a887d1f"), ref _categoryName, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("c796ab5b-e43f-4e58-b1b6-fc157a887d1f"), ref _categoryName, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _selectedOptionName;
        public virtual string SelectedOptionName {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5cbea149-e6cc-4cd5-bc1b-7b51ebde9bad"), ref _selectedOptionName, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5cbea149-e6cc-4cd5-bc1b-7b51ebde9bad"), ref _selectedOptionName, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FloatPropertyValue _selectedOptionPrice;
        public virtual double SelectedOptionPrice {
        get { return FloatPropertyValue.GetValue(WAFID.GetDataValueId("aed0112f-0c23-48f0-a453-5afe9cd71dfe"), ref _selectedOptionPrice, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); FloatPropertyValue.SetValue(WAFID.GetDataValueId("aed0112f-0c23-48f0-a453-5afe9cd71dfe"), ref _selectedOptionPrice, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("4e9ae475-0ac8-49aa-bc98-bb730b26b8be");
            }
        }

        public static int PropertyIdCategoryName {
            get {
                return WAFID.GetPropertyId("94ed6f0f-9bc8-4d04-8c13-eb005e19e788");
            }
        }

        public static int DataValueIdCategoryNameCategoryName {
            get {
                return WAFID.GetDataValueId("c796ab5b-e43f-4e58-b1b6-fc157a887d1f");
            }
        }

        public static int PropertyIdSelectedOptionName {
            get {
                return WAFID.GetPropertyId("59b72926-56ea-4c58-805e-7bc22c288a5d");
            }
        }

        public static int DataValueIdSelectedOptionNameSelectedOptionName {
            get {
                return WAFID.GetDataValueId("5cbea149-e6cc-4cd5-bc1b-7b51ebde9bad");
            }
        }

        public static int PropertyIdSelectedOptionPrice {
            get {
                return WAFID.GetPropertyId("73ba6e7c-341e-4bfe-beac-992df4393190");
            }
        }

        public static int DataValueIdSelectedOptionPriceSelectedOptionPrice {
            get {
                return WAFID.GetDataValueId("aed0112f-0c23-48f0-a453-5afe9cd71dfe");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("94ed6f0f-9bc8-4d04-8c13-eb005e19e788")) {
                object init = CategoryName;
                return _categoryName;
            }
            else if (propertyId == WAFID.GetPropertyId("59b72926-56ea-4c58-805e-7bc22c288a5d")) {
                object init = SelectedOptionName;
                return _selectedOptionName;
            }
            else if (propertyId == WAFID.GetPropertyId("73ba6e7c-341e-4bfe-beac-992df4393190")) {
                object init = SelectedOptionPrice;
                return _selectedOptionPrice;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _categoryName = null;
            _selectedOptionName = null;
            _selectedOptionPrice = null;
            base.ResetPropertyValues();
        }
    }
}
