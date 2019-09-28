using MaterialSkinPlus;
using MaterialSkinPlus.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenebStudio
{
    public partial class ProjectSelector : MaterialForm
    {
        public ProjectSelector()
        {
            InitializeComponent();
            InitializeMaterialTheme();
        }

        private void InitializeMaterialTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
            listRecent.LargeImageList = imgList;
            listCreate.LargeImageList = imgList;

            // Make the column headers.
            listRecent.MakeColumnHeaders(
                "Title", 230, HorizontalAlignment.Left,
                "Path", 220, HorizontalAlignment.Left);

            listCreate.MakeColumnHeaders(
                "Title", 230, HorizontalAlignment.Left,
                "Path", 220, HorizontalAlignment.Left);

            // Add data rows.


            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/vba.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/vbgp.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/avbt.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/ccl.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/da.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/err.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/vbcl.htm");

            listCreate.AddRow(0, "Dart", "http://www.vb-helper.com/vba.htm");
            listCreate.AddRow(1, "Flutter", "http://www.vb-helper.com/vbgp.htm");
            listCreate.AddRow(0, "Dart", "http://www.vb-helper.com/avbt.htm");
            listCreate.AddRow(1, "Flutter", "http://www.vb-helper.com/ccl.htm");
            listCreate.AddRow(0, "Dart", "http://www.vb-helper.com/da.htm");
            listCreate.AddRow(1, "Flutter", "http://www.vb-helper.com/err.htm");
            listCreate.AddRow(0, "Dart", "http://www.vb-helper.com/vbcl.htm");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    File.WriteAllText(Application.StartupPath + "\\openedProject.deneb", fbd.SelectedPath);
                }
            }
            this.Close();
        }
    }
}
