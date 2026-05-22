using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8);
        Alumno a2 = new Alumno(2, "Ana", 9);
        Alumno a3 = new Alumno(3, "Pedro", 7);

        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("LISTA DE ALUMNOS");

        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBUSCAR ALUMNO");

        Alumno buscado = lista.BuscarAlumno("Ana");

        if (buscado != null)
        {
            Console.WriteLine(buscado);
        }

        Alumno noExiste = lista.BuscarAlumno("Carlos");

        if (noExiste == null)
        {
            Console.WriteLine("Carlos -> No existe");
        }

        Console.WriteLine("\nELIMINAR ALUMNO");

        lista.EliminarAlumno(a2);

        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nELIMINAR PRIMER ELEMENTO");

        lista.EliminarAlumnoPorPosicion(0);

        foreach (Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Juan", 8);
        Alumno a2 = new Alumno(2, "Ana", 9);
        Alumno a3 = new Alumno(3, "Pedro", 7);

        diccionario.AgregarAlumno(100, a1);
        diccionario.AgregarAlumno(101, a2);
        diccionario.AgregarAlumno(102, a3);

        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (var alumno in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(alumno.Key + " - " + alumno.Value);
        }

        Console.WriteLine("\nBUSCAR ALUMNO");

        Console.WriteLine(diccionario.BuscarAlumno(101));

        if (diccionario.ObtenerDiccionario().ContainsKey(200))
        {
            Console.WriteLine(diccionario.BuscarAlumno(200));
        }
        else
        {
            Console.WriteLine("Legajo 200 -> No existe");
        }

        Console.WriteLine("\nELIMINAR ALUMNO");

        diccionario.EliminarAlumno(100);

        foreach (var alumno in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine(alumno.Key + " - " + alumno.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        Console.WriteLine(linq.GetPrimero());

        Console.WriteLine("\nULTIMO LIBRO");
        Console.WriteLine(linq.GetUltimo());

        Console.WriteLine("\nTOTAL PRECIOS");
        Console.WriteLine(linq.GetTotalPrecios());

        Console.WriteLine("\nPROMEDIO PRECIOS");
        Console.WriteLine(Math.Round(linq.GetPromedioPrecios(), 2));

        Console.WriteLine("\nLIBROS ID MAYOR A 15");

        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBROS");

        foreach (string libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBRO CON MAYOR PRECIO");
        Console.WriteLine(linq.GetMayorPrecio());

        Console.WriteLine("\nLIBRO CON MENOR PRECIO");
        Console.WriteLine(linq.GetMenorPrecio());

        Console.WriteLine("\nLIBROS CON PRECIO SUPERIOR AL PROMEDIO");

        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLIBROS ORDENADOS DESCENDENTEMENTE POR TÍTULO");

        foreach (Libro libro in linq.GetOrdenadosDesc())
        {
            Console.WriteLine(libro);
        }
    }

}
