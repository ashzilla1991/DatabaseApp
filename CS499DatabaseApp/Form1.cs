using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS499DatabaseApp
{
    public partial class Form1 : Form
    {
        private CustomersDAO customersDAO;
        private OrdersDAO ordersDAO;
        BindingSource customersBindingSource = new BindingSource();
        BindingSource ordersBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            customersDAO = new CustomersDAO(); 
            ordersDAO = new OrdersDAO();       

            //text box
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        //load customers button
        private void button1_Click(object sender, EventArgs e)
        {
            //loading customers
            List<Customers> customers = customersDAO.GetAllCustomers();

            //setting the searched customers as the data source for the customers binding source
            customersBindingSource.DataSource = customers;

            //setting the customers binding source as the data source for the datagridview
            dataGridView1.DataSource = customersBindingSource;
        }

        //search customers button
        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;

            //searching customers
            List<Customers> customers = customersDAO.SearchCustomers(searchTerm);

            //setting the searched customers as the data source for the customers binding source
            customersBindingSource.DataSource = customers;

            //setting the customers binding source as the data source for the datagridview
            dataGridView1.DataSource = customersBindingSource;
        }

        //load orders button
        private void button4_Click(object sender, EventArgs e)
        {
            //loading orders
            List<Orders> orders = ordersDAO.GetAllOrders();

            //setting the searched orders as the data source for the orders binding source
            ordersBindingSource.DataSource = orders;

            //setting the orders binding source as the data source for the datagridview
            dataGridView1.DataSource = ordersBindingSource;
        }

        //search orders button
        private void button5_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox2.Text;

            //searching orders
            List<Orders> orders = ordersDAO.SearchOrders(searchTerm);

            //setting the searched orders as the data source for the orders binding source
            ordersBindingSource.DataSource = orders;

            //setting orders binding source as the data source for the datagridview
            dataGridView1.DataSource = ordersBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void groupBox1_Enter(object sender, EventArgs e)
        {}

        private void button3_Click_1(object sender, EventArgs e)
        {
            //error handling if orderID is the wrong format
            int orderId;
            if (!int.TryParse(txt_orderid.Text, out orderId))
            {
                MessageBox.Show("OrderID is invalid. Re-enter OrderID & try again.");
                return;
            }

            //error handling if customerID is the wrong format
            int customerId;
            if (!int.TryParse(txt_customerid.Text, out customerId))
            {
                MessageBox.Show("CustomerID is invalid. Re-enter CustomerID & try again.");
                return;
            }

            //create new object
            Orders order = new Orders
            {
                OrderID = orderId,
                CustomerID = customerId,
                SKU = txt_sku.Text,
                Description = txt_description.Text
            };

            //add order to the database
            int result = ordersDAO.AddOrder(order);

            if (result > 0)
            {
                //success order popup
                MessageBox.Show("Order added!");

                List<Orders> orders = ordersDAO.GetAllOrders();
                ordersBindingSource.DataSource = orders;
                dataGridView1.DataSource = ordersBindingSource;
            }
            else
            {
                //order error popup
                MessageBox.Show("Unable to add order.");
            }
        }

        //customers search box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;

            //validating search term
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridView1.DataSource = null;
                return;
            }

            //searching customers
            List<Customers> customers = customersDAO.SearchCustomers(searchTerm);

            //setting the searched customers as the data source for the customers binding source
            customersBindingSource.DataSource = customers;

            //setting customers binding source as the data source for the datagridview
            dataGridView1.DataSource = customersBindingSource;
        }

        //orders search box
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox2.Text;

            //validating search term
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridView1.DataSource = null;
                return;
            }

            //searching orders
            List<Orders> orders = ordersDAO.SearchOrders(searchTerm);

            //setting the searched orders as the data source for the ordersbinding source
            ordersBindingSource.DataSource = orders;

            //setting orders binding source as the data source for datagridview
            dataGridView1.DataSource = ordersBindingSource;
        }
    }
}
