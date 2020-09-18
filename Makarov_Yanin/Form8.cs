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
    public partial class Form8 : Form
    {
        private SqlConnection connect;
        public class читательский_билет
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
        public Form8()
        {
            InitializeComponent();
        }

        private void читательский_билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательский_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Читательский_билет". При необходимости она может быть перемещена или удалена.
            this.читательский_билетTableAdapter.Fill(this.makarov_YaninDataSet.Читательский_билет);

        }
        public void InsertЧитательский_билет(int Номер_билета, int Паспорт_читателя, DateTime Дата_выдачи, DateTime Дата_сдачи, int ISBN)
        {

            // Оператор SQL
            string sql = string.Format("Insert Into Читательский_билет" +
                   "(Номер_билета, Паспорт_читателя, Дата_выдачи, Дата_сдачи, ISBN) Values(@Номер_билета, @Паспорт_читателя, @Дата_выдачи, @Дата_сдачи, @ISBN)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Номер_билета", Номер_билета);
                cmd.Parameters.AddWithValue("@Паспорт_читателя", Паспорт_читателя);
                cmd.Parameters.AddWithValue("@Дата_выдачи", Дата_выдачи);
                cmd.Parameters.AddWithValue("@Дата_сдачи", Дата_сдачи);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
    

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteЧитательский_билет(int id)
        {
            string sql = string.Format("Delete from Читательский_билет where Номер_билета = '{0}'", id);
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
