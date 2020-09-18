using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makarov_Yanin
{
    public partial class Form3 : Form
    {
        private SqlConnection connect;

        public class Библиотеки
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
        public Form3()
        {
            InitializeComponent();
        }

        private void библиотекиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.библиотекиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Библиотеки". При необходимости она может быть перемещена или удалена.
            this.библиотекиTableAdapter.Fill(this.makarov_YaninDataSet.Библиотеки);

        }
        public void InsertБиблиотеки(int ID_Библиотеки, string Название_библиотеки, string Улица, string Номер_строения)
        {

            // Оператор SQL
            string sql = string.Format("Insert Into Inventory" +
                   "(ID_Библиотеки, Название_библиотеки, Улица, Номер_строения) Values(@ID_Библиотеки, @Название_библиотеки, @Улица, @Номер_строения)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("ID_Библиотеки", ID_Библиотеки);
                cmd.Parameters.AddWithValue("Название_библиотеки", Название_библиотеки);
                cmd.Parameters.AddWithValue("Улица", Улица);
                cmd.Parameters.AddWithValue("Номер_строения", Номер_строения);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteБиблиотеки(int id)
        {
            string sql = string.Format("Delete from Библиотеки where ID_Библиотеки = '{0}'", id);
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form test = new Form1();
            test.Show();
            this.Hide();
        }


    }

}
