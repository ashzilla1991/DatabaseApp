using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CS499DatabaseApp
{
    //class for orders data access operations
    internal class OrdersDAO
    {
        //connecting to MySQL database
        private string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=quantigrationrma;";

        //pulling all the orders in the database
        public List<Orders> GetAllOrders()
        {
            //list that stores all the orders
            List<Orders> returnThese = new List<Orders>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //SQL query for selecting the orders
                    string query = "SELECT * FROM ORDERS";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating a new object & populating it 
                                Orders order = new Orders
                                {
                                    OrderID = reader.GetInt32(0),
                                    CustomerID = reader.GetInt32(1),
                                    SKU = reader.GetString(2),
                                    Description = reader.GetString(3),
                                };
                                //order is added to the list
                                returnThese.Add(order);
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

            //return list of orders
            return returnThese;
        }

        //adding a new order to the database
        public int AddOrder(Orders order)
        {
            int result = 0;

            try
            {
                //connecting to MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //SQL query for adding a new order
                    string query = "INSERT INTO ORDERS (OrderID, CustomerID, SKU, Description) VALUES (@OrderID, @CustomerID, @SKU, @Description)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //parameters for the SQL query
                        command.Parameters.AddWithValue("@OrderID", order.OrderID);
                        command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                        command.Parameters.AddWithValue("@SKU", order.SKU);
                        command.Parameters.AddWithValue("@Description", order.Description);

                        //executing query
                        result = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //error handling
                Console.WriteLine("The following error occurred: " + ex.Message);
            }

            return result;
        }

        //searching for orders
        public List<Orders> SearchOrders(string searchTerm)
        {
            //list that stores searched orders
            List<Orders> returnThese = new List<Orders>();

            try
            {
                //connecting to MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //SQL query for searching orders that match what's in the search box
                    string query = "SELECT * FROM ORDERS WHERE OrderID LIKE @SearchTerm OR CustomerID LIKE @SearchTerm OR SKU LIKE @SearchTerm OR Description LIKE @SearchTerm";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //adding the search terms to the query
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //creating & populating new object
                                Orders order = new Orders
                                {
                                    OrderID = reader.GetInt32(0),
                                    CustomerID = reader.GetInt32(1),
                                    SKU = reader.GetString(2),
                                    Description = reader.GetString(3),
                                };
                                //adding order to list
                                returnThese.Add(order);
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

            //returning the orders that match the search
            return returnThese;
        }
    }
}
