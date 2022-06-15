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
    public partial class ImageAndTextModule: WAF.Engine.Content.RelatudeFishingShop.ModuleBase {
        FilePropertyValue _image;
        public virtual FilePropertyValue Image {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("ba2a2c43-9ff5-46b7-bdd0-073b7a5a5a42"),WAFID.GetDataValueId("d8c4e620-b9c4-431c-9149-276209ef6629"),WAFID.GetDataValueId("979dee70-6df8-4e96-abcd-2bb9ecb2ec87"),WAFID.GetDataValueId("ecf24288-88d9-455e-96d0-8d2be40c6b45"),WAFID.GetDataValueId("62d5f261-035c-4fc3-bcdb-d6a514a6f5b1"),WAFID.GetDataValueId("bd3e25cf-be16-402e-984a-3f147b5b14ca"), ref _image, this, WAFID.GetDataValueId("105e5f96-1f21-4020-98f8-10d7a8f9722b")); }
        }
      
        ShortStringPropertyValue _header;
        public virtual string Header {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("045c58e0-9775-4690-b173-ce5837f8d81d"), ref _header, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("045c58e0-9775-4690-b173-ce5837f8d81d"), ref _header, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _text;
        public virtual string Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("6c6a9722-ee45-422f-a94b-10ca7090bb7d"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("6c6a9722-ee45-422f-a94b-10ca7090bb7d"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        EnumerationPropertyValue _imagePosition;
        public virtual RelatudeFishingShop.ImageModulePosition ImagePosition {
        get { return (RelatudeFishingShop.ImageModulePosition) EnumerationPropertyValue.GetValue(WAFID.GetDataValueId("2b46e0bc-23eb-4916-b83c-2f20309ee400"), ref _imagePosition, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); EnumerationPropertyValue.SetValue(WAFID.GetDataValueId("2b46e0bc-23eb-4916-b83c-2f20309ee400"), ref _imagePosition, this.Session, this.ContentId, this.ContentData.DataValueById, (int)value); }
        }
      
        ShortStringPropertyValue _linkText;
        public virtual string LinkText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("eac32eb8-8375-4ebf-aba2-847d78a7337b"), ref _linkText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("eac32eb8-8375-4ebf-aba2-847d78a7337b"), ref _linkText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _link;
        public virtual LinkPropertyValue Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("815e5669-4f2b-4f56-b775-be5fac34b9dc"), ref _link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ImageAndTextModule>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ImageAndTextModule>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ImageAndTextModule>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319");
            }
        }

        public static int PropertyIdImage {
            get {
                return WAFID.GetPropertyId("105e5f96-1f21-4020-98f8-10d7a8f9722b");
            }
        }

        public static int DataValueIdImageImageFilename {
            get {
                return WAFID.GetDataValueId("d8c4e620-b9c4-431c-9149-276209ef6629");
            }
        }

        public static int DataValueIdImageImageTypeName {
            get {
                return WAFID.GetDataValueId("979dee70-6df8-4e96-abcd-2bb9ecb2ec87");
            }
        }

        public static int DataValueIdImageImageExtension {
            get {
                return WAFID.GetDataValueId("ecf24288-88d9-455e-96d0-8d2be40c6b45");
            }
        }

        public static int DataValueIdImageImageBytes {
            get {
                return WAFID.GetDataValueId("62d5f261-035c-4fc3-bcdb-d6a514a6f5b1");
            }
        }

        public static int DataValueIdImageImageInfo {
            get {
                return WAFID.GetDataValueId("bd3e25cf-be16-402e-984a-3f147b5b14ca");
            }
        }

        public static int DataValueIdImageImageInt {
            get {
                return WAFID.GetDataValueId("ba2a2c43-9ff5-46b7-bdd0-073b7a5a5a42");
            }
        }

        public static int PropertyIdHeader {
            get {
                return WAFID.GetPropertyId("d2a82d3d-c0fc-42b3-a55f-baf2cfbd0a1b");
            }
        }

        public static int DataValueIdHeaderHeader {
            get {
                return WAFID.GetDataValueId("045c58e0-9775-4690-b173-ce5837f8d81d");
            }
        }

        public static int PropertyIdText {
            get {
                return WAFID.GetPropertyId("bedf0322-4618-4485-9f44-e680e7f47386");
            }
        }

        public static int DataValueIdTextText {
            get {
                return WAFID.GetDataValueId("6c6a9722-ee45-422f-a94b-10ca7090bb7d");
            }
        }

        public static int PropertyIdImagePosition {
            get {
                return WAFID.GetPropertyId("8dceb77e-7eda-47a7-be3e-27f5588cb451");
            }
        }

        public static int DataValueIdImagePositionImagePosition {
            get {
                return WAFID.GetDataValueId("2b46e0bc-23eb-4916-b83c-2f20309ee400");
            }
        }

        public static int PropertyIdLinkText {
            get {
                return WAFID.GetPropertyId("9e98fb5a-4832-44a4-866b-9fd3305b0636");
            }
        }

        public static int DataValueIdLinkTextLinkText {
            get {
                return WAFID.GetDataValueId("eac32eb8-8375-4ebf-aba2-847d78a7337b");
            }
        }

        public static int PropertyIdLink {
            get {
                return WAFID.GetPropertyId("6d843722-5e94-4498-a142-0105c2bb5e49");
            }
        }

        public static int DataValueIdLinkLink {
            get {
                return WAFID.GetDataValueId("815e5669-4f2b-4f56-b775-be5fac34b9dc");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("105e5f96-1f21-4020-98f8-10d7a8f9722b")) {
                object init = Image;
                return _image;
            }
            else if (propertyId == WAFID.GetPropertyId("d2a82d3d-c0fc-42b3-a55f-baf2cfbd0a1b")) {
                object init = Header;
                return _header;
            }
            else if (propertyId == WAFID.GetPropertyId("bedf0322-4618-4485-9f44-e680e7f47386")) {
                object init = Text;
                return _text;
            }
            else if (propertyId == WAFID.GetPropertyId("8dceb77e-7eda-47a7-be3e-27f5588cb451")) {
                object init = ImagePosition;
                return _imagePosition;
            }
            else if (propertyId == WAFID.GetPropertyId("9e98fb5a-4832-44a4-866b-9fd3305b0636")) {
                object init = LinkText;
                return _linkText;
            }
            else if (propertyId == WAFID.GetPropertyId("6d843722-5e94-4498-a142-0105c2bb5e49")) {
                object init = Link;
                return _link;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _image = null;
            _header = null;
            _text = null;
            _imagePosition = null;
            _linkText = null;
            _link = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {
    public abstract class SqlImageAndTextModule {
        public static SqlTable Table {
            get {
                return new SqlTable("image_and_text_module", WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString Image_image_filename {
                get {
                    return new SqlFieldShortString("image_filename", Table, WAFID.GetDataValueId("d8c4e620-b9c4-431c-9149-276209ef6629"));
                }
            }

            public static SqlFieldShortString Image_image_type_name {
                get {
                    return new SqlFieldShortString("image_type_name", Table, WAFID.GetDataValueId("979dee70-6df8-4e96-abcd-2bb9ecb2ec87"));
                }
            }

            public static SqlFieldShortString Image_image_extension {
                get {
                    return new SqlFieldShortString("image_extension", Table, WAFID.GetDataValueId("ecf24288-88d9-455e-96d0-8d2be40c6b45"));
                }
            }

            public static SqlFieldFloat Image_image_bytes {
                get {
                    return new SqlFieldFloat("image_bytes", Table, WAFID.GetDataValueId("62d5f261-035c-4fc3-bcdb-d6a514a6f5b1"));
                }
            }

            public static SqlFieldLongString Image_image_info {
                get {
                    return new SqlFieldLongString("image_info", Table, WAFID.GetDataValueId("bd3e25cf-be16-402e-984a-3f147b5b14ca"));
                }
            }

            public static SqlFieldInteger Image_image_int {
                get {
                    return new SqlFieldInteger("image_int", Table, WAFID.GetDataValueId("ba2a2c43-9ff5-46b7-bdd0-073b7a5a5a42"));
                }
            }

            public static SqlFieldShortString Header {
                get {
                    return new SqlFieldShortString("header", Table, WAFID.GetDataValueId("045c58e0-9775-4690-b173-ce5837f8d81d"));
                }
            }

            public static SqlFieldLongString Text {
                get {
                    return new SqlFieldLongString("text", Table, WAFID.GetDataValueId("6c6a9722-ee45-422f-a94b-10ca7090bb7d"));
                }
            }

            public static SqlFieldInteger ImagePosition {
                get {
                    return new SqlFieldInteger("image_position", Table, WAFID.GetDataValueId("2b46e0bc-23eb-4916-b83c-2f20309ee400"));
                }
            }

            public static SqlFieldShortString LinkText {
                get {
                    return new SqlFieldShortString("link_text", Table, WAFID.GetDataValueId("eac32eb8-8375-4ebf-aba2-847d78a7337b"));
                }
            }

            public static SqlFieldShortString Link {
                get {
                    return new SqlFieldShortString("link", Table, WAFID.GetDataValueId("815e5669-4f2b-4f56-b775-be5fac34b9dc"));
                }
            }

        }
    }
    public class SqlAliasImageAndTextModule : SqlAlias {
        public SqlAliasImageAndTextModule()
            : base(SqlImageAndTextModule.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlImageAndTextModule.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString Image_image_filename {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.Image_image_filename, this);
            }
        }

        public SqlExpressionFieldShortString Image_image_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.Image_image_type_name, this);
            }
        }

        public SqlExpressionFieldShortString Image_image_extension {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.Image_image_extension, this);
            }
        }

        public SqlExpressionFieldFloat Image_image_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlImageAndTextModule.Field.Image_image_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Image_image_info {
            get {
                return new SqlExpressionFieldLongString(SqlImageAndTextModule.Field.Image_image_info, this);
            }
        }

        public SqlExpressionFieldInteger Image_image_int {
            get {
                return new SqlExpressionFieldInteger(SqlImageAndTextModule.Field.Image_image_int, this);
            }
        }

        public SqlExpressionFieldShortString Header {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.Header, this);
            }
        }

        public SqlExpressionFieldLongString Text {
            get {
                return new SqlExpressionFieldLongString(SqlImageAndTextModule.Field.Text, this);
            }
        }

        public SqlExpressionFieldInteger ImagePosition {
            get {
                return new SqlExpressionFieldInteger(SqlImageAndTextModule.Field.ImagePosition, this);
            }
        }

        public SqlExpressionFieldShortString LinkText {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.LinkText, this);
            }
        }

        public SqlExpressionFieldShortString Link {
            get {
                return new SqlExpressionFieldShortString(SqlImageAndTextModule.Field.Link, this);
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop {
    [System.Serializable]
    public partial class AqlImageAndTextModule{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")); 
            }
        }

        public static AqlPropertyShortString Image_image_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_filename, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString Image_image_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_type_name, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString Image_image_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_extension, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyFloat Image_image_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_bytes, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyLongString Image_image_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_info, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger Image_image_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Image_image_int, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString Header {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Header, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyLongString Text {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Text, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger ImagePosition {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.ImagePosition, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString LinkText {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.LinkText, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString Link {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.RelatudeFishingShop.SqlImageAndTextModule.Field.Link, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c3cb2447-dc5b-4894-a261-f38d2e73fd25"), new AqlAliasRelation(new WAF.Engine.Query.RelatudeFishingShop.AqlAliasFrontPage(), new WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase(), WAF.Engine.Query.RelatudeFishingShop.AqlRelModulePageModuleBase.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasImageAndTextModule
        : WAF.Engine.Query.RelatudeFishingShop.AqlAliasModuleBase{

        public AqlAliasImageAndTextModule()
            : base(WAFID.GetContentClassId("80d04535-b17e-4bb4-bff2-6d1f2bde0319")) {

        }

        public AqlAliasImageAndTextModule(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString Image_image_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.Image_image_filename, this);
            }
        }

        public AqlExpressionPropertyShortString Image_image_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.Image_image_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString Image_image_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.Image_image_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Image_image_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlImageAndTextModule.Image_image_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Image_image_info {
            get {
                return new AqlExpressionPropertyLongString(AqlImageAndTextModule.Image_image_info, this);
            }
        }

        public AqlExpressionPropertyInteger Image_image_int {
            get {
                return new AqlExpressionPropertyInteger(AqlImageAndTextModule.Image_image_int, this);
            }
        }

        public AqlExpressionPropertyShortString Header {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.Header, this);
            }
        }

        public AqlExpressionPropertyLongString Text {
            get {
                return new AqlExpressionPropertyLongString(AqlImageAndTextModule.Text, this);
            }
        }

        public AqlExpressionPropertyInteger ImagePosition {
            get {
                return new AqlExpressionPropertyInteger(AqlImageAndTextModule.ImagePosition, this);
            }
        }

        public AqlExpressionPropertyShortString LinkText {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.LinkText, this);
            }
        }

        public AqlExpressionPropertyShortString Link {
            get {
                return new AqlExpressionPropertyShortString(AqlImageAndTextModule.Link, this);
            }
        }

    }
}
