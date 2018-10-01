using Lorikeet.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                MessageBox.Show("Cannot run the Lorikeet Program more than once");
                return;
            }

            // Application.Run(new FormMapHover());
            
            DialogResult dr = new DialogResult();

            var form = new FormLogin();
            dr = form.ShowDialog();

            int lastLogID = Logging.GetLastLogID();

            if (dr == DialogResult.Cancel)
            {
                return;
            }
            else if (dr == DialogResult.OK)
            {
                if (lastLogID == -1)
                {
                    Logging.AddLogEntry(0, Logging.ErrorCodes.OK, Logging.RefreshCodes.None, "Initializing Logging System", true);
                    lastLogID = 1;
                }
                else
                {
                    Logging.AddLogEntry(form.staffID, Logging.ErrorCodes.OK, Logging.RefreshCodes.None, "Login Successful", false);
                }

                string staffName = null;
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        staffName = (from s in context.Staffs
                                     where s.StaffID == form.staffID
                                     select s.StaffName).DefaultIfEmpty().First();

                        if (staffName != null)
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\Documents\\" + staffName);
                            Directory.CreateDirectory(Application.StartupPath + "\\Documents\\Shared");
                        }
                        else
                        {
                            MessageBox.Show("Couldn't Initialize Document Directory");
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Couldnt Initialize Document System");
                }
                Application.Run(new Form1(form.staffID));
            }
        }
    }
}
