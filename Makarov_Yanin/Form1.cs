using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makarov_Yanin
{
    public partial class Form1 : Form
        
    {
     

  
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

          

        }

        private void библиотекиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.библиотекиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        private void библиотекиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.библиотекиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.makarov_YaninDataSet);

        }

        //private void button1_Click(object sender, EventArgs e);


        private void button2_Click(object sender, EventArgs e)
        {
            Form test = new Form2();
            test.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form aaa = new Form3();
            aaa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form b = new Form4();
            b.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form d = new Form5();
            d.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form сотрудники = new Form6();
            сотрудники.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form читатели = new Form7();
            читатели.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form читательский_билет = new Form8();
            читательский_билет.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }   

