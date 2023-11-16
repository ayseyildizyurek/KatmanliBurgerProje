using KatmanliBurger_DATA.Concretes;
using KatmanliBurger_DATA.DomainModels;
using KatmanliBurger_DATA.Enums;

namespace KatmanliBurger_UI.Models
{
	public class OrderCreateViewModel
	{
        public List<BasketLine> BasketLines { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal Tax { get; set; }
		public decimal TotalPriceWithTax { get; set; }
	}
}
