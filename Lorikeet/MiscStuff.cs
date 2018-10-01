using Lorikeet.Data;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Lorikeet
{
    static class MiscStuff
    {
        public static string googleApiKey = "AIzaSyBV8DuRAmePxFvrHlSyF0E5Jm_5l1trJtw";

        public static DateTime GetDateTimeFromUnixTime(long dt)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(dt);
            DateTime dateTime = dateTimeOffset.UtcDateTime;

            return dateTime;
        }

        public static string GetSuffix(int dayNumber)
        {
            string suffix = (dayNumber % 10 == 1 && dayNumber != 11) ? "st"
            : (dayNumber % 10 == 2 && dayNumber != 12) ? "nd"
            : (dayNumber % 10 == 3 && dayNumber != 13) ? "rd"
            : "th";

            return suffix;
        }

        public static string GetStaffName(int staffID)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var staffName = (from s in context.Staffs
                                     where s.StaffID == staffID
                                     select s).DefaultIfEmpty().First();

                    if (staffName != null)
                    {
                        return staffName.StaffName;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetAllMessages(ex));
                return null;
            }
        }

        public static int GetAccessLevel(int staffID)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var accessLevel = (from l in context.Logins
                                       join s in context.Staffs on l.LoginID equals s.LoginID
                                       where s.StaffID == staffID
                                       select l.Access).FirstOrDefault();
                    if (accessLevel != null)
                    {
                        return accessLevel.Value;
                    }
                    else return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
            return 0;
        }

        public static string GetMemberName(int memberID)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var memberName = (from m in context.Members
                                      where m.MemberID == memberID
                                      select m).DefaultIfEmpty().First();

                    if (memberName != null)
                    {
                        return memberName.FirstName + " " + memberName.Surname;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetAllMessages(ex));
                return null;
            }
        }

        public static int GetMemberID(string name)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    string[] wholeName = name.Split(' ');
                    string firstName = wholeName[0];
                    string surname = wholeName[1];

                    var memberName = (from m in context.Members
                                      where m.FirstName == firstName && m.Surname.Contains(surname)
                                      select m).DefaultIfEmpty().First();

                    if (memberName != null)
                    {
                        return memberName.MemberID;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetAllMessages(ex));
                return -1;
            }
        }

        public static string GetAllMessages(this Exception ex)
        {
            if (ex == null)
                throw new ArgumentNullException("ex");

            StringBuilder sb = new StringBuilder();

            while (ex != null)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (sb.Length > 0)
                        sb.Append(" ");

                    sb.Append(ex.Message);
                }

                ex = ex.InnerException;
            }

            return sb.ToString();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var Client = new WebClient())
                using (var stream = Client.OpenRead("http://www.google.com"))
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
