using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07.Services
{
    public class DatabaseConnectionService
    {

        // Property to store the connection string
        private readonly string _connectionString;

        // Constructor to initialize the connection string
        public DatabaseConnectionService()
        {
            // Set the connection string. Update this with your actual database details.
            _connectionString = "Server=localhost;Database=test;User ID=testuser;Password=testuser;";
        }

        // Method to get the connection string
        public string GetConnectionString()
        {
            return _connectionString;
        }

    }
}
