using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class StudentRUDForm : Form
    {
        public StudentRUDForm()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbppDataSet);
        }

        private void StudentRUDForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbppDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dbppDataSet.Student);
            // TODO: This line of code loads data into the 'dbppDataSet.Card' table. You can move, or remove it, as needed.
            this.cardTableAdapter.Fill(this.dbppDataSet.Card);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            balanceTextBox.Text = "0";
        }

        private void studentBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            if (this.balanceTextBox.Text != "")
            {
                this.nameTextBox.Text = this.nameTextBox.Text.Trim();
                this.lastNameTextBox.Text = this.lastNameTextBox.Text.Trim();
                this.emailTextBox.Text = this.emailTextBox.Text.Trim();
                this.emailParentTextBox.Text = this.emailParentTextBox.Text.Trim();

                this.balanceTextBox.Text = this.balanceTextBox.Text.Trim();
                int iLen = this.balanceTextBox.Text.Length;
                if (iLen > 5 && this.balanceTextBox.Text[iLen - 5] == ',')
                    this.balanceTextBox.Text = this.balanceTextBox.Text.Trim().Remove(this.balanceTextBox.Text.Trim().Length - 2);

                this.passwordTextBox.Text = "".PadLeft(this.passwordTextBox.Text.Trim().Length, '*');

                //checking if user has card
                //if (studentTableAdapter.GetData())
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard();
            formCard.ShowDialog();
        }
    }
}
