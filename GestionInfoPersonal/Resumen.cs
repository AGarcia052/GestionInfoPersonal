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

        string SuscritoBoletin {  get; set; }

        string AceptaTermCondiciones {  get; set; }

        String Hobbies { get; set; }

        String Pais {  get; set; }

        public Resumen(string nombre, string direccion, string correo, string genero, string fechaNac, int edad,
            string suscritoBoletin, string aceptaTerm, String hobbies, string pais)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Genero = genero;
            this.FechaNac = fechaNac;
            this.Edad = edad;
            this.SuscritoBoletin = suscritoBoletin;
            this.AceptaTermCondiciones = aceptaTerm;
            this.Hobbies = hobbies;
            this.Pais = pais;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n" + "Dirección: " + Direccion + "\n" + "Correo: " + Correo + "\n" +
                "Género: " + Genero + "\n" + "Fecha Nacimiento: " + FechaNac + "\n" + "Edad: " + Edad + "\n" +
                 SuscritoBoletin + "\n" + AceptaTermCondiciones +"\n"+ "Hobbies: " + Hobbies + "\n" + "País: " + Pais + "\n";
        }
    }
}
