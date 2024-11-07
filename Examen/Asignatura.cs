using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Asignatura
    {
    }

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
