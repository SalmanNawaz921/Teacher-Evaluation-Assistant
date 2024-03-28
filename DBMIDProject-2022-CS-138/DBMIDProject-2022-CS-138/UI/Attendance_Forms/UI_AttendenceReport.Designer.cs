namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    partial class frm_AttendenceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Download = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_CompleteReport = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grid_AttendenceReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AttendenceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(627, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 650);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(133, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 77);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.box_Date);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(494, 77);
            this.panel10.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date";
            // 
            // box_Date
            // 
            this.box_Date.Animated = true;
            this.box_Date.AutoRoundedCorners = true;
            this.box_Date.BackColor = System.Drawing.Color.Transparent;
            this.box_Date.BorderRadius = 17;
            this.box_Date.Checked = true;
            this.box_Date.FillColor = System.Drawing.Color.White;
            this.box_Date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.box_Date.Location = new System.Drawing.Point(210, 23);
            this.box_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.box_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.box_Date.Name = "box_Date";
            this.box_Date.Size = new System.Drawing.Size(165, 36);
            this.box_Date.TabIndex = 0;
            this.box_Date.UseTransparentBackground = true;
            this.box_Date.Value = new System.DateTime(2024, 3, 8, 18, 13, 17, 591);
            this.box_Date.ValueChanged += new System.EventHandler(this.box_Date_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(133, 573);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 77);
            this.panel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Download);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 77);
            this.panel8.TabIndex = 1;
            // 
            // btn_Download
            // 
            this.btn_Download.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Download.FlatAppearance.BorderSize = 0;
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Download.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btn_Download.IconColor = System.Drawing.Color.Black;
            this.btn_Download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Download.IconSize = 32;
            this.btn_Download.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Download.Location = new System.Drawing.Point(178, 0);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(80, 77);
            this.btn_Download.TabIndex = 41;
            this.btn_Download.Text = "Download";
            this.btn_Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_CompleteReport);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(264, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 77);
            this.panel5.TabIndex = 0;
            // 
            // btn_CompleteReport
            // 
            this.btn_CompleteReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_CompleteReport.FlatAppearance.BorderSize = 0;
            this.btn_CompleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompleteReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_CompleteReport.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btn_CompleteReport.IconColor = System.Drawing.Color.Black;
            this.btn_CompleteReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompleteReport.IconSize = 32;
            this.btn_CompleteReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CompleteReport.Location = new System.Drawing.Point(0, 0);
            this.btn_CompleteReport.Name = "btn_CompleteReport";
            this.btn_CompleteReport.Size = new System.Drawing.Size(80, 77);
            this.btn_CompleteReport.TabIndex = 43;
            this.btn_CompleteReport.Text = "Download";
            this.btn_CompleteReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CompleteReport.UseVisualStyleBackColor = true;
            this.btn_CompleteReport.Click += new System.EventHandler(this.btn_CompleteReport_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(133, 545);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 28);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grid_AttendenceReport);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(133, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(494, 468);
            this.panel7.TabIndex = 5;
            // 
            // grid_AttendenceReport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_AttendenceReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AttendenceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_AttendenceReport.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AttendenceReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_AttendenceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_AttendenceReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AttendenceReport.Location = new System.Drawing.Point(0, 0);
            this.grid_AttendenceReport.Name = "grid_AttendenceReport";
            this.grid_AttendenceReport.ReadOnly = true;
            this.grid_AttendenceReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_AttendenceReport.RowHeadersVisible = false;
            this.grid_AttendenceReport.RowTemplate.ReadOnly = true;
            this.grid_AttendenceReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AttendenceReport.Size = new System.Drawing.Size(494, 468);
            this.grid_AttendenceReport.TabIndex = 49;
            this.grid_AttendenceReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_AttendenceReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_AttendenceReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_AttendenceReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_AttendenceReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_AttendenceReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_AttendenceReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_AttendenceReport.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_AttendenceReport.ThemeStyle.ReadOnly = true;
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.Height = 22;
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AttendenceReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_AttendenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 650);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AttendenceReport";
            this.Text = "Attendence Report";
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_AttendenceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker box_Date;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btn_Download;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btn_CompleteReport;
        private Guna.UI2.WinForms.Guna2DataGridView grid_AttendenceReport;
    }
}