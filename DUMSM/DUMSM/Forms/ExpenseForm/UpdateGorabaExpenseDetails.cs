using DUMSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.ExpenseForm
{
    public partial class UpdateGorabaExpenseDetails : Form
    {
        GorabaExpense oldExpense;
        public UpdateGorabaExpenseDetails(GorabaExpense gorabaExpense)
        {
            InitializeComponent();
            oldExpense = gorabaExpense;
        }

        private void UpdateGorabaExpenseDetails_Load(object sender, EventArgs e)
        {
            Vouchertxt.Text = oldExpense.VoucherNumber;
            Fieldtxt.Text = oldExpense.Field;
            Ammounttxt.Text = oldExpense.Ammount.ToString();
            RegisterDatetxt.Text = oldExpense.ExpenseDate;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var expense = new GorabaExpense();
                expense.Id = oldExpense.Id;
                expense.VoucherNumber = Vouchertxt.Text;
                expense.ExpenseDate = RegisterDatetxt.Text;

                object selectedItem = Fieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                expense.Field = ((string)selectedItem);



                if (willInsert)
                {
                    CRUDOperation.Update(expense);
                    PopUpMessage.SuccessRegistrationMessage("খরচের তথ্য আপডেট ");
                    this.Close();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "খরচের তথ্য আপডেট");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("খরচের তথ্য আপডেট");
            }
        }
    }
}
