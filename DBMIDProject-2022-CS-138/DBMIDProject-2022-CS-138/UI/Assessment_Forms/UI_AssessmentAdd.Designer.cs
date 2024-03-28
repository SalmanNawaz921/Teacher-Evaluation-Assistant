namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    partial class frm_AssessmentAdd
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
            this.btn_Submit = new FontAwesome.Sharp.IconButton();
            this.pnl_TWeightage = new System.Windows.Forms.Panel();
            this.txt_TWeightage = new System.Windows.Forms.RichTextBox();
            this.lbl_TWeightage = new System.Windows.Forms.Label();
            this.pnl_TMarks = new System.Windows.Forms.Panel();
            this.txt_TMarks = new System.Windows.Forms.RichTextBox();
            this.lbl_TMarks = new System.Windows.Forms.Label();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.txt_Title = new System.Windows.Forms.RichTextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_TWeightage.SuspendLayout();
            this.pnl_TMarks.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.btn_Submit);
            this.pnl_Main.Controls.Add(this.pnl_TWeightage);
            this.pnl_Main.Controls.Add(this.pnl_TMarks);
            this.pnl_Main.Controls.Add(this.pnl_Title);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(504, 461);
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
            this.btn_Submit.Location = new System.Drawing.Point(173, 389);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 53);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // pnl_TWeightage
            // 
            this.pnl_TWeightage.Controls.Add(this.txt_TWeightage);
            this.pnl_TWeightage.Controls.Add(this.lbl_TWeightage);
            this.pnl_TWeightage.Location = new System.Drawing.Point(51, 281);
            this.pnl_TWeightage.Name = "pnl_TWeightage";
            this.pnl_TWeightage.Size = new System.Drawing.Size(423, 68);
            this.pnl_TWeightage.TabIndex = 3;
            // 
            // txt_TWeightage
            // 
            this.txt_TWeightage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TWeightage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TWeightage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TWeightage.Location = new System.Drawing.Point(165, 20);
            this.txt_TWeightage.Name = "txt_TWeightage";
            this.txt_TWeightage.Size = new System.Drawing.Size(237, 33);
            this.txt_TWeightage.TabIndex = 1;
            this.txt_TWeightage.Text = "";
            // 
            // lbl_TWeightage
            // 
            this.lbl_TWeightage.AutoSize = true;
            this.lbl_TWeightage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TWeightage.Location = new System.Drawing.Point(11, 20);
            this.lbl_TWeightage.Name = "lbl_TWeightage";
            this.lbl_TWeightage.Size = new System.Drawing.Size(148, 25);
            this.lbl_TWeightage.TabIndex = 0;
            this.lbl_TWeightage.Text = "Total Weightage";
            // 
            // pnl_TMarks
            // 
            this.pnl_TMarks.Controls.Add(this.txt_TMarks);
            this.pnl_TMarks.Controls.Add(this.lbl_TMarks);
            this.pnl_TMarks.Location = new System.Drawing.Point(51, 183);
            this.pnl_TMarks.Name = "pnl_TMarks";
            this.pnl_TMarks.Size = new System.Drawing.Size(423, 68);
            this.pnl_TMarks.TabIndex = 2;
            // 
            // txt_TMarks
            // 
            this.txt_TMarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TMarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TMarks.Location = new System.Drawing.Point(165, 20);
            this.txt_TMarks.Name = "txt_TMarks";
            this.txt_TMarks.Size = new System.Drawing.Size(237, 33);
            this.txt_TMarks.TabIndex = 1;
            this.txt_TMarks.Text = "";
            // 
            // lbl_TMarks
            // 
            this.lbl_TMarks.AutoSize = true;
            this.lbl_TMarks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TMarks.Location = new System.Drawing.Point(11, 20);
            this.lbl_TMarks.Name = "lbl_TMarks";
            this.lbl_TMarks.Size = new System.Drawing.Size(108, 25);
            this.lbl_TMarks.TabIndex = 0;
            this.lbl_TMarks.Text = "Total Marks";
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.txt_Title);
            this.pnl_Title.Controls.Add(this.lbl_Title);
            this.pnl_Title.Location = new System.Drawing.Point(51, 89);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(423, 68);
            this.pnl_Title.TabIndex = 0;
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Title.Location = new System.Drawing.Point(165, 20);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(237, 33);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.Text = "";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(11, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(48, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            // 
            // frm_AssessmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_AssessmentAdd";
            this.Text = "Add Assessment";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_TWeightage.ResumeLayout(false);
            this.pnl_TWeightage.PerformLayout();
            this.pnl_TMarks.ResumeLayout(false);
            this.pnl_TMarks.PerformLayout();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private FontAwesome.Sharp.IconButton btn_Submit;
        private System.Windows.Forms.Panel pnl_TWeightage;
        private System.Windows.Forms.RichTextBox txt_TWeightage;
        private System.Windows.Forms.Label lbl_TWeightage;
        private System.Windows.Forms.Panel pnl_TMarks;
        private System.Windows.Forms.RichTextBox txt_TMarks;
        private System.Windows.Forms.Label lbl_TMarks;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.RichTextBox txt_Title;
        private System.Windows.Forms.Label lbl_Title;
    }
}