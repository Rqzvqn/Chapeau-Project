using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using System.Collections.Generic;
using ChapeauDAL;

namespace ChapeauDAL
{
    public class TableDAO:BaseDAO
    {
        public List<Table> GetAllTables()
        {
            string query = $"SELECT tableId, capacity, tableNR, status FROM [Table]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Table> tables = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return tables;
        }

        public void UpdateStateTableToTrue(int tableNR)
        {
            string query = $"UPDATE [Table] SET status=2 WHERE tableId=@tableNR";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableNR", tableNR);

            ExecuteEditQuery(query, sqlParameters);
        }

        public Table GetTableByTableNr(int tableNR)
        {
            string query = "SELECT tableId, capacity, [status], tableNR FROM [Table] WHERE tableId=@tableNR";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableNR", tableNR);

            List<Table> tables = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (tables.Count > 0)
            {
                return tables[0];
            } else
            {
                return null;
            }
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();

                table.TableId = (int)(dr["tableId"]);
                table.Capacity = (int)(dr["capacity"]);
                table.TableNumber = (int)(dr["tableNR"]);
                table.Status = (TableStatus)(dr["status"]);

                tables.Add(table);
            }

            return tables;
        }
    }
}
