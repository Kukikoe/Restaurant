using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant.DBControllers
{
    public class ProductDbController
    {
        public static string ConnectionString = @"Server=tcp:studyserver.database.windows.net,1433;Initial Catalog=RestaurantDB;Persist Security Info=False;User ID=MainUser;Password=ghbvf2GHBVF;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        /// <summary>
        /// Add new product into tbProducts
        /// </summary>
        /// <param name="name">Name of product</param>
        /// <param name="unit">Unit measurement of product</param>
        /// <returns>Return count of added products (1 or 0)</returns>
        public static bool AddProduct(string name, string unit)
        {
            string sqlExpression = "AddProductSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
                command.Parameters.Add(new SqlParameter { ParameterName = "@unit", Value = unit });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Select products from tbProducts
        /// </summary>
        /// <returns>list of products</returns>
        public static List<Product> GetProducts()
        {
            string sqlExpression = "SelectProductsSp";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                List<Product> list = new List<Product>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string unit = reader.GetString(2);
                        list.Add(new Product() { Id = id, Name = name, Unit = unit });
                }
            }
                return list;
            }
        }
        /// <summary>
        /// Delete row with current ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Return true if deleting success, else false</returns>
        public static bool DeleteProduct(int id)
        {
            string sqlExpression = "DeleteProductSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
                command.ExecuteNonQuery();
                return true;

            }
        }
    }
}
