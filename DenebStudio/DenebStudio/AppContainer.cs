using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenebStudio
{
    public partial class AppContainer : TitleBarTabs
    {
        private bool firstTab = true;
        public string actualPath = string.Empty;
        public AppContainer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Icon.FromHandle(Properties.Resources.EditIcon.GetHicon());
            //ForeColor = Color.FromArgb(13,71,161);
            
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new DenebStudio
                {
                    Text = "New Tab",
                    Icon = Icon.FromHandle(Properties.Resources.EditIcon.GetHicon())
                }

            };
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            //e.Graphics.Clear(Color.Black);
        }
    }
}
