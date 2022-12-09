using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 창의적_종합설계_프로젝트_서버용.NetWork
{
  internal static class Packet
    {
        public const string Pack_TestMessage = "P_SHORTMESSAGE";//실험용 패킷

        public const string Pack_SubjectUpdate = "P_SUBJECTUPDATE";
        public const string Pack_SubjectUpdate_S = "P_SUBJECTUPDATE_S";
        public const string Pack_SubjectUpdate_F = "P_SUBJECTUPDATE_F";
        //프로그램 문제 들어오는
        //프로그램 문제 업데이트 성공
        //프로그램 문제 업데이트 실패

        public const string Pack_CustomInsert = "P_CUSTOMINSERT";
        public const string Pack_CustomInsert_S = "P_CUSTOMINSERT_S";
        public const string Pack_CustomInsert_F = "P_CUSTOMINSERT_F";
        //사용자 등록 들어오는
        //사용자 등록 성공
        //사용자 등록 실패

        public const string Pack_CustomSubjectInsert = "P_CUTOMSUJECTINSERT";
        public const string Pack_CustomSubjectInsert_S = "P_CUTOMSUJECTINSERT_S";
        public const string Pack_CustomSubjectInsert_F = "P_CUTOMSUJECTINSERT_F";
        //사용자 문제 등록 들어
        //사용자 문제 등록 성공    (사용자 출입확인 필요)   
        //사용자 문제 등록 실패

        public const string Pack_CustomSubjectUpdate = "P_CUTOMSUJECTUPDATE";
        public const string Pack_CustomSubjectUpdate_S = "P_CUTOMSUJECTUPDATE_S";
        public const string Pack_CustomSubjectUpdate_F = "P_CUTOMSUJECTUPDATE_F";
        //사용자 문제 업데이트 들어오는거
        //사용자 문제 업데이트 성공  (사용자 출입확인 필요)
        //사용자 문제 업데이트 실패  

        public const string Pack_CustomSubjectDelete = "P_CUTOMSUJECTDELETE";
        public const string Pack_CustomSubjectDelete_S = "P_CUTOMSUJECTDELETE_S";
        public const string Pack_CustomSubjectDelete_F = "P_CUTOMSUJECTDELETE_F";
        //사용자 문제 삭제들어오는거
        //사용자 문제 삭제성공     (사용자 출입확인 필요)
        //사용자 문제 삭제실패
        public static string ShortMessage(string nickname, string msg)
        {
            string pack = string.Empty;

            pack += Pack_TestMessage + "@";
            pack += nickname + "#";
            pack += msg;

            return pack;
        }
        //public static string SubjectUpdate(string nickname, string msg) //일딴보류
        //{
        //    string pack = string.Empty;

        //    pack += Pack_TestMessage + "@";
        //    pack += nickname + "#";
        //    pack += msg;

        //    return pack;
        //}
        public static string CustomInsert(bool TF)
        {
            if (TF==true)
            {
                string pack = string.Empty;
                pack += Pack_CustomInsert_S + "@";
                return pack;
            }
            else
            {
                string pack = string.Empty;
                pack += Pack_CustomInsert_F + "@";
                return pack;
            }
           
           
        }
        public static string CustomSubjectInsert(bool TF)
        {
            if (TF == true)
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectInsert_S + "@";
                return pack;
            }
            else
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectInsert_F + "@";
                return pack;
            }

        }
        public static string CustomSubjectDelete(bool TF)
        {
            if (TF == true)
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectDelete_S + "@";
                return pack;
            }
            else
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectDelete_S + "@";
                return pack;
            }
        }
        public static string CustomSubjectUpdate(bool TF)
        {
            if (TF == true)
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectUpdate_S + "@";
                return pack;
            }
            else
            {
                string pack = string.Empty;
                pack += Pack_CustomSubjectUpdate_F + "@";
                return pack;
            }
        }


    }
}
