namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    partial class frm_CompleteAttendenceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_CompleteReport = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grid_CompleteAttendenceReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CompleteAttendenceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(133, 506);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 28);
            this.panel6.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(133, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 77);
            this.panel3.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(478, 77);
            this.panel10.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complete Attendance Report";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(611, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 534);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 534);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 77);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_CompleteReport);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(508, 77);
            this.panel8.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(514, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 77);
            this.panel5.TabIndex = 0;
            // 
            // btn_CompleteReport
            // 
            this.btn_CompleteReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CompleteReport.FlatAppearance.BorderSize = 0;
            this.btn_CompleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompleteReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_CompleteReport.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btn_CompleteReport.IconColor = System.Drawing.Color.Black;
            this.btn_CompleteReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompleteReport.IconSize = 32;
            this.btn_CompleteReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CompleteReport.Location = new System.Drawing.Point(428, 0);
            this.btn_CompleteReport.Name = "btn_CompleteReport";
            this.btn_CompleteReport.Size = new System.Drawing.Size(80, 77);
            this.btn_CompleteReport.TabIndex = 44;
            this.btn_CompleteReport.Text = "Download";
            this.btn_CompleteReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CompleteReport.UseVisualStyleBackColor = true;
            this.btn_CompleteReport.Click += new System.EventHandler(this.btn_CompleteReport_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grid_CompleteAttendenceReport);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(133, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(478, 429);
            this.panel7.TabIndex = 11;
            // 
            // grid_CompleteAttendenceReport
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grid_CompleteAttendenceReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_CompleteAttendenceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_CompleteAttendenceReport.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CompleteAttendenceReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_CompleteAttendenceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CompleteAttendenceReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CompleteAttendenceReport.Location = new System.Drawing.Point(0, 0);
            this.grid_CompleteAttendenceReport.Name = "grid_CompleteAttendenceReport";
            this.grid_CompleteAttendenceReport.ReadOnly = true;
            this.grid_CompleteAttendenceReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_CompleteAttendenceReport.RowHeadersVisible = false;
            this.grid_CompleteAttendenceReport.RowTemplate.ReadOnly = true;
            this.grid_CompleteAttendenceReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CompleteAttendenceReport.Size = new System.Drawing.Size(478, 429);
            this.grid_CompleteAttendenceReport.TabIndex = 50;
            this.grid_CompleteAttendenceReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_CompleteAttendenceReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_CompleteAttendenceReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_CompleteAttendenceReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_CompleteAttendenceReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_CompleteAttendenceReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_CompleteAttendenceReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_CompleteAttendenceReport.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_CompleteAttendenceReport.ThemeStyle.ReadOnly = true;
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.Height = 22;
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CompleteAttendenceReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_CompleteAttendenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frm_CompleteAttendenceReport";
            this.Text = "Complete Attendance Report";
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CompleteAttendenceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btn_CompleteReport;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2DataGridView grid_CompleteAttendenceReport;
    }
}