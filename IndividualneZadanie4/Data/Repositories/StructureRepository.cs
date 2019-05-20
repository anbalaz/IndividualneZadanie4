using Data.Models;
using System;
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
                    return structures;
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
                    return structures;
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
                    return structure;
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

        public bool UpdateStructure(Structure structure, int previousDirectorId)
        {
            string sqlQueryUpdateNewDirector = @"UPDATE Employee SET StructureID = @structureID WHERE ID = @employeeId";
            string sqlQueryUpdatePastDirector = @"UPDATE Employee SET StructureID = null WHERE ID = @previousDirectorId";
            string sqlQueryUpdateStructure = @"UPDATE Structure SET Name = @name, EmployeeID = @employeeID WHERE ID = @structureID";

            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = structure.Name;
                        command.Parameters.Add("@employeeID", SqlDbType.Int).Value = structure.Employee.ID != 0 ? (object)structure.Employee.ID : DBNull.Value;
                        command.Parameters.Add("@structureID", SqlDbType.Int).Value = structure.ID;
                        command.Parameters.Add("@previousDirectorId", SqlDbType.Int).Value = previousDirectorId;
                        try
                        {
                            if (previousDirectorId != 0)
                            {
                                command.CommandText = sqlQueryUpdatePastDirector;
                                command.ExecuteNonQuery();
                            }
                            command.CommandText = sqlQueryUpdateNewDirector;
                            command.ExecuteNonQuery();
                            command.CommandText = sqlQueryUpdateStructure;
                            command.ExecuteNonQuery();
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.StackTrace);
                            Debug.WriteLine(e.Message);
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool InsertStructure(Structure structure)
        {
            string sqlQueryUpdateDirector = @"UPDATE Employee SET StructureID = @structureID WHERE ID = @employeeID";
            string sqlQueryInsertStructure = @"INSERT INTO Structure(Name, Code, OrganizationLevel, EmployeeID, StructureID) 
                                               VALUES(@name, @code, @organizationLevel, @employeeId, @firmStructureID)";

            using (SqlConnection connection = new SqlConnection(Route.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = structure.Name;
                        command.Parameters.Add("@code", SqlDbType.Int).Value = structure.ID;
                        command.Parameters.Add("@organizationLevel", SqlDbType.Int).Value = (int)structure.Level;
                        command.Parameters.Add("@employeeID", SqlDbType.Int).Value = structure.Employee.ID != 0 ? (object)structure.Employee.ID : DBNull.Value;
                        command.Parameters.Add("@firmStructureID", SqlDbType.Int).Value = structure.FirmStructure != null ? (object)structure.FirmStructure.ID : DBNull.Value;
                        command.Parameters.Add("@structureID", SqlDbType.Int).Value = structure.ID;

                        try
                        {
                            command.CommandText = sqlQueryInsertStructure;
                            command.ExecuteNonQuery();
                            if (structure.Employee.ID != 0)
                            {
                                command.CommandText = sqlQueryUpdateDirector;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.StackTrace);
                            Debug.WriteLine(e.Message);
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}