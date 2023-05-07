using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using NewShop.Services.Interface;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace NewShop.Controllers
{
    public class ShopController : RenderController
    {
        private readonly IProductHelper _productHelper;
       
        public ShopController(ILogger<RenderController> logger, IProductHelper productHelper,ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _productHelper = productHelper;
        }
        public override IActionResult Index()
        {
            ViewBag.currentpageurl = CurrentPage.Url();
            var products = _productHelper.Getallproduct();
            ViewBag.allproducts = products;
            return CurrentTemplate(CurrentPage);
        }
    }
}
