namespace DBMIDProject_2022_CS_138.UI.Dashboard
{
    partial class frm_Dashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_ActiveStudentsCount = new System.Windows.Forms.Label();
            this.lbl_ActiveStudents = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_InactiveStudentsCount = new System.Windows.Forms.Label();
            this.lbl_InactiveStudents = new System.Windows.Forms.Label();
            this.pB_InactiveStudents = new FontAwesome.Sharp.IconPictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_ClosCount = new System.Windows.Forms.Label();
            this.lbl_Clos = new System.Windows.Forms.Label();
            this.pB_Clos = new FontAwesome.Sharp.IconPictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_RubricsCount = new System.Windows.Forms.Label();
            this.lbl_Rubrics = new System.Windows.Forms.Label();
            this.pB_Rubrics = new FontAwesome.Sharp.IconPictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_AssessmentsCount = new System.Windows.Forms.Label();
            this.lbl_Assessments = new System.Windows.Forms.Label();
            this.pB_Assessments = new FontAwesome.Sharp.IconPictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_RubricLevelsCount = new System.Windows.Forms.Label();
            this.lbl_RubricLevels = new System.Windows.Forms.Label();
            this.pB_RubricLevels = new FontAwesome.Sharp.IconPictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_InactiveStudents)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Clos)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Rubrics)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Assessments)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_RubricLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 873);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(706, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 873);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(118, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 82);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(118, 770);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 103);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_ActiveStudentsCount);
            this.panel5.Controls.Add(this.lbl_ActiveStudents);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.Location = new System.Drawing.Point(124, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 160);
            this.panel5.TabIndex = 6;
            // 
            // lbl_ActiveStudentsCount
            // 
            this.lbl_ActiveStudentsCount.AutoSize = true;
            this.lbl_ActiveStudentsCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActiveStudentsCount.Location = new System.Drawing.Point(186, 60);
            this.lbl_ActiveStudentsCount.Name = "lbl_ActiveStudentsCount";
            this.lbl_ActiveStudentsCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_ActiveStudentsCount.TabIndex = 2;
            this.lbl_ActiveStudentsCount.Text = "0";
            // 
            // lbl_ActiveStudents
            // 
            this.lbl_ActiveStudents.AutoSize = true;
            this.lbl_ActiveStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActiveStudents.ForeColor = System.Drawing.Color.Green;
            this.lbl_ActiveStudents.Location = new System.Drawing.Point(5, 130);
            this.lbl_ActiveStudents.Name = "lbl_ActiveStudents";
            this.lbl_ActiveStudents.Size = new System.Drawing.Size(150, 25);
            this.lbl_ActiveStudents.TabIndex = 1;
            this.lbl_ActiveStudents.Text = "Active Students";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 160;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(160, 160);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_InactiveStudentsCount);
            this.panel7.Controls.Add(this.lbl_InactiveStudents);
            this.panel7.Controls.Add(this.pB_InactiveStudents);
            this.panel7.Location = new System.Drawing.Point(430, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 160);
            this.panel7.TabIndex = 9;
            // 
            // lbl_InactiveStudentsCount
            // 
            this.lbl_InactiveStudentsCount.AutoSize = true;
            this.lbl_InactiveStudentsCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InactiveStudentsCount.Location = new System.Drawing.Point(195, 49);
            this.lbl_InactiveStudentsCount.Name = "lbl_InactiveStudentsCount";
            this.lbl_InactiveStudentsCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_InactiveStudentsCount.TabIndex = 2;
            this.lbl_InactiveStudentsCount.Text = "0";
            // 
            // lbl_InactiveStudents
            // 
            this.lbl_InactiveStudents.AutoSize = true;
            this.lbl_InactiveStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InactiveStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lbl_InactiveStudents.Location = new System.Drawing.Point(5, 130);
            this.lbl_InactiveStudents.Name = "lbl_InactiveStudents";
            this.lbl_InactiveStudents.Size = new System.Drawing.Size(165, 25);
            this.lbl_InactiveStudents.TabIndex = 1;
            this.lbl_InactiveStudents.Text = "Inactive Students";
            // 
            // pB_InactiveStudents
            // 
            this.pB_InactiveStudents.BackColor = System.Drawing.SystemColors.Control;
            this.pB_InactiveStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pB_InactiveStudents.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.pB_InactiveStudents.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pB_InactiveStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pB_InactiveStudents.IconSize = 160;
            this.pB_InactiveStudents.Location = new System.Drawing.Point(0, 0);
            this.pB_InactiveStudents.Name = "pB_InactiveStudents";
            this.pB_InactiveStudents.Size = new System.Drawing.Size(160, 160);
            this.pB_InactiveStudents.TabIndex = 0;
            this.pB_InactiveStudents.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_ClosCount);
            this.panel8.Controls.Add(this.lbl_Clos);
            this.panel8.Controls.Add(this.pB_Clos);
            this.panel8.Location = new System.Drawing.Point(118, 280);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 160);
            this.panel8.TabIndex = 7;
            // 
            // lbl_ClosCount
            // 
            this.lbl_ClosCount.AutoSize = true;
            this.lbl_ClosCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosCount.Location = new System.Drawing.Point(192, 50);
            this.lbl_ClosCount.Name = "lbl_ClosCount";
            this.lbl_ClosCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_ClosCount.TabIndex = 2;
            this.lbl_ClosCount.Text = "0";
            // 
            // lbl_Clos
            // 
            this.lbl_Clos.AutoSize = true;
            this.lbl_Clos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clos.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Clos.Location = new System.Drawing.Point(39, 132);
            this.lbl_Clos.Name = "lbl_Clos";
            this.lbl_Clos.Size = new System.Drawing.Size(56, 25);
            this.lbl_Clos.TabIndex = 1;
            this.lbl_Clos.Text = "CLOs";
            // 
            // pB_Clos
            // 
            this.pB_Clos.BackColor = System.Drawing.SystemColors.Control;
            this.pB_Clos.ForeColor = System.Drawing.Color.Gold;
            this.pB_Clos.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.pB_Clos.IconColor = System.Drawing.Color.Gold;
            this.pB_Clos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pB_Clos.IconSize = 142;
            this.pB_Clos.Location = new System.Drawing.Point(0, 0);
            this.pB_Clos.Name = "pB_Clos";
            this.pB_Clos.Size = new System.Drawing.Size(155, 142);
            this.pB_Clos.TabIndex = 0;
            this.pB_Clos.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbl_RubricsCount);
            this.panel10.Controls.Add(this.lbl_Rubrics);
            this.panel10.Controls.Add(this.pB_Rubrics);
            this.panel10.Location = new System.Drawing.Point(430, 280);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(276, 160);
            this.panel10.TabIndex = 10;
            // 
            // lbl_RubricsCount
            // 
            this.lbl_RubricsCount.AutoSize = true;
            this.lbl_RubricsCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RubricsCount.Location = new System.Drawing.Point(195, 50);
            this.lbl_RubricsCount.Name = "lbl_RubricsCount";
            this.lbl_RubricsCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_RubricsCount.TabIndex = 2;
            this.lbl_RubricsCount.Text = "0";
            // 
            // lbl_Rubrics
            // 
            this.lbl_Rubrics.AutoSize = true;
            this.lbl_Rubrics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rubrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lbl_Rubrics.Location = new System.Drawing.Point(39, 132);
            this.lbl_Rubrics.Name = "lbl_Rubrics";
            this.lbl_Rubrics.Size = new System.Drawing.Size(78, 25);
            this.lbl_Rubrics.TabIndex = 1;
            this.lbl_Rubrics.Text = "Rubrics";
            // 
            // pB_Rubrics
            // 
            this.pB_Rubrics.BackColor = System.Drawing.SystemColors.Control;
            this.pB_Rubrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pB_Rubrics.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.pB_Rubrics.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pB_Rubrics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pB_Rubrics.IconSize = 160;
            this.pB_Rubrics.Location = new System.Drawing.Point(0, 0);
            this.pB_Rubrics.Name = "pB_Rubrics";
            this.pB_Rubrics.Size = new System.Drawing.Size(170, 160);
            this.pB_Rubrics.TabIndex = 0;
            this.pB_Rubrics.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_AssessmentsCount);
            this.panel9.Controls.Add(this.lbl_Assessments);
            this.panel9.Controls.Add(this.pB_Assessments);
            this.panel9.Location = new System.Drawing.Point(118, 468);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 160);
            this.panel9.TabIndex = 8;
            // 
            // lbl_AssessmentsCount
            // 
            this.lbl_AssessmentsCount.AutoSize = true;
            this.lbl_AssessmentsCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssessmentsCount.Location = new System.Drawing.Point(192, 60);
            this.lbl_AssessmentsCount.Name = "lbl_AssessmentsCount";
            this.lbl_AssessmentsCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_AssessmentsCount.TabIndex = 2;
            this.lbl_AssessmentsCount.Text = "0";
            // 
            // lbl_Assessments
            // 
            this.lbl_Assessments.AutoSize = true;
            this.lbl_Assessments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Assessments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lbl_Assessments.Location = new System.Drawing.Point(15, 132);
            this.lbl_Assessments.Name = "lbl_Assessments";
            this.lbl_Assessments.Size = new System.Drawing.Size(121, 25);
            this.lbl_Assessments.TabIndex = 1;
            this.lbl_Assessments.Text = "Assessments";
            // 
            // pB_Assessments
            // 
            this.pB_Assessments.BackColor = System.Drawing.SystemColors.Control;
            this.pB_Assessments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pB_Assessments.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.pB_Assessments.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pB_Assessments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pB_Assessments.IconSize = 152;
            this.pB_Assessments.Location = new System.Drawing.Point(3, 0);
            this.pB_Assessments.Name = "pB_Assessments";
            this.pB_Assessments.Size = new System.Drawing.Size(152, 160);
            this.pB_Assessments.TabIndex = 0;
            this.pB_Assessments.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl_RubricLevelsCount);
            this.panel11.Controls.Add(this.lbl_RubricLevels);
            this.panel11.Controls.Add(this.pB_RubricLevels);
            this.panel11.Location = new System.Drawing.Point(430, 468);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(276, 160);
            this.panel11.TabIndex = 11;
            // 
            // lbl_RubricLevelsCount
            // 
            this.lbl_RubricLevelsCount.AutoSize = true;
            this.lbl_RubricLevelsCount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RubricLevelsCount.Location = new System.Drawing.Point(195, 36);
            this.lbl_RubricLevelsCount.Name = "lbl_RubricLevelsCount";
            this.lbl_RubricLevelsCount.Size = new System.Drawing.Size(43, 50);
            this.lbl_RubricLevelsCount.TabIndex = 2;
            this.lbl_RubricLevelsCount.Text = "0";
            // 
            // lbl_RubricLevels
            // 
            this.lbl_RubricLevels.AutoSize = true;
            this.lbl_RubricLevels.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RubricLevels.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_RubricLevels.Location = new System.Drawing.Point(7, 132);
            this.lbl_RubricLevels.Name = "lbl_RubricLevels";
            this.lbl_RubricLevels.Size = new System.Drawing.Size(128, 25);
            this.lbl_RubricLevels.TabIndex = 1;
            this.lbl_RubricLevels.Text = "Rubric Levels";
            // 
            // pB_RubricLevels
            // 
            this.pB_RubricLevels.BackColor = System.Drawing.SystemColors.Control;
            this.pB_RubricLevels.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pB_RubricLevels.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.pB_RubricLevels.IconColor = System.Drawing.Color.DodgerBlue;
            this.pB_RubricLevels.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pB_RubricLevels.IconSize = 142;
            this.pB_RubricLevels.Location = new System.Drawing.Point(0, 0);
            this.pB_RubricLevels.Name = "pB_RubricLevels";
            this.pB_RubricLevels.Size = new System.Drawing.Size(155, 142);
            this.pB_RubricLevels.TabIndex = 0;
            this.pB_RubricLevels.TabStop = false;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 873);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.Text = "Dashboard";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_InactiveStudents)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Clos)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Rubrics)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Assessments)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_RubricLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_AssessmentsCount;
        private System.Windows.Forms.Label lbl_Assessments;
        private FontAwesome.Sharp.IconPictureBox pB_Assessments;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_ActiveStudentsCount;
        private System.Windows.Forms.Label lbl_ActiveStudents;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_InactiveStudentsCount;
        private System.Windows.Forms.Label lbl_InactiveStudents;
        private FontAwesome.Sharp.IconPictureBox pB_InactiveStudents;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_ClosCount;
        private System.Windows.Forms.Label lbl_Clos;
        private FontAwesome.Sharp.IconPictureBox pB_Clos;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_RubricsCount;
        private System.Windows.Forms.Label lbl_Rubrics;
        private FontAwesome.Sharp.IconPictureBox pB_Rubrics;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbl_RubricLevelsCount;
        private System.Windows.Forms.Label lbl_RubricLevels;
        private FontAwesome.Sharp.IconPictureBox pB_RubricLevels;
    }
}