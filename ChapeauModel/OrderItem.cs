using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class OrderItem : MenuItem
    {
        public int OrderID { get; set; }

        public OrderStatus Status { get; set; }

        public string Requests { get; set; }

        public int Quantity { get; set; }
        public DateTime OrderTime { get; set; }
        public string Comment { get; set; }

        public OrderItem() {    /*  :)  */  }
        public OrderItem(int OrderID, OrderStatus Status, string Requests, int Quantity, int ID, string Name, ItemType Type, MealType Mealtype, double Price, DateTime OrderTime)
            :base(ID, Name, Type, Mealtype, Price)
        {
            this.OrderID = OrderID;
            this.Status = Status;
            this.Requests = Requests;
            this.Quantity = Quantity;
        }
        public OrderItem(MenuItem item)
            : base(item.ID, item.Name, item.Type, item.MealType, item.Price)
        {   /*  :)  */  }
    }
}
