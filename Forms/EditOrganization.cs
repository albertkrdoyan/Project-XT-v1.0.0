using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_XT_v1_0_0.Forms
{
    public partial class EditOrganization : Form
    {
        private readonly Database db;
        private readonly string[] originalData;
        public EditOrganization(string orgName)
        {
            InitializeComponent();

			db = new Database("C:\\Users\\alber\\Desktop\\Project XT v1.0.0\\Project XT DB\\projext_xt.db");

			DataTable dt = db.GetData($"SELECT * FROM Organizations Where Name = '{orgName}'");
            originalData = new string[4];

            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();

            originalData[0] = textBox1.Text;
            originalData[1] = textBox2.Text;
            originalData[2] = textBox4.Text;
            originalData[3] = textBox5.Text;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string tin = textBox2.Text;
            string bankAccNumber = textBox4.Text;
            string bankAccName = textBox5.Text;

            string errorMsg = " դաշտը չի կարող լինել դատարկ:";
            if (name == "")
                errorMsg = "Անվանման" + errorMsg;
            else if (tin == "")
                errorMsg = "ՀՎՀՀ" + errorMsg;
            else if (bankAccNumber == "")
                errorMsg = "Հաշվեհամար" + errorMsg;
            else if (bankAccName == "")
                errorMsg = "Բանկի անվանում" + errorMsg;

            if (errorMsg[0] != ' ')
            {
                MessageBox.Show(errorMsg);
                return;
            }

            DataTable dt = db.GetData(
                "SELECT * FROM Organizations " +
                $"WHERE Name = '{name}' OR TIN = '{tin}' OR BankAccountNumber = '{bankAccNumber}'"
            );

            if (dt.Rows.Count > 1)
            {
                MessageBox.Show("Նման կազմակերպություն արդեն գոություն ունի:");
                return;
            }

            db.ExecuteNonQuery(
                "UPDATE Organizations " +
                $"SET Name = '{name}', TIN = '{tin}', BankAccountNumber = '{bankAccNumber}', BankAccountName = '{bankAccName}' " +
                $"WHERE Name = '{originalData[0]}'"
            );

            this.Dispose();
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
