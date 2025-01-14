using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public enum Role
    {
        Manager = 1,Chef,Waiter,Barman
    }
    public enum OrderStatus
    {
        New = 1, Preparing, Ready, Served, Paid
    }
    public enum Payment
    {
        Cash, Card
    }
    public enum TableStatus
    {
        Free, Reserved, Occupied, Ongoing, FoodReady, FoodServed, Paying
    }
    public enum ItemType
    {
        Starters = 1, Main, Entremet, Desert, Softdrink, Beer, wine, Spiritdrink, CoffeeTea
    }
    public enum MealType
    {
        Lunch = 1, Dinner, Other
    }
    /*public enum OrderItemStatus
    {
        NotStarted = 1, Preparing, Done, Served
    }*/
}
