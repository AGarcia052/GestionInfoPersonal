using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfoPersonal
{
    internal class Resumen
    {
        String Nombre { get; set; }
        String Direccion { get;set; }

        String Correo { get; set; }

        String Genero { get; set; }

        String FechaNac {  get; set; }

        int Edad {  get; set; }

        bool SuscritoBoletin {  get; set; }

        bool AceptaTermCondiciones {  get; set; }

        List<String> Hobbies { get; set; }

        String Pais {  get; set; }




    }
}
