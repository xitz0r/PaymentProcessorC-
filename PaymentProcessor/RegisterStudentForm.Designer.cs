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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentForm));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelEmailStudent = new System.Windows.Forms.Label();
            this.textBoxEmailStudent = new System.Windows.Forms.TextBox();
            this.labelEmailParent = new System.Windows.Forms.Label();
            this.textBoxEmailParent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(142, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 28);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(25, 83);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(66, 13);
            this.labelNascimento.TabIndex = 3;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Checked = false;
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(142, 77);
            this.dateTimePickerNascimento.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerNascimento.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(28, 238);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(67, 22);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOk.Location = new System.Drawing.Point(174, 238);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(67, 22);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Salvar";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(142, 51);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(100, 20);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(25, 54);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(64, 13);
            this.labelSobrenome.TabIndex = 15;
            this.labelSobrenome.Text = "Sobrenome:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(142, 157);
            this.textBoxPassword.MaxLength = 6;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(25, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 13);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Senha:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(101, 238);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(67, 22);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.AutoSize = true;
            this.labelPasswordConfirm.Location = new System.Drawing.Point(25, 186);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(86, 13);
            this.labelPasswordConfirm.TabIndex = 19;
            this.labelPasswordConfirm.Text = "Confirmar senha:";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(142, 183);
            this.textBoxPasswordConfirm.MaxLength = 6;
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordConfirm.TabIndex = 7;
            this.textBoxPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // labelEmailStudent
            // 
            this.labelEmailStudent.AutoSize = true;
            this.labelEmailStudent.Location = new System.Drawing.Point(25, 106);
            this.labelEmailStudent.Name = "labelEmailStudent";
            this.labelEmailStudent.Size = new System.Drawing.Size(88, 13);
            this.labelEmailStudent.TabIndex = 21;
            this.labelEmailStudent.Text = "E-mail estudante:";
            // 
            // textBoxEmailStudent
            // 
            this.textBoxEmailStudent.Location = new System.Drawing.Point(142, 103);
            this.textBoxEmailStudent.Name = "textBoxEmailStudent";
            this.textBoxEmailStudent.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailStudent.TabIndex = 4;
            // 
            // labelEmailParent
            // 
            this.labelEmailParent.AutoSize = true;
            this.labelEmailParent.Location = new System.Drawing.Point(25, 134);
            this.labelEmailParent.Name = "labelEmailParent";
            this.labelEmailParent.Size = new System.Drawing.Size(98, 13);
            this.labelEmailParent.TabIndex = 23;
            this.labelEmailParent.Text = "E-mail responsável:";
            // 
            // textBoxEmailParent
            // 
            this.textBoxEmailParent.Location = new System.Drawing.Point(142, 131);
            this.textBoxEmailParent.Name = "textBoxEmailParent";
            this.textBoxEmailParent.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailParent.TabIndex = 5;
            // 
            // RegisterStudentForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.textBoxEmailParent);
            this.Controls.Add(this.labelEmailParent);
            this.Controls.Add(this.textBoxEmailStudent);
            this.Controls.Add(this.labelEmailStudent);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.labelPasswordConfirm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterStudentForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Label labelEmailStudent;
        private System.Windows.Forms.TextBox textBoxEmailStudent;
        private System.Windows.Forms.Label labelEmailParent;
        private System.Windows.Forms.TextBox textBoxEmailParent;
    }
}