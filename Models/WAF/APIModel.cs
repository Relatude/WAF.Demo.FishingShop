// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("0c407e42-4721-4680-a902-3afc6a7af059")]
public class FrontPage : WAF.API.Native.HierarchicalContent {
public FrontPage(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _modulesGuid = new Guid("ccc2df4f-4e0d-4283-8831-bd6d9e0b93b9");
        [PropertyGuid("ccc2df4f-4e0d-4283-8831-bd6d9e0b93b9")]
        public IQueryable<WAF.API.RelatudeFishingShop.ModuleBase> Modules {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_modulesGuid)).Cast<WAF.API.RelatudeFishingShop.ModuleBase>();}
        set {DataProvider.SetPropertyValue(_modulesGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("92b87541-ebac-4e5d-86f3-e8dea32727e9")]
public class SliderImage : WAF.API.Native.InnerContentBase {
public SliderImage(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _imageGuid = new Guid("83fe4a36-a8fc-495d-b084-82e28de639b1");
        [PropertyGuid("83fe4a36-a8fc-495d-b084-82e28de639b1")]
        public PropertyTypes.FileInfo Image {
        get { return DataProvider.GetFileInfo(_imageGuid); }
        set { throw new NotSupportedException(); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("3b17b6d1-d229-4348-a27a-3cd525f51ec8")]
public class ModuleBase : WAF.API.Native.HierarchicalContent {
public ModuleBase(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _modulePagesGuid = new Guid("c3cb2447-dc5b-4894-a261-f38d2e73fd25");
        [PropertyGuid("c3cb2447-dc5b-4894-a261-f38d2e73fd25")]
        public IQueryable<WAF.API.RelatudeFishingShop.FrontPage>
        ModulePages {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_modulePagesGuid)).Cast<WAF.API.RelatudeFishingShop.FrontPage>();}
        set {DataProvider.SetPropertyValue(_modulePagesGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("85c64b77-7d8d-4f75-9944-07ee1b5ebe7b")]
public class SliderModule : WAF.API.RelatudeFishingShop.ModuleBase {
public SliderModule(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _imagesGuid = new Guid("55d32b9b-fd3c-4f90-82a7-9c1d8accec47");
        [PropertyGuid("55d32b9b-fd3c-4f90-82a7-9c1d8accec47")]
        public System.Collections.Generic.List<WAF.API.RelatudeFishingShop.SliderImage> Images {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_imagesGuid)).Cast<WAF.API.RelatudeFishingShop.SliderImage>().ToList();}
        set {DataProvider.SetPropertyValue(_imagesGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("80d04535-b17e-4bb4-bff2-6d1f2bde0319")]
public class ImageAndTextModule : WAF.API.RelatudeFishingShop.ModuleBase {
public ImageAndTextModule(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _imageGuid = new Guid("105e5f96-1f21-4020-98f8-10d7a8f9722b");
        [PropertyGuid("105e5f96-1f21-4020-98f8-10d7a8f9722b")]
        public PropertyTypes.FileInfo Image {
        get { return DataProvider.GetFileInfo(_imageGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _headerGuid = new Guid("d2a82d3d-c0fc-42b3-a55f-baf2cfbd0a1b");
        [PropertyGuid("d2a82d3d-c0fc-42b3-a55f-baf2cfbd0a1b")]
        public string Header {
        get { return (string)DataProvider.GetPropertyValue(_headerGuid); }
        set { DataProvider.SetPropertyValue(_headerGuid, value); }
        }
      
        static Guid _textGuid = new Guid("bedf0322-4618-4485-9f44-e680e7f47386");
        [PropertyGuid("bedf0322-4618-4485-9f44-e680e7f47386")]
        public string Text {
        get { return (string)DataProvider.GetPropertyValue(_textGuid); }
        set { DataProvider.SetPropertyValue(_textGuid, value); }
        }
      
        static Guid _imagePositionGuid = new Guid("8dceb77e-7eda-47a7-be3e-27f5588cb451");
        [PropertyGuid("8dceb77e-7eda-47a7-be3e-27f5588cb451")]
        public string ImagePosition {
        get { return (string)DataProvider.GetPropertyValue(_imagePositionGuid); }
        set { DataProvider.SetPropertyValue(_imagePositionGuid, value); }
        }
      
        static Guid _linkTextGuid = new Guid("9e98fb5a-4832-44a4-866b-9fd3305b0636");
        [PropertyGuid("9e98fb5a-4832-44a4-866b-9fd3305b0636")]
        public string LinkText {
        get { return (string)DataProvider.GetPropertyValue(_linkTextGuid); }
        set { DataProvider.SetPropertyValue(_linkTextGuid, value); }
        }
      
        static Guid _linkGuid = new Guid("6d843722-5e94-4498-a142-0105c2bb5e49");
        [PropertyGuid("6d843722-5e94-4498-a142-0105c2bb5e49")]
        public string Link {
        get { return (string)DataProvider.GetPropertyValue(_linkGuid); }
        set { DataProvider.SetPropertyValue(_linkGuid, value); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("512a493c-2d5f-4f3d-9a9e-16033f665f4d")]
public class ProductsModule : WAF.API.RelatudeFishingShop.ModuleBase {
public ProductsModule(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headerGuid = new Guid("f1a60762-1131-4242-8e88-71229fcea4e9");
        [PropertyGuid("f1a60762-1131-4242-8e88-71229fcea4e9")]
        public string Header {
        get { return (string)DataProvider.GetPropertyValue(_headerGuid); }
        set { DataProvider.SetPropertyValue(_headerGuid, value); }
        }
      
        static Guid _productsGuid = new Guid("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55");
        [PropertyGuid("3e6b7a80-7c1c-4b75-ad5d-70cd8ecc6b55")]
        public IQueryable<WAF.API.Native.ProductBase> Products {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_productsGuid)).Cast<WAF.API.Native.ProductBase>();}
        set {DataProvider.SetPropertyValue(_productsGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("f649cb50-47ad-47c0-b3d5-e11087c665f7")]
public class ControlPanel : WAF.API.Native.HierarchicalContent {
public ControlPanel(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headerGuid = new Guid("825fdc28-5732-480b-9979-5021ce85bd72");
        [PropertyGuid("825fdc28-5732-480b-9979-5021ce85bd72")]
        public System.Collections.Generic.List<WAF.API.RelatudeFishingShop.InnerNodeParent> Header {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_headerGuid)).Cast<WAF.API.RelatudeFishingShop.InnerNodeParent>().ToList();}
        set {DataProvider.SetPropertyValue(_headerGuid, value);}
        }
      
        static Guid _headerLogoGuid = new Guid("b54ed168-846f-4e21-83ac-4dc9af8baa7b");
        [PropertyGuid("b54ed168-846f-4e21-83ac-4dc9af8baa7b")]
        public PropertyTypes.FileInfo HeaderLogo {
        get { return DataProvider.GetFileInfo(_headerLogoGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _mainProductCategoryGuid = new Guid("9b0f7b06-7665-4df5-8ae6-d1f6b4a2aa9a");
        [PropertyGuid("9b0f7b06-7665-4df5-8ae6-d1f6b4a2aa9a")]
        public WAF.API.Native.ProductCategory MainProductCategory{
        get { return DataProvider.GetPropertyValue(_mainProductCategoryGuid) as WAF.API.Native.ProductCategory;}
        set { DataProvider.SetPropertyValue(_mainProductCategoryGuid, value);}
        }
      
        static Guid _shoppingCartPageGuid = new Guid("8ebc0655-1dc7-474c-8a4e-2953665348af");
        [PropertyGuid("8ebc0655-1dc7-474c-8a4e-2953665348af")]
        public WAF.API.Native.HierarchicalContent ShoppingCartPage{
        get { return DataProvider.GetPropertyValue(_shoppingCartPageGuid) as WAF.API.Native.HierarchicalContent;}
        set { DataProvider.SetPropertyValue(_shoppingCartPageGuid, value);}
        }
      
        static Guid _checkoutPageGuid = new Guid("8aa12960-fb6a-4b7d-8381-1da335e50c6f");
        [PropertyGuid("8aa12960-fb6a-4b7d-8381-1da335e50c6f")]
        public WAF.API.Native.HierarchicalContent CheckoutPage{
        get { return DataProvider.GetPropertyValue(_checkoutPageGuid) as WAF.API.Native.HierarchicalContent;}
        set { DataProvider.SetPropertyValue(_checkoutPageGuid, value);}
        }
      
        static Guid _searchPageGuid = new Guid("a4625963-817e-4a7e-b22e-b3713c2b773e");
        [PropertyGuid("a4625963-817e-4a7e-b22e-b3713c2b773e")]
        public WAF.API.RelatudeFishingShop.Article SearchPage{
        get { return DataProvider.GetPropertyValue(_searchPageGuid) as WAF.API.RelatudeFishingShop.Article;}
        set { DataProvider.SetPropertyValue(_searchPageGuid, value);}
        }
      
        static Guid _footerInfoGuid = new Guid("3b2f9778-ff9b-4a65-954f-5ec68bcaed0f");
        [PropertyGuid("3b2f9778-ff9b-4a65-954f-5ec68bcaed0f")]
        public string FooterInfo {
        get { return (string)DataProvider.GetPropertyValue(_footerInfoGuid); }
        set { DataProvider.SetPropertyValue(_footerInfoGuid, value); }
        }
      
        static Guid _footerGuid = new Guid("7cd8bd97-33dc-40bf-9c9e-26ff2b53cb23");
        [PropertyGuid("7cd8bd97-33dc-40bf-9c9e-26ff2b53cb23")]
        public System.Collections.Generic.List<WAF.API.RelatudeFishingShop.InnerNodeParent> Footer {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_footerGuid)).Cast<WAF.API.RelatudeFishingShop.InnerNodeParent>().ToList();}
        set {DataProvider.SetPropertyValue(_footerGuid, value);}
        }
      
        static Guid _footerLogoGuid = new Guid("5ad9af94-7324-4f2e-a8ab-4774083d1b27");
        [PropertyGuid("5ad9af94-7324-4f2e-a8ab-4774083d1b27")]
        public PropertyTypes.FileInfo FooterLogo {
        get { return DataProvider.GetFileInfo(_footerLogoGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _instagramGuid = new Guid("35e65af1-3259-456b-90d3-3857da62d14a");
        [PropertyGuid("35e65af1-3259-456b-90d3-3857da62d14a")]
        public string Instagram {
        get { return (string)DataProvider.GetPropertyValue(_instagramGuid); }
        set { DataProvider.SetPropertyValue(_instagramGuid, value); }
        }
      
        static Guid _facebookGuid = new Guid("a1b29b53-9e5d-4fb8-a6fa-56d2586d7eeb");
        [PropertyGuid("a1b29b53-9e5d-4fb8-a6fa-56d2586d7eeb")]
        public string Facebook {
        get { return (string)DataProvider.GetPropertyValue(_facebookGuid); }
        set { DataProvider.SetPropertyValue(_facebookGuid, value); }
        }
      
        static Guid _twitterGuid = new Guid("8a2f79b6-4b8f-4b79-b082-224c59e20389");
        [PropertyGuid("8a2f79b6-4b8f-4b79-b082-224c59e20389")]
        public string Twitter {
        get { return (string)DataProvider.GetPropertyValue(_twitterGuid); }
        set { DataProvider.SetPropertyValue(_twitterGuid, value); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("a89cb04c-e6d4-463a-89c5-99f966196e93")]
public class InnerNodeParent : WAF.API.Native.InnerContentBase {
public InnerNodeParent(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _nodeGuid = new Guid("cb4a1356-c0e4-4fb7-991a-d26dccd3afa7");
        [PropertyGuid("cb4a1356-c0e4-4fb7-991a-d26dccd3afa7")]
        public WAF.API.Native.HierarchicalContent Node{
        get { return DataProvider.GetPropertyValue(_nodeGuid) as WAF.API.Native.HierarchicalContent;}
        set { DataProvider.SetPropertyValue(_nodeGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("4e9ae475-0ac8-49aa-bc98-bb730b26b8be")]
public class SelectedOption : WAF.API.Native.InnerContentBase {
public SelectedOption(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _categoryNameGuid = new Guid("94ed6f0f-9bc8-4d04-8c13-eb005e19e788");
        [PropertyGuid("94ed6f0f-9bc8-4d04-8c13-eb005e19e788")]
        public string CategoryName {
        get { return (string)DataProvider.GetPropertyValue(_categoryNameGuid); }
        set { DataProvider.SetPropertyValue(_categoryNameGuid, value); }
        }
      
        static Guid _selectedOptionNameGuid = new Guid("59b72926-56ea-4c58-805e-7bc22c288a5d");
        [PropertyGuid("59b72926-56ea-4c58-805e-7bc22c288a5d")]
        public string SelectedOptionName {
        get { return (string)DataProvider.GetPropertyValue(_selectedOptionNameGuid); }
        set { DataProvider.SetPropertyValue(_selectedOptionNameGuid, value); }
        }
      
        static Guid _selectedOptionPriceGuid = new Guid("73ba6e7c-341e-4bfe-beac-992df4393190");
        [PropertyGuid("73ba6e7c-341e-4bfe-beac-992df4393190")]
        public double SelectedOptionPrice {
        get { return (double)DataProvider.GetPropertyValue(_selectedOptionPriceGuid); }
        set { DataProvider.SetPropertyValue(_selectedOptionPriceGuid, value); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("0529124f-268c-42b4-8ff5-3990e15042c7")]
public class RelatudeFishingShopOrderItem : WAF.API.Native.OrderItem {
public RelatudeFishingShopOrderItem(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _customeOptionsGuid = new Guid("97ac5a31-24d2-43a8-af9c-80977f9e69e6");
        [PropertyGuid("97ac5a31-24d2-43a8-af9c-80977f9e69e6")]
        public System.Collections.Generic.List<WAF.API.RelatudeFishingShop.SelectedOption> CustomeOptions {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_customeOptionsGuid)).Cast<WAF.API.RelatudeFishingShop.SelectedOption>().ToList();}
        set {DataProvider.SetPropertyValue(_customeOptionsGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("7b1c0f56-4bf7-4948-bc38-e85ed386fe72")]
public class Product : WAF.API.Native.ProductBase {
public Product(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _autoGeneratedMetaDescriptionGuid = new Guid("2fb3bb0e-4512-4956-8045-78af98eced7b");
        [PropertyGuid("2fb3bb0e-4512-4956-8045-78af98eced7b")]
        public string AutoGeneratedMetaDescription {
        get { return (string)DataProvider.GetPropertyValue(_autoGeneratedMetaDescriptionGuid); }
        set { DataProvider.SetPropertyValue(_autoGeneratedMetaDescriptionGuid, value); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("2e34c7e4-41f5-4b43-93b3-2b7b5e5b163e")]
public class InnerProduct : WAF.API.Native.InnerContentBase {
public InnerProduct(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _productGuid = new Guid("bf6a064e-acf3-4c20-bb08-1d0a0f75b5d9");
        [PropertyGuid("bf6a064e-acf3-4c20-bb08-1d0a0f75b5d9")]
        public WAF.API.RelatudeFishingShop.Product Product{
        get { return DataProvider.GetPropertyValue(_productGuid) as WAF.API.RelatudeFishingShop.Product;}
        set { DataProvider.SetPropertyValue(_productGuid, value);}
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("89d055b1-ed59-4634-8c36-3ecdccba6745")]
public class Article : WAF.API.Native.ArticleBase {
public Article(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _autoGeneratedMetaDescriptionGuid = new Guid("d20d57b4-2653-4411-9c04-cf90276e7b1e");
        [PropertyGuid("d20d57b4-2653-4411-9c04-cf90276e7b1e")]
        public string AutoGeneratedMetaDescription {
        get { return (string)DataProvider.GetPropertyValue(_autoGeneratedMetaDescriptionGuid); }
        set { DataProvider.SetPropertyValue(_autoGeneratedMetaDescriptionGuid, value); }
        }
      
}
}

namespace WAF.API.RelatudeFishingShop {
[ClassGuid("597956ef-0eb9-4d58-8ec8-5891e7cb870a")]
public class RelatudeFishingShopProductCategory : WAF.API.Native.ProductCategory {
public RelatudeFishingShopProductCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _autoGeneratedMetaDescriptionGuid = new Guid("043d9832-60f2-4b1f-aa39-304cb74acc33");
        [PropertyGuid("043d9832-60f2-4b1f-aa39-304cb74acc33")]
        public string AutoGeneratedMetaDescription {
        get { return (string)DataProvider.GetPropertyValue(_autoGeneratedMetaDescriptionGuid); }
        set { DataProvider.SetPropertyValue(_autoGeneratedMetaDescriptionGuid, value); }
        }
      
}
}
