using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozaicaApp
{
    public partial class LoginForm : Form
    {
        private string _connectionString = "Data Source=ADCLG1;Initial Catalog=Kozlov1091UP;Integrated Security=True;";
        public string role = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверные данные для входа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = loginTextBox.Text != "" && pswdTextBox.Text != "";
        }

        private bool CheckLogin()
        {
            string password = pswdTextBox.Text;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) " +
                    "FROM auth " +
                    "WHERE login = @login AND " +
                    "password = @pswd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", loginTextBox.Text);
                command.Parameters.AddWithValue("@pswd", password);
                if ((int)command.ExecuteScalar() == 1)
                {
                    string query2 = "SELECT role " +
                        "FROM auth " +
                        "WHERE login = @login AND password = @pswd";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@login", loginTextBox.Text);
                    command2.Parameters.AddWithValue("@pswd", password);
                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            role = reader[0].ToString();
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
