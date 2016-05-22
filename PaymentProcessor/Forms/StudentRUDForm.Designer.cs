namespace PaymentProcessor
{
    partial class StudentRUDForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label emailParentLabel;
            System.Windows.Forms.Label balanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRUDForm));
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailParentTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            emailParentLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(55, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Matrícula:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nome:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 93);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(64, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Sobrenome:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(12, 120);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(66, 13);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Nascimento:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "e-mail:";
            // 
            // emailParentLabel
            // 
            emailParentLabel.AutoSize = true;
            emailParentLabel.Location = new System.Drawing.Point(12, 171);
            emailParentLabel.Name = "emailParentLabel";
            emailParentLabel.Size = new System.Drawing.Size(97, 13);
            emailParentLabel.TabIndex = 11;
            emailParentLabel.Text = "e-mail responsável:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(12, 197);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(37, 13);
            balanceLabel.TabIndex = 13;
            balanceLabel.Text = "Saldo:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(113, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(113, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(113, 90);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.CustomFormat = "";
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(113, 116);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(113, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // emailParentTextBox
            // 
            this.emailParentTextBox.Enabled = false;
            this.emailParentTextBox.Location = new System.Drawing.Point(113, 168);
            this.emailParentTextBox.Name = "emailParentTextBox";
            this.emailParentTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailParentTextBox.TabIndex = 12;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Enabled = false;
            this.balanceTextBox.Location = new System.Drawing.Point(113, 194);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.balanceTextBox.TabIndex = 14;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(238, 241);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Próximo";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(113, 241);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 18;
            this.buttonPrevious.Text = "Anterior";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(319, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(55, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // StudentRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 293);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(emailParentLabel);
            this.Controls.Add(this.emailParentTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentRUDForm";
            this.Text = "Formulário Estudante";
            this.Load += new System.EventHandler(this.StudentRUDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox emailParentTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonSearch;
    }
}