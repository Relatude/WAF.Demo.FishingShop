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
    public partial class ProductsModule: WAF.Engine.Content.RelatudeFishingShop.ModuleBase {
        ShortStringPropertyValue _header;
        public virtual string Header {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("637e9893-4202-4b3f-b076-7ae32c24ef57"), ref _header, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("637e9893-4202-4b3f-b076-7ae32c24ef57"), ref _header, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.ProductBase> _products;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.ProductBase> Products{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.ProductBase>.GetValue(WAFID.GetDataValueId("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55"), ref _products, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ProductsModule>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ProductsModule>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ProductsModule>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d");
            }
        }

        public static int PropertyIdHeader {
            get {
                return WAFID.GetPropertyId("f1a60762-1131-4242-8e88-71229fcea4e9");
            }
        }

        public static int DataValueIdHeaderHeader {
            get {
                return WAFID.GetDataValueId("637e9893-4202-4b3f-b076-7ae32c24ef57");
            }
        }

        public static int PropertyIdProducts {
            get {
                return WAFID.GetPropertyId("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("f1a60762-1131-4242-8e88-71229fcea4e9")) {
                object init = Header;
                return _header;
            }
            else if (propertyId == WAFID.GetPropertyId("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55")) {
                object init = Products;
                return _products;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _header = null;
            _products = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlProductsModule {
        public static SqlTable Table {
            get {
                return new SqlTable("products_module", WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString Header {
                get {
                    return new SqlFieldShortString("header", Table, WAFID.GetDataValueId("637e9893-4202-4b3f-b076-7ae32c24ef57"));
                }
            }

        }
    }
    public class SqlAliasProductsModule : SqlAlias {
        public SqlAliasProductsModule()
            : base(SqlProductsModule.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlProductsModule.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString Header {
            get {
                return new SqlExpressionFieldShortString(SqlProductsModule.Field.Header, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlProductsModule{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")); 
            }
        }

        public static AqlPropertyShortString Header {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlProductsModule.Field.Header, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyRelation Products {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55"), new AqlAliasRelation(new WAF.Engine.Query.RelatudeFishingShop.AqlAliasProductsModule(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.RelatudeFishingShop.AqlRelProductModuleProduct.Relation));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25"), new AqlAliasRelation(new WAF.Engine.Query.RelatudeFishingShop.AqlAliasFrontPage(), new WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase(), WAF.Engine.Query.RelatudeFishingShop.AqlRelModulePageModuleBase.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasProductsModule
        : WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase{

        public AqlAliasProductsModule()
            : base(WAFID.GetContentClassId("512a493c-2d5f-4f3d-9a9e-16033f665f4d")) {

        }

        public AqlAliasProductsModule(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString Header {
            get {
                return new AqlExpressionPropertyShortString(AqlProductsModule.Header, this);
            }
        }

    }
}
