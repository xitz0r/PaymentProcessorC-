namespace PaymentProcessor
{
    partial class ShopkeeperMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopkeeperMenu));
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(33, 41);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(112, 100);
            this.buttonSale.TabIndex = 1;
            this.buttonSale.Text = "Venda";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // buttonRefund
            // 
            this.buttonRefund.Location = new System.Drawing.Point(191, 41);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(112, 100);
            this.buttonRefund.TabIndex = 2;
            this.buttonRefund.Text = "Estorno";
            this.buttonRefund.UseVisualStyleBackColor = true;
            // 
            // ShopkeeperMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 184);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.buttonSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopkeeperMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Lojista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonRefund;
    }
}