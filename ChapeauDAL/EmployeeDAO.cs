using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDAO
    {
        public Employee GetEmployee(string username, string password)
        {
            string query = $"SELECT Id, name, role, password FROM Employee WHERE [name] = @username AND [password] = @password";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("username", username);
            sqlParameters[1] = new SqlParameter("password", password);

            List<Employee> employees = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (employees.Count == 0)
            {
                return null;
            }
            else
            {
                return employees[0];
            }
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee();

                employee.Id = (int)(dr["Id"]);
                employee.Name = (string)(dr["name"]);
                employee.Role = (Role)(int)dr["role"];
                employee.Password = (string)(dr["password"]);

                employees.Add(employee);
            }

            return employees;
        }
    }
}
