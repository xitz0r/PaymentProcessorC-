namespace PaymentProcessor
{
    partial class ManagerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenuForm));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(37, 59);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(112, 100);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Cadastrar Aluno";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.Location = new System.Drawing.Point(273, 59);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(112, 100);
            this.buttonCard.TabIndex = 1;
            this.buttonCard.Text = "Cadastrar/Bloquear Cartão";
            this.buttonCard.UseVisualStyleBackColor = true;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(37, 165);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(112, 100);
            this.buttonRefill.TabIndex = 2;
            this.buttonRefill.Text = "Recarga";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(155, 59);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 100);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Procurar/Editar Aluno";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 316);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonCard);
            this.Controls.Add(this.buttonRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Processor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button buttonEdit;
    }
}

