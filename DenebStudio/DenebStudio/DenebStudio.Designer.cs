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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.pnlProjetManager = new System.Windows.Forms.Panel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.indexedTextbox1 = new DenebStudioControls.IndexedTextbox();
            this.pnlMain.SuspendLayout();
            this.pnlCode.SuspendLayout();
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
            this.pnlMain.Location = new System.Drawing.Point(0, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(916, 493);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlCode
            // 
            this.pnlCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlCode.Controls.Add(this.indexedTextbox1);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCode.Location = new System.Drawing.Point(243, 0);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(673, 300);
            this.pnlCode.TabIndex = 2;
            // 
            // pnlConsole
            // 
            this.pnlConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsole.Location = new System.Drawing.Point(243, 300);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(673, 193);
            this.pnlConsole.TabIndex = 1;
            // 
            // pnlProjetManager
            // 
            this.pnlProjetManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlProjetManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjetManager.Location = new System.Drawing.Point(0, 0);
            this.pnlProjetManager.Name = "pnlProjetManager";
            this.pnlProjetManager.Size = new System.Drawing.Size(243, 493);
            this.pnlProjetManager.TabIndex = 0;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // indexedTextbox1
            // 
            this.indexedTextbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indexedTextbox1.ForeColor = System.Drawing.SystemColors.Control;
            this.indexedTextbox1.Location = new System.Drawing.Point(0, 0);
            this.indexedTextbox1.Name = "indexedTextbox1";
            this.indexedTextbox1.Size = new System.Drawing.Size(673, 300);
            this.indexedTextbox1.TabIndex = 0;
            // 
            // DenebStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 554);
            this.Controls.Add(this.pnlMain);
            this.Name = "DenebStudio";
            this.Text = "Deneb Studio";
            this.pnlMain.ResumeLayout(false);
            this.pnlCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.Panel pnlProjetManager;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private DenebStudioControls.IndexedTextbox indexedTextbox1;
    }
}

