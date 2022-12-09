using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 창의적_종합설계_프로젝트_서버용
{
    public class WB_DataBase
    {
        public SqlConnection Scon { get; private set; }
          private string constr = @"Data Source=DESKTOP-SQPOS0F\SQLEXPRESS;Initial Catalog=wb_subject;User ID=bsh;Password=9023";
        private DataSet wb_dataset = new DataSet("wb_subject");

        public void Open()
        {
            Scon = new SqlConnection(constr);
            Scon.Open(); //연결 열기
        }

        public void Close()
        {
            Scon.Close();
        }

        //Product --------------------------------------------------------------------
        #region ExecuteNonQuery (insert, update, delete)
        //insert into Product values('C언어', 30000, 'C언어책입니다');
        public void Insert_Customer(string 아이디, string 비밀번호)
        {
            string sql = string.Format("insert into Custom values('{0}','{1}');",
                아이디, 비밀번호);

            ExecuteNonQuery(sql);
        }
        public void Insert_Subject(string subject_title, string subject_question1, string subject_question2, 
            string subject_question3, string subject_question4, int subject_answer)
        {
            string sql = string.Format("insert into Subject values('{0}','{1}','{2}','{3}','{4}',{5});",
                subject_title, subject_question1, subject_question2, subject_question3, subject_question4, subject_answer);

            ExecuteNonQuery(sql);
        }
        public void Delete_Subject(int subject_no)
        {
            string sql = string.Format("delete from Subject where subject_no = {0};", subject_no);

            ExecuteNonQuery(sql);
        }
        public void Update_Subject(int subject_num, string subject_title, string subject_question1, string subject_question2,
            string subject_question3, string subject_question4, int subject_answer)
        {
            string sql = string.Format("update Subject set subject_tile = '{0}', sbject_qestion1 = '{1}', sbject_qestion2 = '{2}', " +
                "sbject_qestion3 = '{3}', sbject_qestion4 = '{4}', suject_answer = {5} where subject_no = {6};",
            subject_title, subject_question1, subject_question2, subject_question3,
                subject_question4, subject_answer, subject_num);

            ExecuteNonQuery(sql);
        }

        public void Delete_Customer(int CID)
        {
            string sql = string.Format("delete from Custom where CID = {0};", CID);

            ExecuteNonQuery(sql);
        }
        public void Update_Customer(int cid ,string 아이디 ,string 비밀번호)
        {
            string sql = string.Format("update Custom set Cname = '{0}', Cpassward = '{1}' where CID = {2};",
                아이디, 비밀번호, cid);

            ExecuteNonQuery(sql);
        }
    
        private void ExecuteNonQuery(string sql)
        {
            using (SqlCommand scom = new SqlCommand(sql, Scon))
            {
                int ret = scom.ExecuteNonQuery();  //insert, update, delete
                if (ret != 1)
                    throw new Exception("기능 요청 실패");
            }
        }
        #endregion

        #region ExecuteReader( select )
        public List<Subject> SelectAll_Subject()
        {
            string sql = "select * from Subject;";

            SqlCommand scom = new SqlCommand(sql, Scon);
            SqlDataReader reader = scom.ExecuteReader();

            List<Subject> subjects= new List<Subject>();
            while (reader.Read())
            {
                Subject p = new Subject(int.Parse(reader[0].ToString()),
                    reader[1].ToString(),reader[2].ToString(), reader[3].ToString(),
                    reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()));

                subjects.Add(p);
            }
            reader.Close();

            return subjects;
        }
        public List<Customer> SelectAll_Customer()
        {
            string sql = "select * from Custom;";

            SqlCommand scom = new SqlCommand(sql, Scon);
            SqlDataReader reader = scom.ExecuteReader();

            List<Customer> cstomers = new List<Customer>();
            while (reader.Read())
            {
                Customer p = new Customer(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());

                cstomers.Add(p);
            }
            reader.Close();

            return cstomers;
        }
        #endregion



        #region  문제추가 메인부분      Subject_Fill
        public DataTable Subject_Fill()
        {
            string sql = "select * from Subject;";//쿼리문을 사용하기에 원하는 정보를 출력가능

            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql, conn);//쿼리문가 서버에 대한 정보를 담는 작업 

                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey; // 제약조건도 같이 가져오는 속성값

                adapter.Fill(wb_dataset, "Subject");
                adapter.Dispose();      //객체 파괴혹은 종료 

            }
            return wb_dataset.Tables["Subject"];//또는 wb36_dataset.Tables[0]
        }


        #endregion


        #region ExecuteScalar (select)
        //public int ProductRowCount()
        //{
        //    string sql = "select COUNT(*) from Product;";

        //    SqlCommand scom = new SqlCommand(sql, Scon);
        //    int count = (int)scom.ExecuteScalar();

        //    return count;
        //}
        #endregion
        //-----------------------------------------------------------------------------

        //Custom ----------------------------------------------------------------------
        //Product와 동일한 기능메서드

        //-----------------------------------------------------------------------------

        //Sale ------------------------------------------------------------------------
        //insert, select, delete
    }
}
