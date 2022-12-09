using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 창의적_종합설계_프로젝트_서버용
{
    public partial class TEL고객DB : Form
    {
        public List<Customer> Customers =new List<Customer>();
        public WB_DataBase database;
        public TEL고객DB()
        {
            InitializeComponent();
            

        }



        public void PrintAll_Customer()
        {
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            database.Update_Customer(int.Parse(TB_CID.Text),TB_아이디.Text,TB_비밀번호.Text);
            PrintAll_Customer();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (int.Parse(TB_CID.Text) != 1)
            {
                database.Delete_Customer(int.Parse(TB_CID.Text));
                PrintAll_Customer();
            }
            else MessageBox.Show("관리자는 삭제할수 없습니다.", "알람");
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
           database.Insert_Customer(TB_아이디.Text, TB_비밀번호.Text);
            PrintAll_Customer();
        }

        private void TEL고객DB_Load(object sender, EventArgs e)
        {
            PrintAll_Customer();
        }

        private void LV_CUTOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_CUTOM.FocusedItem.Index >= 0)
            {
                int index = LV_CUTOM.FocusedItem.Index;
                TB_CID.Text = Customers[index].CID.ToString();
                TB_아이디.Text = Customers[index].아이디;
                TB_비밀번호.Text = Customers[index].비밀번호;
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }
            else
            {
                TB_CID.Text = " ";
                TB_아이디.Text =" ";
                TB_비밀번호.Text = " ";
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;

            }
        }
    }
}
