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
    public partial class ProjectCreator : MaterialForm
    {
        private string prjType = string.Empty;
        private ProjectType actualType;
        TemplateGeneration template = new TemplateGeneration();
        public ProjectCreator(ProjectType projectType)
        {
            actualType = projectType;
            InitializeComponent();
            InitializeMaterialTheme();
            if (actualType == ProjectType.ConsoleFull)
            {
                prjType = "Dart";
                txtProjectPath.Text = Application.StartupPath + "\\DenebProjects\\" + prjType + "\\";
            }
            
        }

        private void InitializeMaterialTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private async void btnCreateProject_Click(object sender, EventArgs e)
        {
            string projectPath = Path.Combine(txtProjectPath.Text, txtProjectName.Text);
            File.WriteAllText(Application.StartupPath + "\\OpenedProject.deneb", projectPath);
            prgCreating.Value += 10; // 20
            await Task.Delay(2000);
            if (!Directory.Exists(projectPath))
            {
                prgCreating.Value += 10; // 30
                await Task.Delay(2000);
                Directory.CreateDirectory(projectPath);
                Directory.CreateDirectory($"{projectPath}\\bin");
                Directory.CreateDirectory($"{projectPath}\\lib");
            }
            template.Path = txtProjectPath.Text;
            template.ProjectName = txtProjectName.Text;
            prgCreating.Value += 10;//40
            template.GenerateProject(actualType);
            await Task.Delay(2000);
            Program.launch = true;

            prgCreating.Value += 50;//90
            await Task.Delay(2000);
            prgCreating.Value += 10; //100
            this.Close();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            txtProjectName.Text = txtProjectName.Text.ToLower().Replace(" ", "_");
            txtProjectName.SelectionStart = txtProjectName.Text.Length;
        }
    }
}
