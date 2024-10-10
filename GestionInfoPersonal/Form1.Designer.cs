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
            components = new System.ComponentModel.Container();
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
            lblPuntuacion = new Label();
            lblPuntuaciónForm = new Label();
            lblPais = new Label();
            lblHobbies = new Label();
            trkPuntuacion = new TrackBar();
            cmbPais = new ComboBox();
            chLBHobbies = new CheckedListBox();
            chBTerminos = new CheckBox();
            chBSuscripcion = new CheckBox();
            tbPVisualizacion = new TabPage();
            lblFechaHora = new Label();
            picImgPerfil = new PictureBox();
            timerFecha = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblGuardar = new Label();
            tbCPrincipal.SuspendLayout();
            tbPDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUPEdad).BeginInit();
            pnlGenero.SuspendLayout();
            tbPPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkPuntuacion).BeginInit();
            tbPVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImgPerfil).BeginInit();
            SuspendLayout();
            // 
            // tbCPrincipal
            // 
            tbCPrincipal.Controls.Add(tbPDatos);
            tbCPrincipal.Controls.Add(tbPPreferencias);
            tbCPrincipal.Controls.Add(tbPVisualizacion);
            tbCPrincipal.Location = new Point(22, 9);
            tbCPrincipal.Margin = new Padding(3, 2, 3, 2);
            tbCPrincipal.Name = "tbCPrincipal";
            tbCPrincipal.SelectedIndex = 0;
            tbCPrincipal.Size = new Size(648, 304);
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
            tbPDatos.Location = new Point(4, 24);
            tbPDatos.Margin = new Padding(3, 2, 3, 2);
            tbPDatos.Name = "tbPDatos";
            tbPDatos.Padding = new Padding(3, 2, 3, 2);
            tbPDatos.Size = new Size(640, 276);
            tbPDatos.TabIndex = 0;
            tbPDatos.Text = "Datos Personales";
            tbPDatos.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(482, 93);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(103, 15);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(438, 26);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // numUPEdad
            // 
            numUPEdad.Location = new Point(500, 20);
            numUPEdad.Margin = new Padding(3, 2, 3, 2);
            numUPEdad.Name = "numUPEdad";
            numUPEdad.Size = new Size(131, 23);
            numUPEdad.TabIndex = 9;
            numUPEdad.ValueChanged += numUPEdad_ValueChanged;
            // 
            // mthCFechaNacimiento
            // 
            mthCFechaNacimiento.Location = new Point(438, 115);
            mthCFechaNacimiento.Margin = new Padding(8, 7, 8, 7);
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
            pnlGenero.Location = new Point(29, 122);
            pnlGenero.Margin = new Padding(3, 2, 3, 2);
            pnlGenero.Name = "pnlGenero";
            pnlGenero.Size = new Size(193, 109);
            pnlGenero.TabIndex = 7;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(3, 14);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Género:";
            // 
            // rboOtro
            // 
            rboOtro.AutoSize = true;
            rboOtro.Location = new Point(86, 75);
            rboOtro.Margin = new Padding(3, 2, 3, 2);
            rboOtro.Name = "rboOtro";
            rboOtro.Size = new Size(49, 19);
            rboOtro.TabIndex = 2;
            rboOtro.TabStop = true;
            rboOtro.Text = "Otro";
            rboOtro.UseVisualStyleBackColor = true;
            // 
            // rboHombre
            // 
            rboHombre.AutoSize = true;
            rboHombre.Location = new Point(86, 14);
            rboHombre.Margin = new Padding(3, 2, 3, 2);
            rboHombre.Name = "rboHombre";
            rboHombre.Size = new Size(80, 19);
            rboHombre.TabIndex = 0;
            rboHombre.TabStop = true;
            rboHombre.Text = "Masculino";
            rboHombre.UseVisualStyleBackColor = true;
            // 
            // rboMujer
            // 
            rboMujer.AutoSize = true;
            rboMujer.Location = new Point(86, 44);
            rboMujer.Margin = new Padding(3, 2, 3, 2);
            rboMujer.Name = "rboMujer";
            rboMujer.Size = new Size(78, 19);
            rboMujer.TabIndex = 1;
            rboMujer.TabStop = true;
            rboMujer.Text = "Femenino";
            rboMujer.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(179, 86);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(212, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(179, 52);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(212, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 20);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(29, 92);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(29, 52);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(29, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tbPPreferencias
            // 
            tbPPreferencias.Controls.Add(lblPuntuacion);
            tbPPreferencias.Controls.Add(lblPuntuaciónForm);
            tbPPreferencias.Controls.Add(lblPais);
            tbPPreferencias.Controls.Add(lblHobbies);
            tbPPreferencias.Controls.Add(trkPuntuacion);
            tbPPreferencias.Controls.Add(cmbPais);
            tbPPreferencias.Controls.Add(chLBHobbies);
            tbPPreferencias.Controls.Add(chBTerminos);
            tbPPreferencias.Controls.Add(chBSuscripcion);
            tbPPreferencias.Location = new Point(4, 24);
            tbPPreferencias.Margin = new Padding(3, 2, 3, 2);
            tbPPreferencias.Name = "tbPPreferencias";
            tbPPreferencias.Padding = new Padding(3, 2, 3, 2);
            tbPPreferencias.Size = new Size(640, 276);
            tbPPreferencias.TabIndex = 1;
            tbPPreferencias.Text = "Preferencias";
            tbPPreferencias.UseVisualStyleBackColor = true;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.Location = new Point(476, 164);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(54, 19);
            lblPuntuacion.TabIndex = 9;
            // 
            // lblPuntuaciónForm
            // 
            lblPuntuaciónForm.AutoSize = true;
            lblPuntuaciónForm.Location = new Point(36, 165);
            lblPuntuaciónForm.Name = "lblPuntuaciónForm";
            lblPuntuaciónForm.Size = new Size(129, 15);
            lblPuntuaciónForm.TabIndex = 7;
            lblPuntuaciónForm.Text = "Puntuación Formulario";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(36, 118);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 6;
            lblPais.Text = "País";
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Location = new Point(36, 47);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(51, 15);
            lblHobbies.TabIndex = 5;
            lblHobbies.Text = "Hobbies";
            // 
            // trkPuntuacion
            // 
            trkPuntuacion.Location = new Point(192, 150);
            trkPuntuacion.Margin = new Padding(3, 2, 3, 2);
            trkPuntuacion.Name = "trkPuntuacion";
            trkPuntuacion.Size = new Size(269, 45);
            trkPuntuacion.TabIndex = 4;
            trkPuntuacion.Scroll += trkPuntuacion_Scroll;
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "España", "Honduras", "Nicaragua", "Guatemala" });
            cmbPais.Location = new Point(192, 112);
            cmbPais.Margin = new Padding(3, 2, 3, 2);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(133, 23);
            cmbPais.TabIndex = 3;
            // 
            // chLBHobbies
            // 
            chLBHobbies.FormattingEnabled = true;
            chLBHobbies.Items.AddRange(new object[] { "Fútbol", "Senderismo", "Películas", "Fiesta" });
            chLBHobbies.Location = new Point(192, 16);
            chLBHobbies.Margin = new Padding(3, 2, 3, 2);
            chLBHobbies.Name = "chLBHobbies";
            chLBHobbies.Size = new Size(132, 76);
            chLBHobbies.TabIndex = 8;
            // 
            // chBTerminos
            // 
            chBTerminos.AutoSize = true;
            chBTerminos.Location = new Point(36, 239);
            chBTerminos.Margin = new Padding(3, 2, 3, 2);
            chBTerminos.Name = "chBTerminos";
            chBTerminos.Size = new Size(246, 19);
            chBTerminos.TabIndex = 1;
            chBTerminos.Text = "Acepto los términos y condiciones de uso";
            chBTerminos.UseVisualStyleBackColor = true;
            // 
            // chBSuscripcion
            // 
            chBSuscripcion.AutoSize = true;
            chBSuscripcion.Location = new Point(36, 210);
            chBSuscripcion.Margin = new Padding(3, 2, 3, 2);
            chBSuscripcion.Name = "chBSuscripcion";
            chBSuscripcion.Size = new Size(180, 19);
            chBSuscripcion.TabIndex = 0;
            chBSuscripcion.Text = "Acepto suscribirme al boletín";
            chBSuscripcion.UseVisualStyleBackColor = true;
            // 
            // tbPVisualizacion
            // 
            tbPVisualizacion.Controls.Add(lblFechaHora);
            tbPVisualizacion.Controls.Add(picImgPerfil);
            tbPVisualizacion.Location = new Point(4, 24);
            tbPVisualizacion.Margin = new Padding(3, 2, 3, 2);
            tbPVisualizacion.Name = "tbPVisualizacion";
            tbPVisualizacion.Size = new Size(640, 276);
            tbPVisualizacion.TabIndex = 2;
            tbPVisualizacion.Text = "Visualización";
            tbPVisualizacion.UseVisualStyleBackColor = true;
            // 
            // lblFechaHora
            // 
            lblFechaHora.Location = new Point(425, 28);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(186, 19);
            lblFechaHora.TabIndex = 1;
            // 
            // picImgPerfil
            // 
            //picImgPerfil.Image = Properties.Resources.PERFIL_VACIO;
            picImgPerfil.Location = new Point(28, 130);
            picImgPerfil.Margin = new Padding(3, 2, 3, 2);
            picImgPerfil.Name = "picImgPerfil";
            picImgPerfil.Size = new Size(160, 134);
            picImgPerfil.TabIndex = 0;
            picImgPerfil.TabStop = false;
            // 
            // timerFecha
            // 
            timerFecha.Enabled = true;
            timerFecha.Interval = 1000;
            timerFecha.Tick += timerFecha_Tick;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.PaleTurquoise;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(549, 339);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(53, 339);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 34);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(301, 339);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblGuardar
            // 
            lblGuardar.BackColor = SystemColors.Window;
            lblGuardar.Location = new Point(703, 31);
            lblGuardar.Name = "lblGuardar";
            lblGuardar.Size = new Size(220, 282);
            lblGuardar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(965, 412);
            Controls.Add(lblGuardar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(tbCPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "FormPrincipal";
            Load += Form1_Load;
            tbCPrincipal.ResumeLayout(false);
            tbPDatos.ResumeLayout(false);
            tbPDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUPEdad).EndInit();
            pnlGenero.ResumeLayout(false);
            pnlGenero.PerformLayout();
            tbPPreferencias.ResumeLayout(false);
            tbPPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkPuntuacion).EndInit();
            tbPVisualizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImgPerfil).EndInit();
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
        private TrackBar trkPuntuacion;
        private ComboBox cmbPais;
        private CheckedListBox chLBHobbies;
        private CheckBox chBTerminos;
        private CheckBox chBSuscripcion;
        private Label lblPuntuaciónForm;
        private Label lblPais;
        private Label lblHobbies;
        private Label lblPuntuacion;
        private Label label1;
        private PictureBox picBImgPerfil;
        private Label lblFechaHora;
        private PictureBox picImgPerfil;
        private System.Windows.Forms.Timer timerFecha;
        private ToolTip toolTip1;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblGuardar;
    }
}
