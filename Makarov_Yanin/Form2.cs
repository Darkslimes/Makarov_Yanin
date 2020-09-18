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

namespace Makarov_Yanin
{
    public partial class Form2 : Form

    {
        private SqlConnection connect;

        public class Финансирование
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
        public Form2()
        {
            InitializeComponent();
        }

        private void финансированиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.финансированиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Финансирование". При необходимости она может быть перемещена или удалена.
            this.финансированиеTableAdapter.Fill(this.makarov_YaninDataSet.Финансирование);

        }

        public void InsertФинансирование(int ID_Библиотеки, string Источник_финансирования)
        {
            // Оператор SQL
            string sql = string.Format("Insert Into Финансирование" +"(ID_Библиотеки, Источник_финансирования) Values(@ID_Библиотеки, @Источник_финансирования)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@ID_Библиотеки", ID_Библиотеки);
                cmd.Parameters.AddWithValue("@Источник_финансирования", Источник_финансирования);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteФинансирование(int id)
        {
            string sql = string.Format("Delete from Финансирование where ID_Библиотеки = '{0}'", id);
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
