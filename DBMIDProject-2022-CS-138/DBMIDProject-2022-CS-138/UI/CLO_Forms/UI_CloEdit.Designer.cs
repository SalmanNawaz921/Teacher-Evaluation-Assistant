namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    partial class frm_CloEdit
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.RichTextBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.pnl_Name.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(11, 20);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // pnl_Name
            // 
            this.pnl_Name.Controls.Add(this.txt_Name);
            this.pnl_Name.Controls.Add(this.lbl_Name);
            this.pnl_Name.Location = new System.Drawing.Point(33, 125);
            this.pnl_Name.Name = "pnl_Name";
            this.pnl_Name.Size = new System.Drawing.Size(423, 68);
            this.pnl_Name.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Name.Location = new System.Drawing.Point(165, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(237, 33);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Text = "";
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.btn_Confirm);
            this.pnl_Main.Controls.Add(this.pnl_Name);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(501, 394);
            this.pnl_Main.TabIndex = 2;
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
            this.btn_Confirm.Location = new System.Drawing.Point(171, 241);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(130, 53);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confrim";
            this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_CloEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 394);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_CloEdit";
            this.Text = "UI_CloEdit";
            this.pnl_Name.ResumeLayout(false);
            this.pnl_Name.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Confirm;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel pnl_Name;
        private System.Windows.Forms.RichTextBox txt_Name;
        private System.Windows.Forms.Panel pnl_Main;
    }
}