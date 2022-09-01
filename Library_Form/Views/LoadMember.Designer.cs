namespace Library_Form.Views
{
    partial class LoadMember
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
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadMember = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 128);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAR SOCIO";
            // 
            // groupLoan
            // 
            this.groupLoan.BackColor = System.Drawing.Color.PaleGreen;
            this.groupLoan.Controls.Add(this.rbVip);
            this.groupLoan.Controls.Add(this.txtMemberId);
            this.groupLoan.Controls.Add(this.label4);
            this.groupLoan.Controls.Add(this.txtMemberLastName);
            this.groupLoan.Controls.Add(this.txtMemberName);
            this.groupLoan.Controls.Add(this.label3);
            this.groupLoan.Controls.Add(this.label2);
            this.groupLoan.Location = new System.Drawing.Point(130, 169);
            this.groupLoan.Name = "groupLoan";
            this.groupLoan.Size = new System.Drawing.Size(339, 239);
            this.groupLoan.TabIndex = 3;
            this.groupLoan.TabStop = false;
            this.groupLoan.Text = "Socio";
            // 
            // rbVip
            // 
            this.rbVip.AutoSize = true;
            this.rbVip.Location = new System.Drawing.Point(91, 159);
            this.rbVip.Name = "rbVip";
            this.rbVip.Size = new System.Drawing.Size(51, 24);
            this.rbVip.TabIndex = 6;
            this.rbVip.TabStop = true;
            this.rbVip.Text = "VIP";
            this.rbVip.UseVisualStyleBackColor = true;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(91, 116);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(187, 27);
            this.txtMemberId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo:";
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.Location = new System.Drawing.Point(91, 83);
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(187, 27);
            this.txtMemberLastName.TabIndex = 3;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(91, 50);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(187, 27);
            this.txtMemberName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btnLoadMember
            // 
            this.btnLoadMember.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadMember.Location = new System.Drawing.Point(130, 429);
            this.btnLoadMember.Name = "btnLoadMember";
            this.btnLoadMember.Size = new System.Drawing.Size(181, 61);
            this.btnLoadMember.TabIndex = 5;
            this.btnLoadMember.Text = "CARGAR SOCIO";
            this.btnLoadMember.UseVisualStyleBackColor = false;
            this.btnLoadMember.Click += new System.EventHandler(this.btnLoadMember_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(356, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoadMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(614, 521);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadMember);
            this.Controls.Add(this.groupLoan);
            this.Controls.Add(this.panel1);
            this.Name = "LoadMember";
            this.Text = "Cargar socio";
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
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadMember;
        private System.Windows.Forms.Button btnExit;
    }
}