using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Basecode.Main.Models
{
    public class SearchResultsModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public SearchResultsModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<string> SearchResults { get; set; }

        public void OnGet(string searchQuery)
        {
            // Connect to the database using the connection string from appsettings.json
            // string connectionString = _configuration.GetConnectionString("YourConnectionString");
            // using (SqlConnection connection = new SqlConnection(connectionString))
            // {
            //     connection.Open();

            //     // Perform a database query based on the search query
            //     string query = $"SELECT * FROM YourTable WHERE YourColumn LIKE '%{searchQuery}%'";
            //     using (SqlCommand command = new SqlCommand(query, connection))
            //     {
            //         SqlDataReader reader = command.ExecuteReader();
            //         SearchResults = new List<string>();

            //         while (reader.Read())
            //         {
            //             // Retrieve data from the database and add it to the SearchResults list
            //             string result = reader.GetString(0); // Replace 0 with the appropriate column index
            //             SearchResults.Add(result);
            //         }

            //         reader.Close();
            //     }

            //     connection.Close();
            // }
        }
    }
}