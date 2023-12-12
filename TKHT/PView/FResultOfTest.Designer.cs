namespace TKHT.PView
{
    partial class FResultOfTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.diemkq = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dgvAttemptQestion = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttemptQestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // diemkq
            // 
            this.diemkq.AutoSize = true;
            this.diemkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemkq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diemkq.Location = new System.Drawing.Point(603, 56);
            this.diemkq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diemkq.Name = "diemkq";
            this.diemkq.Size = new System.Drawing.Size(66, 24);
            this.diemkq.TabIndex = 2;
            this.diemkq.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(9, 86);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 24);
            this.name.TabIndex = 5;
            this.name.Text = "label4";
            // 
            // dgvAttemptQestion
            // 
            this.dgvAttemptQestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttemptQestion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.dgvAttemptQestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttemptQestion.ColumnHeadersHeight = 34;
            this.dgvAttemptQestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ChapterName,
            this.Question,
            this.Answer});
            this.dgvAttemptQestion.Location = new System.Drawing.Point(9, 142);
            this.dgvAttemptQestion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAttemptQestion.Name = "dgvAttemptQestion";
            this.dgvAttemptQestion.RowHeadersWidth = 62;
            this.dgvAttemptQestion.RowTemplate.Height = 28;
            this.dgvAttemptQestion.Size = new System.Drawing.Size(1035, 764);
            this.dgvAttemptQestion.TabIndex = 0;
            this.dgvAttemptQestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttemptQestion_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "AttemptId";
            this.id.HeaderText = "AttemptId";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // ChapterName
            // 
            this.ChapterName.DataPropertyName = "ChapterName";
            this.ChapterName.HeaderText = "ChapterName";
            this.ChapterName.MinimumWidth = 8;
            this.ChapterName.Name = "ChapterName";
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "Question";
            this.Question.MinimumWidth = 8;
            this.Question.Name = "Question";
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Answer";
            this.Answer.MinimumWidth = 8;
            this.Answer.Name = "Answer";
            // 
            // FResultOfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1053, 690);
            this.Controls.Add(this.name);
            this.Controls.Add(this.diemkq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAttemptQestion);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FResultOfTest";
            this.Text = "FResultOfTest";
            this.Load += new System.EventHandler(this.FResultOfTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttemptQestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label diemkq;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dgvAttemptQestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}