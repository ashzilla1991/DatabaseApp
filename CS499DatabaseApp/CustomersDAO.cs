using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CS499DatabaseApp
{
    //class for customers data access operations
    internal class CustomersDAO
    {
        //connecting to MySQL database
        private string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=quantigrationrma;";

        //pulling all the customers in the database
        public List<Customers> GetAllCustomers()
        {
            //list that stores all customers
            List<Customers> returnThese = new List<Customers>();

            try
            {

                //connecting to MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    
                    //SQL query for selecting all customers
                    string query = "SELECT * FROM CUSTOMERS";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating a new object & populating it
                                Customers customer = new Customers
                                {
                                    CustomerID = reader.GetInt32(0),
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    StreetAddress = reader.GetString(3),
                                    City = reader.GetString(4),
                                    State = reader.GetString(5),
                                    ZipCode = reader.GetInt32(6),
                                    Telephone = reader.GetString(7)
                                };
                                //adding customer to the list
                                returnThese.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //error handling
                Console.WriteLine("The following error occurred: " + ex.Message);
            }

            //return list of customers
            return returnThese;
        }

        //searching for customers
        public List<Customers> SearchCustomers(string searchTerm)
        {
            //list that stores searched customers
            List<Customers> returnThese = new List<Customers>();

            try
            {   //connecting to MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    ////SQL query for searching customers that match what's in the search box
                    string query = "SELECT * FROM CUSTOMERS WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR City LIKE @SearchTerm OR State LIKE @SearchTerm";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //adding the search terms to the query
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating and populating new object
                                Customers customer = new Customers
                                {
                                    CustomerID = reader.GetInt32(0),
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    StreetAddress = reader.GetString(3),
                                    City = reader.GetString(4),
                                    State = reader.GetString(5),
                                    ZipCode = reader.GetInt32(6),
                                    Telephone = reader.GetString(7)
                                };
                                //adding customers to the list
                                returnThese.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //error handling
                Console.WriteLine("The following error occurred: " + ex.Message);
            }

            //return customers that match the search
            return returnThese;
        }
    }
}
