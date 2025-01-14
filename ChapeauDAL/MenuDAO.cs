using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class MenuDAO:BaseDAO
    {
        public List<MenuItem> GetMenu()
        {
            string query = "SELECT ID, name, type, price, Mealtype FROM Menu";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<MenuItem> Menu = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return Menu;
        }
        //public List<MenuCategory> GetDrinks()
        //{
        //    string query = "SELECT ID, name , type, price, Mealtype FROM Menu WHERE Mealtype = 3";

        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    List<MenuItem> drinks = ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //    return drinks;
        //}

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> Menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem();

                item.ID = (int)(dr["ID"]);
                item.Name = (string)(dr["name"]);
                item.Type = (ItemType)(int)dr["type"];
                item.MealType = (MealType)(dr["Mealtype"]);
                item.Price = (double)dr["price"];

                Menu.Add(item);
            }

            return Menu;
        }
    }
}
