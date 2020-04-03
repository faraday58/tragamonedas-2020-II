namespace TragaMonedas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.achivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeCronometro = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.ptbDer = new System.Windows.Forms.PictureBox();
            this.ptbCtro = new System.Windows.Forms.PictureBox();
            this.ptbIzq = new System.Windows.Forms.PictureBox();
            this.créditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCtro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIzq)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achivoToolStripMenuItem,
            this.jugarToolStripMenuItem,
            this.créditoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // achivoToolStripMenuItem
            // 
            this.achivoToolStripMenuItem.Name = "achivoToolStripMenuItem";
            this.achivoToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.achivoToolStripMenuItem.Text = "Achivo";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.jugarToolStripMenuItem.Text = "Jugar";
            this.jugarToolStripMenuItem.Click += new System.EventHandler(this.JugarToolStripMenuItem_Click);
            // 
            // timeCronometro
            // 
            this.timeCronometro.Interval = 1000;
            this.timeCronometro.Tick += new System.EventHandler(this.TimeCronometro_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo:";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(383, 44);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(51, 20);
            this.lbTiempo.TabIndex = 2;
            this.lbTiempo.Text = "label1";
            // 
            // ptbDer
            // 
            this.ptbDer.Image = global::TragaMonedas.Properties.Resources.CEREZAS;
            this.ptbDer.Location = new System.Drawing.Point(568, 86);
            this.ptbDer.Name = "ptbDer";
            this.ptbDer.Size = new System.Drawing.Size(187, 144);
            this.ptbDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDer.TabIndex = 0;
            this.ptbDer.TabStop = false;
            // 
            // ptbCtro
            // 
            this.ptbCtro.Image = global::TragaMonedas.Properties.Resources.mangos_big_750570;
            this.ptbCtro.Location = new System.Drawing.Point(298, 86);
            this.ptbCtro.Name = "ptbCtro";
            this.ptbCtro.Size = new System.Drawing.Size(187, 144);
            this.ptbCtro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCtro.TabIndex = 0;
            this.ptbCtro.TabStop = false;
            // 
            // ptbIzq
            // 
            this.ptbIzq.Image = global::TragaMonedas.Properties.Resources.uvas;
            this.ptbIzq.Location = new System.Drawing.Point(51, 86);
            this.ptbIzq.Name = "ptbIzq";
            this.ptbIzq.Size = new System.Drawing.Size(187, 144);
            this.ptbIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIzq.TabIndex = 0;
            this.ptbIzq.TabStop = false;
            // 
            // créditoToolStripMenuItem
            // 
            this.créditoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.créditoToolStripMenuItem.Name = "créditoToolStripMenuItem";
            this.créditoToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.créditoToolStripMenuItem.Text = "Crédito";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inicialToolStripMenuItem.Text = "Inicial";
            this.inicialToolStripMenuItem.Click += new System.EventHandler(this.InicialToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbDer);
            this.Controls.Add(this.ptbCtro);
            this.Controls.Add(this.ptbIzq);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCtro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIzq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIzq;
        private System.Windows.Forms.PictureBox ptbCtro;
        private System.Windows.Forms.PictureBox ptbDer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem achivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.Timer timeCronometro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.ToolStripMenuItem créditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
    }
}

