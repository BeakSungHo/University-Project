using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 창의적_종합설계_프로젝트_서버용
{
    public partial class TEL문제 : Form
    {
        public List<Subject> Subjects = new List<Subject>();
        public WB_DataBase database = new WB_DataBase();
        public TEL문제()
        {
            InitializeComponent();
        }
        public void PrintAll_Subject()
        {
            Subjects = database.SelectAll_Subject();

            LV_Subject.Items.Clear();
            foreach (Subject subject in Subjects)
            {
                ListViewItem item = new ListViewItem(subject.SB_num.ToString());
                item.SubItems.Add(subject.SB_title);
                item.SubItems.Add(subject.SB_question1);
                item.SubItems.Add(subject.SB_question2);
                item.SubItems.Add(subject.SB_question3);
                item.SubItems.Add(subject.SB_question4);
                item.SubItems.Add(subject.SB_answer.ToString());
                LV_Subject.Items.Add(item);
            }
        }
        private void TEL문제_Load(object sender, EventArgs e)
        {
            try
            {
                PrintAll_Subject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 나가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            database.Insert_Subject(tb_SubjecTitle.Text,
                tb_SubjectQuestion1.Text,
                tb_SubjectQuestion2.Text,
                tb_SubjectQuestion3.Text,
                tb_SubjectQuestion4.Text,
                int.Parse(tb_SubjectAnswer.Text));
            PrintAll_Subject();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            database.Delete_Subject(int.Parse(tb_SubjectID.Text));
            PrintAll_Subject();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            database.Update_Subject(int.Parse(tb_SubjectID.Text),
                tb_SubjecTitle.Text, 
                tb_SubjectQuestion1.Text,
                tb_SubjectQuestion2.Text,
                tb_SubjectQuestion3.Text,
                tb_SubjectQuestion4.Text,
                int.Parse(tb_SubjectAnswer.Text));
            PrintAll_Subject();
        }

        private void LV_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Subject.FocusedItem.Index >= 0)
            {
                int index = LV_Subject.FocusedItem.Index;
                tb_SubjectID.Text = Subjects[index].SB_num.ToString();
                tb_SubjecTitle.Text = Subjects[index].SB_title;
                tb_SubjectQuestion1.Text = Subjects[index].SB_question1;
                tb_SubjectQuestion2.Text = Subjects[index].SB_question2;
                tb_SubjectQuestion3.Text = Subjects[index].SB_question3;
                tb_SubjectQuestion4.Text = Subjects[index].SB_question4;
                tb_SubjectAnswer.Text = Subjects[index].SB_answer.ToString();
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
            else
            {
                tb_SubjectID.Text = " ";
                tb_SubjecTitle.Text = " ";
                tb_SubjectQuestion1.Text = " ";
                tb_SubjectQuestion2.Text = " ";
                tb_SubjectQuestion3.Text = " ";
                tb_SubjectQuestion4.Text = " ";
                tb_SubjectAnswer.Text = " ";
                btn_delete.Enabled = false;
                btn_update.Enabled = false;

            }
        }
    }
}
