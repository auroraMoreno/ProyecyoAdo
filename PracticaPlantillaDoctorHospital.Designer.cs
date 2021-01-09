namespace ProyecyoAdo
{
    partial class PracticaPlantillaDoctorHospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.txtSumaSalarial = new System.Windows.Forms.TextBox();
            this.txtMediaSalarial = new System.Windows.Forms.TextBox();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suma Salarial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Media Salarial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personas";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(33, 76);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(121, 24);
            this.cmbHospitales.TabIndex = 5;
            this.cmbHospitales.SelectedIndexChanged += new System.EventHandler(this.cmbHospitales_SelectedIndexChanged);
            // 
            // txtSumaSalarial
            // 
            this.txtSumaSalarial.Location = new System.Drawing.Point(33, 142);
            this.txtSumaSalarial.Name = "txtSumaSalarial";
            this.txtSumaSalarial.Size = new System.Drawing.Size(100, 22);
            this.txtSumaSalarial.TabIndex = 6;
            // 
            // txtMediaSalarial
            // 
            this.txtMediaSalarial.Location = new System.Drawing.Point(168, 143);
            this.txtMediaSalarial.Name = "txtMediaSalarial";
            this.txtMediaSalarial.Size = new System.Drawing.Size(100, 22);
            this.txtMediaSalarial.TabIndex = 7;
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(303, 142);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(100, 22);
            this.txtPersonas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 16;
            this.lstEmpleados.Location = new System.Drawing.Point(487, 76);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(120, 212);
            this.lstEmpleados.TabIndex = 10;
            // 
            // PracticaPlantillaDoctorHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.txtMediaSalarial);
            this.Controls.Add(this.txtSumaSalarial);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PracticaPlantillaDoctorHospital";
            this.Text = "PracticaPlantillaDoctorHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.TextBox txtSumaSalarial;
        private System.Windows.Forms.TextBox txtMediaSalarial;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}