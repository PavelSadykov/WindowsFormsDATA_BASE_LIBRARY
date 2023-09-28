using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsDATA_BASE_LIBRARY
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
           
            connection = new SqlConnection(@"Data Source=DESKTOP-EKD1ADK;Initial Catalog=Library;Integrated Security=True");
        }
        private void ShowPopularBooksButton_Click(object sender, EventArgs e)
        {
            int numberOfPopularBooks = 3; // 3 самые популярные книги

            //  SQL-запрос 
            string query = $"SELECT TOP {numberOfPopularBooks} Title, TotalCopies - CopiesInLibrary As MostPopular\r\nFROM Books\r\nORDER BY MostPopular DESC;";
            DataTable popularBooks = ExecuteQuery(query);

            // Привязка данных к DataGridView
            dataGridView1.DataSource = popularBooks;
        }

        private void ShowNotPopularBooksButton_Click(object sender, EventArgs e)
        {
            int numberOfBooks = 3; // 3 самые не популярные книги

           //аналогично
            string query = $"SELECT TOP {numberOfBooks} Title, TotalCopies - CopiesInLibrary As NotPopular\r\nFROM Books\r\nORDER BY NotPopular;";
            DataTable NotPopularBooks = ExecuteQuery(query);

            //аналогично
            dataGridView1.DataSource = NotPopularBooks;
        }
        // Метод для выполнения SQL-запроса и возврата результатов в виде DataTable
        private DataTable ExecuteQuery(string query)
        {
            string connectionString = "Data Source=DESKTOP-EKD1ADK;Initial Catalog=Library;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;

            if (!string.IsNullOrEmpty(author) || !string.IsNullOrEmpty(title))
            {
                string query = "";
                if (!string.IsNullOrEmpty(author))
                {
                    query = $"SELECT Title, CopiesInLibrary FROM Books WHERE Author = '{author}'";
                }
                else if (!string.IsNullOrEmpty(title))
                {
                    query = $"SELECT Author, CopiesInLibrary FROM Books WHERE Title = '{title}'";
                }

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    resultDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Введите автора или название книги.");
            }
        }

        private void ShowNotPopularBooksButton_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}

