namespace 창의적_종합설계_프로젝트_서버용
{
    partial class TEL고객DB
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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_비밀번호 = new System.Windows.Forms.TextBox();
            this.TB_아이디 = new System.Windows.Forms.TextBox();
            this.LV_CUTOM = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PASSWORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(226, 153);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(87, 53);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "삽입";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(121, 287);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 53);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(214, 287);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 53);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_비밀번호);
            this.groupBox1.Controls.Add(this.TB_CID);
            this.groupBox1.Controls.Add(this.TB_아이디);
            this.groupBox1.Controls.Add(this.LV_CUTOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "고객 정보 수정";
            // 
            // TB_비밀번호
            // 
            this.TB_비밀번호.Location = new System.Drawing.Point(86, 122);
            this.TB_비밀번호.Name = "TB_비밀번호";
            this.TB_비밀번호.Size = new System.Drawing.Size(227, 25);
            this.TB_비밀번호.TabIndex = 3;
            // 
            // TB_아이디
            // 
            this.TB_아이디.Location = new System.Drawing.Point(86, 71);
            this.TB_아이디.Name = "TB_아이디";
            this.TB_아이디.Size = new System.Drawing.Size(227, 25);
            this.TB_아이디.TabIndex = 3;
            // 
            // LV_CUTOM
            // 
            this.LV_CUTOM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.NAME,
            this.PASSWORD});
            this.LV_CUTOM.FullRowSelect = true;
            this.LV_CUTOM.HideSelection = false;
            this.LV_CUTOM.Location = new System.Drawing.Point(358, 35);
            this.LV_CUTOM.Name = "LV_CUTOM";
            this.LV_CUTOM.Size = new System.Drawing.Size(355, 324);
            this.LV_CUTOM.TabIndex = 2;
            this.LV_CUTOM.UseCompatibleStateImageBehavior = false;
            this.LV_CUTOM.View = System.Windows.Forms.View.Details;
            this.LV_CUTOM.SelectedIndexChanged += new System.EventHandler(this.LV_CUTOM_SelectedIndexChanged);
            // 
            // CID
            // 
            this.CID.Text = "CID";
            this.CID.Width = 91;
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            this.NAME.Width = 129;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Text = "PASSWORD";
            this.PASSWORD.Width = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "CID";
            // 
            // TB_CID
            // 
            this.TB_CID.Enabled = false;
            this.TB_CID.Location = new System.Drawing.Point(86, 236);
            this.TB_CID.Name = "TB_CID";
            this.TB_CID.Size = new System.Drawing.Size(227, 25);
            this.TB_CID.TabIndex = 3;
            // 
            // TEL고객DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "TEL고객DB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TEL고객DB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_아이디;
        private System.Windows.Forms.ListView LV_CUTOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_비밀번호;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader PASSWORD;
        private System.Windows.Forms.TextBox TB_CID;
        private System.Windows.Forms.Label label3;
    }
}