namespace ProyecyoAdo
{
    partial class Form01PrimerADO
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.Columnas = new System.Windows.Forms.Label();
            this.lstcolumnas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsttipos = new System.Windows.Forms.ListBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(49, 44);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(49, 91);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(88, 23);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(49, 133);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(75, 45);
            this.btnLeerDatos.TabIndex = 2;
            this.btnLeerDatos.Text = "Leer datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            this.btnLeerDatos.Click += new System.EventHandler(this.btnLeerDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.Location = new System.Drawing.Point(173, 41);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(120, 199);
            this.lstApellidos.TabIndex = 4;
            // 
            // Columnas
            // 
            this.Columnas.AutoSize = true;
            this.Columnas.Location = new System.Drawing.Point(311, 25);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(53, 13);
            this.Columnas.TabIndex = 5;
            this.Columnas.Text = "Columnas";
            // 
            // lstcolumnas
            // 
            this.lstcolumnas.FormattingEnabled = true;
            this.lstcolumnas.Location = new System.Drawing.Point(314, 41);
            this.lstcolumnas.Name = "lstcolumnas";
            this.lstcolumnas.Size = new System.Drawing.Size(120, 199);
            this.lstcolumnas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos";
            // 
            // lsttipos
            // 
            this.lsttipos.FormattingEnabled = true;
            this.lsttipos.Location = new System.Drawing.Point(459, 44);
            this.lsttipos.Name = "lsttipos";
            this.lsttipos.Size = new System.Drawing.Size(120, 199);
            this.lsttipos.TabIndex = 8;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(60, 205);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(49, 13);
            this.lblestado.TabIndex = 9;
            this.lblestado.Text = "lblestado";
            // 
            // Form01PrimerADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 318);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lsttipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstcolumnas);
            this.Controls.Add(this.Columnas);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeerDatos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form01PrimerADO";
            this.Text = "Form01PrimerADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLeerDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstApellidos;
        private System.Windows.Forms.Label Columnas;
        private System.Windows.Forms.ListBox lstcolumnas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsttipos;
        private System.Windows.Forms.Label lblestado;
    }
}