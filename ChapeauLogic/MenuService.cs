using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuService
    {
        private MenuDAO menuDAO;

        public MenuService()
        {
            menuDAO = new MenuDAO();
        }

        public List<MenuItem> GetMenu()
        {
            return menuDAO.GetMenu();
        }
    }
}
