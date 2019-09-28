using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace DenebStudio
{
    static class Program
    {
        public static AppContainer container;
        public static string path = string.Empty;
        public static bool firstLaunch = true;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectSelector());

            container = new AppContainer();
            container.Tabs.Add(new EasyTabs.TitleBarTab(container)
            {
                Content = new DenebStudio
                {
                    Text = "Deneb Studio",
                    Icon = Icon.FromHandle(Properties.Resources.EditIcon.GetHicon())
                }
            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);

        }

    }
}
