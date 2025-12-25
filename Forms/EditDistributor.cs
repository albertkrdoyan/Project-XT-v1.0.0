using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_XT_v1_0_0.Forms
{
    public partial class EditDistributor : Form
    {
        private readonly Database db;
        private readonly string[] originalData;
		private readonly DataTable dt;

        public EditDistributor(string orgName)
        {
            InitializeComponent();

			db = new Database("C:\\Users\\alber\\Desktop\\Project XT v1.0.0\\Project XT DB\\projext_xt.db");
			dt = db.GetData($"SELECT * FROM Distributors Where Name = '{orgName}'");

			originalData = new string[3];
			originalData[0] = dt.Rows[0][0].ToString()!;
            originalData[1] = dt.Rows[0][2].ToString()!;
            originalData[2] = dt.Rows[0][4].ToString()!;

            dt = db.GetData($"SELECT * FROM Organizations ORDER BY Name");

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.Text = originalData[1];
            textBox1.Text = originalData[0];
            textBox2.Text = originalData[2];
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Անվանում դաշտը չի կարող լինել դատարկ:");
                return;
            }

            string query = "SELECT * FROM Distributors " +
                $"WHERE Name='{textBox1.Text}'";

			if (textBox1.Text != originalData[0] && db.GetData(query).Rows.Count == 1) 
            {
				MessageBox.Show("Նման կազմակերպություն արդեն գոություն ունի:");
				return;
			}

			query = "UPDATE Distributors " +
                $"SET Name='{textBox1.Text}', Organization='{dt.Rows[comboBox1.SelectedIndex][0]}', TIN='{dt.Rows[comboBox1.SelectedIndex][1]}', Phone='{textBox2.Text}' " +
                $"WHERE Name='{originalData[0]}'";
			db.ExecuteNonQuery(query);

            this.Dispose();
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
