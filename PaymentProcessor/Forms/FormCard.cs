using PaymentProcessor.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class FormCard : Form
    {
        private bool inputToLabel = true, firstTime = true;
        private Timer timer = new Timer();

        public Card ReturnValueCard { get; set; }

        public FormCard()
        {
            InitializeComponent();
        }

        private void FormCard_Load(object sender, EventArgs e)
        {
            //KeyPreview = true;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void FormCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firstTime)
            {
                timer.Start();
                firstTime = false;
            }
            else
            {
                timer.Stop();
                timer.Start();
            }

            if (inputToLabel)
            {
                label2.Text = label2.Text + e.KeyChar;
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValueCard = new Card("%b44444444444444444^you/a gift for^23101211000000220000000?\r;44444444444444444=231012110000220?\r;04144?", 123);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                /* Not on UI thread, reenter there... */
                this.BeginInvoke(new EventHandler(timer_Tick), sender, e);
            }
            else
            {
                lock (timer)
                {
                    /* only work when this is no reentry while we are already working */
                    if (this.timer.Enabled)
                    {
                        this.timer.Stop();
                        this.Close();
                    }
                }
            }
        }
    }
}
