namespace PaymentProcessor
{
    partial class MainMenuForm
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
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonShopkeeper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(43, 40);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(112, 100);
            this.buttonManager.TabIndex = 1;
            this.buttonManager.Text = "Administrador";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonShopkeeper
            // 
            this.buttonShopkeeper.Location = new System.Drawing.Point(181, 40);
            this.buttonShopkeeper.Name = "buttonShopkeeper";
            this.buttonShopkeeper.Size = new System.Drawing.Size(112, 100);
            this.buttonShopkeeper.TabIndex = 2;
            this.buttonShopkeeper.Text = "Lojista";
            this.buttonShopkeeper.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 179);
            this.Controls.Add(this.buttonShopkeeper);
            this.Controls.Add(this.buttonManager);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonShopkeeper;
    }
}