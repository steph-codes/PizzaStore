using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4 
            },
            
            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
             new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            },
            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                Baseprice=2, TomatoSauce=true,
                Cheese=true, FinalPrice=4
            }

        };
        public void OnGet()
        {
        }
    }
}
