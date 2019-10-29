namespace DenebStudio
{
    partial class ProjectSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSelector));
            this.btnOpenProject = new MaterialSkinPlus.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkinPlus.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listRecent = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.materialLabel1 = new MaterialSkinPlus.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateProject = new MaterialSkinPlus.Controls.MaterialRaisedButton();
            this.listCreate = new System.Windows.Forms.ListView();
            this.materialLabel3 = new MaterialSkinPlus.Controls.MaterialLabel();
            this.pnlSelector = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.AutoSize = true;
            this.btnOpenProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenProject.Depth = 0;
            this.btnOpenProject.Icon = null;
            this.btnOpenProject.Location = new System.Drawing.Point(263, 431);
            this.btnOpenProject.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Primary = true;
            this.btnOpenProject.Size = new System.Drawing.Size(133, 36);
            this.btnOpenProject.TabIndex = 1;
            this.btnOpenProject.Text = "Abrir Proyecto";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 24);
            this.materialLabel2.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Seleccionar Proyecto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listRecent);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.btnOpenProject);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 477);
            this.panel1.TabIndex = 3;
            // 
            // listRecent
            // 
            this.listRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRecent.ForeColor = System.Drawing.SystemColors.Info;
            this.listRecent.HideSelection = false;
            this.listRecent.LargeImageList = this.imgList;
            this.listRecent.Location = new System.Drawing.Point(12, 48);
            this.listRecent.Name = "listRecent";
            this.listRecent.Size = new System.Drawing.Size(386, 361);
            this.listRecent.SmallImageList = this.imgList;
            this.listRecent.TabIndex = 3;
            this.listRecent.UseCompatibleStateImageBehavior = false;
            this.listRecent.View = System.Windows.Forms.View.Tile;
            this.listRecent.DoubleClick += new System.EventHandler(this.listRecent_DoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "DartLogoB.png");
            this.imgList.Images.SetKeyName(1, "FlutterLogo.png");
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 229);
            this.materialLabel1.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(271, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "No se encontraron proyectos recientes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateProject);
            this.panel2.Controls.Add(this.listCreate);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(412, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 477);
            this.panel2.TabIndex = 4;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.AutoSize = true;
            this.btnCreateProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateProject.Depth = 0;
            this.btnCreateProject.Icon = null;
            this.btnCreateProject.Location = new System.Drawing.Point(269, 431);
            this.btnCreateProject.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Primary = true;
            this.btnCreateProject.Size = new System.Drawing.Size(137, 36);
            this.btnCreateProject.TabIndex = 4;
            this.btnCreateProject.Text = "Crear Proyecto";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // listCreate
            // 
            this.listCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCreate.ForeColor = System.Drawing.SystemColors.Info;
            this.listCreate.HideSelection = false;
            this.listCreate.LargeImageList = this.imgList;
            this.listCreate.Location = new System.Drawing.Point(16, 48);
            this.listCreate.Name = "listCreate";
            this.listCreate.Size = new System.Drawing.Size(386, 361);
            this.listCreate.SmallImageList = this.imgList;
            this.listCreate.TabIndex = 4;
            this.listCreate.UseCompatibleStateImageBehavior = false;
            this.listCreate.View = System.Windows.Forms.View.Tile;
            this.listCreate.DoubleClick += new System.EventHandler(this.listCreate_DoubleClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(16, 24);
            this.materialLabel3.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Seleccionar Proyecto";
            // 
            // pnlSelector
            // 
            this.pnlSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelector.Controls.Add(this.panel2);
            this.pnlSelector.Controls.Add(this.panel1);
            this.pnlSelector.Location = new System.Drawing.Point(1, 64);
            this.pnlSelector.Name = "pnlSelector";
            this.pnlSelector.Size = new System.Drawing.Size(824, 477);
            this.pnlSelector.TabIndex = 5;
            // 
            // ProjectSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 543);
            this.Controls.Add(this.pnlSelector);
            this.MaximizeBox = false;
            this.Name = "ProjectSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkinPlus.Controls.MaterialRaisedButton btnOpenProject;
        private MaterialSkinPlus.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkinPlus.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel pnlSelector;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView listRecent;
        private System.Windows.Forms.ListView listCreate;
        private MaterialSkinPlus.Controls.MaterialRaisedButton btnCreateProject;
        private MaterialSkinPlus.Controls.MaterialLabel materialLabel1;
    }
}