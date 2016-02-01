﻿namespace PaymentProcessor
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
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.buttonStudentPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(37, 59);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(112, 100);
            this.buttonStudent.TabIndex = 0;
            this.buttonStudent.Text = "Cadastrar/Editar Aluno";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.Location = new System.Drawing.Point(155, 59);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(112, 100);
            this.buttonCard.TabIndex = 1;
            this.buttonCard.Text = "Cadastrar/Bloquear Cartão";
            this.buttonCard.UseVisualStyleBackColor = true;
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(37, 165);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(112, 100);
            this.buttonRefill.TabIndex = 2;
            this.buttonRefill.Text = "Recarga";
            this.buttonRefill.UseVisualStyleBackColor = true;
            // 
            // buttonStudentPassword
            // 
            this.buttonStudentPassword.Location = new System.Drawing.Point(155, 165);
            this.buttonStudentPassword.Name = "buttonStudentPassword";
            this.buttonStudentPassword.Size = new System.Drawing.Size(112, 100);
            this.buttonStudentPassword.TabIndex = 3;
            this.buttonStudentPassword.Text = "Trocar Senha\r\nAluno";
            this.buttonStudentPassword.UseVisualStyleBackColor = true;
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 316);
            this.Controls.Add(this.buttonStudentPassword);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonCard);
            this.Controls.Add(this.buttonStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Processor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button buttonStudentPassword;
    }
}

