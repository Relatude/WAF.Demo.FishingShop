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
    public partial class RelatudeFishingShopOrderItem: WAF.Engine.Content.Native.OrderItem {
        InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SelectedOption> _customeOptions;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SelectedOption> CustomeOptions{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SelectedOption>.GetValue(WAFID.GetDataValueId("97ac5a31-24d2-43a8-af9c-80977f9e69e6"), ref _customeOptions, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<RelatudeFishingShopOrderItem>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<RelatudeFishingShopOrderItem>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<RelatudeFishingShopOrderItem>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7");
            }
        }

        public static int PropertyIdCustomeOptions {
            get {
                return WAFID.GetPropertyId("97ac5a31-24d2-43a8-af9c-80977f9e69e6");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("97ac5a31-24d2-43a8-af9c-80977f9e69e6")) {
                object init = CustomeOptions;
                return _customeOptions;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _customeOptions = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlRelatudeFishingShopOrderItem {
        public static SqlTable Table {
            get {
                return new SqlTable("relatude_fishing_shop_order_item", WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

        }
    }
    public class SqlAliasRelatudeFishingShopOrderItem : SqlAlias {
        public SqlAliasRelatudeFishingShopOrderItem()
            : base(SqlRelatudeFishingShopOrderItem.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlRelatudeFishingShopOrderItem.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlRelatudeFishingShopOrderItem{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")); 
            }
        }

        public static AqlPropertyFloat ItemTotalExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.ItemTotalExVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat ItemTotalIncVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.ItemTotalIncVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat ItemTotalVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.ItemTotalVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat ItemPriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.ItemPriceExVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat ItemPriceIncVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.ItemPriceIncVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat DiscountAmountExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.DiscountAmountExVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyFloat DiscountAmountIncVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlOrderItem.Field.DiscountAmountIncVat, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyShortString Status {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlOrderItem.Field.Status, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyInteger Quantity {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlOrderItem.Field.Quantity, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyRelation Product {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("601471bc-1176-4b1c-a3b1-1fc1cd7dc42f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasOrderItem(), WAF.Engine.Query.Native.AqlRelProductOrdeItems.Relation));
            }
        }

        public static AqlPropertyRelation Order {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("ec0bfccc-7aad-425f-bb50-090ea7f164e8"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasOrder(), new WAF.Engine.Query.Native.AqlAliasOrderItem(), WAF.Engine.Query.Native.AqlRelOrderItems.Relation));
            }
        }

        public static AqlPropertyInteger ShippedQuantity {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlOrderItem.Field.ShippedQuantity, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyBoolean ManualPriceOverride {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlOrderItem.Field.ManualPriceOverride, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyInteger SelectedSimpleVariant {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlOrderItem.Field.SelectedSimpleVariant, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyShortString ProductName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlOrderItem.Field.ProductName, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

        public static AqlPropertyInteger ProductNodeId {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlOrderItem.Field.ProductNodeId, WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasRelatudeFishingShopOrderItem
        : WAF.Engine.Query.Native.AqlAliasOrderItem{

        public AqlAliasRelatudeFishingShopOrderItem()
            : base(WAFID.GetContentClassId("0529124f-268c-42b4-8ff5-3990e15042c7")) {

        }

        public AqlAliasRelatudeFishingShopOrderItem(int contentClassId)
            : base(contentClassId) {

        }

    }
}
