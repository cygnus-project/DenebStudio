﻿using MaterialSkinPlus;
using MaterialSkinPlus.Controls;
using Newtonsoft.Json;
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
            if (!Directory.Exists($"{Application.StartupPath}\\DenebProjects"))
            {
                Directory.CreateDirectory($"{Application.StartupPath}\\DenebProjects");
            }
            if (!Directory.Exists($"{Application.StartupPath}\\DenebProjects\\Dart"))
            {
                Directory.CreateDirectory($"{Application.StartupPath}\\DenebProjects\\Dart");
            }
            if (!Directory.Exists($"{Application.StartupPath}\\DenebProjects\\Flutter"))
            {
                Directory.CreateDirectory($"{Application.StartupPath}\\DenebProjects\\Flutter");
            }

            //Program.launch = true;
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

            if (File.Exists(Application.StartupPath + "\\WorkedProjects.deneb"))
            {
                List<WorkedProject> workedProjectList = JsonConvert.DeserializeObject<List<WorkedProject>>(File.ReadAllText(Application.StartupPath + "\\WorkedProjects.deneb"));
                foreach (WorkedProject item in workedProjectList)
                {
                    if (item.Path.Contains("Dart"))
                    {
                        listRecent.AddRow(0, item.Name, item.Path);
                    }
                    else if (item.Path.Contains("Flutter"))
                    {
                        listRecent.AddRow(1, item.Name, item.Path);
                    }
                    
                }
            }



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

            listCreate.AddRow(0, "Dart Console Full", "Aplicación de ejecutable en Consola");
            listCreate.AddRow(0, "Dart Package Full", "Paquete de librerias");
            listCreate.AddRow(0, "Dart Shelf", "Dart Shelf");
            listCreate.AddRow(0, "Dart Web with Angular", "Aplicación web con Angular");
            listCreate.AddRow(0, "Dart Web Simple", "Aplicación web básica");
            listCreate.AddRow(0, "Dart Web Stagexl", "Aplicación web para juegos 2D");
            listCreate.AddRow(1, "Flutter App", "Aplicación básica de Flutter");
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
            /*using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    File.WriteAllText(Application.StartupPath + "\\OpenedProject.deneb", fbd.SelectedPath);
                }
            }*/
            if (listRecent.SelectedItems.Count > 0)
            {
                string project = listRecent.SelectedItems[0].SubItems[1].Text;
                File.WriteAllText(Application.StartupPath + "\\OpenedProject.deneb", project);
                Program.launch = true;
                this.Close(); 
            }
        }

        private async void btnCreateProject_Click(object sender, EventArgs e)
        {
            ProjectCreator projectCreator = null;
            if (listCreate.SelectedItems.Count > 0)
            {
                if (listCreate.SelectedItems[0].Index == 0)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 1)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 2)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 3)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 4)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 5)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 6)
                {
                    projectCreator = new ProjectCreator("Dart");
                }
                else if (listCreate.SelectedItems[0].Index == 7)
                {
                    projectCreator = new ProjectCreator("Flutter");
                }
                else if (listCreate.SelectedItems[0].Index == 8)
                {
                    projectCreator = new ProjectCreator("Flutter");
                }
                else if (listCreate.SelectedItems[0].Index == 9)
                {
                    projectCreator = new ProjectCreator("Flutter");
                }
                else if (listCreate.SelectedItems[0].Index == 10)
                {
                    projectCreator = new ProjectCreator("Flutter");
                } 
            }

            if (projectCreator != null)
            {
                projectCreator.ShowDialog();
                await Task.Delay(2000);
                this.Close();
            }
            

        }


    }
}
