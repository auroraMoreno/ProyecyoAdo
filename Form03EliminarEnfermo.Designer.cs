namespace ProyecyoAdo
{
    partial class Form03EliminarEnfermo
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
            this.lblEnfermos = new System.Windows.Forms.Label();
            this.lstEnfermos = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnfermos
            // 
            this.lblEnfermos.AutoSize = true;
            this.lblEnfermos.Location = new System.Drawing.Point(36, 106);
            this.lblEnfermos.Name = "lblEnfermos";
            this.lblEnfermos.Size = new System.Drawing.Size(51, 13);
            this.lblEnfermos.TabIndex = 9;
            this.lblEnfermos.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            this.lstEnfermos.FormattingEnabled = true;
            this.lstEnfermos.Location = new System.Drawing.Point(36, 125);
            this.lstEnfermos.Name = "lstEnfermos";
            this.lstEnfermos.Size = new System.Drawing.Size(238, 316);
            this.lstEnfermos.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 72);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Buscar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(36, 46);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(187, 20);
            this.txtInscripcion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inscripcion";
            // 
            // Form03EliminarEnfermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 501);
            this.Controls.Add(this.lblEnfermos);
            this.Controls.Add(this.lstEnfermos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtInscripcion);
            this.Controls.Add(this.label1);
            this.Name = "Form03EliminarEnfermo";
            this.Text = "Form03EliminarEnfermo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnfermos;
        private System.Windows.Forms.ListBox lstEnfermos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Label label1;
    }
}