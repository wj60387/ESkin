using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using BDAuscultation.SQLite;
using BDAuscultation.Commucation;

namespace BDAuscultation
{
    public delegate void StethcopeConnectChanged(string StetName,bool isConnect);
    public delegate void ShowMessage(string Msg);
     
    public class Mediator
    {
        public static AuscultationService.AuscultationServiceClient remoteService = new AuscultationService.AuscultationServiceClient("WSHttpBinding_IAuscultationService");
        public static void Init()
        {
            using (OperationContextScope scope = new OperationContextScope(remoteService.InnerChannel))
            {
                MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
                header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
              
            }
        }
        
      
        public static SqliteHelper sqliteHelper = new SqliteHelper(Setting.localSqliteConnectstring);
        public static SupSocket SuperSocket = new SupSocket(Setting.serverUrl);
        public static event ShowMessage ShowMessageEvent;
        public static event Action ClearMessageEvent;
        /// <summary>
        /// 听诊器连接状态变化事件
        /// </summary>
        public static event StethcopeConnectChanged StethcopeConnectChangedEvent;

        public static void OnStethcopeConnectChanged(string StetName, bool isConnect)
        {
            if (Mediator.StethcopeConnectChangedEvent != null)
            {
                Mediator.StethcopeConnectChangedEvent(StetName, isConnect);
            }
        }
        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
           ShowMsg(e.Exception.ToString());
        }
        public static void ShowMsg(string Msg)
        {
            if (ShowMessageEvent != null)
            {
                ShowMessageEvent(Msg);
                 
            }
        }
        public static void ClearInfo()
        {
            if (ClearMessageEvent != null)
            {
                ClearMessageEvent();
            }
        }
        public static void WriteLog(string FormName,string Message)
        {
            if (!Setting.isConnected) return;
            using (OperationContextScope scope = new OperationContextScope(remoteService.InnerChannel))
            {
                MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
                header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);
            var endpoint = remoteService.GetEndPoint();
            string sql = "insert into UserOperLog(SN, MAC, FormName, EndPoint, Message) select {0},{1},{2},{3},{4}";
            Mediator.remoteService.ExecuteNonQuery(sql, new string[]{Setting.authorizationInfo.AuthorizationNum,
                Setting.authorizationInfo.MachineCode, FormName, endpoint, Message});
            }
        }
    }
    
}
