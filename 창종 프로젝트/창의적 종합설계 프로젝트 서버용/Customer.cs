using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 창의적_종합설계_프로젝트_서버용
{

    public class Customer
    {
        public int CID { get; private set; }
        public string 아이디 { get; private set; }
        public string 비밀번호 { get; private set; }
        public Customer(int _CID, string _아이디, string _비밀번호)
        {
            CID = _CID;
            아이디 = _아이디;
            비밀번호 = _비밀번호;
        }

    }
}
