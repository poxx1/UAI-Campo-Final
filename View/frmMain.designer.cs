namespace View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.maquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprob = new System.Windows.Forms.ToolStripMenuItem();
            this.salir03 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEjemplo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuG = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dAsignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.idiomasToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(107, 20);
            this.fileMenu.Tag = "configuracion01";
            this.fileMenu.Text = "1. Configuración";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.usuariosToolStripMenuItem.Tag = "usuarios1A";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.seguridadToolStripMenuItem.Tag = "patentesyfamilias1B";
            this.seguridadToolStripMenuItem.Text = "Patentes y Familias";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.idiomasToolStripMenuItem.Tag = "idiomas1C";
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.maquinasToolStripMenuItem,
            this.salir03,
            this.mnuSelectIdioma,
            this.mnuEjemplo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // maquinasToolStripMenuItem
            // 
            this.maquinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.reparacionesToolStripMenuItem,
            this.aprob,
            this.dAsignacionesToolStripMenuItem});
            this.maquinasToolStripMenuItem.Name = "maquinasToolStripMenuItem";
            this.maquinasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.maquinasToolStripMenuItem.Text = "2. Maquinas";
            this.maquinasToolStripMenuItem.Click += new System.EventHandler(this.maquinasToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresosToolStripMenuItem.Tag = "ingresos2A";
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reparacionesToolStripMenuItem.Tag = "reparaciones2B";
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            this.reparacionesToolStripMenuItem.Click += new System.EventHandler(this.reparacionesToolStripMenuItem_Click);
            // 
            // aprob
            // 
            this.aprob.Name = "aprob";
            this.aprob.Size = new System.Drawing.Size(180, 22);
            this.aprob.Tag = "aprobaciones2C";
            this.aprob.Text = "Aprobaciones";
            this.aprob.Click += new System.EventHandler(this.aprobacionesToolStripMenuItem_Click);
            // 
            // salir03
            // 
            this.salir03.Name = "salir03";
            this.salir03.Size = new System.Drawing.Size(53, 20);
            this.salir03.Tag = "salir03";
            this.salir03.Text = "3. Salir";
            this.salir03.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnuSelectIdioma
            // 
            this.mnuSelectIdioma.Name = "mnuSelectIdioma";
            this.mnuSelectIdioma.Size = new System.Drawing.Size(119, 20);
            this.mnuSelectIdioma.Text = "Seleccionar Idioma";
            this.mnuSelectIdioma.Click += new System.EventHandler(this.mnuSelectIdioma_Click);
            // 
            // mnuEjemplo
            // 
            this.mnuEjemplo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuA,
            this.mnuB,
            this.mnuC,
            this.mnuD,
            this.mnuE,
            this.mnuG});
            this.mnuEjemplo.Name = "mnuEjemplo";
            this.mnuEjemplo.Size = new System.Drawing.Size(96, 20);
            this.mnuEjemplo.Text = "Menu ejemplo";
            this.mnuEjemplo.Click += new System.EventHandler(this.mnuEjemplo_Click);
            // 
            // mnuA
            // 
            this.mnuA.Name = "mnuA";
            this.mnuA.Size = new System.Drawing.Size(150, 22);
            this.mnuA.Text = "Puede hacer A";
            // 
            // mnuB
            // 
            this.mnuB.Name = "mnuB";
            this.mnuB.Size = new System.Drawing.Size(150, 22);
            this.mnuB.Text = "Puede hacer B";
            // 
            // mnuC
            // 
            this.mnuC.Name = "mnuC";
            this.mnuC.Size = new System.Drawing.Size(150, 22);
            this.mnuC.Text = "Puede hacer C";
            // 
            // mnuD
            // 
            this.mnuD.Name = "mnuD";
            this.mnuD.Size = new System.Drawing.Size(150, 22);
            this.mnuD.Text = "Puede hacer D";
            // 
            // mnuE
            // 
            this.mnuE.Name = "mnuE";
            this.mnuE.Size = new System.Drawing.Size(150, 22);
            this.mnuE.Text = "Puede hacer E";
            // 
            // mnuG
            // 
            this.mnuG.Name = "mnuG";
            this.mnuG.Size = new System.Drawing.Size(150, 22);
            this.mnuG.Text = "Puede hacer G";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // dAsignacionesToolStripMenuItem
            // 
            this.dAsignacionesToolStripMenuItem.Name = "dAsignacionesToolStripMenuItem";
            this.dAsignacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dAsignacionesToolStripMenuItem.Text = "2. D Asignaciones";
            this.dAsignacionesToolStripMenuItem.Click += new System.EventHandler(this.dAsignacionesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEjemplo;
        private System.Windows.Forms.ToolStripMenuItem mnuA;
        private System.Windows.Forms.ToolStripMenuItem mnuB;
        private System.Windows.Forms.ToolStripMenuItem mnuC;
        private System.Windows.Forms.ToolStripMenuItem mnuD;
        private System.Windows.Forms.ToolStripMenuItem mnuE;
        private System.Windows.Forms.ToolStripMenuItem mnuG;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectIdioma;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem maquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salir03;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprob;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAsignacionesToolStripMenuItem;
    }
}



