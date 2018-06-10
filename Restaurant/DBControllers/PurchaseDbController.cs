using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DBControllers
{
    public class PurchaseDbController
    {
        public static string ConnectionString = @"Server=tcp:studyserver.database.windows.net,1433;Initial Catalog=RestaurantDB;Persist Security Info=False;User ID=MainUser;Password=ghbvf2GHBVF;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        /// <summary>
        /// Add purchase in tbPurchasess
        /// </summary>
        /// <param name="idProduct">Id of product</param>
        /// <param name="quantity">Quantity of product</param>
        /// <param name="price">Price for one unit</param>
        /// <param name="unit">Unit measurement of product</param>
        /// <returns></returns>
        public static bool AddPurchase(int idProduct, double quantity, double price, string unit)
        {
            string sqlExpression = "AddPurchaseSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@idProduct", Value = idProduct });
                command.Parameters.Add(new SqlParameter { ParameterName = "@quantity", Value = quantity });
                command.Parameters.Add(new SqlParameter { ParameterName = "@price", Value = price });
                command.Parameters.Add(new SqlParameter { ParameterName = "@unit", Value = unit });
                command.Parameters.Add(new SqlParameter { ParameterName = "@totalAmount", Value = price * quantity });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Select purchases from tbPurchases
        /// </summary>
        /// <returns>list of purchases</returns>
        public static List<Purchase> GetPurchases()
        {
            string sqlExpression = "SelectPurchasesSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<Purchase> list = new List<Purchase>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int idProduct = reader.GetInt32(1);
                        double quantity = reader.GetDouble(2);
                        double price = reader.GetDouble(3);
                        string unit = reader.GetString(4);
                        double totalAmount = reader.GetDouble(5);
                        list.Add(new Purchase() { Id = id, IdProduct = idProduct, Quantity = quantity, Price = price, Unit = unit, TotalAmount = totalAmount });
                    }
                }
                reader.Close();
                return list;
            }
        }
        /// <summary>
        /// Delete row with current ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Return true if deleting success, else false</returns>
        public static bool DeletePurchase(int id)
        {
            string sqlExpression = "DeletePurchaseSP";
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
