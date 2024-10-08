using GestionInfoPersonal.Properties;

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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
