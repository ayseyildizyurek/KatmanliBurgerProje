using KatmanliBurger_DAL.Abstracts;
using KatmanliBurger_SERVICE.Services.BurgerServices;
using KatmanliBurger_SERVICE.Services.ByProductServices;
using KatmanliBurger_SERVICE.Services.CategoryServices;
using KatmanliBurger_SERVICE.Services.MenuServices;
using KatmanliBurger_UI.DTOs.MenuProductViewDtos;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
