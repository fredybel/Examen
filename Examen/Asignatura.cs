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



            if (NotaFinal < 60)
                return "Reprobado";
            else if (NotaFinal < 80)
                return "Bueno";
            else if (NotaFinal < 90)
                return "Muy Bueno";
            else
                return "Sobresaliente";

        }
        

        
        public void Imprimir()
        {
            if (N1 < 0 || N1 > 30 || N2 < 0 || N2 > 30)
            {
                Console.WriteLine("La nota del primer o segundo parcial sobrepasa del 30%");
                
            }
            if (N3 < 0 || N3 > 40)
            {
                Console.WriteLine("La nota del primer o segundo parcial sobrepasa del 40%");
            }

            double NotaFinal = CalcularNotaFinal();
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de la cuenta: {NumeroCuenta}");
            Console.WriteLine($"correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase:: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final:: {CalcularNotaFinal()}-{MensajeNotaFinal(NotaFinal)}");
            Console.WriteLine($"Nota Final:: {CalcularNotaFinal(N1, N2, N3)}-{MensajeNotaFinal(NotaFinal)}");
            Console.WriteLine("***********************************************");



        }
    }
}