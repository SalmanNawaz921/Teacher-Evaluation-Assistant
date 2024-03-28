﻿namespace DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms
{
    partial class frm_RubricLevelAdd
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
            this.lbl_RubricId = new System.Windows.Forms.Label();
            this.pnl_RegNo = new System.Windows.Forms.Panel();
            this.txt_Details = new System.Windows.Forms.RichTextBox();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.pnl_RubricIds = new System.Windows.Forms.Panel();
            this.box_RubricId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Submit = new FontAwesome.Sharp.IconButton();
            this.pnl_MeasurementLevel = new System.Windows.Forms.Panel();
            this.box_MeasurementLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_MeasurementLevel = new System.Windows.Forms.Label();
            this.pnl_RegNo.SuspendLayout();
            this.pnl_RubricIds.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_MeasurementLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RubricId
            // 
            this.lbl_RubricId.AutoSize = true;
            this.lbl_RubricId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RubricId.Location = new System.Drawing.Point(11, 20);
            this.lbl_RubricId.Name = "lbl_RubricId";
            this.lbl_RubricId.Size = new System.Drawing.Size(87, 25);
            this.lbl_RubricId.TabIndex = 0;
            this.lbl_RubricId.Text = "Rubric Id";
            // 
            // pnl_RegNo
            // 
            this.pnl_RegNo.Controls.Add(this.txt_Details);
            this.pnl_RegNo.Controls.Add(this.lbl_Details);
            this.pnl_RegNo.Location = new System.Drawing.Point(51, 231);
            this.pnl_RegNo.Name = "pnl_RegNo";
            this.pnl_RegNo.Size = new System.Drawing.Size(377, 152);
            this.pnl_RegNo.TabIndex = 5;
            // 
            // txt_Details
            // 
            this.txt_Details.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Details.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Details.Location = new System.Drawing.Point(117, 29);
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(247, 109);
            this.txt_Details.TabIndex = 1;
            this.txt_Details.Text = "";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Location = new System.Drawing.Point(11, 70);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(69, 25);
            this.lbl_Details.TabIndex = 0;
            this.lbl_Details.Text = "Details";
            // 
            // pnl_RubricIds
            // 
            this.pnl_RubricIds.Controls.Add(this.box_RubricId);
            this.pnl_RubricIds.Controls.Add(this.lbl_RubricId);
            this.pnl_RubricIds.Location = new System.Drawing.Point(51, 89);
            this.pnl_RubricIds.Name = "pnl_RubricIds";
            this.pnl_RubricIds.Size = new System.Drawing.Size(377, 79);
            this.pnl_RubricIds.TabIndex = 0;
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
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.pnl_MeasurementLevel);
            this.pnl_Main.Controls.Add(this.btn_Submit);
            this.pnl_Main.Controls.Add(this.pnl_RegNo);
            this.pnl_Main.Controls.Add(this.pnl_RubricIds);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(530, 642);
            this.pnl_Main.TabIndex = 2;
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
            this.btn_Submit.Location = new System.Drawing.Point(178, 536);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(92, 53);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Add";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // pnl_MeasurementLevel
            // 
            this.pnl_MeasurementLevel.Controls.Add(this.box_MeasurementLevel);
            this.pnl_MeasurementLevel.Controls.Add(this.lbl_MeasurementLevel);
            this.pnl_MeasurementLevel.Location = new System.Drawing.Point(51, 418);
            this.pnl_MeasurementLevel.Name = "pnl_MeasurementLevel";
            this.pnl_MeasurementLevel.Size = new System.Drawing.Size(377, 79);
            this.pnl_MeasurementLevel.TabIndex = 2;
            // 
            // box_MeasurementLevel
            // 
            this.box_MeasurementLevel.BackColor = System.Drawing.Color.Transparent;
            this.box_MeasurementLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_MeasurementLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_MeasurementLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_MeasurementLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_MeasurementLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_MeasurementLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_MeasurementLevel.ItemHeight = 30;
            this.box_MeasurementLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.box_MeasurementLevel.Location = new System.Drawing.Point(213, 20);
            this.box_MeasurementLevel.Name = "box_MeasurementLevel";
            this.box_MeasurementLevel.Size = new System.Drawing.Size(135, 36);
            this.box_MeasurementLevel.StartIndex = 0;
            this.box_MeasurementLevel.TabIndex = 1;
            // 
            // lbl_MeasurementLevel
            // 
            this.lbl_MeasurementLevel.AutoSize = true;
            this.lbl_MeasurementLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MeasurementLevel.Location = new System.Drawing.Point(11, 20);
            this.lbl_MeasurementLevel.Name = "lbl_MeasurementLevel";
            this.lbl_MeasurementLevel.Size = new System.Drawing.Size(176, 25);
            this.lbl_MeasurementLevel.TabIndex = 0;
            this.lbl_MeasurementLevel.Text = "Measurement Level";
            // 
            // frm_RubricLevelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 642);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_RubricLevelAdd";
            this.Text = "Add Rubric Level";
            this.pnl_RegNo.ResumeLayout(false);
            this.pnl_RegNo.PerformLayout();
            this.pnl_RubricIds.ResumeLayout(false);
            this.pnl_RubricIds.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_MeasurementLevel.ResumeLayout(false);
            this.pnl_MeasurementLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RubricId;
        private System.Windows.Forms.Panel pnl_RegNo;
        private System.Windows.Forms.RichTextBox txt_Details;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Panel pnl_RubricIds;
        private Guna.UI2.WinForms.Guna2ComboBox box_RubricId;
        private System.Windows.Forms.Panel pnl_Main;
        private FontAwesome.Sharp.IconButton btn_Submit;
        private System.Windows.Forms.Panel pnl_MeasurementLevel;
        private Guna.UI2.WinForms.Guna2ComboBox box_MeasurementLevel;
        private System.Windows.Forms.Label lbl_MeasurementLevel;
    }
}