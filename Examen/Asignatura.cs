using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    //CLASE HIJA
    public class Asignatura : Alumno, IAsignatura//HERENCIA
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public string N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }


        public double CalcularNotaFinal()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de la cuenta: {NumeroCuenta}");
            Console.WriteLine($"correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase:: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");

        }


        public string MensajeNotaFinal(double NotaFinal)
        {
            throw new NotImplementedException();
        }
    }
}