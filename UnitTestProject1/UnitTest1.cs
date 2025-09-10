using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string _connectionString = "Data Source=ADCLG1;Initial Catalog=Kozlov1091UP;Integrated Security=True;";

        [TestMethod]
        public void adminAuthCheck()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) " +
                    "FROM auth " +
                    "WHERE login = 'admin' AND " +
                    "password = 'admin'";
                SqlCommand command = new SqlCommand(query, connection);
                int result = (int)command.ExecuteScalar();
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void reuestsPriceCheck()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                double result = 0;
                string query = "SELECT SUM(price) " +
                    "FROM requests ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = Convert.ToDouble(reader[0]);
                }
                Assert.AreEqual(122700, result);
            }
        }
        [TestMethod]
        public void reuestsProductsAmountCheck()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Count(product_id) " +
                    "FROM reuests_products";
                SqlCommand command = new SqlCommand(query, connection);
                int result1 = (int)command.ExecuteScalar();

                string query2 = "SELECT product_amount " +
                    "FROM requests";
                SqlCommand command2 = new SqlCommand(query2, connection);
                int result2 = (int)command.ExecuteScalar();
                
                Assert.AreEqual(result1, result2);
            }
        }
    }
}