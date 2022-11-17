namespace Parley
{
    partial class Futbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Futbol));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.txtFederados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMundial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.Confederacion = new System.Windows.Forms.ComboBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TuParley";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.txtFederados);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMundial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTeam);
            this.groupBox1.Controls.Add(this.Confederacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro para el mundial";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(369, 56);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(92, 38);
            this.Buscar.TabIndex = 13;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 44);
            this.button4.TabIndex = 12;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(257, 299);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(99, 44);
            this.bUpdate.TabIndex = 11;
            this.bUpdate.Text = "Actualizar";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(152, 299);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(99, 44);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Eliminar";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(47, 299);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(99, 44);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Registrar";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // txtFederados
            // 
            this.txtFederados.Location = new System.Drawing.Point(257, 223);
            this.txtFederados.Name = "txtFederados";
            this.txtFederados.Size = new System.Drawing.Size(47, 26);
            this.txtFederados.TabIndex = 8;
            this.txtFederados.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad de jugadores federados";
            // 
            // txtMundial
            // 
            this.txtMundial.Location = new System.Drawing.Point(257, 169);
            this.txtMundial.Name = "txtMundial";
            this.txtMundial.Size = new System.Drawing.Size(47, 26);
            this.txtMundial.TabIndex = 6;
            this.txtMundial.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Participaciones en el Mundial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confederacion";
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(257, 62);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(100, 26);
            this.txtTeam.TabIndex = 3;
            // 
            // Confederacion
            // 
            this.Confederacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Confederacion.FormattingEnabled = true;
            this.Confederacion.Items.AddRange(new object[] {
            "AFC (Asia)",
            "CAF (África)",
            "CONCACAF (Centro america)",
            "CONMEBOL (Sudamerica)",
            "UEFA (Europa)",
            "OFC (Oceania)"});
            this.Confederacion.Location = new System.Drawing.Point(257, 116);
            this.Confederacion.Name = "Confederacion";
            this.Confederacion.Size = new System.Drawing.Size(208, 28);
            this.Confederacion.TabIndex = 2;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Futbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Futbol";
            this.ShowIcon = false;
            this.Text = "Futbol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.ComboBox Confederacion;
        private System.Windows.Forms.TextBox txtFederados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMundial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Button Buscar;
    }
}