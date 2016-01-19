using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using PanGu.Forms;
using PanGu.Common;

namespace PanGu
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ApplicationThreadException);

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            if (new FormLogin().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }

        }

        #region Events
        private static void ApplicationThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                log4net.LogManager.GetLogger(Constants.LOGGER_APPEND_ROOT).Error(e.Exception);

                XtraMessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
