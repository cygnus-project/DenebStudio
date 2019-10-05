namespace DenebStudio
{
    partial class ProjectCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProjectName = new MaterialSkinPlus.Controls.MaterialSingleLineTextField();
            this.txtProjectPath = new MaterialSkinPlus.Controls.MaterialSingleLineTextField();
            this.btnCreateProject = new MaterialSkinPlus.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prgCreating = new MaterialSkinPlus.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Hint = "Ingrese Nombre del Proyecto";
            this.txtProjectName.Location = new System.Drawing.Point(26, 86);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.Size = new System.Drawing.Size(473, 23);
            this.txtProjectName.TabIndex = 0;
            this.txtProjectName.TabStop = false;
            this.txtProjectName.UseSystemPasswordChar = false;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Depth = 0;
            this.txtProjectPath.Hint = "C:/Users/@user/sources/Deneb/";
            this.txtProjectPath.Location = new System.Drawing.Point(26, 115);
            this.txtProjectPath.MaxLength = 32767;
            this.txtProjectPath.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.PasswordChar = '\0';
            this.txtProjectPath.SelectedText = "";
            this.txtProjectPath.SelectionLength = 0;
            this.txtProjectPath.SelectionStart = 0;
            this.txtProjectPath.Size = new System.Drawing.Size(422, 23);
            this.txtProjectPath.TabIndex = 1;
            this.txtProjectPath.TabStop = false;
            this.txtProjectPath.UseSystemPasswordChar = false;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.AutoSize = true;
            this.btnCreateProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateProject.Depth = 0;
            this.btnCreateProject.Icon = null;
            this.btnCreateProject.Location = new System.Drawing.Point(197, 144);
            this.btnCreateProject.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Primary = true;
            this.btnCreateProject.Size = new System.Drawing.Size(137, 36);
            this.btnCreateProject.TabIndex = 2;
            this.btnCreateProject.Text = "Crear Proyecto";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DenebStudio.Properties.Resources.EditIcon;
            this.pictureBox1.Location = new System.Drawing.Point(455, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // prgCreating
            // 
            this.prgCreating.Depth = 0;
            this.prgCreating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgCreating.ForeColor = System.Drawing.Color.Teal;
            this.prgCreating.Location = new System.Drawing.Point(0, 203);
            this.prgCreating.MarqueeAnimationSpeed = 50;
            this.prgCreating.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.prgCreating.Name = "prgCreating";
            this.prgCreating.Size = new System.Drawing.Size(525, 5);
            this.prgCreating.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgCreating.TabIndex = 4;
            this.prgCreating.Value = 5;
            // 
            // ProjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 208);
            this.Controls.Add(this.prgCreating);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.txtProjectName);
            this.Name = "ProjectCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectCreator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkinPlus.Controls.MaterialSingleLineTextField txtProjectName;
        private MaterialSkinPlus.Controls.MaterialSingleLineTextField txtProjectPath;
        private MaterialSkinPlus.Controls.MaterialRaisedButton btnCreateProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkinPlus.Controls.MaterialProgressBar prgCreating;
    }
}