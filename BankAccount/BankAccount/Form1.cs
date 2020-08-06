using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        SimbaBankAccount myAccount = new SimbaBankAccount();

        bool withClick = false;
        bool depClick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double withdraw = double.Parse(txtInput.Text);

            try
            {
                if (withdraw <= 1000.00)
                {
                    myAccount.WithdrawInput = withdraw;
                    txtInput.Clear();
                }
                if(withdraw > 1000.00)
                    throw (new TooLargeException("Amount to be withdrawn is too large(>1000)"+
                        ",not acceptable!"));
            }
            catch (TooLargeException ex)
            {
                lblError.Text = ex.Message;
            }
            withClick = true;
        }
        private void btnDeposit(object sender, EventArgs e)
        {
            double deposit = Convert.ToDouble(txtInput.Text);

            try
            {
                if (deposit < 10000.00 && deposit >= 0)
                {
                    myAccount.DepositInput = deposit;
                    txtInput.Clear();
                }
                else 
                if (deposit >= 10000.00)
                {
                    throw (new TooLargeException("TooLargeException: Amount deposited is too large(>=10000)" +
                            ",not acceptable!"));
                }
                else 
                if (deposit < 0)
                {
                    throw (new NegativeDepositException("NegativeDepositException: Amount deposited is negative" +
                          ",which is not acceptable!"));
                }
            }
            catch (TooLargeException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (NegativeDepositException ex)
            {
                lblError.Text = ex.Message;
            }
            depClick = true;
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            double withBalance = myAccount.CalculateBalanceAfterWithdraw();
            double depBalance = myAccount.CalculateBalanceAfterDeposit();

            try
            { 
                if (withClick == true && withBalance >= 0)
                {
                    txtAccBalance.Text = withBalance.ToString("c");
                    withClick = false;
                }
                else 
                if (withClick == true && withBalance < 0)
                {
                    txtAccBalance.Text = withBalance.ToString("c");
                    withClick = false;
                    throw (new NegativeBalanceException("NegativeBalanceException: Account " +
                        "Balance is negative,which is not acceptable!"));
                }
                if (depClick == true && depBalance >= 0)
                {
                    txtAccBalance.Text = depBalance.ToString("c");
                    depClick = false;
                }
                else 
                if (depClick == true && depBalance < 0)
                {
                    txtAccBalance.Text = depBalance.ToString("c");
                    depClick = false;
                    throw (new NegativeBalanceException("NegativeBalanceException: Account " +
                        "Balance is negative,which is not acceptable!"));
                }
            }
            catch (NegativeBalanceException ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
