namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    partial class frm_ClosUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grid_CLOs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Edit = new FontAwesome.Sharp.IconButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnl_TopGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CLOs)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(549, 0);
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
            this.btn_Search.Location = new System.Drawing.Point(15, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.PasswordChar = '\0';
            this.btn_Search.PlaceholderText = "Search By Name...";
            this.btn_Search.SelectedText = "";
            this.btn_Search.Size = new System.Drawing.Size(200, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.TextChanged += new System.EventHandler(this.btn_Search_TextChanged);
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(780, 53);
            this.pnl_TopGrid.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 96);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 493);
            this.panel9.TabIndex = 20;
            // 
            // grid_CLOs
            // 
            this.grid_CLOs.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grid_CLOs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_CLOs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_CLOs.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CLOs.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_CLOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CLOs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CLOs.Location = new System.Drawing.Point(0, 96);
            this.grid_CLOs.Name = "grid_CLOs";
            this.grid_CLOs.ReadOnly = true;
            this.grid_CLOs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_CLOs.RowHeadersVisible = false;
            this.grid_CLOs.RowTemplate.ReadOnly = true;
            this.grid_CLOs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CLOs.Size = new System.Drawing.Size(671, 493);
            this.grid_CLOs.TabIndex = 17;
            this.grid_CLOs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_CLOs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_CLOs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_CLOs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_CLOs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_CLOs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_CLOs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CLOs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_CLOs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_CLOs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_CLOs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_CLOs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_CLOs.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_CLOs.ThemeStyle.ReadOnly = true;
            this.grid_CLOs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_CLOs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_CLOs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_CLOs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_CLOs.ThemeStyle.RowsStyle.Height = 22;
            this.grid_CLOs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_CLOs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(671, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 493);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(780, 43);
            this.panel5.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 589);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(780, 43);
            this.panel8.TabIndex = 18;
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
            this.btn_Add.Location = new System.Drawing.Point(222, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 54);
            this.btn_Add.TabIndex = 22;
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
            this.btn_Delete.Location = new System.Drawing.Point(302, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 54);
            this.btn_Delete.TabIndex = 24;
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
            this.btn_Edit.Location = new System.Drawing.Point(382, 0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 54);
            this.btn_Edit.TabIndex = 23;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 632);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(780, 60);
            this.pnl_Bottom.TabIndex = 14;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 54);
            this.panel3.TabIndex = 0;
            // 
            // frm_ClosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 692);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.grid_CLOs);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnl_TopGrid);
            this.Controls.Add(this.pnl_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ClosUI";
            this.Text = "CLOS";
            this.panel2.ResumeLayout(false);
            this.pnl_TopGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CLOs)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2DataGridView grid_CLOs;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox btn_Search;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}