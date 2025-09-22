using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = db.banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakıfBankBalance = db.banks.Where(x => x.BankTitle == "Vakıf Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasıBalance = db.banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblİş.Text=isBankasıBalance.ToString(); 
            lblZiraat.Text=ziraatBankBalance.ToString();
            lblVakıf.Text= vakıfBankBalance.ToString();
             var Process=db.Process.OrderByDescending(x=>x.BankprocessId).Take(1).FirstOrDefault ();
            lblBankProcess1.Text = Process.Description + " " + Process.Amount + " " + Process.ProcessDate;

            var Process2 = db.Process.OrderByDescending(x => x.BankprocessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = Process2.Description + " " + Process2.Amount + " " + Process2.ProcessDate;

           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
