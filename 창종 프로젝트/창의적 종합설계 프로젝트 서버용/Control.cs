using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 창의적_종합설계_프로젝트_서버용.NetWork;

namespace 창의적_종합설계_프로젝트_서버용
{
        internal class Control
        {
            private Wb_TcpListener server = null;
            private TEL서버메인 mainForm;
            private WB_DataBase database;
            #region 싱글톤
            public static Control Instance { get; private set; }
            static Control()
            {
                Instance = new Control();
            }
            private Control()
            {

            }
            #endregion
            public void thisForm(TEL서버메인 form)
            {
                mainForm = form;
            }
            public void thisDataBase(WB_DataBase formdatabase)
            {
                database= formdatabase;
            }
            #region 네트워크
        //메세지 수신부 (클라이언트로 들어온 메세지 처리)




            public string RecvMessage(string packet)
            {
                string[] sp1 = packet.Split('@');
                //if (sp1[0] == Packet.Pack_TestMessage)
                //{
                //    //수신 처리
                //    string[] sp2 = sp1[1].Split('#');
                //    mainForm.MsgPrint(sp2[0], sp2[1]);

                //    //송신 생성(echo)
                //    string pack = Packet.ShortMessage(sp2[0], sp2[1]);//받은메세지를 다시 보내기위해서 만듬
                //    return pack;
                //}
            switch (sp1[0]) {
                case Packet.Pack_TestMessage:
                    {
                    string[] sp2 = sp1[1].Split('#');
                    mainForm.MsgPrint(sp2[0], sp2[1]);

                    //송신 생성(echo)
                    string pack = Packet.ShortMessage(sp2[0], sp2[1]);//받은메세지를 다시 보내기위해서 만듬
                    return pack;

                    }

                case Packet.Pack_CustomInsert:
                    {
                        try
                        {
                            mainForm.TestPrint(sp1);//받은 패킷명령어 출력
                            string[] sp2 = sp1[1].Split('#');
                            database.Insert_Customer(sp2[0], sp2[1]);
                            mainForm.PrintAll_Customer();
                            //송신 생성(echo)
                            string pack = Packet.CustomInsert(true);//받은메세지 보내기위해서 패킷 조립
                            return pack;

                        }
                        catch(Exception)
                        {
                       
                            string pack = Packet.CustomInsert(false);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                        }
                    }
                case Packet.Pack_CustomSubjectInsert:
                    {
                        try
                        {
                            mainForm.TestPrint(sp1);//받은 패킷명령어 출력
                            string[] sp2 = sp1[1].Split('#');
                            database.Insert_Subject(sp2[0], sp2[1], sp2[2], sp2[3], sp2[4], int.Parse(sp2[5]));
                            mainForm.PrintAll_Subject();
                            //송신 생성(echo)
                            string pack = Packet.CustomSubjectInsert(true);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                            //asd#asd#dasd#sd#1 실험용
                        }
                        catch (Exception)
                        {

                            string pack = Packet.CustomSubjectInsert(false);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                        }
                    }
                case Packet.Pack_CustomSubjectDelete:
                    {
                        try
                        {
                            mainForm.TestPrint(sp1);//받은 패킷명령어 출력
                            string[] sp2 = sp1[1].Split('#');
                            database.Delete_Subject(int.Parse(sp2[0]));
                            mainForm.PrintAll_Subject();
                            //송신 생성(echo)
                            string pack = Packet.CustomSubjectDelete(true);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                            //asd#asd#dasd#sd#1 실험용
                        }
                        catch (Exception)
                        {

                            string pack = Packet.CustomSubjectDelete(false);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                        }
                    }
                case Packet.Pack_CustomSubjectUpdate:
                    {
                        try
                        {
                            mainForm.TestPrint(sp1);//받은 패킷명령어 출력
                            string[] sp2 = sp1[1].Split('#');
                            database.Update_Subject(int.Parse(sp2[0]), sp2[1], sp2[2],sp2[3],sp2[4],sp2[5],int.Parse(sp2[6]));
                            mainForm.PrintAll_Subject();
                            //송신 생성(echo)
                            string pack = Packet.CustomSubjectUpdate(true);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                            //asd#asd#dasd#sd#1 실험용
                        }
                        catch (Exception)
                        {

                            string pack = Packet.CustomSubjectUpdate(false);//받은메세지 보내기위해서 패킷 조립
                            return pack;
                        }
                    }

            }

                return string.Empty;
            }


            //로그메시지 수신부 (서버시작/종료/클라이언트 연결/ 해제)
            public void LogMessage(string msg)
            {
                mainForm.LogPrint(msg);
            }
            public void ServerStart(int port)
            {
                server = new Wb_TcpListener(port);  // TCP 포트 열기
                server.Recvfunc = RecvMessage;      //메세지 받기
                server.Logfunc = LogMessage;
                server.Start();
                server.Run();

                //Console.ReadKey();

            }
            public void ServerStop()
            {
                server.Close();

            }


            #endregion
        }
   
}
