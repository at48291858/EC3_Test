namespace EC3
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsTrabajadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTrabajadores = new System.Windows.Forms.ToolStripButton();
            this.btnArea = new System.Windows.Forms.ToolStripButton();
            this.btnSalirMenu = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTrabajadores,
            this.tsArea,
            this.tsSalir});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(604, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsTrabajadores
            // 
            this.tsTrabajadores.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTrabajadores.Image = global::EC3.Properties.Resources.itrabajador;
            this.tsTrabajadores.Name = "tsTrabajadores";
            this.tsTrabajadores.Size = new System.Drawing.Size(113, 20);
            this.tsTrabajadores.Text = "Trabajadores";
            this.tsTrabajadores.Click += new System.EventHandler(this.tsTrabajadores_Click);
            // 
            // tsArea
            // 
            this.tsArea.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsArea.Image = global::EC3.Properties.Resources.iarea;
            this.tsArea.Name = "tsArea";
            this.tsArea.Size = new System.Drawing.Size(62, 20);
            this.tsArea.Text = "Área";
            this.tsArea.Click += new System.EventHandler(this.tsArea_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSalir.Image = global::EC3.Properties.Resources.eliminar;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(60, 20);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrabajadores,
            this.btnArea,
            this.btnSalirMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTrabajadores.Image = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.Image")));
            this.btnTrabajadores.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Size = new System.Drawing.Size(23, 22);
            this.btnTrabajadores.Text = "toolStripButton1";
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnArea
            // 
            this.btnArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArea.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.Image")));
            this.btnArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(23, 22);
            this.btnArea.Text = "toolStripButton2";
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalirMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirMenu.Image")));
            this.btnSalirMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(23, 22);
            this.btnSalirMenu.Text = "toolStripButton3";
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EC3.Properties.Resources.menu_imagen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsTrabajadores;
        private System.Windows.Forms.ToolStripMenuItem tsArea;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTrabajadores;
        private System.Windows.Forms.ToolStripButton btnArea;
        private System.Windows.Forms.ToolStripButton btnSalirMenu;
    }
}