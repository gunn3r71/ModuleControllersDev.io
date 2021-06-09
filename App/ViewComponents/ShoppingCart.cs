using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.ViewComponents
{
    [ViewComponent(Name = "ShoppingCart")]
    public class ShoppingCart : ViewComponent
    {
        public int ProductsAmount { get; set; }

        public ShoppingCart()
        {
            ProductsAmount = 10;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ProductsAmount);
        }
    }
}
