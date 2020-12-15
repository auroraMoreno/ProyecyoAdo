namespace ProyecyoAdo
{
    partial class Form11HospitalesPlantilla
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
            this.panelHospitales = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lsvPlantilla = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // panelHospitales
            // 
            this.panelHospitales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelHospitales.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHospitales.Location = new System.Drawing.Point(0, 0);
            this.panelHospitales.Name = "panelHospitales";
            this.panelHospitales.Size = new System.Drawing.Size(200, 327);
            this.panelHospitales.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 327);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lsvPlantilla
            // 
            this.lsvPlantilla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvPlantilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPlantilla.HideSelection = false;
            this.lsvPlantilla.Location = new System.Drawing.Point(203, 0);
            this.lsvPlantilla.Name = "lsvPlantilla";
            this.lsvPlantilla.Size = new System.Drawing.Size(467, 327);
            this.lsvPlantilla.TabIndex = 2;
            this.lsvPlantilla.UseCompatibleStateImageBehavior = false;
            this.lsvPlantilla.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IdHospital";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Direccion";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefono";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Num_Camas";
            this.columnHeader5.Width = 145;
            // 
            // Form11HospitalesPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 327);
            this.Controls.Add(this.lsvPlantilla);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelHospitales);
            this.Name = "Form11HospitalesPlantilla";
            this.Text = "Form11HospitalesPlantilla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHospitales;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lsvPlantilla;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}