using Umbraco.Cms.Core.Models.PublishedContent;

namespace NewShop.Services.Interface
{
    public interface IProductHelper
    {
        public IEnumerable<IPublishedContent> Getallproduct();
        public IPublishedContent Getproductbyid(int id);
    }
}
