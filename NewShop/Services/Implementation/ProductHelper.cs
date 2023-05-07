using NewShop.Services.Interface;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace NewShop.Services.Implementation;

public class ProductHelper : IProductHelper
{
    private readonly UmbracoHelper _helper;
    public ProductHelper(UmbracoHelper helper)
    {
        _helper = helper;
    }

        
    public IEnumerable<Product> Getallproduct()
    {
        var allproduct = _helper.Content(Guid.Parse("f3fc9b58-6658-4000-ad0f-246041a3f830"))
            .ChildrenOfType("product")
            .Where(x => x.IsVisible());

        return allproduct.Select(item => item as Product).ToList();
    }

    public Product Getproductbyid(int id)
    {
        var product = Getallproduct().FirstOrDefault(x => x.Id == id);
        return product;
    }
}