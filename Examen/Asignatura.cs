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
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }



        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            return N1 + N2 + N3;
        }



        public string MensajeNotaFinal(double NotaFinal)
        {
               
                if (NotaFinal < 60)
                    return "Reprobado";
                if (NotaFinal < 80)
                    return "Bueno";
                if (NotaFinal < 90)
                    return "Muy Bueno";
                return "Sobresaliente";
            
        }
        public void Imprimir()
        {
            double NotaFinal = CalcularNotaFinal();
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de la cuenta: {NumeroCuenta}");
            Console.WriteLine($"correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase:: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final:: {CalcularNotaFinal()}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final:: {NotaFinal}-{MensajeNotaFinal(NotaFinal)}");

            
        }

       
    }
}