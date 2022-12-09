using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 창의적_종합설계_프로젝트_서버용
{

    public class Subject
    {
        public int SB_num { get; private set; }
        public string SB_title { get; private set; }
        public string SB_question1{ get; private set; }
        public string SB_question2 { get; private set; }
        public string SB_question3 { get; private set; }
        public string SB_question4 { get; private set; }
        public int SB_answer { get; private set; }
        public Subject(int _SB_num, string _SB_title, string _SB_question1, 
            string _SB_question2, string _SB_question3, string _SB_question4, int _SB_answer)
        {
            SB_num = _SB_num;
            SB_title = _SB_title;
            SB_question1 = _SB_question1;
            SB_question2 = _SB_question2;
            SB_question3 = _SB_question3;
            SB_question4 = _SB_question4;
            SB_answer = _SB_answer;

        }
    }
}
