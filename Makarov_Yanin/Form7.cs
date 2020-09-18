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

    public partial class Form7 : Form
    {
        private SqlConnection connect;

        public class Читатели
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
        public Form7()
        {
            InitializeComponent();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.makarov_YaninDataSet.Читатели);

        }
        public void InsertЧитатели(int Паспорт_читателя, string Фамилия, string Имя, string Отчество, DateTime дата_рождения, int ID_Библиотеки, int номер_билета)
        {

            // Оператор SQL
            string sql = string.Format("Insert Into Читатели" +
                   "(Паспорт_читателя, Фамилия, Имя, Отчество, дата_рождения, ID_Библиотеки, номер_билета ) Values(@Паспорт_читателя, @Фамилия, @Имя, @Отчество, @дата_рождения, @ID_Библиотеки, @номер_билета)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Паспорт_читателя", Паспорт_читателя);
                cmd.Parameters.AddWithValue("@Фамилия", Фамилия);
                cmd.Parameters.AddWithValue("@Имя", Имя);
                cmd.Parameters.AddWithValue("@Отчество", Отчество);
                cmd.Parameters.AddWithValue("@дата_рождения", дата_рождения);
                cmd.Parameters.AddWithValue("@ID_Библиотеки", ID_Библиотеки);
                cmd.Parameters.AddWithValue("@ID_Библиотеки", номер_билета);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteЧитатели(int id)
        {
            string sql = string.Format("Delete from Читатели where Паспорт_читателя = '{0}'", id);
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
