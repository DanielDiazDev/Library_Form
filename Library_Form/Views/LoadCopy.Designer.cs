namespace Library_Form.Views
{
    partial class LoadCopy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupLoan = new System.Windows.Forms.GroupBox();
            this.txtBookLocation = new System.Windows.Forms.TextBox();
            this.txtBookEditionYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadCopy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 128);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAR EJEMPLAR";
            // 
            // groupLoan
            // 
            this.groupLoan.BackColor = System.Drawing.Color.PaleGreen;
            this.groupLoan.Controls.Add(this.txtBookLocation);
            this.groupLoan.Controls.Add(this.txtBookEditionYear);
            this.groupLoan.Controls.Add(this.label6);
            this.groupLoan.Controls.Add(this.label5);
            this.groupLoan.Controls.Add(this.txtBookAuthor);
            this.groupLoan.Controls.Add(this.label4);
            this.groupLoan.Controls.Add(this.txtBookIsbn);
            this.groupLoan.Controls.Add(this.txtBookTitle);
            this.groupLoan.Controls.Add(this.label3);
            this.groupLoan.Controls.Add(this.label2);
            this.groupLoan.Location = new System.Drawing.Point(124, 175);
            this.groupLoan.Name = "groupLoan";
            this.groupLoan.Size = new System.Drawing.Size(339, 239);
            this.groupLoan.TabIndex = 4;
            this.groupLoan.TabStop = false;
            this.groupLoan.Text = "Cargar ejemplar";
            // 
            // txtBookLocation
            // 
            this.txtBookLocation.Location = new System.Drawing.Point(102, 182);
            this.txtBookLocation.Name = "txtBookLocation";
            this.txtBookLocation.Size = new System.Drawing.Size(187, 27);
            this.txtBookLocation.TabIndex = 9;
            // 
            // txtBookEditionYear
            // 
            this.txtBookEditionYear.Location = new System.Drawing.Point(102, 149);
            this.txtBookEditionYear.Name = "txtBookEditionYear";
            this.txtBookEditionYear.Size = new System.Drawing.Size(187, 27);
            this.txtBookEditionYear.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ubicacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edicion:";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(102, 116);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(187, 27);
            this.txtBookAuthor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Autor:";
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(102, 83);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(187, 27);
            this.txtBookIsbn.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(102, 50);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(187, 27);
            this.txtBookTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            // 
            // btnLoadCopy
            // 
            this.btnLoadCopy.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadCopy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCopy.Location = new System.Drawing.Point(124, 451);
            this.btnLoadCopy.Name = "btnLoadCopy";
            this.btnLoadCopy.Size = new System.Drawing.Size(187, 61);
            this.btnLoadCopy.TabIndex = 10;
            this.btnLoadCopy.Text = "CARGAR LIBRO";
            this.btnLoadCopy.UseVisualStyleBackColor = false;
            this.btnLoadCopy.Click += new System.EventHandler(this.btnLoadCopy_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(350, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoadCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 591);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadCopy);
            this.Controls.Add(this.groupLoan);
            this.Controls.Add(this.panel1);
            this.Name = "LoadCopy";
            this.Text = "Cargar ejemplar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupLoan.ResumeLayout(false);
            this.groupLoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLoan;
        private System.Windows.Forms.TextBox txtBookLocation;
        private System.Windows.Forms.TextBox txtBookEditionYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadCopy;
        private System.Windows.Forms.Button btnExit;
    }
}