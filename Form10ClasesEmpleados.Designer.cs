namespace ProyecyoAdo
{
    partial class Form10ClasesEmpleados
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
            this.cmboficios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvEmpleados = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnIncremento = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // cmboficios
            // 
            this.cmboficios.FormattingEnabled = true;
            this.cmboficios.Location = new System.Drawing.Point(13, 30);
            this.cmboficios.Name = "cmboficios";
            this.cmboficios.Size = new System.Drawing.Size(121, 21);
            this.cmboficios.TabIndex = 1;
            this.cmboficios.SelectedIndexChanged += new System.EventHandler(this.cmboficios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // lsvEmpleados
            // 
            this.lsvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvEmpleados.HideSelection = false;
            this.lsvEmpleados.Location = new System.Drawing.Point(13, 98);
            this.lsvEmpleados.Name = "lsvEmpleados";
            this.lsvEmpleados.Size = new System.Drawing.Size(501, 202);
            this.lsvEmpleados.TabIndex = 3;
            this.lsvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lsvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(332, 30);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 20);
            this.txtIncremento.TabIndex = 5;
            // 
            // btnIncremento
            // 
            this.btnIncremento.Location = new System.Drawing.Point(332, 57);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Size = new System.Drawing.Size(108, 23);
            this.btnIncremento.TabIndex = 6;
            this.btnIncremento.Text = "Incrementar salario";
            this.btnIncremento.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDEMPLEADO";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "APELLIDO";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OFICIO";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SALARIO";
            this.columnHeader4.Width = 124;
            // 
            // Form10ClasesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 330);
            this.Controls.Add(this.btnIncremento);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboficios);
            this.Controls.Add(this.label1);
            this.Name = "Form10ClasesEmpleados";
            this.Text = "Form10ClasesEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboficios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Button btnIncremento;
    }
}