namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    partial class frm_AssessmentWiseResult
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.box_Assessment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Assessment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_TopGrid = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.grid_AssessmentWiseResult = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Download = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_TopGrid.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AssessmentWiseResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(529, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 53);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btn_Download);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 54);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 69);
            this.panel4.TabIndex = 60;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(493, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(267, 69);
            this.panel10.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.box_Assessment);
            this.panel7.Controls.Add(this.lbl_Assessment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(359, 69);
            this.panel7.TabIndex = 0;
            // 
            // box_Assessment
            // 
            this.box_Assessment.AutoRoundedCorners = true;
            this.box_Assessment.BackColor = System.Drawing.Color.Transparent;
            this.box_Assessment.BorderRadius = 17;
            this.box_Assessment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_Assessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Assessment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_Assessment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_Assessment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_Assessment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_Assessment.ItemHeight = 30;
            this.box_Assessment.Location = new System.Drawing.Point(23, 27);
            this.box_Assessment.Name = "box_Assessment";
            this.box_Assessment.Size = new System.Drawing.Size(213, 36);
            this.box_Assessment.TabIndex = 1;
            this.box_Assessment.SelectedIndexChanged += new System.EventHandler(this.box_Assessment_SelectedIndexChanged);
            // 
            // lbl_Assessment
            // 
            this.lbl_Assessment.AutoSize = true;
            this.lbl_Assessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Assessment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Assessment.Location = new System.Drawing.Point(0, 0);
            this.lbl_Assessment.Name = "lbl_Assessment";
            this.lbl_Assessment.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.lbl_Assessment.Size = new System.Drawing.Size(172, 21);
            this.lbl_Assessment.TabIndex = 0;
            this.lbl_Assessment.Text = "Assessment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 60);
            this.panel1.TabIndex = 31;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.White;
            this.pnl_Bottom.Controls.Add(this.panel1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 590);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(760, 60);
            this.pnl_Bottom.TabIndex = 57;
            // 
            // pnl_TopGrid
            // 
            this.pnl_TopGrid.Controls.Add(this.panel2);
            this.pnl_TopGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopGrid.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopGrid.Name = "pnl_TopGrid";
            this.pnl_TopGrid.Size = new System.Drawing.Size(760, 53);
            this.pnl_TopGrid.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 57);
            this.panel5.TabIndex = 61;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 179);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 411);
            this.panel9.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(651, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 411);
            this.panel6.TabIndex = 65;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.grid_AssessmentWiseResult);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(109, 179);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(542, 411);
            this.panel11.TabIndex = 66;
            // 
            // grid_AssessmentWiseResult
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_AssessmentWiseResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AssessmentWiseResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_AssessmentWiseResult.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AssessmentWiseResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_AssessmentWiseResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_AssessmentWiseResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AssessmentWiseResult.Location = new System.Drawing.Point(0, 0);
            this.grid_AssessmentWiseResult.Name = "grid_AssessmentWiseResult";
            this.grid_AssessmentWiseResult.ReadOnly = true;
            this.grid_AssessmentWiseResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_AssessmentWiseResult.RowHeadersVisible = false;
            this.grid_AssessmentWiseResult.RowTemplate.ReadOnly = true;
            this.grid_AssessmentWiseResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AssessmentWiseResult.Size = new System.Drawing.Size(542, 411);
            this.grid_AssessmentWiseResult.TabIndex = 64;
            this.grid_AssessmentWiseResult.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_AssessmentWiseResult.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_AssessmentWiseResult.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_AssessmentWiseResult.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_AssessmentWiseResult.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_AssessmentWiseResult.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_AssessmentWiseResult.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_AssessmentWiseResult.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_AssessmentWiseResult.ThemeStyle.ReadOnly = true;
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.Height = 22;
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_AssessmentWiseResult.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_Download.Location = new System.Drawing.Point(370, 0);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(80, 54);
            this.btn_Download.TabIndex = 39;
            this.btn_Download.Text = "Download";
            this.btn_Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // frm_AssessmentWiseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 650);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_TopGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AssessmentWiseResult";
            this.Text = "Assessment Wise Result";
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_TopGrid.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_AssessmentWiseResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_Download;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2ComboBox box_Assessment;
        private System.Windows.Forms.Label lbl_Assessment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_TopGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2DataGridView grid_AssessmentWiseResult;
    }
}