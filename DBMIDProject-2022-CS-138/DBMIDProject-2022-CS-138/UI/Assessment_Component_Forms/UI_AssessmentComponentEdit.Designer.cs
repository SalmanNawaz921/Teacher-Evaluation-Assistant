namespace DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms
{
    partial class frm_AssessmentComponentEdit
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
            this.pnl_TMarks = new System.Windows.Forms.Panel();
            this.txt_TMarks = new System.Windows.Forms.RichTextBox();
            this.lbl_TMarks = new System.Windows.Forms.Label();
            this.pnl_RubricId = new System.Windows.Forms.Panel();
            this.box_RubricId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_RubricID = new System.Windows.Forms.Label();
            this.pnl_AssessmentId = new System.Windows.Forms.Panel();
            this.box_Assessmentid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_AssessmentId = new System.Windows.Forms.Label();
            this.pnl_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.RichTextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.pnl_Main.SuspendLayout();
            this.pnl_TMarks.SuspendLayout();
            this.pnl_RubricId.SuspendLayout();
            this.pnl_AssessmentId.SuspendLayout();
            this.pnl_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.pnl_TMarks);
            this.pnl_Main.Controls.Add(this.pnl_RubricId);
            this.pnl_Main.Controls.Add(this.pnl_AssessmentId);
            this.pnl_Main.Controls.Add(this.pnl_Name);
            this.pnl_Main.Controls.Add(this.btn_Confirm);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(492, 582);
            this.pnl_Main.TabIndex = 3;
            // 
            // pnl_TMarks
            // 
            this.pnl_TMarks.Controls.Add(this.txt_TMarks);
            this.pnl_TMarks.Controls.Add(this.lbl_TMarks);
            this.pnl_TMarks.Location = new System.Drawing.Point(51, 255);
            this.pnl_TMarks.Name = "pnl_TMarks";
            this.pnl_TMarks.Size = new System.Drawing.Size(389, 68);
            this.pnl_TMarks.TabIndex = 8;
            // 
            // txt_TMarks
            // 
            this.txt_TMarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TMarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TMarks.Location = new System.Drawing.Point(127, 20);
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
            // pnl_RubricId
            // 
            this.pnl_RubricId.Controls.Add(this.box_RubricId);
            this.pnl_RubricId.Controls.Add(this.lbl_RubricID);
            this.pnl_RubricId.Location = new System.Drawing.Point(51, 147);
            this.pnl_RubricId.Name = "pnl_RubricId";
            this.pnl_RubricId.Size = new System.Drawing.Size(389, 74);
            this.pnl_RubricId.TabIndex = 8;
            // 
            // box_RubricId
            // 
            this.box_RubricId.BackColor = System.Drawing.Color.Transparent;
            this.box_RubricId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_RubricId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_RubricId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_RubricId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_RubricId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_RubricId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_RubricId.ItemHeight = 30;
            this.box_RubricId.Location = new System.Drawing.Point(127, 20);
            this.box_RubricId.Name = "box_RubricId";
            this.box_RubricId.Size = new System.Drawing.Size(237, 36);
            this.box_RubricId.TabIndex = 1;
            // 
            // lbl_RubricID
            // 
            this.lbl_RubricID.AutoSize = true;
            this.lbl_RubricID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RubricID.Location = new System.Drawing.Point(11, 20);
            this.lbl_RubricID.Name = "lbl_RubricID";
            this.lbl_RubricID.Size = new System.Drawing.Size(87, 25);
            this.lbl_RubricID.TabIndex = 0;
            this.lbl_RubricID.Text = "Rubric Id";
            // 
            // pnl_AssessmentId
            // 
            this.pnl_AssessmentId.Controls.Add(this.box_Assessmentid);
            this.pnl_AssessmentId.Controls.Add(this.lbl_AssessmentId);
            this.pnl_AssessmentId.Location = new System.Drawing.Point(51, 365);
            this.pnl_AssessmentId.Name = "pnl_AssessmentId";
            this.pnl_AssessmentId.Size = new System.Drawing.Size(389, 79);
            this.pnl_AssessmentId.TabIndex = 0;
            // 
            // box_Assessmentid
            // 
            this.box_Assessmentid.BackColor = System.Drawing.Color.Transparent;
            this.box_Assessmentid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_Assessmentid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Assessmentid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_Assessmentid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_Assessmentid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_Assessmentid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_Assessmentid.ItemHeight = 30;
            this.box_Assessmentid.Location = new System.Drawing.Point(140, 20);
            this.box_Assessmentid.Name = "box_Assessmentid";
            this.box_Assessmentid.Size = new System.Drawing.Size(237, 36);
            this.box_Assessmentid.TabIndex = 1;
            // 
            // lbl_AssessmentId
            // 
            this.lbl_AssessmentId.AutoSize = true;
            this.lbl_AssessmentId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssessmentId.Location = new System.Drawing.Point(3, 24);
            this.lbl_AssessmentId.Name = "lbl_AssessmentId";
            this.lbl_AssessmentId.Size = new System.Drawing.Size(130, 25);
            this.lbl_AssessmentId.TabIndex = 0;
            this.lbl_AssessmentId.Text = "Assessment Id";
            // 
            // pnl_Name
            // 
            this.pnl_Name.Controls.Add(this.txt_Name);
            this.pnl_Name.Controls.Add(this.lbl_Name);
            this.pnl_Name.Location = new System.Drawing.Point(51, 46);
            this.pnl_Name.Name = "pnl_Name";
            this.pnl_Name.Size = new System.Drawing.Size(389, 68);
            this.pnl_Name.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Name.Location = new System.Drawing.Point(127, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(237, 33);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Text = "";
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
            this.btn_Confirm.Location = new System.Drawing.Point(165, 476);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(139, 53);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_AssessmentComponentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 582);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_AssessmentComponentEdit";
            this.Text = "Edit Assessment Component";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_TMarks.ResumeLayout(false);
            this.pnl_TMarks.PerformLayout();
            this.pnl_RubricId.ResumeLayout(false);
            this.pnl_RubricId.PerformLayout();
            this.pnl_AssessmentId.ResumeLayout(false);
            this.pnl_AssessmentId.PerformLayout();
            this.pnl_Name.ResumeLayout(false);
            this.pnl_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_TMarks;
        private System.Windows.Forms.RichTextBox txt_TMarks;
        private System.Windows.Forms.Label lbl_TMarks;
        private System.Windows.Forms.Panel pnl_RubricId;
        private Guna.UI2.WinForms.Guna2ComboBox box_RubricId;
        private System.Windows.Forms.Label lbl_RubricID;
        private System.Windows.Forms.Panel pnl_AssessmentId;
        private Guna.UI2.WinForms.Guna2ComboBox box_Assessmentid;
        private System.Windows.Forms.Label lbl_AssessmentId;
        private System.Windows.Forms.Panel pnl_Name;
        private System.Windows.Forms.RichTextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private FontAwesome.Sharp.IconButton btn_Confirm;
    }
}