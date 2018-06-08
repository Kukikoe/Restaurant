using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Restaurant.Entities;


namespace Restaurant.DBControllers
{
    public class DishesDbController
    {
        public static string ConnectionString = @"Server = tcp:studyserver.database.windows.net,1433;Initial Catalog = RestaurantDB; Persist Security Info=False;User ID=MainUser;Password=ghbvf2GHBVF; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
        /// <summary>
        /// Add dish in tbDishes
        /// </summary>
        /// <param name="name">Name of dish</param>
        /// <param name="recipeId">Id of recipe</param>
        /// <param name="portionSize">Size of portion</param>
        /// <param name="unit">Unit measurement of one dish</param>
        /// <param name="price">Price of one dish</param>
        /// <returns>Return count of added dishes (1 or 0)</returns>
        public static bool AddDish(string name, int recipeId, int portionSize, string unit, int price)
        {
            string sqlExpression = "AddDishSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
                command.Parameters.Add(new SqlParameter { ParameterName = "@recipeId", Value = recipeId });
                command.Parameters.Add(new SqlParameter { ParameterName = "@portionSize", Value = portionSize });
                command.Parameters.Add(new SqlParameter { ParameterName = "@unit", Value = unit });
                command.Parameters.Add(new SqlParameter { ParameterName = "@price", Value = price });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Select all dishes from tbDishes
        /// </summary>
        /// <returns>list of dishes</returns>
        public static List<Dish> GetDishes()
        {
            string sqlExpression = "SelectDishesSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<Dish> list = new List<Dish>();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int recipeId = reader.GetInt32(2);
                        int portionSize = reader.GetInt32(3);
                        string unit = reader.GetString(4);
                        int price = reader.GetInt32(5);
                        list.Add(new Dish(){Id = id, Name = name, RecipeId = recipeId, PortionSize = portionSize, Unit = unit, Price = price});
                    }
                }
                reader.Close();
                return list;
            }
        }
    }
}
