
namespace Examen
{                             //CLASE HIJA
    public class Asignatura :Alumno,  IAsignatura//HERENCIA
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
            throw new NotImplementedException();
        }

        public string MensajeNotaFinal(double NotaFinal)
        {
            
        }
        public void Imprimir(string NombreAlumno)
        {
            Console.WriteLine();
            Console.WriteLine($"{NombreAlumno}");
        }
    }
}



