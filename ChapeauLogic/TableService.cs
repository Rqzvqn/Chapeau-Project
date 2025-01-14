using System;
using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class TableService
    {
        private TableDAO tableDAO;
        public TableService()
        {
            tableDAO = new TableDAO();
        }


        public List<Table> GetAllTables()
        {
            List<Table> tables = tableDAO.GetAllTables();
            return tables;
        }

        public Table GetTableByTableNR(int tableNr)
        {
            Table table = tableDAO.GetTableByTableNr(tableNr);
            return table;

        }

        public void UpdateStateTableToTrue(int tableNR)
        {
            tableDAO.UpdateStateTableToTrue(tableNR);
        }
    }
}
