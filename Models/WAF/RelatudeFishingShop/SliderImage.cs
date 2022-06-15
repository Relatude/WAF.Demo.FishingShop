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
    public partial class SliderImage: WAF.Engine.Content.InnerContentBase {
        FilePropertyValue _image;
        public virtual FilePropertyValue Image {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("1fc5f7de-5384-4f5e-9ac3-eef7f69b4002"),WAFID.GetDataValueId("e4d76cfc-1dd6-477f-85df-0e0b25fd4aa4"),WAFID.GetDataValueId("15ace530-2a54-45fe-8bb4-b63e1a392484"),WAFID.GetDataValueId("7ba1142b-850d-401c-829e-52593df09624"),WAFID.GetDataValueId("84d74fbf-3549-4c1a-9b4d-ef0eb6b63e50"),WAFID.GetDataValueId("ed3a41f3-acd5-4999-8d78-78a7a8bb22e2"), ref _image, this, WAFID.GetDataValueId("83fe4a36-a8fc-495d-b084-82e28de639b1")); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("92b87541-ebac-4e5d-86f3-e8dea32727e9");
            }
        }

        public static int PropertyIdImage {
            get {
                return WAFID.GetPropertyId("83fe4a36-a8fc-495d-b084-82e28de639b1");
            }
        }

        public static int DataValueIdImageImageFilename {
            get {
                return WAFID.GetDataValueId("e4d76cfc-1dd6-477f-85df-0e0b25fd4aa4");
            }
        }

        public static int DataValueIdImageImageTypeName {
            get {
                return WAFID.GetDataValueId("15ace530-2a54-45fe-8bb4-b63e1a392484");
            }
        }

        public static int DataValueIdImageImageExtension {
            get {
                return WAFID.GetDataValueId("7ba1142b-850d-401c-829e-52593df09624");
            }
        }

        public static int DataValueIdImageImageBytes {
            get {
                return WAFID.GetDataValueId("84d74fbf-3549-4c1a-9b4d-ef0eb6b63e50");
            }
        }

        public static int DataValueIdImageImageInfo {
            get {
                return WAFID.GetDataValueId("ed3a41f3-acd5-4999-8d78-78a7a8bb22e2");
            }
        }

        public static int DataValueIdImageImageInt {
            get {
                return WAFID.GetDataValueId("1fc5f7de-5384-4f5e-9ac3-eef7f69b4002");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("83fe4a36-a8fc-495d-b084-82e28de639b1")) {
                object init = Image;
                return _image;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _image = null;
            base.ResetPropertyValues();
        }
    }
}
