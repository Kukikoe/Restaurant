using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace RestaurantDataAccessLayer.DBControllers
{
    public class RecipeDbController
    {
        public static string ConnectionString = "Server = tcp:studyserver.database.windows.net,1433;Initial Catalog = RestaurantDB; Persist Security Info=False;User ID=MainUser;Password=ghbvf2GHBVF; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

        /// <summary>
        /// Add recipe in tbRecipes
        /// </summary>
        /// <param name="nameDish">Name of dish</param>
        /// <param name="recipe">Recipe of this dish</param>
        /// <returns>Return count of added recipes (1 or 0)</returns>
        public static bool AddRecipe(string nameDish, string recipe)
        {
            string sqlExpression = "AddRecipeSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@nameDish", Value = nameDish });
                command.Parameters.Add(new SqlParameter { ParameterName = "@resipe", Value = recipe });
                var result = command.ExecuteScalar();
                return true;
            }
        }
        /// <summary>
        /// Select recipe from tbRecipes
        /// </summary>
        /// <returns>list of recipes</returns>
        public static List<Recipe> GetRecipes()
        {
            string sqlExpression = "SelectRecipesSP";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                List<Recipe> list = new List<Recipe>();
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nameDish = reader.GetString(1);
                        string recipe = reader.GetString(2);

                        list.Add(new Recipe(){Id = id, NameDish = nameDish, Recipy = recipe});
                    }
                }
                reader.Close();
                return list;
            }
        }
    }
}
