namespace 창의적_종합설계_프로젝트_서버용
{
    partial class TEL서버메인
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LV_CUTOM = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_SUBJECT = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_1번 = new System.Windows.Forms.Label();
            this.LB_2번 = new System.Windows.Forms.Label();
            this.LB_3번 = new System.Windows.Forms.Label();
            this.LB_4번 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_답 = new System.Windows.Forms.Label();
            this.LB_문제내역 = new System.Windows.Forms.Label();
            this.BTN_ON = new System.Windows.Forms.Button();
            this.BTN_OFF = new System.Windows.Forms.Button();
            this.TB_server = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.데이터베이스다시연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연결끊기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터베이스수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.문제수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_CUTOM
            // 
            this.LV_CUTOM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LV_CUTOM.HideSelection = false;
            this.LV_CUTOM.Location = new System.Drawing.Point(548, 21);
            this.LV_CUTOM.Name = "LV_CUTOM";
            this.LV_CUTOM.Size = new System.Drawing.Size(304, 406);
            this.LV_CUTOM.TabIndex = 0;
            this.LV_CUTOM.UseCompatibleStateImageBehavior = false;
            this.LV_CUTOM.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "CID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "아이디";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "비밀번호";
            this.columnHeader3.Width = 120;
            // 
            // LV_SUBJECT
            // 
            this.LV_SUBJECT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.LV_SUBJECT.FullRowSelect = true;
            this.LV_SUBJECT.HideSelection = false;
            this.LV_SUBJECT.Location = new System.Drawing.Point(858, 22);
            this.LV_SUBJECT.Name = "LV_SUBJECT";
            this.LV_SUBJECT.Size = new System.Drawing.Size(590, 406);
            this.LV_SUBJECT.TabIndex = 0;
            this.LV_SUBJECT.UseCompatibleStateImageBehavior = false;
            this.LV_SUBJECT.View = System.Windows.Forms.View.Details;
            this.LV_SUBJECT.SelectedIndexChanged += new System.EventHandler(this.LV_SUBJECT_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SB_NUM";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SB_TITLE";
            this.columnHeader5.Width = 340;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SB_QUESTION1";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SB_QUESTION2";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SB_QUESTION3";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SB_QUESTION4";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SB_ASWER";
            this.columnHeader10.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "답 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "1번 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "2번 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "3번 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "4번 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "문제 :";
            // 
            // LB_1번
            // 
            this.LB_1번.Location = new System.Drawing.Point(92, 106);
            this.LB_1번.Name = "LB_1번";
            this.LB_1번.Size = new System.Drawing.Size(782, 65);
            this.LB_1번.TabIndex = 1;
            this.LB_1번.Text = "내용";
            // 
            // LB_2번
            // 
            this.LB_2번.Location = new System.Drawing.Point(92, 186);
            this.LB_2번.Name = "LB_2번";
            this.LB_2번.Size = new System.Drawing.Size(782, 66);
            this.LB_2번.TabIndex = 1;
            this.LB_2번.Text = "내용";
            // 
            // LB_3번
            // 
            this.LB_3번.Location = new System.Drawing.Point(93, 263);
            this.LB_3번.Name = "LB_3번";
            this.LB_3번.Size = new System.Drawing.Size(782, 70);
            this.LB_3번.TabIndex = 1;
            this.LB_3번.Text = "내용";
            // 
            // LB_4번
            // 
            this.LB_4번.Location = new System.Drawing.Point(93, 347);
            this.LB_4번.Name = "LB_4번";
            this.LB_4번.Size = new System.Drawing.Size(782, 94);
            this.LB_4번.TabIndex = 1;
            this.LB_4번.Text = "내용";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_4번);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LB_3번);
            this.groupBox1.Controls.Add(this.LB_답);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LB_2번);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LB_문제내역);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LB_1번);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(564, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문제 뷰 클릭하면 확인가능";
            // 
            // LB_답
            // 
            this.LB_답.AutoSize = true;
            this.LB_답.Location = new System.Drawing.Point(67, 65);
            this.LB_답.Name = "LB_답";
            this.LB_답.Size = new System.Drawing.Size(22, 15);
            this.LB_답.TabIndex = 1;
            this.LB_답.Text = "답";
            // 
            // LB_문제내역
            // 
            this.LB_문제내역.Location = new System.Drawing.Point(92, 30);
            this.LB_문제내역.Name = "LB_문제내역";
            this.LB_문제내역.Size = new System.Drawing.Size(792, 65);
            this.LB_문제내역.TabIndex = 1;
            this.LB_문제내역.Text = "문제내역 ";
            // 
            // BTN_ON
            // 
            this.BTN_ON.Location = new System.Drawing.Point(50, 24);
            this.BTN_ON.Name = "BTN_ON";
            this.BTN_ON.Size = new System.Drawing.Size(166, 86);
            this.BTN_ON.TabIndex = 1;
            this.BTN_ON.Text = "서버 켜기";
            this.BTN_ON.UseVisualStyleBackColor = true;
            this.BTN_ON.Click += new System.EventHandler(this.BTN_ON_Click);
            // 
            // BTN_OFF
            // 
            this.BTN_OFF.Enabled = false;
            this.BTN_OFF.Location = new System.Drawing.Point(268, 24);
            this.BTN_OFF.Name = "BTN_OFF";
            this.BTN_OFF.Size = new System.Drawing.Size(166, 86);
            this.BTN_OFF.TabIndex = 1;
            this.BTN_OFF.Text = "서버끄기";
            this.BTN_OFF.UseVisualStyleBackColor = true;
            this.BTN_OFF.Click += new System.EventHandler(this.BTN_OFF_Click);
            // 
            // TB_server
            // 
            this.TB_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_server.Location = new System.Drawing.Point(15, 122);
            this.TB_server.Multiline = true;
            this.TB_server.Name = "TB_server";
            this.TB_server.ReadOnly = true;
            this.TB_server.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_server.Size = new System.Drawing.Size(484, 461);
            this.TB_server.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_server);
            this.groupBox2.Controls.Add(this.BTN_OFF);
            this.groupBox2.Controls.Add(this.BTN_ON);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 593);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서버 관련 ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.데이터베이스다시연결ToolStripMenuItem,
            this.데이터베이스수정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 데이터베이스다시연결ToolStripMenuItem
            // 
            this.데이터베이스다시연결ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.연결끊기ToolStripMenuItem,
            this.dB연결ToolStripMenuItem});
            this.데이터베이스다시연결ToolStripMenuItem.Name = "데이터베이스다시연결ToolStripMenuItem";
            this.데이터베이스다시연결ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.데이터베이스다시연결ToolStripMenuItem.Text = "데이터베이스 연결";
            // 
            // 연결끊기ToolStripMenuItem
            // 
            this.연결끊기ToolStripMenuItem.Name = "연결끊기ToolStripMenuItem";
            this.연결끊기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.연결끊기ToolStripMenuItem.Text = "연결끊기";
            this.연결끊기ToolStripMenuItem.Click += new System.EventHandler(this.연결끊기ToolStripMenuItem_Click);
            // 
            // dB연결ToolStripMenuItem
            // 
            this.dB연결ToolStripMenuItem.Enabled = false;
            this.dB연결ToolStripMenuItem.Name = "dB연결ToolStripMenuItem";
            this.dB연결ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dB연결ToolStripMenuItem.Text = "DB 연결";
            this.dB연결ToolStripMenuItem.Click += new System.EventHandler(this.dB연결ToolStripMenuItem_Click);
            // 
            // 데이터베이스수정ToolStripMenuItem
            // 
            this.데이터베이스수정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객수정ToolStripMenuItem,
            this.문제수정ToolStripMenuItem});
            this.데이터베이스수정ToolStripMenuItem.Name = "데이터베이스수정ToolStripMenuItem";
            this.데이터베이스수정ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.데이터베이스수정ToolStripMenuItem.Text = "데이터베이스 수정";
            // 
            // 고객수정ToolStripMenuItem
            // 
            this.고객수정ToolStripMenuItem.Name = "고객수정ToolStripMenuItem";
            this.고객수정ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.고객수정ToolStripMenuItem.Text = "고객 수정";
            this.고객수정ToolStripMenuItem.Click += new System.EventHandler(this.고객수정ToolStripMenuItem_Click);
            // 
            // 문제수정ToolStripMenuItem
            // 
            this.문제수정ToolStripMenuItem.Name = "문제수정ToolStripMenuItem";
            this.문제수정ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.문제수정ToolStripMenuItem.Text = "문제 수정";
            this.문제수정ToolStripMenuItem.Click += new System.EventHandler(this.문제수정ToolStripMenuItem_Click);
            // 
            // TEL서버메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV_SUBJECT);
            this.Controls.Add(this.LV_CUTOM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TEL서버메인";
            this.Text = "TELL 서버 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_CUTOM;
        private System.Windows.Forms.ListView LV_SUBJECT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_1번;
        private System.Windows.Forms.Label LB_2번;
        private System.Windows.Forms.Label LB_3번;
        private System.Windows.Forms.Label LB_4번;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_문제내역;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label LB_답;
        private System.Windows.Forms.Button BTN_ON;
        private System.Windows.Forms.Button BTN_OFF;
        private System.Windows.Forms.TextBox TB_server;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 데이터베이스다시연결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터베이스수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 문제수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연결끊기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dB연결ToolStripMenuItem;
    }
}

