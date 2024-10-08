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
            tbPPreferencias = new TabPage();
            tbPVisualizacion = new TabPage();
            tbCPrincipal.SuspendLayout();
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
            tbPDatos.Location = new Point(4, 29);
            tbPDatos.Name = "tbPDatos";
            tbPDatos.Padding = new Padding(3);
            tbPDatos.Size = new Size(733, 372);
            tbPDatos.TabIndex = 0;
            tbPDatos.Text = "Datos Personales";
            tbPDatos.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCPrincipal;
        private TabPage tbPDatos;
        private TabPage tbPPreferencias;
        private TabPage tbPVisualizacion;
    }
}
