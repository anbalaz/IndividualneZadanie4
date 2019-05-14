using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> SelectEmployeesList(int code)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT ID,LastName,FirstName,Title,PhoneNumber,EmailAddress,StructureID FROM Employee WHERE StructureID =@code;";
                    command.Parameters.Add("@code", SqlDbType.Int).Value = code;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Employee employee = new Employee();
                                    employee.ID = reader.GetInt32(0);
                                    employee.LastName = reader.GetString(1);
                                    employee.FirstName = reader.GetString(2);
                                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                                    employee.PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                                    employee.EmailAddress = reader.IsDBNull(5) ? null : reader.GetString(5);
                                    employee.FirmStructure = new Structure() {ID= reader.GetInt32(6) };
                                    employees.Add(employee);
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return employees;
            }
        }

        public List<Employee> SelectEmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT ID,LastName,FirstName,Title,PhoneNumber,EmailAddress,StructureID FROM Employee;";
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Employee employee = new Employee();
                                    employee.ID = reader.GetInt32(0);
                                    employee.LastName = reader.GetString(1);
                                    employee.FirstName = reader.GetString(2);
                                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                                    employee.PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                                    employee.EmailAddress = reader.IsDBNull(5) ? null : reader.GetString(5);
                                    employee.FirmStructure = new Structure() { ID = reader.GetInt32(6) };
                                    employees.Add(employee);
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return employees;
            }
        }

        public Employee SelectEmployee(int code)
        {
            Employee employee = new Employee();
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {   
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT s.EmployeeID,LastName,FirstName,Title,PhoneNumber,EmailAddress,e.StructureID FROM Employee AS e
                                            LEFT JOIN Structure AS s ON s.EmployeeID=e.ID
                                            WHERE s.EmployeeID=@code;";
                    command.Parameters.Add("@code", SqlDbType.Int).Value = code;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    employee.ID = reader.GetInt32(0);
                                    employee.LastName = reader.GetString(1);
                                    employee.FirstName = reader.GetString(2);
                                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                                    employee.PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                                    employee.EmailAddress = reader.IsDBNull(5) ? null : reader.GetString(5);
                                    employee.FirmStructure = new Structure() { ID = reader.GetInt32(6) };
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return employee;
            }
        }
    }
}
