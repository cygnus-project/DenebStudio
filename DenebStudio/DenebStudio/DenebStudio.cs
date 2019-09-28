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
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace DenebStudio
{
    public partial class DenebStudio : MaterialForm
    {
        static SolidBrush keywordBrush = new SolidBrush(Color.FromArgb(92, 204, 226));

        readonly Style BlueBoldStyle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        readonly Style KeywordStyle = new TextStyle(keywordBrush, null, FontStyle.Regular);
        readonly Style ClassNameStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        readonly Style StringStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        readonly Style CommentTagStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        readonly Style CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        readonly Style AttributeStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        readonly Style NumberStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        readonly Style MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        readonly Style RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        readonly Style BlackStyle = new TextStyle(Brushes.Black, null, FontStyle.Regular);



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
                    bool fileExists = false;
                    string newPath = e.Node.Tag.ToString();
                    int index = -1;
                    foreach (TitleBarTab tab in Program.container.Tabs)
                    {
                        index++;
                        if (tab.Content.Text == GetFileName(newPath))
                        {
                            fileExists = true;
                            Program.container.SelectedTabIndex = index;
                        }
                    }
                    if (!fileExists)
                    {
                        Program.path = newPath;
                        Program.container.Tabs.Add(new EasyTabs.TitleBarTab(Program.container)
                        {
                            Content = new DenebStudio
                            {
                                Text = GetFileName(e.Node.Tag.ToString()),
                                Icon = Icon.FromHandle(Properties.Resources.EditIcon.GetHicon())
                            }
                        });
                        Program.container.SelectedTabIndex = Program.container.Tabs.Count - 1;
                    }

                }
            }
        }

        private void tabOpenedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(e.ToString());
            
        }

        static SolidBrush commentsBrush = new SolidBrush(Color.FromArgb(159, 205, 50));
        Style commentsStyle = new TextStyle(commentsBrush, null, FontStyle.Italic);

        static SolidBrush typesBrush = new SolidBrush(Color.FromArgb(106, 201, 216));
        Style typesStyle = new TextStyle(typesBrush, null, FontStyle.Bold);

        Regex DartStringRegex;
        Regex DartCommentRegex1;
        Regex DartCommentRegex2;
        Regex DartCommentRegex3;
        Regex DartNumberRegex;
        Regex DartAttributeRegex;
        Regex DartClassNameRegex;
        Regex DartKeywordRegex;

        protected void InitDartRegex()
        {
            //CSharpStringRegex = new Regex( @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'", RegexCompiledOption);

            DartStringRegex =
                new Regex(
                    @"
                            # Character definitions:
                            '
                            (?> # disable backtracking
                              (?:
                                \\[^\r\n]|    # escaped meta char
                                [^'\r\n]      # any character except '
                              )*
                            )
                            '?
                            |
                            # Normal string & verbatim strings definitions:
                            (?<verbatimIdentifier>@)?         # this group matches if it is an verbatim string
                            ""
                            (?> # disable backtracking
                              (?:
                                # match and consume an escaped character including escaped double quote ("") char
                                (?(verbatimIdentifier)        # if it is a verbatim string ...
                                  """"|                         #   then: only match an escaped double quote ("") char
                                  \\.                         #   else: match an escaped sequence
                                )
                                | # OR
            
                                # match any char except double quote char ("")
                                [^""]
                              )*
                            )
                            ""
                        ",
                    RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace |
                    RegexCompiledOption
                    ); //thanks to rittergig for this regex

            DartCommentRegex1 = new Regex(@"//.*$", RegexOptions.Multiline | RegexCompiledOption);
            DartCommentRegex2 = new Regex(@"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            DartCommentRegex3 = new Regex(@"(/\*.*?\*/)|(.*\*/)",
                                            RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            DartNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b",
                                          RegexCompiledOption);
            DartAttributeRegex = new Regex(@"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline | RegexCompiledOption);
            DartClassNameRegex = new Regex(@"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b", RegexCompiledOption);
            DartKeywordRegex =
                new Regex(
                    @"\b(abstract|add|alias|as|ascending|async|await|base|bool|break|by|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|descending|do|double|dynamic|else|enum|equals|event|explicit|extern|false|finally|fixed|float|for|foreach|from|get|global|goto|group|if|implicit|in|int|interface|internal|into|is|join|let|lock|long|nameof|namespace|new|null|object|on|operator|orderby|out|override|params|partial|private|protected|public|readonly|ref|remove|return|sbyte|sealed|select|set|short|sizeof|stackalloc|static|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|using|value|var|virtual|void|volatile|when|where|while|yield)\b|#region\b|#endregion\b",
                    RegexCompiledOption);
        }

        protected static readonly Platform platformType = PlatformType.GetOperationSystemPlatform();
        public static RegexOptions RegexCompiledOption
        {
            get
            {
                if (platformType == Platform.X86)
                    return RegexOptions.Compiled;
                else
                    return RegexOptions.None;
            }
        }

        private bool firstTime = true;
        private void txtCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (firstTime)
            {
                InitDartRegex();
                firstTime = false;
            }
            Range range = (sender as FastColoredTextBox).Range;

            range.ClearStyle(commentsStyle);
            range.SetStyle(commentsStyle, @"//.*$", RegexOptions.Multiline);
            range.SetStyle(typesStyle, @"\b(class|struct|enum)\s+(?<range>[\w_]+?)\b");

            range.ClearStyle(commentsStyle);
            //comment highlighting
            range.SetStyle(commentsStyle, @"//.*$", RegexOptions.Multiline);
            range.SetStyle(commentsStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            range.SetStyle(commentsStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline |
                        RegexOptions.RightToLeft);

            range.tb.CommentPrefix = "//";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '{';
            range.tb.RightBracket2 = '}';
            range.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

            range.tb.AutoIndentCharsPatterns
                = @"
^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);
^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);
";
            //clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, AttributeStyle, ClassNameStyle, KeywordStyle);
            //
            //string highlighting
            range.SetStyle(StringStyle, DartStringRegex);
            //comment highlighting
            range.SetStyle(CommentStyle, DartCommentRegex1);
            range.SetStyle(CommentStyle, DartCommentRegex2);
            range.SetStyle(CommentStyle, DartCommentRegex3);
            //number highlighting
            range.SetStyle(NumberStyle, DartNumberRegex);
            //attribute highlighting
            range.SetStyle(AttributeStyle, DartAttributeRegex);
            //class name highlighting
            range.SetStyle(ClassNameStyle, DartClassNameRegex);
            //keyword highlighting
            range.SetStyle(KeywordStyle, DartKeywordRegex);

            //find document comments
            foreach (Range r in range.GetRanges(@"^\s*///.*$", RegexOptions.Multiline))
            {
                //remove C# highlighting from this fragment
                r.ClearStyle(StyleIndex.All);
                //do XML highlighting;
                //
                r.SetStyle(CommentStyle);

                //prefix '///'
                foreach (Range rr in r.GetRanges(@"^\s*///", RegexOptions.Multiline))
                {
                    rr.ClearStyle(StyleIndex.All);
                    rr.SetStyle(CommentTagStyle);
                }
            }

            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers("{", "}"); //allow to collapse brackets block
            range.SetFoldingMarkers(@"#region\b", @"#endregion\b"); //allow to collapse #region blocks
            range.SetFoldingMarkers(@"/\*", @"\*/"); //allow to collapse comment block



        }
    }
}
