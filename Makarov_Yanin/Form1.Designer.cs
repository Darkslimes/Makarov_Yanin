﻿namespace Makarov_Yanin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.библиотекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makarov_YaninDataSet = new Makarov_Yanin.Makarov_YaninDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекиTableAdapter = new Makarov_Yanin.Makarov_YaninDataSetTableAdapters.БиблиотекиTableAdapter();
            this.tableAdapterManager = new Makarov_Yanin.Makarov_YaninDataSetTableAdapters.TableAdapterManager();
            this.книгиTableAdapter = new Makarov_Yanin.Makarov_YaninDataSetTableAdapters.КнигиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makarov_YaninDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 65);
            this.button3.TabIndex = 8;
            this.button3.Text = "Библиотеки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // библиотекиBindingSource
            // 
            this.библиотекиBindingSource.DataMember = "Библиотеки";
            this.библиотекиBindingSource.DataSource = this.makarov_YaninDataSet;
            // 
            // makarov_YaninDataSet
            // 
            this.makarov_YaninDataSet.DataSetName = "Makarov_YaninDataSet";
            this.makarov_YaninDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "Финансирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.makarov_YaninDataSet;
            // 
            // библиотекиTableAdapter
            // 
            this.библиотекиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Makarov_Yanin.Makarov_YaninDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БиблиотекиTableAdapter = this.библиотекиTableAdapter;
            this.tableAdapterManager.Деловая_характеристика_работникаTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ФинансированиеTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            this.tableAdapterManager.Читательский_билетTableAdapter = null;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Читательский билет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(672, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 65);
            this.button4.TabIndex = 10;
            this.button4.Text = "Читатели";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(536, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 65);
            this.button5.TabIndex = 11;
            this.button5.Text = "Сотрудники";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(405, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 65);
            this.button6.TabIndex = 12;
            this.button6.Text = "Книги";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(256, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 65);
            this.button7.TabIndex = 13;
            this.button7.Text = "Деловая характеристика работника";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 477);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 64);
            this.button8.TabIndex = 14;
            this.button8.Text = "ВЫХОД";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(755, 477);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(185, 64);
            this.button9.TabIndex = 15;
            this.button9.Text = "Авторы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 521);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Этая великая, гениальная программа создана разработчиками, которых зовут Макаров " +
    "О.С и Янин Р.Д.";
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Makarov_Yanin.Properties.Resources.iStock_9491180681000_d_850;
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.библиотекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makarov_YaninDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Makarov_YaninDataSet makarov_YaninDataSet;
        private System.Windows.Forms.BindingSource библиотекиBindingSource;
        private Makarov_YaninDataSetTableAdapters.БиблиотекиTableAdapter библиотекиTableAdapter;
        private Makarov_YaninDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private Makarov_YaninDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

