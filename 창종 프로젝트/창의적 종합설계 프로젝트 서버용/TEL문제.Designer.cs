namespace 창의적_종합설계_프로젝트_서버용
{
    partial class TEL문제
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
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변경된사항저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.나가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LV_Subject = new System.Windows.Forms.ListView();
            this.SUBJECTI_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_TITLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_QUESTION1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_QUESTION2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_QUESTION3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_QUESTION4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT_ANSWER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tb_SubjectAnswer = new System.Windows.Forms.TextBox();
            this.tb_SubjectID = new System.Windows.Forms.TextBox();
            this.tb_SubjectQuestion4 = new System.Windows.Forms.TextBox();
            this.tb_SubjectQuestion3 = new System.Windows.Forms.TextBox();
            this.tb_SubjectQuestion2 = new System.Windows.Forms.TextBox();
            this.tb_SubjecTitle = new System.Windows.Forms.TextBox();
            this.tb_SubjectQuestion1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.나가기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.변경된사항저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 변경된사항저장ToolStripMenuItem
            // 
            this.변경된사항저장ToolStripMenuItem.Name = "변경된사항저장ToolStripMenuItem";
            this.변경된사항저장ToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.변경된사항저장ToolStripMenuItem.Text = "변경된사항 저장 (&S)";
            // 
            // 나가기ToolStripMenuItem
            // 
            this.나가기ToolStripMenuItem.Name = "나가기ToolStripMenuItem";
            this.나가기ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.나가기ToolStripMenuItem.Text = "나가기";
            this.나가기ToolStripMenuItem.Click += new System.EventHandler(this.나가기ToolStripMenuItem_Click);
            // 
            // LV_Subject
            // 
            this.LV_Subject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SUBJECTI_ID,
            this.SUBJECT_TITLE,
            this.SUBJECT_QUESTION1,
            this.SUBJECT_QUESTION2,
            this.SUBJECT_QUESTION3,
            this.SUBJECT_QUESTION4,
            this.SUBJECT_ANSWER});
            this.LV_Subject.FullRowSelect = true;
            this.LV_Subject.HideSelection = false;
            this.LV_Subject.Location = new System.Drawing.Point(19, 22);
            this.LV_Subject.Name = "LV_Subject";
            this.LV_Subject.Size = new System.Drawing.Size(1295, 323);
            this.LV_Subject.TabIndex = 3;
            this.LV_Subject.UseCompatibleStateImageBehavior = false;
            this.LV_Subject.View = System.Windows.Forms.View.Details;
            this.LV_Subject.SelectedIndexChanged += new System.EventHandler(this.LV_Subject_SelectedIndexChanged);
            // 
            // SUBJECTI_ID
            // 
            this.SUBJECTI_ID.Text = "SUBJECTI_ID";
            this.SUBJECTI_ID.Width = 116;
            // 
            // SUBJECT_TITLE
            // 
            this.SUBJECT_TITLE.Text = "SUBJECT_TITLE";
            this.SUBJECT_TITLE.Width = 129;
            // 
            // SUBJECT_QUESTION1
            // 
            this.SUBJECT_QUESTION1.Text = "SUBJECT_QUESTION1";
            this.SUBJECT_QUESTION1.Width = 172;
            // 
            // SUBJECT_QUESTION2
            // 
            this.SUBJECT_QUESTION2.Text = "SUBJECT_QUESTION2";
            this.SUBJECT_QUESTION2.Width = 174;
            // 
            // SUBJECT_QUESTION3
            // 
            this.SUBJECT_QUESTION3.Text = "SUBJECT_QUESTION3";
            this.SUBJECT_QUESTION3.Width = 179;
            // 
            // SUBJECT_QUESTION4
            // 
            this.SUBJECT_QUESTION4.Text = "SUBJECT_QUESTION4";
            this.SUBJECT_QUESTION4.Width = 172;
            // 
            // SUBJECT_ANSWER
            // 
            this.SUBJECT_ANSWER.Text = "SUBJECT_ANSWER";
            this.SUBJECT_ANSWER.Width = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SB_ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "1번 문제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "2번 문제";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "3번 문제";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "4번 문제";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "정답 :";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1554, 863);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ㄴ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LV_Subject);
            this.groupBox3.Location = new System.Drawing.Point(77, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1352, 364);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "문제 로그";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_insert);
            this.groupBox2.Controls.Add(this.tb_SubjectAnswer);
            this.groupBox2.Controls.Add(this.tb_SubjectID);
            this.groupBox2.Controls.Add(this.tb_SubjectQuestion4);
            this.groupBox2.Controls.Add(this.tb_SubjectQuestion3);
            this.groupBox2.Controls.Add(this.tb_SubjectQuestion2);
            this.groupBox2.Controls.Add(this.tb_SubjecTitle);
            this.groupBox2.Controls.Add(this.tb_SubjectQuestion1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(75, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1354, 470);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "문제뷰 클릭하면 선택가능";
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(100, 217);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 40);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(100, 175);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 40);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(100, 134);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 40);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "삽입";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_SubjectAnswer
            // 
            this.tb_SubjectAnswer.Location = new System.Drawing.Point(128, 81);
            this.tb_SubjectAnswer.Name = "tb_SubjectAnswer";
            this.tb_SubjectAnswer.Size = new System.Drawing.Size(92, 25);
            this.tb_SubjectAnswer.TabIndex = 6;
            // 
            // tb_SubjectID
            // 
            this.tb_SubjectID.Enabled = false;
            this.tb_SubjectID.Location = new System.Drawing.Point(128, 38);
            this.tb_SubjectID.Name = "tb_SubjectID";
            this.tb_SubjectID.Size = new System.Drawing.Size(92, 25);
            this.tb_SubjectID.TabIndex = 6;
            // 
            // tb_SubjectQuestion4
            // 
            this.tb_SubjectQuestion4.Location = new System.Drawing.Point(364, 339);
            this.tb_SubjectQuestion4.Multiline = true;
            this.tb_SubjectQuestion4.Name = "tb_SubjectQuestion4";
            this.tb_SubjectQuestion4.Size = new System.Drawing.Size(952, 62);
            this.tb_SubjectQuestion4.TabIndex = 5;
            // 
            // tb_SubjectQuestion3
            // 
            this.tb_SubjectQuestion3.Location = new System.Drawing.Point(364, 267);
            this.tb_SubjectQuestion3.Multiline = true;
            this.tb_SubjectQuestion3.Name = "tb_SubjectQuestion3";
            this.tb_SubjectQuestion3.Size = new System.Drawing.Size(952, 62);
            this.tb_SubjectQuestion3.TabIndex = 5;
            // 
            // tb_SubjectQuestion2
            // 
            this.tb_SubjectQuestion2.Location = new System.Drawing.Point(364, 196);
            this.tb_SubjectQuestion2.Multiline = true;
            this.tb_SubjectQuestion2.Name = "tb_SubjectQuestion2";
            this.tb_SubjectQuestion2.Size = new System.Drawing.Size(952, 62);
            this.tb_SubjectQuestion2.TabIndex = 5;
            // 
            // tb_SubjecTitle
            // 
            this.tb_SubjecTitle.Location = new System.Drawing.Point(364, 44);
            this.tb_SubjecTitle.Multiline = true;
            this.tb_SubjecTitle.Name = "tb_SubjecTitle";
            this.tb_SubjecTitle.Size = new System.Drawing.Size(952, 62);
            this.tb_SubjecTitle.TabIndex = 5;
            // 
            // tb_SubjectQuestion1
            // 
            this.tb_SubjectQuestion1.Location = new System.Drawing.Point(364, 123);
            this.tb_SubjectQuestion1.Multiline = true;
            this.tb_SubjectQuestion1.Name = "tb_SubjectQuestion1";
            this.tb_SubjectQuestion1.Size = new System.Drawing.Size(952, 62);
            this.tb_SubjectQuestion1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "문제 제목 :";
            // 
            // TEL문제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 863);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TEL문제";
            this.Text = "TEL문제";
            this.Load += new System.EventHandler(this.TEL문제_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경된사항저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 나가기ToolStripMenuItem;
        private System.Windows.Forms.ListView LV_Subject;
        private System.Windows.Forms.ColumnHeader SUBJECTI_ID;
        private System.Windows.Forms.ColumnHeader SUBJECT_TITLE;
        private System.Windows.Forms.ColumnHeader SUBJECT_QUESTION1;
        private System.Windows.Forms.ColumnHeader SUBJECT_QUESTION2;
        private System.Windows.Forms.ColumnHeader SUBJECT_QUESTION3;
        private System.Windows.Forms.ColumnHeader SUBJECT_QUESTION4;
        private System.Windows.Forms.ColumnHeader SUBJECT_ANSWER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_SubjectAnswer;
        private System.Windows.Forms.TextBox tb_SubjectID;
        private System.Windows.Forms.TextBox tb_SubjectQuestion4;
        private System.Windows.Forms.TextBox tb_SubjectQuestion3;
        private System.Windows.Forms.TextBox tb_SubjectQuestion2;
        private System.Windows.Forms.TextBox tb_SubjectQuestion1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tb_SubjecTitle;
        private System.Windows.Forms.Label label6;
    }
}