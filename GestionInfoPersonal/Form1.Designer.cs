namespace GestionInfoPersonal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbCPrincipal = new TabControl();
            tbPDatos = new TabPage();
            lblFechaNac = new Label();
            lblEdad = new Label();
            numUPEdad = new NumericUpDown();
            mthCFechaNacimiento = new MonthCalendar();
            pnlGenero = new Panel();
            lblGenero = new Label();
            rboOtro = new RadioButton();
            rboHombre = new RadioButton();
            rboMujer = new RadioButton();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            tbPPreferencias = new TabPage();
            tbPVisualizacion = new TabPage();
            tbCPrincipal.SuspendLayout();
            tbPDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUPEdad).BeginInit();
            pnlGenero.SuspendLayout();
            SuspendLayout();
            // 
            // tbCPrincipal
            // 
            tbCPrincipal.Controls.Add(tbPDatos);
            tbCPrincipal.Controls.Add(tbPPreferencias);
            tbCPrincipal.Controls.Add(tbPVisualizacion);
            tbCPrincipal.Location = new Point(25, 12);
            tbCPrincipal.Name = "tbCPrincipal";
            tbCPrincipal.SelectedIndex = 0;
            tbCPrincipal.Size = new Size(741, 405);
            tbCPrincipal.TabIndex = 0;
            // 
            // tbPDatos
            // 
            tbPDatos.Controls.Add(lblFechaNac);
            tbPDatos.Controls.Add(lblEdad);
            tbPDatos.Controls.Add(numUPEdad);
            tbPDatos.Controls.Add(mthCFechaNacimiento);
            tbPDatos.Controls.Add(pnlGenero);
            tbPDatos.Controls.Add(txtCorreo);
            tbPDatos.Controls.Add(txtDireccion);
            tbPDatos.Controls.Add(txtNombre);
            tbPDatos.Controls.Add(lblCorreo);
            tbPDatos.Controls.Add(lblDireccion);
            tbPDatos.Controls.Add(lblNombre);
            tbPDatos.Location = new Point(4, 29);
            tbPDatos.Name = "tbPDatos";
            tbPDatos.Padding = new Padding(3);
            tbPDatos.Size = new Size(733, 372);
            tbPDatos.TabIndex = 0;
            tbPDatos.Text = "Datos Personales";
            tbPDatos.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(551, 124);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(128, 20);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(501, 34);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // numUPEdad
            // 
            numUPEdad.Location = new Point(571, 27);
            numUPEdad.Name = "numUPEdad";
            numUPEdad.Size = new Size(150, 27);
            numUPEdad.TabIndex = 9;
            numUPEdad.ValueChanged += numUPEdad_ValueChanged;
            // 
            // mthCFechaNacimiento
            // 
            mthCFechaNacimiento.Location = new Point(501, 153);
            mthCFechaNacimiento.Name = "mthCFechaNacimiento";
            mthCFechaNacimiento.TabIndex = 8;
            mthCFechaNacimiento.TodayDate = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // pnlGenero
            // 
            pnlGenero.BorderStyle = BorderStyle.FixedSingle;
            pnlGenero.Controls.Add(lblGenero);
            pnlGenero.Controls.Add(rboOtro);
            pnlGenero.Controls.Add(rboHombre);
            pnlGenero.Controls.Add(rboMujer);
            pnlGenero.Location = new Point(33, 163);
            pnlGenero.Name = "pnlGenero";
            pnlGenero.Size = new Size(220, 145);
            pnlGenero.TabIndex = 7;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(3, 18);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(60, 20);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Género:";
            // 
            // rboOtro
            // 
            rboOtro.AutoSize = true;
            rboOtro.Location = new Point(98, 100);
            rboOtro.Name = "rboOtro";
            rboOtro.Size = new Size(60, 24);
            rboOtro.TabIndex = 2;
            rboOtro.TabStop = true;
            rboOtro.Text = "Otro";
            rboOtro.UseVisualStyleBackColor = true;
            // 
            // rboHombre
            // 
            rboHombre.AutoSize = true;
            rboHombre.Location = new Point(98, 18);
            rboHombre.Name = "rboHombre";
            rboHombre.Size = new Size(97, 24);
            rboHombre.TabIndex = 0;
            rboHombre.TabStop = true;
            rboHombre.Text = "Masculino";
            rboHombre.UseVisualStyleBackColor = true;
            // 
            // rboMujer
            // 
            rboMujer.AutoSize = true;
            rboMujer.Location = new Point(98, 59);
            rboMujer.Name = "rboMujer";
            rboMujer.Size = new Size(95, 24);
            rboMujer.TabIndex = 1;
            rboMujer.TabStop = true;
            rboMujer.Text = "Femenino";
            rboMujer.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(205, 115);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(242, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(205, 70);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(242, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(205, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(33, 122);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(132, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(33, 70);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tbPPreferencias
            // 
            tbPPreferencias.Location = new Point(4, 29);
            tbPPreferencias.Name = "tbPPreferencias";
            tbPPreferencias.Padding = new Padding(3);
            tbPPreferencias.Size = new Size(733, 372);
            tbPPreferencias.TabIndex = 1;
            tbPPreferencias.Text = "Preferencias";
            tbPPreferencias.UseVisualStyleBackColor = true;
            // 
            // tbPVisualizacion
            // 
            tbPVisualizacion.Location = new Point(4, 29);
            tbPVisualizacion.Name = "tbPVisualizacion";
            tbPVisualizacion.Size = new Size(733, 372);
            tbPVisualizacion.TabIndex = 2;
            tbPVisualizacion.Text = "Visualización";
            tbPVisualizacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(tbCPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "FormPrincipal";
            tbCPrincipal.ResumeLayout(false);
            tbPDatos.ResumeLayout(false);
            tbPDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUPEdad).EndInit();
            pnlGenero.ResumeLayout(false);
            pnlGenero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCPrincipal;
        private TabPage tbPDatos;
        private TabPage tbPPreferencias;
        private TabPage tbPVisualizacion;
        private RadioButton rboOtro;
        private RadioButton rboMujer;
        private RadioButton rboHombre;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblNombre;
        private Panel pnlGenero;
        private Label lblGenero;
        private NumericUpDown numUPEdad;
        private MonthCalendar mthCFechaNacimiento;
        private Label lblEdad;
        private Label lblFechaNac;
    }
}
