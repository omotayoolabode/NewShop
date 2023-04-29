using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace NewShop.Services.Interface
{
    public interface IProductHelper
    {
        public IEnumerable<Product> Getallproduct();
        public Product Getproductbyid(int id);
    }
}
