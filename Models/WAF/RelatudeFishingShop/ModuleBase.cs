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
    public partial class ModuleBase: WAF.Engine.Content.Native.HierarchicalContent {
        NodeRelationsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.FrontPage> _modulePages;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.FrontPage> ModulePages{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.FrontPage>.GetValue(WAFID.GetDataValueId("c3cb2447-dc5b-4894-a261-f38d2e73fd25"), ref _modulePages, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModuleBase>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModuleBase>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModuleBase>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8");
            }
        }

        public static int PropertyIdModulePages {
            get {
                return WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25")) {
                object init = ModulePages;
                return _modulePages;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _modulePages = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlModuleBase {
        public static SqlTable Table {
            get {
                return new SqlTable("module_base", WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
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
    public class SqlAliasModuleBase : SqlAlias {
        public SqlAliasModuleBase()
            : base(SqlModuleBase.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModuleBase.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlModuleBase{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")); 
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25"), new AqlAliasRelation(new WAF.Engine.Query.RelatudeFishingShop.AqlAliasFrontPage(), new WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase(), WAF.Engine.Query.RelatudeFishingShop.AqlRelModulePageModuleBase.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModuleBase
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasModuleBase()
            : base(WAFID.GetContentClassId("3b17b6d1-d229-4348-a27a-3cd525f51ec8")) {

        }

        public AqlAliasModuleBase(int contentClassId)
            : base(contentClassId) {

        }

    }
}
