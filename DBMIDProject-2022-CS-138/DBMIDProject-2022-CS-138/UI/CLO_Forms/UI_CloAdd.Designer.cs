namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    partial class frm_CloAdd
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
            this.btn_Submit = new FontAwesome.Sharp.IconButton();
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
            this.pnl_Main.Controls.Add(this.btn_Submit);
            this.pnl_Main.Controls.Add(this.pnl_Name);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(501, 394);
            this.pnl_Main.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_Submit.IconColor = System.Drawing.Color.Black;
            this.btn_Submit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Submit.IconSize = 28;
            this.btn_Submit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Submit.Location = new System.Drawing.Point(171, 241);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 53);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_CloAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 394);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_CloAdd";
            this.Text = "UI_CloAdd";
            this.pnl_Name.ResumeLayout(false);
            this.pnl_Name.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private FontAwesome.Sharp.IconButton btn_Submit;
        private System.Windows.Forms.Panel pnl_Name;
        private System.Windows.Forms.RichTextBox txt_Name;
        private System.Windows.Forms.Panel pnl_Main;
    }
}