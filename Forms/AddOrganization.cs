using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_XT_v1_0_0.Forms
{
    public partial class AddOrganization : Form
    {
        readonly Database db;
        public AddOrganization()
        {
            InitializeComponent();                        

            db = new Database("C:\\Users\\alber\\Desktop\\Project XT DB\\projext_xt.db");
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Նման կազմակերպություն արդեն գոություն ունի:");
                return;
            }

            db.ExecuteNonQuery(
                "INSERT INTO Organizations (Name, TIN, Debt, BankAccountNumber, BankAccountName) " +
                $"VALUES ('{name}', '{tin}', 0, '{bankAccNumber}', '{bankAccName}')"
            );

            this.Dispose();
        }
    }
}
