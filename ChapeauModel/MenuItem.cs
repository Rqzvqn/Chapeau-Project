using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ItemType Type { get; set; }
        public MealType MealType { get; set; }
        public double Price { get; set; }
        public MenuItem() { /*  :)  */ }

        public MenuItem(int ID, string Name, ItemType Type, MealType Mealtype, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Type = Type;
            this.MealType = MealType;
            this.Price = Price;
        }
    }
}
