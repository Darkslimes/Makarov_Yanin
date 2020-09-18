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
    public partial class Form6 : Form
    {
        private SqlConnection connect;

        public class Сотрудники
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
        public Form6()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.makarov_YaninDataSet.Сотрудники);

        }
        public void InsertСотрудники(int Паспорт_сотрудника, string Фамилия, string Имя, string Отчество, DateTime год_рождения, int оклад, int ID_Библиотеки)
        {

            // Оператор SQL
            string sql = string.Format("Insert Into Сотрудники" +
                   "(Паспорт_сотрудника, Фамилия, Имя, Отчество, год_рождения, оклад, ID_Библиотеки) Values(@Паспорт_сотрудника, @Фамилия, @Имя, @Отчество, @год_рождения, @оклад, @ID_Библиотеки)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Паспорт_сотрудника", Паспорт_сотрудника);
                cmd.Parameters.AddWithValue("@Фамилия", Фамилия);
                cmd.Parameters.AddWithValue("@Имя", Имя);
                cmd.Parameters.AddWithValue("@Отчество", Отчество);
                cmd.Parameters.AddWithValue("@год_рождения", год_рождения);
                cmd.Parameters.AddWithValue("@оклад", оклад);
                cmd.Parameters.AddWithValue("@ID_Библиотеки", ID_Библиотеки);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteСотрудники(int id)
        {
            string sql = string.Format("Delete from Сотрудники where Паспорт_сотрудника = '{0}'", id);
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
