using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class NavbarBasketViewComponent : ViewComponent
    {
        // todo: yarın IBasketViewModelService üzerinden BasketViewModel türünde
        // sepeti buraya getireceğiz ve öğelerinin sayısını View'a aktaracağız
        // ki o View da navbarın sağ üstüne yerleştirilecek view component ile..
        public NavbarBasketViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
