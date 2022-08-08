using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizza.Models;

namespace RazzorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
           new PizzasModel(){ImagTitle="Margerita",
               PizzaName="Margerita",BasePrice=2,
               TomatoSauce=true,
               Cheese=true, 
               FinalPrice=4
           },
           new PizzasModel(){ImagTitle="Bolognese",
               PizzaName="Bolognese",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=5
           },
           new PizzasModel(){ImagTitle="Hawaiian",
               PizzaName="Hawaiian",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=6
           },
           new PizzasModel(){ImagTitle="MeatFeast",
               PizzaName="MeatFeast",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=7
           },
           new PizzasModel(){
               ImagTitle="Mushroom",
               PizzaName="Mushroom",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               FinalPrice=8
           },
           new PizzasModel(){ImagTitle="Pepperoni",
               PizzaName="Pepperoni",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               Peperoni=true,
               FinalPrice=9
           },
           new PizzasModel(){ImagTitle="Seafood",
               PizzaName="Seafood",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=10
           },
           new PizzasModel(){ImagTitle="Vegetarian",
               PizzaName="Vegetarian",BasePrice=2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=4
           },
         };
        public void OnGet()
        {
        }
    }
}
