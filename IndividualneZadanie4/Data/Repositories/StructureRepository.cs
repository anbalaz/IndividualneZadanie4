using Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Data.Repositories
{
    public class StructureRepository
    {

        public List<Structure> SelectStructureList(int code, OrganizationLevel level)
        {
            List<Structure> structures = new List<Structure>();
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
                    string sqlQuery = $"SELECT * FROM Structure WHERE OrganizationLevel=@level";
                    if (code != 0)
                    {
                        sqlQuery += " AND StructureID=@code";
                        command.Parameters.Add("@code", SqlDbType.Int).Value = code;
                    }
                    command.Parameters.Add("@level", SqlDbType.Int).Value = (int)level;
                    command.CommandText = sqlQuery;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Structure structure = new Structure();
                                    structure.ID = reader.GetInt32(0);
                                    structure.Name = reader.GetString(1);
                                    structure.Code = reader.GetInt32(2);
                                    structure.Level = (OrganizationLevel)reader.GetInt32(3);
                                    structure.Employee = reader.IsDBNull(4) ? null : new Employee() { ID = reader.GetInt32(4) };
                                    structure.FirmStructure = reader.IsDBNull(5) ? null : new Structure() { ID = reader.GetInt32(5) };

                                    structures.Add(structure);
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return structures;
            }
        }

        public List<Structure> SelectStructureList()
        {
            List<Structure> structures = new List<Structure>();
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
                    string sqlQuery = $"SELECT * FROM Structure";
                    command.CommandText = sqlQuery;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Structure structure = new Structure();
                                    structure.ID = reader.GetInt32(0);
                                    structure.Name = reader.GetString(1);
                                    structure.Code = reader.GetInt32(2);
                                    structure.Level = (OrganizationLevel)reader.GetInt32(3);
                                    structure.Employee = reader.IsDBNull(4) ? null : new Employee() { ID = reader.GetInt32(4) };
                                    structure.FirmStructure = reader.IsDBNull(5) ? null : new Structure() { ID = reader.GetInt32(5) };
                                    structures.Add(structure);
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return structures;
            }
        }

        public Structure SelectStructure(int code)
        {
            Structure structure = new Structure();
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
                    string sqlQuery = $"SELECT * FROM Structure WHERE Code=@code";
                    command.Parameters.Add("@code", SqlDbType.Int).Value = code;
                    command.CommandText = sqlQuery;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    structure.ID = reader.GetInt32(0);
                                    structure.Name = reader.GetString(1);
                                    structure.Code = reader.GetInt32(2);
                                    structure.Level = (OrganizationLevel)reader.GetInt32(3);
                                    structure.Employee = reader.IsDBNull(4) ? null : new Employee() { ID = reader.GetInt32(4) };
                                    structure.FirmStructure = reader.IsDBNull(5) ? null : new Structure() { ID = reader.GetInt32(5) };
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }
                return structure;
            }
        }
    }
}