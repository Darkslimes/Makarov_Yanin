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

namespace Makarov_Yanin
{
    public partial class Form5 : Form
    {
        private SqlConnection connect;

        public class Книги
        {
            private SqlConnection connect = null;

            public void OpenConnection(string connectionString)
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
            }

            public void CloseConnection()
            {
                connect.Close();
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.makarov_YaninDataSet.Книги);

        }
        public void InsertКниги(int ISBN, string Название_книги, string Язык, string Автор, string Жанр, DateTime год_изадния, int ID_Библиотеки)
        {

            // Оператор SQL
            string sql = string.Format("Insert Into Inventory" +
                   "(ISBN, Название_книги, Язык, Автор, Жанр, год_изадния, ID_Библиотеки) Values(@ISBN, @Название_книги, @Язык, @Автор, @Жанр, @год_издания, @ID_Библиотеки)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Название_книги", Название_книги);
                cmd.Parameters.AddWithValue("@Язык", Язык);
                cmd.Parameters.AddWithValue("@Автор", Автор);
                cmd.Parameters.AddWithValue("@Жанр", Жанр);
                cmd.Parameters.AddWithValue("@год_изадния", год_изадния);
                cmd.Parameters.AddWithValue("@ID_Библиотеки", ID_Библиотеки);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteКниги(int id)
        {
            string sql = string.Format("Delete from Книги where ISBN = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("[Fuck u]", ex);
                    throw error;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form test = new Form1();
            test.Show();
            this.Hide();
        }
    }

}
