﻿namespace Parley
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.besibolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saludoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cerrar,
            this.Registrar,
            this.saludoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cerrar
            // 
            this.Cerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 29);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Registrar
            // 
            this.Registrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.besibolToolStripMenuItem,
            this.futbolToolStripMenuItem});
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(166, 29);
            this.Registrar.Text = "Registrar equipos";
            // 
            // besibolToolStripMenuItem
            // 
            this.besibolToolStripMenuItem.Name = "besibolToolStripMenuItem";
            this.besibolToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.besibolToolStripMenuItem.Text = "Beisbol";
            this.besibolToolStripMenuItem.Click += new System.EventHandler(this.besibolToolStripMenuItem_Click);
            // 
            // futbolToolStripMenuItem
            // 
            this.futbolToolStripMenuItem.Name = "futbolToolStripMenuItem";
            this.futbolToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.futbolToolStripMenuItem.Text = "Futbol";
            this.futbolToolStripMenuItem.Click += new System.EventHandler(this.futbolToolStripMenuItem_Click);
            // 
            // saludoToolStripMenuItem
            // 
            this.saludoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            this.saludoToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.saludoToolStripMenuItem.Text = "Saludo";
            this.saludoToolStripMenuItem.Click += new System.EventHandler(this.saludoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al parley. Aun estamos trabajando en la funcionalidad\r\ndel programa, p" +
    "ero por ahora puede registrar a tus equipos favoritos";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(249, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 31);
            this.labelName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido al parley. Aun estamos trabajando en la funcionalidad del programa, \r\n" +
    "pero por ahora puede registrar a tus equipos favoritos\r\n";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(581, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "TuParley";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Registrar;
        private System.Windows.Forms.ToolStripMenuItem besibolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saludoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
    }
}

