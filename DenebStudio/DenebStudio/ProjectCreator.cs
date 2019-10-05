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
        public ProjectCreator(string ProjectType)
        {
            InitializeComponent();
            InitializeMaterialTheme();
            prjType = ProjectType;
            txtProjectPath.Text = Application.StartupPath + "\\DenebProjects\\" + ProjectType + "\\";
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
            prgCreating.Value += 10;
            await Task.Delay(2000);
            if (!Directory.Exists(projectPath))
            {
                prgCreating.Value += 10;
                await Task.Delay(2000);
                Directory.CreateDirectory(projectPath);
            }
            prgCreating.Value += 10;
            await Task.Delay(2000);
            Program.launch = true;
            prgCreating.Value += 10;
            await Task.Delay(2000);
            prgCreating.Value += 10;
            this.Close();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            txtProjectName.Text = txtProjectName.Text.ToLower().Replace(" ", "_");
            txtProjectName.SelectionStart = txtProjectName.Text.Length;
        }
    }
}
