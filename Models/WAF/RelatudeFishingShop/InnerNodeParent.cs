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
    public partial class InnerNodeParent: WAF.Engine.Content.InnerContentBase {
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _node;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> Node{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetPropValue(WAFID.GetDataValueId("5f2ed81e-9552-4715-9fab-1ba403df849e"), ref _node, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("a89cb04c-e6d4-463a-89c5-99f966196e93");
            }
        }

        public static int PropertyIdNode {
            get {
                return WAFID.GetPropertyId("cb4a1356-c0e4-4fb7-991a-d26dccd3afa7");
            }
        }

        public static int DataValueIdNodeNode {
            get {
                return WAFID.GetDataValueId("5f2ed81e-9552-4715-9fab-1ba403df849e");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("cb4a1356-c0e4-4fb7-991a-d26dccd3afa7")) {
                object init = Node;
                return _node;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _node = null;
            base.ResetPropertyValues();
        }
    }
}
