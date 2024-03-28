namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    partial class frm_AssessmentUI
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Edit = new FontAwesome.Sharp.IconButton();
            this.grid_Assessment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_TopGrid.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Assessment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 683);
            this.panel9.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(715, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 683);
            this.panel6.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 736);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(824, 10);
            this.panel8.TabIndex = 25;
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(824, 53);
            this.pnl_TopGrid.TabIndex = 23;
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
            this.btn_Search.PlaceholderText = "Search By Title...";
            this.btn_Search.SelectedText = "";
            this.btn_Search.Size = new System.Drawing.Size(200, 36);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.TextChanged += new System.EventHandler(this.btn_Search_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(764, 43);
            this.panel5.TabIndex = 26;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.panel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 746);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(824, 60);
            this.pnl_Bottom.TabIndex = 22;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 54);
            this.panel3.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.IconSize = 32;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(268, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 54);
            this.btn_Add.TabIndex = 37;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.IconSize = 32;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Delete.Location = new System.Drawing.Point(348, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(63, 54);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Edit.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btn_Edit.IconColor = System.Drawing.Color.Black;
            this.btn_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Edit.IconSize = 32;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Edit.Location = new System.Drawing.Point(411, 0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(77, 54);
            this.btn_Edit.TabIndex = 36;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click_1);
            // 
            // grid_Assessment
            // 
            this.grid_Assessment.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_Assessment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Assessment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Assessment.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Assessment.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Assessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Assessment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Assessment.Location = new System.Drawing.Point(109, 53);
            this.grid_Assessment.Name = "grid_Assessment";
            this.grid_Assessment.ReadOnly = true;
            this.grid_Assessment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_Assessment.RowHeadersVisible = false;
            this.grid_Assessment.RowTemplate.ReadOnly = true;
            this.grid_Assessment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Assessment.Size = new System.Drawing.Size(606, 683);
            this.grid_Assessment.TabIndex = 37;
            this.grid_Assessment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_Assessment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_Assessment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_Assessment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_Assessment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_Assessment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_Assessment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Assessment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_Assessment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_Assessment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Assessment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_Assessment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_Assessment.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_Assessment.ThemeStyle.ReadOnly = true;
            this.grid_Assessment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_Assessment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_Assessment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Assessment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_Assessment.ThemeStyle.RowsStyle.Height = 22;
            this.grid_Assessment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Assessment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_AssessmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 806);
            this.Controls.Add(this.grid_Assessment);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnl_TopGrid);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AssessmentUI";
            this.Text = "Assessment";
            this.pnl_TopGrid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Assessment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox btn_Search;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private Guna.UI2.WinForms.Guna2DataGridView grid_Assessment;
    }
}