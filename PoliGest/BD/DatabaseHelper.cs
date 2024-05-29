using System;
using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string _connectionString = @"Data Source=LAPTOP-UGB52NOD\SQLEXPRESS;Initial Catalog=PoliGest;Integrated Security=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
    public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        try
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao executar a consulta não query.", ex);
        }
    }

    public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        try
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao executar a consulta query.", ex);
        }
    }

    public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
    {
        try
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao executar a consulta escalar.", ex);
        }
    }

    public static int Insert(string tableName, SqlParameter[] parameters)
    {
        try
        {
            string query = $"INSERT INTO {tableName} VALUES (";
            for (int i = 0; i < parameters.Length; i++)
            {
                query += "@" + parameters[i].ParameterName;
                if (i < parameters.Length - 1)
                {
                    query += ",";
                }
            }
            query += "); SELECT SCOPE_IDENTITY();";

            object result = ExecuteScalar(query, parameters);
            return Convert.ToInt32(result == null ? -1 : result);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao inserir registro na tabela.", ex);
        }
    }

    public static void Update(string tableName, string whereCondition, SqlParameter[] parameters)
    {
        try
        {
            string query = $"UPDATE {tableName} SET ";
            for (int i = 0; i < parameters.Length; i++)
            {
                query += $"{parameters[i].ParameterName.Substring(1)} = @{parameters[i].ParameterName}";
                if (i < parameters.Length - 1)
                {
                    query += ",";
                }
            }
            query += $" WHERE {whereCondition}";
            ExecuteNonQuery(query, parameters);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao atualizar registro na tabela.", ex);
        }
    }

    public static void Delete(string tableName, string whereCondition, SqlParameter[] parameters)
    {
        try
        {
            string query = $"DELETE FROM {tableName} WHERE {whereCondition}";
            ExecuteNonQuery(query, parameters);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao excluir registro da tabela.", ex);
        }
    }
}