using _2.Restaurant_management_system.View.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Restaurant_management_system
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
            Application.Run(new F_MainMenuDashboard());
        }

        public  static bool IsInDesignMode(this ContainerControl container)
        {
            if(Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                container.Controls.Add(new Label()
                {
                    Text = container.GetType().Name,
                    AutoSize = false,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                });
                return true;
            }
            return false;
        }
    }
}
