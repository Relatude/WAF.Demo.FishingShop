// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.Data.Query;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Data.Query.RelatudeFishingShop {

    public abstract class SqlRelModulePageModuleBase {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_module_page_module_base", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.RelatudeFishingShop {

    public abstract class SqlRelProductModuleProduct {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_product_module_product", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Engine.Query.RelatudeFishingShop{

    [System.Serializable]
    public abstract class AqlRelModulePageModuleBase{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("fb633cb0-0e21-4759-82fe-34187d0a1ffb") );
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop{

    [System.Serializable]
    public abstract class AqlRelProductModuleProduct{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("e4941d99-5880-4caa-baf7-c7f4ae65db37") );
            }
        }

    }
}
namespace WAF.Engine.Query.RelatudeFishingShop{

    [System.Serializable]
    public class AqlAliasRelModulePageModuleBase: AqlAliasRelation {

        public AqlAliasRelModulePageModuleBase(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelModulePageModuleBase.Relation) {

        }
        public AqlAliasRelModulePageModuleBase(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelModulePageModuleBase.Relation, onParent ) {

        }
        public AqlAliasRelModulePageModuleBase(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelModulePageModuleBase.Relation, onChild ) {

        }
        public AqlAliasRelModulePageModuleBase(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelModulePageModuleBase.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.RelatudeFishingShop{

    [System.Serializable]
    public class AqlAliasRelProductModuleProduct: AqlAliasRelation {

        public AqlAliasRelProductModuleProduct(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelProductModuleProduct.Relation) {

        }
        public AqlAliasRelProductModuleProduct(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelProductModuleProduct.Relation, onParent ) {

        }
        public AqlAliasRelProductModuleProduct(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelProductModuleProduct.Relation, onChild ) {

        }
        public AqlAliasRelProductModuleProduct(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelProductModuleProduct.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Content.RelatudeFishingShop{
    [System.Serializable]
    public partial class RelModulePageModuleBase: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("fb633cb0-0e21-4759-82fe-34187d0a1ffb");
            }
        }

    }
}
namespace WAF.Engine.Content.RelatudeFishingShop{
    [System.Serializable]
    public partial class RelProductModuleProduct: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("e4941d99-5880-4caa-baf7-c7f4ae65db37");
            }
        }

    }
}
namespace WAF.Engine.Content.RelatudeFishingShop{

    public enum ImageModulePosition: int{

        Top=0,
        Right=1,
        Left=2,
        Bottom=3,
    }
}
