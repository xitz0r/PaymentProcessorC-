namespace PaymentProcessor.Forms
{
    partial class PasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pinText = new System.Windows.Forms.TextBox();
            this.okPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira sua senha:";
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(28, 65);
            this.pinText.Name = "pinText";
            this.pinText.Size = new System.Drawing.Size(100, 20);
            this.pinText.TabIndex = 2;
            this.pinText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pinText.UseSystemPasswordChar = true;
            // 
            // okPin
            // 
            this.okPin.Location = new System.Drawing.Point(28, 91);
            this.okPin.Name = "okPin";
            this.okPin.Size = new System.Drawing.Size(75, 23);
            this.okPin.TabIndex = 0;
            this.okPin.Text = "OK";
            this.okPin.Click += new System.EventHandler(this.okPin_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 177);
            this.Controls.Add(this.okPin);
            this.Controls.Add(this.pinText);
            this.Controls.Add(this.label1);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pinText;
        private System.Windows.Forms.Button okPin;
    }
}