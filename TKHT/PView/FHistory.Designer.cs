namespace TKHT.PView
{
    partial class FHistory
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.AttemptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DienthoaiSV = new System.Windows.Forms.Label();
            this.tbLoai = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.KhoaSV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.NameSV = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.timKiemHVBTN = new System.Windows.Forms.Button();
            this.lietkehvBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 15, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1761, 46);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.managerToolStripMenuItem.Text = "Home";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 29);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttemptID,
            this.Name,
            this.Date,
            this.Type,
            this.Subject});
            this.dgvHistory.Location = new System.Drawing.Point(32, 184);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.Size = new System.Drawing.Size(1130, 705);
            this.dgvHistory.TabIndex = 115;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);
            this.dgvHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellDoubleClick);
            // 
            // AttemptID
            // 
            this.AttemptID.DataPropertyName = "AttemptId";
            this.AttemptID.HeaderText = "Attempt ID";
            this.AttemptID.MinimumWidth = 8;
            this.AttemptID.Name = "AttemptID";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 8;
            this.Subject.Name = "Subject";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DienthoaiSV);
            this.panel4.Controls.Add(this.tbLoai);
            this.panel4.Location = new System.Drawing.Point(1187, 430);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 48);
            this.panel4.TabIndex = 111;
            // 
            // DienthoaiSV
            // 
            this.DienthoaiSV.AutoSize = true;
            this.DienthoaiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienthoaiSV.ForeColor = System.Drawing.Color.White;
            this.DienthoaiSV.Location = new System.Drawing.Point(30, 15);
            this.DienthoaiSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DienthoaiSV.Name = "DienthoaiSV";
            this.DienthoaiSV.Size = new System.Drawing.Size(53, 25);
            this.DienthoaiSV.TabIndex = 23;
            this.DienthoaiSV.Text = "Loại";
            // 
            // tbLoai
            // 
            this.tbLoai.Location = new System.Drawing.Point(199, 2);
            this.tbLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLoai.Name = "tbLoai";
            this.tbLoai.Size = new System.Drawing.Size(262, 26);
            this.tbLoai.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbSubject);
            this.panel3.Controls.Add(this.KhoaSV);
            this.panel3.Location = new System.Drawing.Point(1187, 296);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 48);
            this.panel3.TabIndex = 109;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(198, 6);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(262, 26);
            this.tbSubject.TabIndex = 8;
            // 
            // KhoaSV
            // 
            this.KhoaSV.AutoSize = true;
            this.KhoaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaSV.ForeColor = System.Drawing.Color.White;
            this.KhoaSV.Location = new System.Drawing.Point(30, 11);
            this.KhoaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KhoaSV.Name = "KhoaSV";
            this.KhoaSV.Size = new System.Drawing.Size(95, 25);
            this.KhoaSV.TabIndex = 21;
            this.KhoaSV.Text = "Môn học";
            this.KhoaSV.Click += new System.EventHandler(this.KhoaSV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dpDate);
            this.panel2.Controls.Add(this.NameSV);
            this.panel2.Location = new System.Drawing.Point(1187, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 48);
            this.panel2.TabIndex = 110;
            // 
            // dpDate
            // 
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate.Location = new System.Drawing.Point(198, 5);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(264, 26);
            this.dpDate.TabIndex = 9;
            // 
            // NameSV
            // 
            this.NameSV.AutoSize = true;
            this.NameSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSV.ForeColor = System.Drawing.Color.White;
            this.NameSV.Location = new System.Drawing.Point(30, 11);
            this.NameSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameSV.Name = "NameSV";
            this.NameSV.Size = new System.Drawing.Size(137, 25);
            this.NameSV.TabIndex = 22;
            this.NameSV.Text = "Ngày làm bài";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(1187, 184);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(471, 26);
            this.tbFind.TabIndex = 106;
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // timKiemHVBTN
            // 
            this.timKiemHVBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.timKiemHVBTN.ForeColor = System.Drawing.Color.White;
            this.timKiemHVBTN.Location = new System.Drawing.Point(1187, 234);
            this.timKiemHVBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timKiemHVBTN.Name = "timKiemHVBTN";
            this.timKiemHVBTN.Size = new System.Drawing.Size(230, 54);
            this.timKiemHVBTN.TabIndex = 107;
            this.timKiemHVBTN.Text = "Tìm kiếm";
            this.timKiemHVBTN.UseVisualStyleBackColor = false;
            this.timKiemHVBTN.Click += new System.EventHandler(this.timKiemHVBTN_Click);
            // 
            // lietkehvBTN
            // 
            this.lietkehvBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lietkehvBTN.ForeColor = System.Drawing.Color.White;
            this.lietkehvBTN.Location = new System.Drawing.Point(32, 92);
            this.lietkehvBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lietkehvBTN.Name = "lietkehvBTN";
            this.lietkehvBTN.Size = new System.Drawing.Size(145, 54);
            this.lietkehvBTN.TabIndex = 105;
            this.lietkehvBTN.Text = "Sắp xếp giảm dần";
            this.lietkehvBTN.UseVisualStyleBackColor = false;
            this.lietkehvBTN.Click += new System.EventHandler(this.lietkehvBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TKHT.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1607, 780);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(230, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 54);
            this.button1.TabIndex = 117;
            this.button1.Text = "Sắp xếp tăng dần";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1761, 934);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.timKiemHVBTN);
            this.Controls.Add(this.lietkehvBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "FHistory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DienthoaiSV;
        private System.Windows.Forms.TextBox tbLoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label KhoaSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label NameSV;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button timKiemHVBTN;
        private System.Windows.Forms.Button lietkehvBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttemptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Button button1;
    }
}