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

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            balanceTextBox.Text = "0";
        }
    }
}
