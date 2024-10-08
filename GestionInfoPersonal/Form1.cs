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
    }
}
