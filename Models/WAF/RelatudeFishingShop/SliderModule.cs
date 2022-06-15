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
    public partial class SliderModule: WAF.Engine.Content.RelatudeFishingShop.ModuleBase {
        InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SliderImage> _images;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SliderImage> Images{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.RelatudeFishingShop.SliderImage>.GetValue(WAFID.GetDataValueId("55d32b9b-fd3c-4f90-82a7-9c1d8accec47"), ref _images, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<SliderModule>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<SliderModule>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<SliderModule>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b");
            }
        }

        public static int PropertyIdImages {
            get {
                return WAFID.GetPropertyId("55d32b9b-fd3c-4f90-82a7-9c1d8accec47");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("55d32b9b-fd3c-4f90-82a7-9c1d8accec47")) {
                object init = Images;
                return _images;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _images = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlSliderModule {
        public static SqlTable Table {
            get {
                return new SqlTable("slider_module", WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
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
    public class SqlAliasSliderModule : SqlAlias {
        public SqlAliasSliderModule()
            : base(SqlSliderModule.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlSliderModule.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlSliderModule{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")); 
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25"), new AqlAliasRelation(new WAF.Engine.Query.RelatudeFishingShop.AqlAliasFrontPage(), new WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase(), WAF.Engine.Query.RelatudeFishingShop.AqlRelModulePageModuleBase.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasSliderModule
        : WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase{

        public AqlAliasSliderModule()
            : base(WAFID.GetContentClassId("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")) {

        }

        public AqlAliasSliderModule(int contentClassId)
            : base(contentClassId) {

        }

    }
}
