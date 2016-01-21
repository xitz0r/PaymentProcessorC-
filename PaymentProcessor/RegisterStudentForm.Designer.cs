namespace PaymentProcessor
{
    partial class RegisterStudentForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonNascimento = new System.Windows.Forms.Button();
            this.labelCPF = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCartao = new System.Windows.Forms.Label();
            this.buttonCartao = new System.Windows.Forms.Button();
            this.labelSwipedCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(111, 89);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 92);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(25, 128);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(66, 13);
            this.labelNascimento.TabIndex = 3;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(63, 192);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.Visible = false;
            // 
            // buttonNascimento
            // 
            this.buttonNascimento.Location = new System.Drawing.Point(111, 123);
            this.buttonNascimento.Name = "buttonNascimento";
            this.buttonNascimento.Size = new System.Drawing.Size(75, 23);
            this.buttonNascimento.TabIndex = 5;
            this.buttonNascimento.Text = "Selecionar dia";
            this.buttonNascimento.UseVisualStyleBackColor = true;
            this.buttonNascimento.Click += new System.EventHandler(this.buttonBirthday_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(25, 61);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 6;
            this.labelCPF.Text = "CPF:";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(111, 58);
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCPF.TabIndex = 7;
            this.maskedTextBoxCPF.Text = "000.000.000-00";
            this.maskedTextBoxCPF.TextChanged += new System.EventHandler(this.maskedTextBoxCPF_TextChanged);
            // 
            // labelCartao
            // 
            this.labelCartao.AutoSize = true;
            this.labelCartao.Location = new System.Drawing.Point(25, 162);
            this.labelCartao.Name = "labelCartao";
            this.labelCartao.Size = new System.Drawing.Size(41, 13);
            this.labelCartao.TabIndex = 8;
            this.labelCartao.Text = "Cartão:";
            // 
            // buttonCartao
            // 
            this.buttonCartao.Location = new System.Drawing.Point(111, 157);
            this.buttonCartao.Name = "buttonCartao";
            this.buttonCartao.Size = new System.Drawing.Size(75, 23);
            this.buttonCartao.TabIndex = 9;
            this.buttonCartao.Text = "Passar cartão";
            this.buttonCartao.UseVisualStyleBackColor = true;
            this.buttonCartao.Click += new System.EventHandler(this.buttonCartao_Click);
            // 
            // labelSwipedCard
            // 
            this.labelSwipedCard.AutoSize = true;
            this.labelSwipedCard.ForeColor = System.Drawing.Color.Green;
            this.labelSwipedCard.Location = new System.Drawing.Point(207, 162);
            this.labelSwipedCard.Name = "labelSwipedCard";
            this.labelSwipedCard.Size = new System.Drawing.Size(0, 13);
            this.labelSwipedCard.TabIndex = 10;
            // 
            // RegisterStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelSwipedCard);
            this.Controls.Add(this.buttonCartao);
            this.Controls.Add(this.labelCartao);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.buttonNascimento);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "RegisterStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterStudentForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonNascimento;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label labelCartao;
        private System.Windows.Forms.Button buttonCartao;
        private System.Windows.Forms.Label labelSwipedCard;
    }
}