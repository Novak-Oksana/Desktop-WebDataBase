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
using MySql.Data.MySqlClient;
using DataBaseApi;

namespace WFPerson
{
    public partial class Form1 : Form
    {
        TableModel tableModel = new TableModel();

        public Form1()
        {
            InitializeComponent();
            SQLSwitch.SelectedIndex = 0;

            tableModel.SetDataBase("MsSQL");
        }

        private Person GetPerson()
        {
            int id = Int32.Parse(tb_id.Text);
            string fn = tb_firstname.Text;
            string ln = tb_lastname.Text;
            int age = Int32.Parse(tb_age.Text);
            return new Person(id, fn, ln, age);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  dataGridBD.DataSource = tableModel.Read();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            dataGridBD.DataSource = tableModel.Read();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            tableModel.Create(GetPerson());
            dataGridBD.DataSource = tableModel.Read();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            tableModel.Update(GetPerson());
            dataGridBD.DataSource = tableModel.Read();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tb_id.Text);
            tableModel.Delete(id);
            dataGridBD.DataSource = tableModel.Read();
                       
        }

        private void SelectServer(object sender, EventArgs e)
        {
            tableModel.SetDataBase(SQLSwitch.SelectedItem.ToString());
            dataGridBD.DataSource = null;
        }
    }
}
