namespace DBMIDProject_2022_CS_138.UI.Student_Result_Forms
{
    partial class frm_StudentResultMark
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_View = new FontAwesome.Sharp.IconButton();
            this.btn_Mark = new FontAwesome.Sharp.IconButton();
            this.btn_Edit = new FontAwesome.Sharp.IconButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.box_MeasurementId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.box_ComponentId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_ComponentId = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grid_StudentDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_TopGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 658);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 10);
            this.panel8.TabIndex = 42;
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(792, 53);
            this.pnl_TopGrid.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(561, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 53);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 60);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_View);
            this.panel3.Controls.Add(this.btn_Mark);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 54);
            this.panel3.TabIndex = 0;
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
            this.btn_View.Location = new System.Drawing.Point(232, 0);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(80, 54);
            this.btn_View.TabIndex = 39;
            this.btn_View.Text = "View";
            this.btn_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Mark
            // 
            this.btn_Mark.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Mark.FlatAppearance.BorderSize = 0;
            this.btn_Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mark.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Mark.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btn_Mark.IconColor = System.Drawing.Color.Black;
            this.btn_Mark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Mark.IconSize = 32;
            this.btn_Mark.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mark.Location = new System.Drawing.Point(312, 0);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(80, 54);
            this.btn_Mark.TabIndex = 37;
            this.btn_Mark.Text = "Mark";
            this.btn_Mark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Mark.UseVisualStyleBackColor = true;
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
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
            this.btn_Edit.Location = new System.Drawing.Point(392, 0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(77, 54);
            this.btn_Edit.TabIndex = 36;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.panel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 668);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(792, 60);
            this.pnl_Bottom.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 69);
            this.panel4.TabIndex = 43;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.box_MeasurementId);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(525, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(267, 69);
            this.panel10.TabIndex = 1;
            // 
            // box_MeasurementId
            // 
            this.box_MeasurementId.AutoRoundedCorners = true;
            this.box_MeasurementId.BackColor = System.Drawing.Color.Transparent;
            this.box_MeasurementId.BorderRadius = 17;
            this.box_MeasurementId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_MeasurementId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_MeasurementId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_MeasurementId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_MeasurementId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_MeasurementId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_MeasurementId.ItemHeight = 30;
            this.box_MeasurementId.Location = new System.Drawing.Point(4, 30);
            this.box_MeasurementId.Name = "box_MeasurementId";
            this.box_MeasurementId.Size = new System.Drawing.Size(189, 36);
            this.box_MeasurementId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Measurement ID";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.box_ComponentId);
            this.panel7.Controls.Add(this.lbl_ComponentId);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 69);
            this.panel7.TabIndex = 0;
            // 
            // box_ComponentId
            // 
            this.box_ComponentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.box_ComponentId.AutoRoundedCorners = true;
            this.box_ComponentId.BackColor = System.Drawing.Color.Transparent;
            this.box_ComponentId.BorderRadius = 17;
            this.box_ComponentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_ComponentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_ComponentId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_ComponentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_ComponentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_ComponentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_ComponentId.ItemHeight = 30;
            this.box_ComponentId.Location = new System.Drawing.Point(75, 27);
            this.box_ComponentId.Name = "box_ComponentId";
            this.box_ComponentId.Size = new System.Drawing.Size(189, 36);
            this.box_ComponentId.TabIndex = 1;
            this.box_ComponentId.SelectedIndexChanged += new System.EventHandler(this.box_ComponentId_SelectedIndexChanged);
            // 
            // lbl_ComponentId
            // 
            this.lbl_ComponentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ComponentId.AutoSize = true;
            this.lbl_ComponentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComponentId.Location = new System.Drawing.Point(67, 3);
            this.lbl_ComponentId.Name = "lbl_ComponentId";
            this.lbl_ComponentId.Size = new System.Drawing.Size(197, 21);
            this.lbl_ComponentId.TabIndex = 0;
            this.lbl_ComponentId.Text = "Assessment Component ID";
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 536);
            this.panel9.TabIndex = 47;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(683, 122);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 536);
            this.panel6.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grid_StudentDetails);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(109, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 536);
            this.panel5.TabIndex = 49;
            // 
            // grid_StudentDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_StudentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_StudentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_StudentDetails.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_StudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_StudentDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentDetails.Location = new System.Drawing.Point(0, 0);
            this.grid_StudentDetails.Name = "grid_StudentDetails";
            this.grid_StudentDetails.ReadOnly = true;
            this.grid_StudentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_StudentDetails.RowHeadersVisible = false;
            this.grid_StudentDetails.RowTemplate.ReadOnly = true;
            this.grid_StudentDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentDetails.Size = new System.Drawing.Size(574, 536);
            this.grid_StudentDetails.TabIndex = 47;
            this.grid_StudentDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_StudentDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_StudentDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_StudentDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_StudentDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_StudentDetails.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_StudentDetails.ThemeStyle.ReadOnly = true;
            this.grid_StudentDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_StudentDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_StudentDetails.ThemeStyle.RowsStyle.Height = 22;
            this.grid_StudentDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_StudentResultMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 728);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnl_TopGrid);
            this.Controls.Add(this.pnl_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentResultMark";
            this.Text = "Mark Student Result";
            this.pnl_TopGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_Mark;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView grid_StudentDetails;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_ComponentId;
        private Guna.UI2.WinForms.Guna2ComboBox box_ComponentId;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2ComboBox box_MeasurementId;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_View;
    }
}