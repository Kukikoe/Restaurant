using Restaurant.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Restaurant.DBControllers
{
    public class LayoutDbController
    {
        public static string ConnectionString = @"Server=tcp:studyserver.database.windows.net,1433;Initial Catalog=RestaurantDB;Persist Security Info=False;User ID=MainUser;Password=ghbvf2GHBVF;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        /// <summary>
        /// Add new layout into tbLayout
        /// </summary>
        /// <param name="quatity">Quantity of product</param>
        /// <param name="idDish">Id of dish</param>
        /// <param name="idProduct">Id of product</param>
        /// <returns>Return count of added layouts (1 or 0)</returns>
        public static bool AddLayout(int quantity, int idDish, int idProduct)
        {
            string sqlExpression = "AddLayoutSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@quantity", Value = quantity });
                command.Parameters.Add(new SqlParameter { ParameterName = "@idDish", Value = idDish });
                command.Parameters.Add(new SqlParameter { ParameterName = "@idProduct", Value = idProduct });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Select layout from tbLayout
        /// </summary>
        /// <returns>list of layout</returns>
        public static List<Layout> GetLayouts()
        {
            string sqlExpression = "SelectLayoutsSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<Layout> list = new List<Layout>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int idDish = reader.GetInt32(1);
                        int idProduct = reader.GetInt32(2);
                        int quantity = reader.GetInt32(3);
                        list.Add(new Layout() { Id = id, IdDish = idDish, IdProduct = idProduct, Quantity = quantity });
                    }
                }
                reader.Close();
                return list;
            }
        }
    }
}
