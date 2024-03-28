namespace DBMIDProject_2022_CS_138.UI.Student_Result_Forms
{
    partial class frm_StudentResultList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grid_StudentsResult = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Download = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentsResult)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 90);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Download);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 617);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 72);
            this.panel4.TabIndex = 3;
            // 
            // grid_StudentsResult
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grid_StudentsResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_StudentsResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_StudentsResult.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentsResult.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_StudentsResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_StudentsResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsResult.Location = new System.Drawing.Point(0, 0);
            this.grid_StudentsResult.Name = "grid_StudentsResult";
            this.grid_StudentsResult.ReadOnly = true;
            this.grid_StudentsResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_StudentsResult.RowHeadersVisible = false;
            this.grid_StudentsResult.RowTemplate.ReadOnly = true;
            this.grid_StudentsResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_StudentsResult.Size = new System.Drawing.Size(540, 527);
            this.grid_StudentsResult.TabIndex = 49;
            this.grid_StudentsResult.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsResult.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_StudentsResult.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_StudentsResult.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_StudentsResult.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_StudentsResult.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsResult.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_StudentsResult.ThemeStyle.HeaderStyle.Height = 30;
            this.grid_StudentsResult.ThemeStyle.ReadOnly = true;
            this.grid_StudentsResult.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_StudentsResult.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_StudentsResult.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_StudentsResult.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_StudentsResult.ThemeStyle.RowsStyle.Height = 22;
            this.grid_StudentsResult.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_StudentsResult.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 527);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(663, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 527);
            this.panel2.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grid_StudentsResult);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(123, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 527);
            this.panel5.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 72);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(444, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 72);
            this.panel7.TabIndex = 1;
            // 
            // btn_Download
            // 
            this.btn_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Download.FlatAppearance.BorderSize = 0;
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Download.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btn_Download.IconColor = System.Drawing.Color.Black;
            this.btn_Download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Download.IconSize = 32;
            this.btn_Download.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Download.Location = new System.Drawing.Point(337, 0);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(107, 72);
            this.btn_Download.TabIndex = 40;
            this.btn_Download.Text = "Download";
            this.btn_Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // frm_StudentResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 689);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frm_StudentResultList";
            this.Text = "Student Result";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_StudentsResult)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView grid_StudentsResult;
        private FontAwesome.Sharp.IconButton btn_Download;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}