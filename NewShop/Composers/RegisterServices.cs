using NewShop.Services.Implementation;
using NewShop.Services.Interface;

namespace NewShop.Composers
{
    public static class RegisterServices
    {
        public static IUmbracoBuilder Register(this IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<IProductHelper, ProductHelper>();
            return builder;
        }
    }
}
