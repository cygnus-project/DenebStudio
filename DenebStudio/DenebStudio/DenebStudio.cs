﻿using MaterialSkinPlus;
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
using EasyTabs;

namespace DenebStudio
{
    public partial class DenebStudio : MaterialForm
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }


        public DenebStudio()
        {
            InitializeComponent();
            InitializeMaterialTheme();
            ListDirectory(trvProjectDirectory, File.ReadAllText(Application.StartupPath + "\\openedProject.deneb"));
            if (Program.path != string.Empty)
            {
                txtCode.Text = File.ReadAllText(Program.path);
            }
        }

        private void InitializeMaterialTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name) { Tag = file.FullName });
            return directoryNode;
        }

        private string GetFileName(string fullPath)
        {
            string name = string.Empty;
            bool incomplete = true;
            for (int i = fullPath.Length-1; i >= 0; i--)
            {
                if (fullPath[i] == '\\')
                {
                    incomplete = false;
                }
                if (incomplete)
                {
                    name += fullPath[i];
                }
            }

            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }

        private void trvProjectDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Tag != null)
                {
                    Program.path = e.Node.Tag.ToString();
                    Program.container.Tabs.Add(new EasyTabs.TitleBarTab(Program.container)
                    {
                        Content = new DenebStudio
                        {
                            Text = GetFileName(e.Node.Tag.ToString()),
                            Icon = Icon.FromHandle(Properties.Resources.EditIcon.GetHicon())
                        }
                    });
                    /*if (tabOpenedFile.TabPages[0].Text == "Empty")
                    {
                        tabOpenedFile.TabPages[0].Text = GetFileName(e.Node.Tag.ToString());
                        //materialTabSelector1.Refresh();
                    }
                    
                    txtCode.richTextBox1.Text = File.ReadAllText(e.Node.Tag.ToString()); */

                }
            }
        }

        private void tabOpenedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(e.ToString());
            
        }
    }
}
