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
    public partial class RelatudeFishingShopProductCategory: WAF.Engine.Content.Native.ProductCategory {
        LongStringPropertyValue _autoGeneratedMetaDescription;
        public virtual string AutoGeneratedMetaDescription {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("9b25657d-506f-4f38-b5aa-c3d85323e408"), ref _autoGeneratedMetaDescription, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("9b25657d-506f-4f38-b5aa-c3d85323e408"), ref _autoGeneratedMetaDescription, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<RelatudeFishingShopProductCategory>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<RelatudeFishingShopProductCategory>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<RelatudeFishingShopProductCategory>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a");
            }
        }

        public static int PropertyIdAutoGeneratedMetaDescription {
            get {
                return WAFID.GetPropertyId("043d9832-60f2-4b1f-aa39-304cb74acc33");
            }
        }

        public static int DataValueIdAutoGeneratedMetaDescriptionAutoGeneratedMetaDescription {
            get {
                return WAFID.GetDataValueId("9b25657d-506f-4f38-b5aa-c3d85323e408");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("043d9832-60f2-4b1f-aa39-304cb74acc33")) {
                object init = AutoGeneratedMetaDescription;
                return _autoGeneratedMetaDescription;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _autoGeneratedMetaDescription = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlRelatudeFishingShopProductCategory {
        public static SqlTable Table {
            get {
                return new SqlTable("relatude_fishing_shop_product_category", WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString AutoGeneratedMetaDescription {
                get {
                    return new SqlFieldLongString("auto_generated_meta_description", Table, WAFID.GetDataValueId("9b25657d-506f-4f38-b5aa-c3d85323e408"));
                }
            }

        }
    }
    public class SqlAliasRelatudeFishingShopProductCategory : SqlAlias {
        public SqlAliasRelatudeFishingShopProductCategory()
            : base(SqlRelatudeFishingShopProductCategory.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlRelatudeFishingShopProductCategory.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString AutoGeneratedMetaDescription {
            get {
                return new SqlExpressionFieldLongString(SqlRelatudeFishingShopProductCategory.Field.AutoGeneratedMetaDescription, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlRelatudeFishingShopProductCategory{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")); 
            }
        }

        public static AqlPropertyLongString AutoGeneratedMetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlRelatudeFishingShopProductCategory.Field.AutoGeneratedMetaDescription, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyLongString CategoryDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductCategory.Field.CategoryDescription, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyRelation SubCategories {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("aa3d752a-4fd1-4b84-95d5-4e6c1f436f85"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductCategory(), WAF.Engine.Query.Native.AqlRelProductCategorySubCategory.Relation));
            }
        }

        public static AqlPropertyRelation Products {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("9569bc27-8c8b-4b1b-b5b2-b56150c9bd73"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductCategoryProducts.Relation));
            }
        }

        public static AqlPropertyRelation HighlightedProducts {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("0617f855-9f05-4274-9d15-0a258c1160f4"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductCategoryHighlightedProducts.Relation));
            }
        }

        public static AqlPropertyRelation Shop {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("0aa8f1d7-2a7c-42f6-83a9-5b9c11e1c43a"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasProductCategory(), WAF.Engine.Query.Native.AqlRelShopProductCategory.Relation));
            }
        }

        public static AqlPropertyRelation ParentCategory {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("4bf8bb48-ee48-4320-a4d6-20c0d80366d0"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductCategory(), WAF.Engine.Query.Native.AqlRelProductCategorySubCategory.Relation));
            }
        }

        public static AqlPropertyBoolean IsTopLevelCategory {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductCategory.Field.IsTopLevelCategory, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyShortString GoogleShoppingCategoryId {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductCategory.Field.GoogleShoppingCategoryId, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasRelatudeFishingShopProductCategory
        : WAF.Engine.Query.Native.AqlAliasProductCategory{

        public AqlAliasRelatudeFishingShopProductCategory()
            : base(WAFID.GetContentClassId("597956ef-0eb9-4d58-8ec8-5891e7cb870a")) {

        }

        public AqlAliasRelatudeFishingShopProductCategory(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString AutoGeneratedMetaDescription {
            get {
                return new AqlExpressionPropertyLongString(AqlRelatudeFishingShopProductCategory.AutoGeneratedMetaDescription, this);
            }
        }

    }
}
