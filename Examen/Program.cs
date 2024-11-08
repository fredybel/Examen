using Examen;
try
{
    Asignatura asignatura = new Asignatura();


    //Impresion Atributos (clase Alumno)
    Console.WriteLine("Ingrese el nombre del alumno:");
    asignatura.NombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cuenta:");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese el Correo electrónico:");
    asignatura.Email = Console.ReadLine();


    //Impresion atributos de (asignatura)
    Console.WriteLine("Ingrese el Nombre de la clase:");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese el Horario de la clase:");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese el Nombre del docente:");
    asignatura.NombreDocente = Console.ReadLine();
    Console.WriteLine();


    //Impresion de parciales
    Console.WriteLine("Ingrese nota del primer parcial::");
    asignatura.N1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese nota del primer parcial::");
    asignatura.N2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese nota del primer parcial::");
    asignatura.N3 = Convert.ToInt32(Console.ReadLine());
    //Impresion metodo
    asignatura.Imprimir();


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



