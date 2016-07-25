namespace PaymentProcessor.Forms
{
    partial class StudentIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentIDForm));
            this.matAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okMat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matAluno
            // 
            this.matAluno.Location = new System.Drawing.Point(12, 36);
            this.matAluno.Name = "matAluno";
            this.matAluno.Size = new System.Drawing.Size(100, 20);
            this.matAluno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula do Aluno:";
            // 
            // okMat
            // 
            this.okMat.Location = new System.Drawing.Point(12, 62);
            this.okMat.Name = "okMat";
            this.okMat.Size = new System.Drawing.Size(75, 23);
            this.okMat.TabIndex = 2;
            this.okMat.Text = "Cadastrar";
            this.okMat.UseVisualStyleBackColor = true;
            this.okMat.Click += new System.EventHandler(this.okMat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bloquear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentIDForm";
            this.Text = "Matricula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okMat;
        private System.Windows.Forms.Button button1;
    }
}