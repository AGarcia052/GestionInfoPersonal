using GestionInfoPersonal.Properties;
using System.Text;

namespace GestionInfoPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void numUPEdad_ValueChanged(object sender, EventArgs e)
        {
            int edad = (int)numUPEdad.Value;
            mthCFechaNacimiento.SetDate(DateTime.Now.AddYears(-edad));

        }

        private void trkPuntuacion_Scroll(object sender, EventArgs e)
        {
            lblPuntuacion.Text = trkPuntuacion.Value.ToString();
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.toolTip1.SetToolTip(this.picImgPerfil, "Imagen de perfil");
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos del formulario");
            this.toolTip1.SetToolTip(this.btnSalir, "Salir del formulario");
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar y mostrar los datos introducidos");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblGuardar.Text = "";
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            numUPEdad.Value = 0;
            rboHombre.Checked = false;
            rboMujer.Checked = false;
            rboOtro.Checked = false;
            chBSuscripcion.Checked = false;
            chBTerminos.Checked = false;
            cmbPais.SelectedIndex = -1;
            for (int i = 0; i < chLBHobbies.Items.Count; i++)
            {
                chLBHobbies.SetItemChecked(i, false);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string genero;

            if (rboHombre.Checked)
                genero = rboHombre.Text;
            else if (rboMujer.Checked)
                genero = rboMujer.Text;
            else genero = rboOtro.Text;

            string fechaNac = mthCFechaNacimiento.SelectionStart.ToString("dd/MM/yyyy");
            int edad = int.Parse(numUPEdad.Text);
            string suscritoBoletin;
            if (chBSuscripcion.Checked)
                suscritoBoletin = "Suscrito al boletín: Sí";
            else
                suscritoBoletin = "Suscrito al boletín: No";
            string aceptaTerminos;
            if (chBTerminos.Checked)
                aceptaTerminos = "Acepta los términos: Sí";
            else aceptaTerminos = "Acepta los términos: No";

            String hobbies = "";

            foreach (var item in chLBHobbies.CheckedItems)
            {
                hobbies += item.ToString() + ", ";
            }

            string pais = cmbPais.Text;
            Resumen resumen = new Resumen(nombre, direccion, correo, genero, fechaNac, edad, suscritoBoletin, aceptaTerminos, hobbies, pais);

            lblGuardar.Text = resumen.ToString();
        }
    }
}
