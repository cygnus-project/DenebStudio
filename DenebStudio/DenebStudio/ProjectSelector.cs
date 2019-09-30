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
            InitializeLists();
            Program.launch = true;
        }

        void InitializeLists()
        {
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


            /*listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/vba.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/vbgp.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/avbt.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/ccl.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/da.htm");
            listRecent.AddRow(1, "Flutter", "http://www.vb-helper.com/err.htm");
            listRecent.AddRow(0, "Dart", "http://www.vb-helper.com/vbcl.htm");*/

            if (listRecent.Items.Count == 0)
            {
                listRecent.Visible = false;
            }

            listCreate.AddRow(0, "Dart Basic Project", "Proyecto Básico solo con clase principal");
            listCreate.AddRow(0, "Dart Console Full", "Aplicación de ejecutable en Consola");
            listCreate.AddRow(0, "Dart Package Full", "Paquete de librerias");
            listCreate.AddRow(0, "Dart Shelf", "Dart Shelf");
            listCreate.AddRow(0, "Dart Web with Angular", "Aplicación web con Angular");
            listCreate.AddRow(0, "Dart Web Simple", "Aplicación web básica");
            listCreate.AddRow(0, "Dart Web Stagexl", "Aplicación web para juegos 2D");
            listCreate.AddRow(1, "Flutter App", "Aplicación básica de Flutter");
            listCreate.AddRow(1, "Flutter Pluging", "Plugin para Flutter");
            listCreate.AddRow(1, "Flutter Web App", "Applicación web con Flutter");
            listCreate.AddRow(1, "Flutter Desktop App", "Aplicación de escritorio con Flutter");
        }

        private void InitializeMaterialTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
            
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
                    File.WriteAllText(Application.StartupPath + "\\OpenedProject.deneb", fbd.SelectedPath);
                }
            }
            this.Close();
        }
    }
}
