namespace Library_Form
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadMember = new System.Windows.Forms.Button();
            this.btnLoadCopy = new System.Windows.Forms.Button();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.btnConsultLoans = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnConsultCopies = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(325, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA";
            // 
            // btnLoadMember
            // 
            this.btnLoadMember.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadMember.Location = new System.Drawing.Point(38, 163);
            this.btnLoadMember.Name = "btnLoadMember";
            this.btnLoadMember.Size = new System.Drawing.Size(199, 87);
            this.btnLoadMember.TabIndex = 1;
            this.btnLoadMember.Text = "CARGAR SOCIO";
            this.btnLoadMember.UseVisualStyleBackColor = false;
            this.btnLoadMember.Click += new System.EventHandler(this.btnLoadMember_Click);
            // 
            // btnLoadCopy
            // 
            this.btnLoadCopy.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadCopy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCopy.Location = new System.Drawing.Point(325, 163);
            this.btnLoadCopy.Name = "btnLoadCopy";
            this.btnLoadCopy.Size = new System.Drawing.Size(199, 87);
            this.btnLoadCopy.TabIndex = 2;
            this.btnLoadCopy.Text = "CARGAR EJEMPLAR";
            this.btnLoadCopy.UseVisualStyleBackColor = false;
            this.btnLoadCopy.Click += new System.EventHandler(this.btnLoadCopy_Click);
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewLoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewLoan.Location = new System.Drawing.Point(610, 163);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(199, 87);
            this.btnNewLoan.TabIndex = 3;
            this.btnNewLoan.Text = "NUEVO PRESTAMO";
            this.btnNewLoan.UseVisualStyleBackColor = false;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // btnConsultLoans
            // 
            this.btnConsultLoans.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConsultLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultLoans.Location = new System.Drawing.Point(38, 289);
            this.btnConsultLoans.Name = "btnConsultLoans";
            this.btnConsultLoans.Size = new System.Drawing.Size(199, 87);
            this.btnConsultLoans.TabIndex = 4;
            this.btnConsultLoans.Text = "CONSULTAR PRESTAMOS";
            this.btnConsultLoans.UseVisualStyleBackColor = false;
            this.btnConsultLoans.Click += new System.EventHandler(this.btnConsultLoans_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnBook.Location = new System.Drawing.Point(325, 289);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(199, 87);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "DEVOLVER LIBRO";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnConsultCopies
            // 
            this.btnConsultCopies.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConsultCopies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultCopies.Location = new System.Drawing.Point(610, 289);
            this.btnConsultCopies.Name = "btnConsultCopies";
            this.btnConsultCopies.Size = new System.Drawing.Size(199, 87);
            this.btnConsultCopies.TabIndex = 6;
            this.btnConsultCopies.Text = "CONSULTAR EJEMPLARES";
            this.btnConsultCopies.UseVisualStyleBackColor = false;
            this.btnConsultCopies.Click += new System.EventHandler(this.btnConsultCopies_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(325, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 54);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(855, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConsultCopies);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnConsultLoans);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.btnLoadCopy);
            this.Controls.Add(this.btnLoadMember);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadMember;
        private System.Windows.Forms.Button btnLoadCopy;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.Button btnConsultLoans;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnConsultCopies;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}
