using Examen;

Asignatura asignatura = new Asignatura();



//Impresion de parciales
Console.WriteLine("Ingrese nota del primer parcial::");
asignatura.N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese nota del primer parcial::");
asignatura.N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese nota del primer parcial::");
asignatura.N3 = Convert.ToInt32(Console.ReadLine());
//Impresion metodo
asignatura.Imprimir();
asignatura.CalcularNotaFinal();
