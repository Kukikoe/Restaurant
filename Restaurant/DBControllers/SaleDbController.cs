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
    public class SaleDbController
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
        public static bool AddSale(int idDish, int numOfSales)
        {
            double price = GetPriceOfDish(idDish);
            string sqlExpression = "AddSaleSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@idDish", Value = idDish });
                command.Parameters.Add(new SqlParameter { ParameterName = "@numOfSales", Value = numOfSales });
                command.Parameters.Add(new SqlParameter { ParameterName = "@totalAmount", Value = price * numOfSales });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Get price from tbDishes in order to know the value of all sales in column TotalAmount in table tbSales
        /// </summary>
        /// <param name="idDish">Id of dish</param>
        /// <returns>Price for dish</returns>
        public static double GetPriceOfDish(int idDish)
        {
            string sqlExpression = "SelectPriceFromtbDishesSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                double price = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        price = reader.GetDouble(0);

                    }
                }
                reader.Close();
                return price;
            }
        }
        /// <summary>
        /// Select sales from tbSales
        /// </summary>
        /// <returns>list of sales</returns>
        public static List<Sale> GetSales()
        {
            string sqlExpression = "SelectSalesSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<Sale> list = new List<Sale>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int idDish = reader.GetInt32(1);
                        int numOfSales = reader.GetInt32(2);
                        double totalAmount = reader.GetDouble(3);
                        list.Add(new Sale() { Id = id, IdDish = idDish, NumOfSales = numOfSales, TotalAmount = totalAmount });
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
        public static bool DeleteSale(int id)
        {
            string sqlExpression = "DeleteSaleSP";
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
