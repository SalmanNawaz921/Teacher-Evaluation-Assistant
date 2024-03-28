namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    partial class frm_Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.grid_StudentAttendence = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_View = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_TopGrid.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentAttendence)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 501);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(773, 60);
            this.pnl_Bottom.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(542, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 53);
            this.panel2.TabIndex = 2;
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(773, 53);
            this.pnl_TopGrid.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(124, 448);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(649, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(124, 448);
            this.panel6.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(124, 448);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(525, 53);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(124, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(525, 53);
            this.panel8.TabIndex = 23;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.box_Date);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(525, 53);
            this.panel10.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 14);
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
            this.box_Date.Location = new System.Drawing.Point(199, 6);
            this.box_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.box_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.box_Date.Name = "box_Date";
            this.box_Date.Size = new System.Drawing.Size(165, 36);
            this.box_Date.TabIndex = 0;
            this.box_Date.UseTransparentBackground = true;
            this.box_Date.Value = new System.DateTime(2024, 3, 8, 18, 13, 17, 591);
            this.box_Date.ValueChanged += new System.EventHandler(this.box_Date_ValueChanged);
            // 
            // grid_StudentAttendence
            // 
            this.grid_StudentAttendence.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grid_StudentAttendence.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentAttendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_StudentAttendence.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentAttendence.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_StudentAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_StudentAttendence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentAttendence.Location = new System.Drawing.Point(124, 106);
            this.grid_StudentAttendence.Name = "grid_StudentAttendence";
            this.grid_StudentAttendence.RowHeadersVisible = false;
            this.grid_StudentAttendence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_StudentAttendence.RowTemplate.DividerHeight = 5;
            this.grid_StudentAttendence.RowTemplate.Height = 30;
            this.grid_StudentAttendence.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentAttendence.Size = new System.Drawing.Size(525, 342);
            this.grid_StudentAttendence.TabIndex = 24;
            this.grid_StudentAttendence.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentAttendence.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_StudentAttendence.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_StudentAttendence.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_StudentAttendence.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_StudentAttendence.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentAttendence.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_StudentAttendence.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_StudentAttendence.ThemeStyle.ReadOnly = false;
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.Height = 30;
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentAttendence.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_StudentAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_StudentAttendence_CellContentClick);
            // 
            // btn_View
            // 
            this.btn_View.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_View.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btn_View.IconColor = System.Drawing.Color.Black;
            this.btn_View.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_View.IconSize = 32;
            this.btn_View.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_View.Location = new System.Drawing.Point(377, 0);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(80, 54);
            this.btn_View.TabIndex = 1;
            this.btn_View.Text = "View";
            this.btn_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_View);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 54);
            this.panel3.TabIndex = 0;
            // 
            // frm_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.grid_StudentAttendence);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_TopGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Attendance";
            this.Text = "Student Attendence";
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_TopGrid.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentAttendence)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_View;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2DateTimePicker box_Date;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView grid_StudentAttendence;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}