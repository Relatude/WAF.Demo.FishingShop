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
    public partial class Product: WAF.Engine.Content.Native.ProductBase {
        LongStringPropertyValue _autoGeneratedMetaDescription;
        public virtual string AutoGeneratedMetaDescription {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("4899b919-6df4-4dc1-9f9e-78e0343fa305"), ref _autoGeneratedMetaDescription, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("4899b919-6df4-4dc1-9f9e-78e0343fa305"), ref _autoGeneratedMetaDescription, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Product>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Product>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Product>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72");
            }
        }

        public static int PropertyIdAutoGeneratedMetaDescription {
            get {
                return WAFID.GetPropertyId("2fb3bb0e-4512-4956-8045-78af98eced7b");
            }
        }

        public static int DataValueIdAutoGeneratedMetaDescriptionAutoGeneratedMetaDescription {
            get {
                return WAFID.GetDataValueId("4899b919-6df4-4dc1-9f9e-78e0343fa305");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("2fb3bb0e-4512-4956-8045-78af98eced7b")) {
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
    public abstract class SqlProduct {
        public static SqlTable Table {
            get {
                return new SqlTable("product", WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
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
                    return new SqlFieldLongString("auto_generated_meta_description", Table, WAFID.GetDataValueId("4899b919-6df4-4dc1-9f9e-78e0343fa305"));
                }
            }

        }
    }
    public class SqlAliasProduct : SqlAlias {
        public SqlAliasProduct()
            : base(SqlProduct.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlProduct.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString AutoGeneratedMetaDescription {
            get {
                return new SqlExpressionFieldLongString(SqlProduct.Field.AutoGeneratedMetaDescription, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlProduct{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")); 
            }
        }

        public static AqlPropertyLongString AutoGeneratedMetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlProduct.Field.AutoGeneratedMetaDescription, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString ItemNumber {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.ItemNumber, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat ShippingCost {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.ShippingCost, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger NumberInStock {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.NumberInStock, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean Subvariant {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.Subvariant, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyRelation Variants {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("506856d8-12d6-424c-a767-6db305657a05"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductVariants.Relation));
            }
        }

        public static AqlPropertyRelation MainVariant {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6acbc442-804d-4edb-988b-e7b8e6d0acb4"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductVariants.Relation));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_filename, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_type_name, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_extension, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat MainProductImage_product_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_bytes, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyLongString MainProductImage_product_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_info, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger MainProductImage_product_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_int, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyLongString ShortDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.ShortDescription, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.Description, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyRelation ProductCategory {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("2b4a9da2-c0b3-4bba-b8db-a2b65c8ce10f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductCategoryProducts.Relation));
            }
        }

        public static AqlPropertyRelation Reviews {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("85021d96-673a-4f22-88a1-086377703a29"), new AqlAliasRelation(new WAF.Engine.Query.AqlAliasContentBase(), new WAF.Engine.Query.Native.AqlAliasReview(), WAF.Engine.Query.Native.AqlRelNodeReviews.Relation));
            }
        }

        public static AqlPropertyRelation OrderItems {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("eb304eb8-9a29-4f43-9695-7cf49095debb"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasOrderItem(), WAF.Engine.Query.Native.AqlRelProductOrdeItems.Relation));
            }
        }

        public static AqlPropertyRelation Manufacturer {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("fdc2f6c0-1e76-4008-8507-1b3fccd46ea6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasManufacturer(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelManufacturerProducts.Relation));
            }
        }

        public static AqlPropertyFloat Currency1PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency1PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat Currency2PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency2PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat Currency3PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency3PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat Currency4PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency4PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyFloat Currency5PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency5PriceExVat, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyRelation ProductDiscounts {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("426899b5-a1f5-4694-8c3f-cd2bc4af99c2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasDiscountBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelDiscountsApplicableToProducts.Relation));
            }
        }

        public static AqlPropertyBoolean IsVariablePriceProduct {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.IsVariablePriceProduct, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyRelation TaxClass {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("53e2098b-a347-421f-9874-82d3f981d580"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasTaxClass(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelTaxClassProducts.Relation));
            }
        }

        public static AqlPropertyLongString JsonProperties {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.JsonProperties, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString GTIN {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.GTIN, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger Weight {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Weight, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger Width {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Width, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger Length {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Length, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger Height {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Height, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean UsesSimpleVariants {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.UsesSimpleVariants, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasProduct
        : WAF.Engine.Query.Native.AqlAliasProductBase{

        public AqlAliasProduct()
            : base(WAFID.GetContentClassId("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")) {

        }

        public AqlAliasProduct(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString AutoGeneratedMetaDescription {
            get {
                return new AqlExpressionPropertyLongString(AqlProduct.AutoGeneratedMetaDescription, this);
            }
        }

    }
}