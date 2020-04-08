using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VipWeb.Model;

namespace VipWeb.Data
{
    public static class VipDataContext
    {
        static VipDataContext()
        {
            var menuList = new List<Menu>
            {
                new Menu { Id = 1, Name = "Coffee", Image = "https://i.imgur.com/32myl6t.jpg",
                    SubMenus =new List<SubMenu> { new SubMenu { Id = 1,Name = "Cappuccino",
                    Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with double espresso, and steamed milk foam.",
                    Price = 200,Image = "https://s15.postimg.cc/gs8p61egb/cappuccino.jpg"},
                    new SubMenu { Id = 2,Name = "Americano",
                    Description = "Caffè Americano is a type of coffee prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from traditionally brewed coffee.",
                    Price = 200,Image = "https://s15.postimg.cc/nvgklnc63/americano.jpg"},
                    new SubMenu { Id = 3,Name = "Mocha",
                    Description = "A caffè mocha, also called mocaccino, is a chocolate-flavored variant of a caffè latte. Other commonly used spellings are mochaccino and also mochachino.",
                    Price = 200,Image = "https://s15.postimg.cc/dle5mfh5n/mocha.jpg"}},
                },
                new Menu { Id = 2, Name = "Tea", Image = "https://i.imgur.com/BbJvKUl.jpg",
                    SubMenus = new List<SubMenu>
                    {
                    new SubMenu { Id = 4,Name = "Green Tea",
                    Description = "Green tea is a type of tea that is made from Camellia sinensis leaves that have not undergone the same withering and oxidation process used to make oolong teas and black teas.",
                    Price = 200,Image = "https://i.imgur.com/LmUJk2V.jpg\r\n"},
                    new SubMenu { Id = 5,Name = "Americano",
                    Description = "Black tea is a type of tea that is more oxidized than oolong, green, and white teas.",
                    Price = 200,Image = "https://i.imgur.com/aNp2kUe.jpg\r\n"},
                    },
                },
                new Menu { Id = 3, Name = "Cold Drinks", Image = "https://i.imgur.com/BbJvKUl.jpg",
                    SubMenus = new List<SubMenu>
                    {
                    new SubMenu { Id = 6,Name = "Apple Juice",
                    Description = "Apple juice is a fruit juice made by the maceration and pressing of an apple.",
                    Price = 200,Image = "https://i.imgur.com/cKMstjY.jpg"},
                    new SubMenu { Id = 7,Name = "Orange Juice",
                    Description = "Orange juice is the liquid extract of the orange tree fruit, produced by squeezing oranges.",
                    Price = 200,Image = "https://i.imgur.com/PC6f3Dc.jpg"},
                    },
                },
            };

            Menus = menuList;
        }


        public static List<Menu> Menus { get; set; }
        public static List<Reservation> Reservations { get; set; }
    }
}
