namespace DBMIDProject_2022_CS_138.UI.Student_Forms
{
    partial class frm_StudentInactive
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
            this.btn_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.grid_StudentsInactive = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Active = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_TopGrid.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentsInactive)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Animated = true;
            this.btn_Search.AutoRoundedCorners = true;
            this.btn_Search.BorderRadius = 17;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_Search.DefaultText = "";
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Search.Location = new System.Drawing.Point(19, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.PasswordChar = '\0';
            this.btn_Search.PlaceholderText = "Search...";
            this.btn_Search.SelectedText = "";
            this.btn_Search.Size = new System.Drawing.Size(200, 36);
            this.btn_Search.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Active);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 54);
            this.panel3.TabIndex = 0;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 60);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(593, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 53);
            this.panel2.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 683);
            this.panel9.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(715, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 683);
            this.panel6.TabIndex = 43;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 736);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(824, 10);
            this.panel8.TabIndex = 40;
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(824, 53);
            this.pnl_TopGrid.TabIndex = 39;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.panel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 746);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(824, 60);
            this.pnl_Bottom.TabIndex = 38;
            // 
            // grid_StudentsInactive
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_StudentsInactive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_StudentsInactive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_StudentsInactive.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentsInactive.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_StudentsInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_StudentsInactive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsInactive.Location = new System.Drawing.Point(109, 53);
            this.grid_StudentsInactive.Name = "grid_StudentsInactive";
            this.grid_StudentsInactive.ReadOnly = true;
            this.grid_StudentsInactive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_StudentsInactive.RowHeadersVisible = false;
            this.grid_StudentsInactive.RowTemplate.ReadOnly = true;
            this.grid_StudentsInactive.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentsInactive.Size = new System.Drawing.Size(606, 683);
            this.grid_StudentsInactive.TabIndex = 44;
            this.grid_StudentsInactive.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsInactive.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_StudentsInactive.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_StudentsInactive.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_StudentsInactive.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_StudentsInactive.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsInactive.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_StudentsInactive.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_StudentsInactive.ThemeStyle.ReadOnly = true;
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.Height = 22;
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsInactive.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_Active
            // 
            this.btn_Active.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Active.FlatAppearance.BorderSize = 0;
            this.btn_Active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Active.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Active.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btn_Active.IconColor = System.Drawing.Color.Black;
            this.btn_Active.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Active.IconSize = 32;
            this.btn_Active.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Active.Location = new System.Drawing.Point(408, 0);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(80, 54);
            this.btn_Active.TabIndex = 37;
            this.btn_Active.Text = " Active";
            this.btn_Active.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Active.UseVisualStyleBackColor = true;
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // frm_StudentInactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 806);
            this.Controls.Add(this.grid_StudentsInactive);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnl_TopGrid);
            this.Controls.Add(this.pnl_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentInactive";
            this.Text = "Inactive Students";
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_TopGrid.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentsInactive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_Active;
        private Guna.UI2.WinForms.Guna2TextBox btn_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel pnl_Bottom;
        private Guna.UI2.WinForms.Guna2DataGridView grid_StudentsInactive;
    }
}