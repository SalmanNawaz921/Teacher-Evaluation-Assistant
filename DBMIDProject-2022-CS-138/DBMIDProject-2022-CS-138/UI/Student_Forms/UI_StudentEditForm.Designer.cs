namespace DBMIDProject_2022_CS_138.UI.Student_Forms
{
    partial class frm_StudentsFormEdit
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Email = new System.Windows.Forms.Panel();
            this.txt_Email = new System.Windows.Forms.RichTextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pnl_Contact = new System.Windows.Forms.Panel();
            this.txt_Contact = new System.Windows.Forms.RichTextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.pnl_lName = new System.Windows.Forms.Panel();
            this.txt_lName = new System.Windows.Forms.RichTextBox();
            this.lbl_lName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_fName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.pnl_RegNo = new System.Windows.Forms.Panel();
            this.txt_RegNo = new System.Windows.Forms.RichTextBox();
            this.lbl_RegNo = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Email.SuspendLayout();
            this.pnl_Contact.SuspendLayout();
            this.pnl_lName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_RegNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.pnl_RegNo);
            this.pnl_Main.Controls.Add(this.btn_Confirm);
            this.pnl_Main.Controls.Add(this.pnl_Email);
            this.pnl_Main.Controls.Add(this.pnl_Contact);
            this.pnl_Main.Controls.Add(this.pnl_lName);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(561, 652);
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_Email
            // 
            this.pnl_Email.Controls.Add(this.txt_Email);
            this.pnl_Email.Controls.Add(this.lbl_Email);
            this.pnl_Email.Location = new System.Drawing.Point(51, 345);
            this.pnl_Email.Name = "pnl_Email";
            this.pnl_Email.Size = new System.Drawing.Size(423, 68);
            this.pnl_Email.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Email.Location = new System.Drawing.Point(165, 20);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(237, 33);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.Text = "";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(11, 20);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(58, 25);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            // 
            // pnl_Contact
            // 
            this.pnl_Contact.Controls.Add(this.txt_Contact);
            this.pnl_Contact.Controls.Add(this.lbl_Contact);
            this.pnl_Contact.Location = new System.Drawing.Point(51, 248);
            this.pnl_Contact.Name = "pnl_Contact";
            this.pnl_Contact.Size = new System.Drawing.Size(423, 68);
            this.pnl_Contact.TabIndex = 3;
            // 
            // txt_Contact
            // 
            this.txt_Contact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Contact.Location = new System.Drawing.Point(165, 20);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(237, 33);
            this.txt_Contact.TabIndex = 1;
            this.txt_Contact.Text = "";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(11, 20);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(77, 25);
            this.lbl_Contact.TabIndex = 0;
            this.lbl_Contact.Text = "Contact";
            // 
            // pnl_lName
            // 
            this.pnl_lName.Controls.Add(this.txt_lName);
            this.pnl_lName.Controls.Add(this.lbl_lName);
            this.pnl_lName.Location = new System.Drawing.Point(51, 150);
            this.pnl_lName.Name = "pnl_lName";
            this.pnl_lName.Size = new System.Drawing.Size(423, 68);
            this.pnl_lName.TabIndex = 2;
            // 
            // txt_lName
            // 
            this.txt_lName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_lName.Location = new System.Drawing.Point(165, 20);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(237, 33);
            this.txt_lName.TabIndex = 1;
            this.txt_lName.Text = "";
            // 
            // lbl_lName
            // 
            this.lbl_lName.AutoSize = true;
            this.lbl_lName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lName.Location = new System.Drawing.Point(11, 20);
            this.lbl_lName.Name = "lbl_lName";
            this.lbl_lName.Size = new System.Drawing.Size(100, 25);
            this.lbl_lName.TabIndex = 0;
            this.lbl_lName.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_fName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 68);
            this.panel1.TabIndex = 0;
            // 
            // txt_fName
            // 
            this.txt_fName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_fName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_fName.Location = new System.Drawing.Point(165, 20);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(237, 33);
            this.txt_fName.TabIndex = 1;
            this.txt_fName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirm.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_Confirm.IconColor = System.Drawing.Color.Black;
            this.btn_Confirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Confirm.IconSize = 28;
            this.btn_Confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Confirm.Location = new System.Drawing.Point(189, 542);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(130, 53);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // pnl_RegNo
            // 
            this.pnl_RegNo.Controls.Add(this.txt_RegNo);
            this.pnl_RegNo.Controls.Add(this.lbl_RegNo);
            this.pnl_RegNo.Location = new System.Drawing.Point(51, 442);
            this.pnl_RegNo.Name = "pnl_RegNo";
            this.pnl_RegNo.Size = new System.Drawing.Size(423, 68);
            this.pnl_RegNo.TabIndex = 8;
            // 
            // txt_RegNo
            // 
            this.txt_RegNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_RegNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_RegNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_RegNo.Location = new System.Drawing.Point(165, 20);
            this.txt_RegNo.Name = "txt_RegNo";
            this.txt_RegNo.Size = new System.Drawing.Size(237, 33);
            this.txt_RegNo.TabIndex = 1;
            this.txt_RegNo.Text = "";
            // 
            // lbl_RegNo
            // 
            this.lbl_RegNo.AutoSize = true;
            this.lbl_RegNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegNo.Location = new System.Drawing.Point(3, 20);
            this.lbl_RegNo.Name = "lbl_RegNo";
            this.lbl_RegNo.Size = new System.Drawing.Size(152, 25);
            this.lbl_RegNo.TabIndex = 0;
            this.lbl_RegNo.Text = "Registeration No";
            // 
            // frm_StudentsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 652);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_StudentsFormEdit";
            this.Text = "UI_StudentEditForm";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Email.ResumeLayout(false);
            this.pnl_Email.PerformLayout();
            this.pnl_Contact.ResumeLayout(false);
            this.pnl_Contact.PerformLayout();
            this.pnl_lName.ResumeLayout(false);
            this.pnl_lName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_RegNo.ResumeLayout(false);
            this.pnl_RegNo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Email;
        private System.Windows.Forms.RichTextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Panel pnl_Contact;
        private System.Windows.Forms.RichTextBox txt_Contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Panel pnl_lName;
        private System.Windows.Forms.RichTextBox txt_lName;
        private System.Windows.Forms.Label lbl_lName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txt_fName;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Confirm;
        private System.Windows.Forms.Panel pnl_RegNo;
        private System.Windows.Forms.RichTextBox txt_RegNo;
        private System.Windows.Forms.Label lbl_RegNo;
    }
}