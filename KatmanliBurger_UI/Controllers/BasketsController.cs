using KatmanliBurger_DATA.Concretes;
using KatmanliBurger_DATA.DomainModels;
using KatmanliBurger_SERVICE.Services.BasketServices;
using KatmanliBurger_SERVICE.Services.BurgerOrderMappingServices;
using KatmanliBurger_SERVICE.Services.BurgerServices;
using KatmanliBurger_SERVICE.Services.ByProductServices;
using KatmanliBurger_SERVICE.Services.MenuOrderMappingServices;
using KatmanliBurger_SERVICE.Services.MenuServices;
using KatmanliBurger_SERVICE.Services.OrderByProductMappingServices;
using KatmanliBurger_SERVICE.Services.OrderServices;
using KatmanliBurger_UI.Helpers;
using KatmanliBurger_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.Controllers
{
	public class BasketsController : Controller
	{
		private IBasketService _basketManager;
		private IBasketSessionHelper _basketSessionHelper;
		private IByProductService _byProductManager;
		private IMenuService _menuManager;
		private IBurgerService _burgerManager;
		private IOrderService _orderManager;
		private IBurgerOrderMappingService _burgerOrderMappingManager;
		private IMenuOrderMappingService _menuOrderMappingManager;
		private IOrderByProductMappingService _orderByProductMappingManager;

		public BasketsController(IBasketService basketManager, IBasketSessionHelper basketSessionHelper, IByProductService byProductManager, IMenuService menuManager, IBurgerService burgerManager, IOrderService orderService, IBurgerOrderMappingService burgerOrderMappingManager, IMenuOrderMappingService menuOrderMappingManager, IOrderByProductMappingService orderByProductMappingManager)
		{
			_basketManager = basketManager;
			_basketSessionHelper = basketSessionHelper;
			_byProductManager = byProductManager;
			_menuManager = menuManager;
			_burgerManager = burgerManager;
			_orderManager = orderService;
			_burgerOrderMappingManager = burgerOrderMappingManager;
			_menuOrderMappingManager = menuOrderMappingManager;
			_orderByProductMappingManager = orderByProductMappingManager;
		}

		public IActionResult Index()
		{
			var model = new BasketListViewModel
			{
				Basket = _basketSessionHelper.GetBasket("basket")
			};
			return View(model);
		}

		public IActionResult AddToBasket(int byProductId = default, int menuId = default, int burgerId = default)
		{
			//Sepetten ürünü çek idye göre
			ByProduct product = _byProductManager.GetById(byProductId);
			Menu menu = _menuManager.GetById(menuId);
			Burger burger = _burgerManager.GetById(burgerId);

			var basket = _basketSessionHelper.GetBasket("basket");
			_basketManager.AddToBasket(basket, product, menu, burger);
			_basketSessionHelper.SetBasket("basket", basket);

			return RedirectToAction("Index", "Baskets");
		}

		public IActionResult RemoveFromBasket(int byProductId = default, int menuId = default, int burgerId = default)
		{
			//Sepetten ürünü çek idye göre
			//ByProduct product = _byProductManager.GetById(byProductId);
			//Menu menu = _menuManager.GetById(menuId);
			//Burger burger = _burgerManager.GetById(burgerId);

			var basket = _basketSessionHelper.GetBasket("basket");
			_basketManager.RemoveFromBasket(basket, byProductId, menuId, burgerId);
			_basketSessionHelper.SetBasket("basket", basket);

			return RedirectToAction("Index");
		}

		public IActionResult AddToOrder()
		{
			Order order = new Order() { UserId = "e768f722-5d9f-40dd-a8ed-a7e9a19d9238" };
			_orderManager.Create(order);
			Basket basket = _basketSessionHelper.GetBasket("basket");

			foreach (var item in basket.BasketLines)
			{
				if (item.Burger is not null)
				{
					order.BurgerOrders = new List<BurgerOrderMapping>()
					{
					   new BurgerOrderMapping
					   {
						BurgerId=item.Burger.Id,
						OrderId=order.Id
					   }
					};

					_burgerOrderMappingManager.Create(order.BurgerOrders);
				}
				if (item.Menu is not null)
				{
					order.MenuOrders = new List<MenuOrderMapping>()
					{
						new MenuOrderMapping
						{
							MenuId=item.Menu.Id,
							OrderId=order.Id
						}
					};

					_menuOrderMappingManager.Create(order.MenuOrders);
				}

				if (item.ByProduct is not null)
				{
					order.OrderByProducts = new List<OrderByProductMapping>
					{
						new OrderByProductMapping
						{
							ByProductId=item.ByProduct.Id,
							OrderId = order.Id
						}
					};
					_orderByProductMappingManager.Create(order.OrderByProducts);
				}
			}

			return View();
		}

	}
}
