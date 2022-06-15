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
    public partial class ControlPanel: WAF.Engine.Content.Native.HierarchicalContent {
        InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent> _header;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent> Header{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent>.GetValue(WAFID.GetDataValueId("825fdc28-5732-480b-9979-5021ce85bd72"), ref _header, this);}
        }
      
        FilePropertyValue _headerLogo;
        public virtual FilePropertyValue HeaderLogo {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("bbc06664-569d-4943-8c0a-1d2d0031b396"),WAFID.GetDataValueId("f34facf0-c247-4802-a418-3c10f9c21640"),WAFID.GetDataValueId("fea79d19-17dd-437c-883b-e162fc6ff619"),WAFID.GetDataValueId("32b449ae-ce40-465f-886a-7570e8f3d906"),WAFID.GetDataValueId("66a96e7c-c6de-4420-89b1-b52858ba6f86"),WAFID.GetDataValueId("3b978bf8-c49c-42bb-98ed-f4e9c293f57a"), ref _headerLogo, this, WAFID.GetDataValueId("b54ed168-846f-4e21-83ac-4dc9af8baa7b")); }
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.ProductCategory> _mainProductCategory;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.ProductCategory> MainProductCategory{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.ProductCategory>.GetPropValue(WAFID.GetDataValueId("5b114b4c-ef9e-478e-b39c-1faf102fc411"), ref _mainProductCategory, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _shoppingCartPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> ShoppingCartPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetPropValue(WAFID.GetDataValueId("b195b66f-db5c-4543-89c8-0ec8504f2036"), ref _shoppingCartPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _checkoutPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> CheckoutPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetPropValue(WAFID.GetDataValueId("8d945694-f5e2-438e-b893-eefc6fdae883"), ref _checkoutPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Article> _searchPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Article> SearchPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.RelatudeFishingShop.Article>.GetPropValue(WAFID.GetDataValueId("40a6f4d9-6da5-4180-ba80-c6f5acbada23"), ref _searchPage, this);}
        }
      
        HTMLPropertyValue _footerInfo;
        public virtual string FooterInfo {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("ad16b69f-0de7-456a-9a80-2ae7b9fc661c"), ref _footerInfo, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("ad16b69f-0de7-456a-9a80-2ae7b9fc661c"), ref _footerInfo, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent> _footer;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent> Footer{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.InnerNodeParent>.GetValue(WAFID.GetDataValueId("7cd8bd97-33dc-40bf-9c9e-26ff2b53cb23"), ref _footer, this);}
        }
      
        FilePropertyValue _footerLogo;
        public virtual FilePropertyValue FooterLogo {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("c09219bc-3434-48e9-bf83-cf2c0e41719f"),WAFID.GetDataValueId("e25bd78c-450a-45c0-aa30-18b16f2eceb0"),WAFID.GetDataValueId("46893031-79d0-427f-b05d-37d09e778338"),WAFID.GetDataValueId("d3ae3fc2-f1a7-4fca-a430-5269d34b2afd"),WAFID.GetDataValueId("441f2c31-8980-4756-bf18-1f67191bb3f5"),WAFID.GetDataValueId("6e12d291-157f-494d-b5d7-a96672178f86"), ref _footerLogo, this, WAFID.GetDataValueId("5ad9af94-7324-4f2e-a8ab-4774083d1b27")); }
        }
      
        LinkPropertyValue _instagram;
        public virtual LinkPropertyValue Instagram {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("a9e1be71-9e8f-45d7-9c32-1a42b08b89f6"), ref _instagram, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _facebook;
        public virtual LinkPropertyValue Facebook {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("4d7d5ae7-cf56-4ea8-a575-5d6a79ea4afa"), ref _facebook, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _twitter;
        public virtual LinkPropertyValue Twitter {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("8c3c8b82-ff59-466c-aeca-b8ba10e7110c"), ref _twitter, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ControlPanel>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ControlPanel>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ControlPanel>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7");
            }
        }

        public static int PropertyIdHeader {
            get {
                return WAFID.GetPropertyId("825fdc28-5732-480b-9979-5021ce85bd72");
            }
        }

        public static int PropertyIdHeaderLogo {
            get {
                return WAFID.GetPropertyId("b54ed168-846f-4e21-83ac-4dc9af8baa7b");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoFilename {
            get {
                return WAFID.GetDataValueId("f34facf0-c247-4802-a418-3c10f9c21640");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoTypeName {
            get {
                return WAFID.GetDataValueId("fea79d19-17dd-437c-883b-e162fc6ff619");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoExtension {
            get {
                return WAFID.GetDataValueId("32b449ae-ce40-465f-886a-7570e8f3d906");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoBytes {
            get {
                return WAFID.GetDataValueId("66a96e7c-c6de-4420-89b1-b52858ba6f86");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoInfo {
            get {
                return WAFID.GetDataValueId("3b978bf8-c49c-42bb-98ed-f4e9c293f57a");
            }
        }

        public static int DataValueIdHeaderLogoHeaderLogoInt {
            get {
                return WAFID.GetDataValueId("bbc06664-569d-4943-8c0a-1d2d0031b396");
            }
        }

        public static int PropertyIdMainProductCategory {
            get {
                return WAFID.GetPropertyId("9b0f7b06-7665-4df5-8ae6-d1f6b4a2aa9a");
            }
        }

        public static int DataValueIdMainProductCategoryMainProductCategory {
            get {
                return WAFID.GetDataValueId("5b114b4c-ef9e-478e-b39c-1faf102fc411");
            }
        }

        public static int PropertyIdShoppingCartPage {
            get {
                return WAFID.GetPropertyId("8ebc0655-1dc7-474c-8a4e-2953665348af");
            }
        }

        public static int DataValueIdShoppingCartPageShoppingCartPage {
            get {
                return WAFID.GetDataValueId("b195b66f-db5c-4543-89c8-0ec8504f2036");
            }
        }

        public static int PropertyIdCheckoutPage {
            get {
                return WAFID.GetPropertyId("8aa12960-fb6a-4b7d-8381-1da335e50c6f");
            }
        }

        public static int DataValueIdCheckoutPageCheckoutPage {
            get {
                return WAFID.GetDataValueId("8d945694-f5e2-438e-b893-eefc6fdae883");
            }
        }

        public static int PropertyIdSearchPage {
            get {
                return WAFID.GetPropertyId("a4625963-817e-4a7e-b22e-b3713c2b773e");
            }
        }

        public static int DataValueIdSearchPageSearchPage {
            get {
                return WAFID.GetDataValueId("40a6f4d9-6da5-4180-ba80-c6f5acbada23");
            }
        }

        public static int PropertyIdFooterInfo {
            get {
                return WAFID.GetPropertyId("3b2f9778-ff9b-4a65-954f-5ec68bcaed0f");
            }
        }

        public static int DataValueIdFooterInfoFooterInfo {
            get {
                return WAFID.GetDataValueId("ad16b69f-0de7-456a-9a80-2ae7b9fc661c");
            }
        }

        public static int PropertyIdFooter {
            get {
                return WAFID.GetPropertyId("7cd8bd97-33dc-40bf-9c9e-26ff2b53cb23");
            }
        }

        public static int PropertyIdFooterLogo {
            get {
                return WAFID.GetPropertyId("5ad9af94-7324-4f2e-a8ab-4774083d1b27");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoFilename {
            get {
                return WAFID.GetDataValueId("e25bd78c-450a-45c0-aa30-18b16f2eceb0");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoTypeName {
            get {
                return WAFID.GetDataValueId("46893031-79d0-427f-b05d-37d09e778338");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoExtension {
            get {
                return WAFID.GetDataValueId("d3ae3fc2-f1a7-4fca-a430-5269d34b2afd");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoBytes {
            get {
                return WAFID.GetDataValueId("441f2c31-8980-4756-bf18-1f67191bb3f5");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoInfo {
            get {
                return WAFID.GetDataValueId("6e12d291-157f-494d-b5d7-a96672178f86");
            }
        }

        public static int DataValueIdFooterLogoFooterLogoInt {
            get {
                return WAFID.GetDataValueId("c09219bc-3434-48e9-bf83-cf2c0e41719f");
            }
        }

        public static int PropertyIdInstagram {
            get {
                return WAFID.GetPropertyId("35e65af1-3259-456b-90d3-3857da62d14a");
            }
        }

        public static int DataValueIdInstagramInstagram {
            get {
                return WAFID.GetDataValueId("a9e1be71-9e8f-45d7-9c32-1a42b08b89f6");
            }
        }

        public static int PropertyIdFacebook {
            get {
                return WAFID.GetPropertyId("a1b29b53-9e5d-4fb8-a6fa-56d2586d7eeb");
            }
        }

        public static int DataValueIdFacebookFacebook {
            get {
                return WAFID.GetDataValueId("4d7d5ae7-cf56-4ea8-a575-5d6a79ea4afa");
            }
        }

        public static int PropertyIdTwitter {
            get {
                return WAFID.GetPropertyId("8a2f79b6-4b8f-4b79-b082-224c59e20389");
            }
        }

        public static int DataValueIdTwitterTwitter {
            get {
                return WAFID.GetDataValueId("8c3c8b82-ff59-466c-aeca-b8ba10e7110c");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("825fdc28-5732-480b-9979-5021ce85bd72")) {
                object init = Header;
                return _header;
            }
            else if (propertyId == WAFID.GetPropertyId("b54ed168-846f-4e21-83ac-4dc9af8baa7b")) {
                object init = HeaderLogo;
                return _headerLogo;
            }
            else if (propertyId == WAFID.GetPropertyId("9b0f7b06-7665-4df5-8ae6-d1f6b4a2aa9a")) {
                object init = MainProductCategory;
                return _mainProductCategory;
            }
            else if (propertyId == WAFID.GetPropertyId("8ebc0655-1dc7-474c-8a4e-2953665348af")) {
                object init = ShoppingCartPage;
                return _shoppingCartPage;
            }
            else if (propertyId == WAFID.GetPropertyId("8aa12960-fb6a-4b7d-8381-1da335e50c6f")) {
                object init = CheckoutPage;
                return _checkoutPage;
            }
            else if (propertyId == WAFID.GetPropertyId("a4625963-817e-4a7e-b22e-b3713c2b773e")) {
                object init = SearchPage;
                return _searchPage;
            }
            else if (propertyId == WAFID.GetPropertyId("3b2f9778-ff9b-4a65-954f-5ec68bcaed0f")) {
                object init = FooterInfo;
                return _footerInfo;
            }
            else if (propertyId == WAFID.GetPropertyId("7cd8bd97-33dc-40bf-9c9e-26ff2b53cb23")) {
                object init = Footer;
                return _footer;
            }
            else if (propertyId == WAFID.GetPropertyId("5ad9af94-7324-4f2e-a8ab-4774083d1b27")) {
                object init = FooterLogo;
                return _footerLogo;
            }
            else if (propertyId == WAFID.GetPropertyId("35e65af1-3259-456b-90d3-3857da62d14a")) {
                object init = Instagram;
                return _instagram;
            }
            else if (propertyId == WAFID.GetPropertyId("a1b29b53-9e5d-4fb8-a6fa-56d2586d7eeb")) {
                object init = Facebook;
                return _facebook;
            }
            else if (propertyId == WAFID.GetPropertyId("8a2f79b6-4b8f-4b79-b082-224c59e20389")) {
                object init = Twitter;
                return _twitter;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _header = null;
            _headerLogo = null;
            _mainProductCategory = null;
            _shoppingCartPage = null;
            _checkoutPage = null;
            _searchPage = null;
            _footerInfo = null;
            _footer = null;
            _footerLogo = null;
            _instagram = null;
            _facebook = null;
            _twitter = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlControlPanel {
        public static SqlTable Table {
            get {
                return new SqlTable("control_panel", WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString HeaderLogo_header_logo_filename {
                get {
                    return new SqlFieldShortString("header_logo_filename", Table, WAFID.GetDataValueId("f34facf0-c247-4802-a418-3c10f9c21640"));
                }
            }

            public static SqlFieldShortString HeaderLogo_header_logo_type_name {
                get {
                    return new SqlFieldShortString("header_logo_type_name", Table, WAFID.GetDataValueId("fea79d19-17dd-437c-883b-e162fc6ff619"));
                }
            }

            public static SqlFieldShortString HeaderLogo_header_logo_extension {
                get {
                    return new SqlFieldShortString("header_logo_extension", Table, WAFID.GetDataValueId("32b449ae-ce40-465f-886a-7570e8f3d906"));
                }
            }

            public static SqlFieldFloat HeaderLogo_header_logo_bytes {
                get {
                    return new SqlFieldFloat("header_logo_bytes", Table, WAFID.GetDataValueId("66a96e7c-c6de-4420-89b1-b52858ba6f86"));
                }
            }

            public static SqlFieldLongString HeaderLogo_header_logo_info {
                get {
                    return new SqlFieldLongString("header_logo_info", Table, WAFID.GetDataValueId("3b978bf8-c49c-42bb-98ed-f4e9c293f57a"));
                }
            }

            public static SqlFieldInteger HeaderLogo_header_logo_int {
                get {
                    return new SqlFieldInteger("header_logo_int", Table, WAFID.GetDataValueId("bbc06664-569d-4943-8c0a-1d2d0031b396"));
                }
            }

            public static SqlFieldInteger MainProductCategory {
                get {
                    return new SqlFieldInteger("main_product_category", Table, WAFID.GetDataValueId("5b114b4c-ef9e-478e-b39c-1faf102fc411"));
                }
            }

            public static SqlFieldInteger ShoppingCartPage {
                get {
                    return new SqlFieldInteger("shopping_cart_page", Table, WAFID.GetDataValueId("b195b66f-db5c-4543-89c8-0ec8504f2036"));
                }
            }

            public static SqlFieldInteger CheckoutPage {
                get {
                    return new SqlFieldInteger("checkout_page", Table, WAFID.GetDataValueId("8d945694-f5e2-438e-b893-eefc6fdae883"));
                }
            }

            public static SqlFieldInteger SearchPage {
                get {
                    return new SqlFieldInteger("search_page", Table, WAFID.GetDataValueId("40a6f4d9-6da5-4180-ba80-c6f5acbada23"));
                }
            }

            public static SqlFieldLongString FooterInfo {
                get {
                    return new SqlFieldLongString("footer_info", Table, WAFID.GetDataValueId("ad16b69f-0de7-456a-9a80-2ae7b9fc661c"));
                }
            }

            public static SqlFieldShortString FooterLogo_footer_logo_filename {
                get {
                    return new SqlFieldShortString("footer_logo_filename", Table, WAFID.GetDataValueId("e25bd78c-450a-45c0-aa30-18b16f2eceb0"));
                }
            }

            public static SqlFieldShortString FooterLogo_footer_logo_type_name {
                get {
                    return new SqlFieldShortString("footer_logo_type_name", Table, WAFID.GetDataValueId("46893031-79d0-427f-b05d-37d09e778338"));
                }
            }

            public static SqlFieldShortString FooterLogo_footer_logo_extension {
                get {
                    return new SqlFieldShortString("footer_logo_extension", Table, WAFID.GetDataValueId("d3ae3fc2-f1a7-4fca-a430-5269d34b2afd"));
                }
            }

            public static SqlFieldFloat FooterLogo_footer_logo_bytes {
                get {
                    return new SqlFieldFloat("footer_logo_bytes", Table, WAFID.GetDataValueId("441f2c31-8980-4756-bf18-1f67191bb3f5"));
                }
            }

            public static SqlFieldLongString FooterLogo_footer_logo_info {
                get {
                    return new SqlFieldLongString("footer_logo_info", Table, WAFID.GetDataValueId("6e12d291-157f-494d-b5d7-a96672178f86"));
                }
            }

            public static SqlFieldInteger FooterLogo_footer_logo_int {
                get {
                    return new SqlFieldInteger("footer_logo_int", Table, WAFID.GetDataValueId("c09219bc-3434-48e9-bf83-cf2c0e41719f"));
                }
            }

            public static SqlFieldShortString Instagram {
                get {
                    return new SqlFieldShortString("instagram", Table, WAFID.GetDataValueId("a9e1be71-9e8f-45d7-9c32-1a42b08b89f6"));
                }
            }

            public static SqlFieldShortString Facebook {
                get {
                    return new SqlFieldShortString("facebook", Table, WAFID.GetDataValueId("4d7d5ae7-cf56-4ea8-a575-5d6a79ea4afa"));
                }
            }

            public static SqlFieldShortString Twitter {
                get {
                    return new SqlFieldShortString("twitter", Table, WAFID.GetDataValueId("8c3c8b82-ff59-466c-aeca-b8ba10e7110c"));
                }
            }

        }
    }
    public class SqlAliasControlPanel : SqlAlias {
        public SqlAliasControlPanel()
            : base(SqlControlPanel.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString HeaderLogo_header_logo_filename {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.HeaderLogo_header_logo_filename, this);
            }
        }

        public SqlExpressionFieldShortString HeaderLogo_header_logo_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.HeaderLogo_header_logo_type_name, this);
            }
        }

        public SqlExpressionFieldShortString HeaderLogo_header_logo_extension {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.HeaderLogo_header_logo_extension, this);
            }
        }

        public SqlExpressionFieldFloat HeaderLogo_header_logo_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlControlPanel.Field.HeaderLogo_header_logo_bytes, this);
            }
        }

        public SqlExpressionFieldLongString HeaderLogo_header_logo_info {
            get {
                return new SqlExpressionFieldLongString(SqlControlPanel.Field.HeaderLogo_header_logo_info, this);
            }
        }

        public SqlExpressionFieldInteger HeaderLogo_header_logo_int {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.HeaderLogo_header_logo_int, this);
            }
        }

        public SqlExpressionFieldInteger MainProductCategory {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.MainProductCategory, this);
            }
        }

        public SqlExpressionFieldInteger ShoppingCartPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ShoppingCartPage, this);
            }
        }

        public SqlExpressionFieldInteger CheckoutPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.CheckoutPage, this);
            }
        }

        public SqlExpressionFieldInteger SearchPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.SearchPage, this);
            }
        }

        public SqlExpressionFieldLongString FooterInfo {
            get {
                return new SqlExpressionFieldLongString(SqlControlPanel.Field.FooterInfo, this);
            }
        }

        public SqlExpressionFieldShortString FooterLogo_footer_logo_filename {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.FooterLogo_footer_logo_filename, this);
            }
        }

        public SqlExpressionFieldShortString FooterLogo_footer_logo_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.FooterLogo_footer_logo_type_name, this);
            }
        }

        public SqlExpressionFieldShortString FooterLogo_footer_logo_extension {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.FooterLogo_footer_logo_extension, this);
            }
        }

        public SqlExpressionFieldFloat FooterLogo_footer_logo_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlControlPanel.Field.FooterLogo_footer_logo_bytes, this);
            }
        }

        public SqlExpressionFieldLongString FooterLogo_footer_logo_info {
            get {
                return new SqlExpressionFieldLongString(SqlControlPanel.Field.FooterLogo_footer_logo_info, this);
            }
        }

        public SqlExpressionFieldInteger FooterLogo_footer_logo_int {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.FooterLogo_footer_logo_int, this);
            }
        }

        public SqlExpressionFieldShortString Instagram {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Instagram, this);
            }
        }

        public SqlExpressionFieldShortString Facebook {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Facebook, this);
            }
        }

        public SqlExpressionFieldShortString Twitter {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Twitter, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlControlPanel{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")); 
            }
        }

        public static AqlPropertyShortString HeaderLogo_header_logo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_filename, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString HeaderLogo_header_logo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_type_name, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString HeaderLogo_header_logo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_extension, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyFloat HeaderLogo_header_logo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_bytes, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyLongString HeaderLogo_header_logo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_info, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger HeaderLogo_header_logo_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.HeaderLogo_header_logo_int, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger MainProductCategory {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.MainProductCategory, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger ShoppingCartPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.ShoppingCartPage, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger CheckoutPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.CheckoutPage, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger SearchPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.SearchPage, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyLongString FooterInfo {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterInfo, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString FooterLogo_footer_logo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_filename, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString FooterLogo_footer_logo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_type_name, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString FooterLogo_footer_logo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_extension, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyFloat FooterLogo_footer_logo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_bytes, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyLongString FooterLogo_footer_logo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_info, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger FooterLogo_footer_logo_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.FooterLogo_footer_logo_int, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString Instagram {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.Instagram, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString Facebook {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.Facebook, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString Twitter {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlControlPanel.Field.Twitter, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasControlPanel
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasControlPanel()
            : base(WAFID.GetContentClassId("f649cb50-47ad-47c0-b3d5-e11087c665f7")) {

        }

        public AqlAliasControlPanel(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString HeaderLogo_header_logo_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.HeaderLogo_header_logo_filename, this);
            }
        }

        public AqlExpressionPropertyShortString HeaderLogo_header_logo_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.HeaderLogo_header_logo_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString HeaderLogo_header_logo_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.HeaderLogo_header_logo_extension, this);
            }
        }

        public AqlExpressionPropertyFloat HeaderLogo_header_logo_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlControlPanel.HeaderLogo_header_logo_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString HeaderLogo_header_logo_info {
            get {
                return new AqlExpressionPropertyLongString(AqlControlPanel.HeaderLogo_header_logo_info, this);
            }
        }

        public AqlExpressionPropertyInteger HeaderLogo_header_logo_int {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.HeaderLogo_header_logo_int, this);
            }
        }

        public AqlExpressionPropertyInteger MainProductCategory {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.MainProductCategory, this);
            }
        }

        public AqlExpressionPropertyInteger ShoppingCartPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.ShoppingCartPage, this);
            }
        }

        public AqlExpressionPropertyInteger CheckoutPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.CheckoutPage, this);
            }
        }

        public AqlExpressionPropertyInteger SearchPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.SearchPage, this);
            }
        }

        public AqlExpressionPropertyLongString FooterInfo {
            get {
                return new AqlExpressionPropertyLongString(AqlControlPanel.FooterInfo, this);
            }
        }

        public AqlExpressionPropertyShortString FooterLogo_footer_logo_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.FooterLogo_footer_logo_filename, this);
            }
        }

        public AqlExpressionPropertyShortString FooterLogo_footer_logo_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.FooterLogo_footer_logo_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString FooterLogo_footer_logo_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.FooterLogo_footer_logo_extension, this);
            }
        }

        public AqlExpressionPropertyFloat FooterLogo_footer_logo_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlControlPanel.FooterLogo_footer_logo_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString FooterLogo_footer_logo_info {
            get {
                return new AqlExpressionPropertyLongString(AqlControlPanel.FooterLogo_footer_logo_info, this);
            }
        }

        public AqlExpressionPropertyInteger FooterLogo_footer_logo_int {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.FooterLogo_footer_logo_int, this);
            }
        }

        public AqlExpressionPropertyShortString Instagram {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Instagram, this);
            }
        }

        public AqlExpressionPropertyShortString Facebook {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Facebook, this);
            }
        }

        public AqlExpressionPropertyShortString Twitter {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Twitter, this);
            }
        }

    }
}
