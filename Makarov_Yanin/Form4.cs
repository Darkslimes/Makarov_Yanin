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
    public partial class Form4 : Form
    {
        private SqlConnection connect;

        public class Деловая_характериситка_работника
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
    public Form4()
        {
            InitializeComponent();
        }

        private void деловая_характеристика_работникаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.деловая_характеристика_работникаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "makarov_YaninDataSet.Деловая_характеристика_работника". При необходимости она может быть перемещена или удалена.
            this.деловая_характеристика_работникаTableAdapter.Fill(this.makarov_YaninDataSet.Деловая_характеристика_работника);

        }
        public void InsertДеловая_характеристика_работника(int Паспорт_сотрудника, string должность, string образование)
        {
            // Оператор SQL
            string sql = string.Format("Insert Into Деловая_характериситка_работника" + "(Паспорт_сотрудника, должность, образование) Values(@Паспорт_сотрудника, @должность, @образование)");

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Паспорт_сотрудника", Паспорт_сотрудника);
                cmd.Parameters.AddWithValue("@должность", должность);
                cmd.Parameters.AddWithValue("@образование", образование);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteДеловая_характеристика_работника(int id)
        {
            string sql = string.Format("Delete from Деловая_характеристика_работника where Паспорт_сотрудника = '{0}'", id);
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
