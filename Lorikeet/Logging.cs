using Lorikeet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public static class Logging
    {
        public enum ErrorCodes
        {
            None = 0,
            Broadcast = 1,
            OK = 2,
            Warning = 3,
            Error = 4
        };

        public enum RefreshCodes
        {
            None = 0,
            DiagnosisMedication = 1,
            Schedule = 2,
            Member = 3,
            Notes = 4,
            Contact = 5,
            DebitCredit = 6,
            Diagnosis = 7,
            Medication = 8
        };

        public class BroadCastLogs
        {
            public List<DateTime> datetime;
            public List<string> messages;
            public List<int> refreshCode;

        }

        public static void AddLogEntry(int staffID, ErrorCodes errorCode, RefreshCodes refreshCode, string message, bool displayNotifyIcon)
        {
            try
            {
                if (displayNotifyIcon)
                {
                    NotifyIcon notifyIcon1 = new NotifyIcon();

                    if (errorCode == ErrorCodes.None)
                        notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.None;
                    else if (errorCode == ErrorCodes.OK)
                        notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                    else if (errorCode == ErrorCodes.Warning)
                        notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
                    else if (errorCode == ErrorCodes.Error)
                        notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;

                    notifyIcon1.BalloonTipText = message;
                    notifyIcon1.BalloonTipTitle = "Logging";
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(3000);
                }
                
                
                using (var context = new LorikeetAppEntities())
                {
                    var logToAdd = new Log();
                    logToAdd.DateTime = DateTime.Now;
                    logToAdd.ErrorCode = (int)errorCode;
                    logToAdd.Message = message;
                    logToAdd.StaffID = staffID;
                    logToAdd.RefreshCode = (int)refreshCode;

                    context.Logs.Add(logToAdd);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        public static int GetLastLogID()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var lastid = (from l in context.Logs
                                  select l).ToList();

                    int id = lastid[lastid.Count() -1].LogID;

                    return id;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static List<int> GetAllRefreshFromID(int id)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    List<int> broadcastLogs = (from l in context.Logs
                                                  where l.LogID > id && l.ErrorCode == 1
                                                  select l.RefreshCode).ToList();


                    return broadcastLogs;
                }
            }
            catch
            {
                return null;
            }
        }



        public static List<Log> GetAllBroadcastLogsFromID(int id)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var broadcastLogs = (from l in context.Logs
                                                  where l.LogID > id && l.ErrorCode == 1
                                                  select l).ToList();
             

                    return broadcastLogs;               
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
