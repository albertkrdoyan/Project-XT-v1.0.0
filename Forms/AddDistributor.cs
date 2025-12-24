using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_XT_v1_0_0.Forms
{
    public partial class AddDistributor : Form
    {
        readonly Database db;
		readonly DataTable dt;

		public AddDistributor()
        {
            InitializeComponent();

            db = new Database("C:\\Users\\alber\\Desktop\\Project XT DB\\projext_xt.db");

            dt = db.GetData("SELECT * FROM Organizations ORDER BY Name");
            
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
				MessageBox.Show("Անվանում դաշտը չի կարող լինել դատարկ:");
                return;
			}

            db.ExecuteNonQuery(
				"INSERT INTO Distributors (Name, Debt, Organization, TIN, Phone) " +
				$"VALUES ('{textBox1.Text}', 0, '{dt.Rows[comboBox1.SelectedIndex][0]}', '{dt.Rows[comboBox1.SelectedIndex][1]}', '{textBox2.Text}')"
			);

			this.Dispose();
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
