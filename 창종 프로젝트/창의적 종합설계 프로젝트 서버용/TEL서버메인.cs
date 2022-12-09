using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 창의적_종합설계_프로젝트_서버용
{
    public partial class TEL서버메인 : Form
    {
        private int port = 9000;
        private WB_DataBase database = new WB_DataBase();
        List<Subject> Subjects = new List<Subject>();
        List<Customer> Customers = new List<Customer>();
        Control con = Control.Instance;

        public TEL서버메인()
        {
            InitializeComponent();
            database.Open();
            con.thisDataBase(database);// 데이터베이스 객체념겨줌
            con.thisForm(this);// 서버폼 객체 생성 
            TB_server.Text = "DB연결성공\r\n";
            PrintAll();


        }
        public void PrintAll()
        {

            PrintAll_Subject();
            PrintAll_Customer();
        }
        public void PrintAll_Subject()
        {
            //----------------------------------------------------------
            Subjects = database.SelectAll_Subject();

            LV_SUBJECT.Items.Clear();

            foreach (Subject subject in Subjects)
            {
                ListViewItem item = new ListViewItem(subject.SB_num.ToString());
                item.SubItems.Add(subject.SB_title);
                item.SubItems.Add(subject.SB_question1);
                item.SubItems.Add(subject.SB_question2);
                item.SubItems.Add(subject.SB_question3);
                item.SubItems.Add(subject.SB_question4);
                item.SubItems.Add(subject.SB_answer.ToString());
                LV_SUBJECT.Items.Add(item);
            }
        }
        public void PrintAll_Customer()
        {
            //----------------------------------------------------------
            Customers = database.SelectAll_Customer();
      


            LV_CUTOM.Items.Clear();

            foreach (Customer customer in Customers)
            {
                ListViewItem item = new ListViewItem(customer.CID.ToString());
                item.SubItems.Add(customer.아이디);
                item.SubItems.Add(customer.비밀번호);
                LV_CUTOM.Items.Add(item);
            }
        }



        #region 버튼 클릭
        private void BTN_ON_Click(object sender, EventArgs e)
        {
            try
            {

                BTN_OFF.Enabled = true;
                BTN_ON.Enabled = false;
                con.ServerStart(port);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void BTN_OFF_Click(object sender, EventArgs e)
        {
         
            con.ServerStop();
            BTN_OFF.Enabled = false;
            BTN_ON.Enabled = true;

        }
        #endregion

        #region 메뉴바 클릭
        private void 연결끊기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_server.Text += "DB연결끊기\r\n";
            database.Close();
            연결끊기ToolStripMenuItem.Enabled = false;
            dB연결ToolStripMenuItem.Enabled = true;
        }
        private void dB연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_server.Text += "DB연결연결\r\n";
            database.Open();
            con.thisDataBase(database);// 데이터베이스 객체념겨줌
            dB연결ToolStripMenuItem.Enabled = false;
            연결끊기ToolStripMenuItem.Enabled = true;
        }
        private void 고객수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TEL고객DB 고객DB = new TEL고객DB();
            고객DB.database = database;
            고객DB.ShowDialog();
            this.Show();
            PrintAll_Customer();
        }

        private void 문제수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TEL문제 문제DB = new TEL문제();
            문제DB.database = database;
            문제DB.ShowDialog();
            this.Show();
            PrintAll_Subject();
        }
        #endregion


        private void LV_SUBJECT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_SUBJECT.FocusedItem.Index >= 0)
            {
                int index = LV_SUBJECT.FocusedItem.Index;
                LB_문제내역.Text = Subjects[index].SB_title;
                LB_1번.Text = Subjects[index].SB_question1;
                LB_2번.Text = Subjects[index].SB_question2;
                LB_3번.Text = Subjects[index].SB_question3;
                LB_4번.Text = Subjects[index].SB_question4;
                LB_답.Text = Subjects[index].SB_answer.ToString();
            }
        }



        //서버 단에서 해야할 일 값을 받으면 select혹은 update 수행 삭제같은경우 1000번째 아이디만 해당
        //두번째로 수정작업이 이뤄지고나서 업데이트 작업이 자동으로 이루어 져야함
        // 패킷의 종류 1.고객 등록, 2. 고객정의


        #region 로그 &메시지 출력
        public void LogPrint(string msg)
        {
            DateTime dt = DateTime.Now;
            string temp = string.Format("[{0}] ({1}:{2}):{3})\r\n", msg, dt.Hour, dt.Minute, dt.Second);
            TB_server.AppendText(temp);
        }
        public void MsgPrint(string nickname, string msg)
        {
            DateTime dt = DateTime.Now;
            string temp = string.Format("[{0}] {1} ({2}:{3}):{4})\r\n",
                nickname, msg, dt.Hour, dt.Minute, dt.Second);
            TB_server.AppendText(temp);
        }
        public void TestPrint(string[] packmsgs)
        {
            DateTime dt = DateTime.Now;
            string msg=null;
            foreach (string packmsg in packmsgs)
            {
                msg +=string.Format(" {0} ",packmsg);
            }
            string temp = string.Format(" {0} ({1}:{2}):{3})\r\n",
               msg, dt.Hour, dt.Minute, dt.Second);
            TB_server.AppendText(temp);
        }
        #endregion


    }
}
