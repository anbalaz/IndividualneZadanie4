using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
                    return employees;
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
                    return employees;
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
                                    employee.FirmStructure = reader.IsDBNull(6) ? null : new Structure() { ID = reader.GetInt32(6) };
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
                    return employee;
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
                                if (reader.Read())
                                {
                                    employee.ID = reader.GetInt32(0);
                                    employee.LastName = reader.GetString(1);
                                    employee.FirstName = reader.GetString(2);
                                    employee.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
                                    employee.PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                                    employee.EmailAddress = reader.IsDBNull(5) ? null : reader.GetString(5);
                                    employee.FirmStructure = reader.IsDBNull(6) ? null : new Structure() { ID = reader.GetInt32(6) };
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

        public bool InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"INSERT INTO Employee(FirstName,LastName,Title,PhoneNumber,EmailAddress,StructureID) 
                                               VALUES(@firstName, @lastName, @title, @phoneNumber, @emailAddress,@firmStructure)";

                        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = employee.FirstName;
                        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employee.LastName;
                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = (object)employee.Title ?? DBNull.Value;
                        command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = (object)employee.PhoneNumber ?? DBNull.Value;
                        command.Parameters.Add("@emailAddress", SqlDbType.NVarChar).Value = (object)employee.EmailAddress ?? DBNull.Value;
                        command.Parameters.Add("@firmStructure", SqlDbType.Int).Value = employee.FirmStructure != null ? (object)employee.FirmStructure.ID : DBNull.Value;
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n {ex}");
                        return false;
                    }
                }
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE Employee
                                               SET FirstName= @firstName,
                                                   LastName= @lastName,
                                                   Title =@title,
                                                   PhoneNumber= @phoneNumber,
                                                   EmailAddress= @emailAddress,
                                                   StructureID= @structureID
                                                   WHERE ID=@id";

                        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = employee.FirstName;
                        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employee.LastName;
                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = (object)employee.Title ?? DBNull.Value;
                        command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = (object)employee.PhoneNumber ?? DBNull.Value;
                        command.Parameters.Add("@emailAddress", SqlDbType.NVarChar).Value = (object)employee.EmailAddress ?? DBNull.Value;
                        command.Parameters.Add("@structureID", SqlDbType.Int).Value = employee.FirmStructure != null ? (object)employee.FirmStructure.ID : DBNull.Value;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = employee.ID;

                        return command.ExecuteNonQuery() > 0;
                    }

                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n {ex}");
                        return false;
                    }
                }
            }
        }
    }
}