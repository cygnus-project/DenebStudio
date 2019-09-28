namespace DenebStudio
{
    partial class DenebStudio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DenebStudio));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.pnlConsoleTitle = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkinPlus.Controls.MaterialLabel();
            this.pnlProjetManager = new System.Windows.Forms.Panel();
            this.trvProjectDirectory = new System.Windows.Forms.TreeView();
            this.pnlPMTitle = new System.Windows.Forms.Panel();
            this.lblProjectManager = new MaterialSkinPlus.Controls.MaterialLabel();
            this.file = new MaterialSkinPlus.Controls.MaterialContextMenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirProjectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.pnlConsole.SuspendLayout();
            this.pnlConsoleTitle.SuspendLayout();
            this.pnlProjetManager.SuspendLayout();
            this.pnlPMTitle.SuspendLayout();
            this.file.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.pnlCode);
            this.pnlMain.Controls.Add(this.pnlConsole);
            this.pnlMain.Controls.Add(this.pnlProjetManager);
            this.pnlMain.Location = new System.Drawing.Point(1, 64);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(914, 489);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlCode
            // 
            this.pnlCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlCode.Controls.Add(this.txtCode);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCode.Location = new System.Drawing.Point(243, 0);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(671, 296);
            this.pnlCode.TabIndex = 0;
            // 
            // pnlConsole
            // 
            this.pnlConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsole.Controls.Add(this.pnlConsoleTitle);
            this.pnlConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsole.Location = new System.Drawing.Point(243, 296);
            this.pnlConsole.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(671, 193);
            this.pnlConsole.TabIndex = 0;
            // 
            // pnlConsoleTitle
            // 
            this.pnlConsoleTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.pnlConsoleTitle.Controls.Add(this.materialLabel1);
            this.pnlConsoleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsoleTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlConsoleTitle.Name = "pnlConsoleTitle";
            this.pnlConsoleTitle.Size = new System.Drawing.Size(669, 25);
            this.pnlConsoleTitle.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 2);
            this.materialLabel1.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Consola";
            // 
            // pnlProjetManager
            // 
            this.pnlProjetManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlProjetManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjetManager.Controls.Add(this.trvProjectDirectory);
            this.pnlProjetManager.Controls.Add(this.pnlPMTitle);
            this.pnlProjetManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjetManager.Location = new System.Drawing.Point(0, 0);
            this.pnlProjetManager.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProjetManager.Name = "pnlProjetManager";
            this.pnlProjetManager.Size = new System.Drawing.Size(243, 489);
            this.pnlProjetManager.TabIndex = 0;
            // 
            // trvProjectDirectory
            // 
            this.trvProjectDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.trvProjectDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjectDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.trvProjectDirectory.Location = new System.Drawing.Point(0, 25);
            this.trvProjectDirectory.Name = "trvProjectDirectory";
            this.trvProjectDirectory.Size = new System.Drawing.Size(241, 462);
            this.trvProjectDirectory.TabIndex = 1;
            this.trvProjectDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjectDirectory_AfterSelect);
            // 
            // pnlPMTitle
            // 
            this.pnlPMTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.pnlPMTitle.Controls.Add(this.lblProjectManager);
            this.pnlPMTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPMTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlPMTitle.Name = "pnlPMTitle";
            this.pnlPMTitle.Size = new System.Drawing.Size(241, 25);
            this.pnlPMTitle.TabIndex = 0;
            // 
            // lblProjectManager
            // 
            this.lblProjectManager.AutoSize = true;
            this.lblProjectManager.Depth = 0;
            this.lblProjectManager.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProjectManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProjectManager.Location = new System.Drawing.Point(4, 4);
            this.lblProjectManager.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.lblProjectManager.Name = "lblProjectManager";
            this.lblProjectManager.Size = new System.Drawing.Size(188, 19);
            this.lblProjectManager.TabIndex = 0;
            this.lblProjectManager.Text = "Administrador de Proyecto";
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.file.Depth = 0;
            this.file.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.file.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.file.Name = "materialContextMenuStrip1";
            this.file.Size = new System.Drawing.Size(116, 48);
            this.file.Text = "Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.abrirProjectoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // abrirProjectoToolStripMenuItem
            // 
            this.abrirProjectoToolStripMenuItem.Name = "abrirProjectoToolStripMenuItem";
            this.abrirProjectoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirProjectoToolStripMenuItem.Text = "Abrir Projecto";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtCode.BackBrush = null;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtCode.CharHeight = 14;
            this.txtCode.CharWidth = 8;
            this.txtCode.CurrentLineColor = System.Drawing.Color.Teal;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtCode.IsReplaceMode = false;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCode.ServiceColors")));
            this.txtCode.Size = new System.Drawing.Size(671, 296);
            this.txtCode.TabIndex = 0;
            this.txtCode.Zoom = 100;
            // 
            // DenebStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(916, 554);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DenebStudio";
            this.Opacity = 0.1D;
            this.Sizable = false;
            this.Text = "Deneb Studio";
            this.pnlMain.ResumeLayout(false);
            this.pnlCode.ResumeLayout(false);
            this.pnlConsole.ResumeLayout(false);
            this.pnlConsoleTitle.ResumeLayout(false);
            this.pnlConsoleTitle.PerformLayout();
            this.pnlProjetManager.ResumeLayout(false);
            this.pnlPMTitle.ResumeLayout(false);
            this.pnlPMTitle.PerformLayout();
            this.file.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.Panel pnlProjetManager;
        private MaterialSkinPlus.Controls.MaterialContextMenuStrip file;
        private System.Windows.Forms.Panel pnlPMTitle;
        private System.Windows.Forms.Panel pnlConsoleTitle;
        private MaterialSkinPlus.Controls.MaterialLabel lblProjectManager;
        private MaterialSkinPlus.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TreeView trvProjectDirectory;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirProjectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox txtCode;
    }
}

