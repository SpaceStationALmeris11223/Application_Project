using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class PlaceOrder : PageModel
    {
        public List<MenuOption> MenuOptions {get; set;}
        public void OnGet()
        {
            MenuOptions = new List<MenuOption>
            {
                //List of Menu optionss
                new MenuOption
                {
                    Name = "Tiger Burger basket",
                    Description = "The original burger that put us on the map. a 1/3-pound patty topped with caramelized onions, lettuce, bacon bits, and our world-famous tiger sauce. Comes with a side of fries or coleslaw.",
                    Price = "13.00",
                    Image = "/Images/TigerBurger.jpg",
                },
                new MenuOption
                {
                    Name = "Crocodilius steak no sides",
                    Description = "Another of our house specials. 1/2 a pound of Crocodile steak, seasoned with 4 of our special seasoning.",
                    Price = "16.00",
                    Image = "/Images/CrocodiliusSteak.jpeg",
                },
                new MenuOption
                {
                    Name = "Cheese Curds",
                    Description = "Cheese curds made with wisconsin cheese, can be beer battered upon request.",
                    Price = "7.00",
                    Image = "/Images/CheeseCurds.jpg",
                },
                new MenuOption
                {
                    Name = "House Jerk wings",
                    Description = "Juicy chicken wings, perfectly charred on the outside with a smoky, bold flavor. Each bite is a mouthwatering explosion of savory heat, and smokey goodness",
                    Price = "12.00",
                    Image = "/Images/JerkWings.jpeg",
                },
                new MenuOption
                {
                    Name = "Coca-Cola",
                    Description = "CocaCola from our foutain",
                    Price = "1.50",
                    Image = "/Images/CocaCola.jpeg",
                },
                new MenuOption
                {
                    Name = "Manhattan Cocktail",
                    Description = "The Manhattan is a smooth, bold blend of whiskey, sweet vermouth, and bitters, delivering a timeless, sophisticated flavor that makes every sip feel like a celebration.",
                    Price = "14.00",
                    Image = "/Images/Manhattan.jpeg",
                }
            };
        }
     public class MenuOption
        {
        public string Name {get; set;}
        public string Description {get; set;}
        public string Price {get; set;}
        public string Image {get; set;}
        }
    }
}
