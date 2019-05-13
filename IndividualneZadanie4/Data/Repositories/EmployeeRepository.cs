using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class EmployeeRepository
    {
        //public List<Employee> SelectEmployeeList()
        //{
        //    List<Employee> employeeList = new List<Employee>();
        //    using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
        //    {
        //        try
        //        {
        //            connection.Open();
        //        }
        //        catch (SqlException e)
        //        {
        //            Debug.WriteLine(e.Message);
        //        }
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = @"SELECT u.[ID],
        //                                    u.[LastName],
        //                                    u.[FirstName],
        //                                    u.[Title],
        //                                    u.[BirthDate],
        //                                    u.[HireDate],
        //                                    u.[TerminationDate],
        //                                    u.[Address],
        //                                    u.[PhoneNumber],
        //                                    u.[EmailAddress], 
        //                                    u.[Login], 
        //                                    u.[Password],
        //                                    ul.[ID],
        //                                    ul.[Name],
        //                                    t.[ID],
        //                                    t.[Name] AS [Town],
        //                                    t.[PostalCode],
        //                                    us.[ID],us.[LastName],us.[FirstName]
        //                                    FROM [Users] AS u
        //                                    INNER JOIN Towns AS t ON u.TownID= t.ID
        //                                    INNER JOIN UserLevels AS ul ON u.UserLevelID=ul.ID
        //                                    LEFT JOIN Users AS us ON u.ReportsToID= us.ID
        //                                    ORDER BY u.LastName ASC";
        //            try
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    {
        //                        while (reader.Read())
        //                        {
        //                            User user = new User();
        //                            user.ID = reader.GetInt32(0);
        //                            user.LastName = reader.GetString(1);
        //                            user.FirstName = reader.GetString(2);
        //                            user.Title = reader.IsDBNull(3) ? null : reader.GetString(3);
        //                            user.BirthDate = reader.GetDateTime(4);
        //                            user.HireDate = reader.GetDateTime(5);
        //                            user.TerminationDate = reader.IsDBNull(6) ? DateTime.MaxValue : reader.GetDateTime(6);
        //                            user.Address = reader.GetString(7);
        //                            user.PhoneNumber = reader.IsDBNull(8) ? null : reader.GetString(8);
        //                            user.EmailAddress = reader.IsDBNull(9) ? null : reader.GetString(9);
        //                            user.Login = reader.GetInt32(10);
        //                            user.Password = reader.GetString(11);

        //                            UserLevel userLevel = new UserLevel();
        //                            userLevel.ID = reader.GetInt32(12);
        //                            userLevel.Name = reader.GetString(13);
        //                            user.UserLevel = userLevel;

        //                            Town town = new Town();
        //                            town.ID = reader.GetInt32(14);
        //                            town.Name = reader.GetString(15);
        //                            town.PostalCode = reader.GetString(16);
        //                            user.Town = town;

        //                            if (!reader.IsDBNull(17))
        //                            {
        //                                User refersToUser = new User();
        //                                refersToUser.ID = reader.GetInt32(17);
        //                                refersToUser.LastName = reader.GetString(18);
        //                                refersToUser.LastName = reader.GetString(19);
        //                                user.UserToReport = refersToUser;
        //                            }
        //                            employeeList.Add(user);
        //                        }
        //                    }
        //                }
        //            }
        //            catch (SqlException e)
        //            {
        //                Debug.WriteLine(e.Message);
        //            }
        //        }
        //        return employeeList;
        //    }
        //}
    }
}
