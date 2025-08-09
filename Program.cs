using System;

// Clase que representa un libro
public class Libro
{
    // Atributos de la clase Libro
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int AnioEdicion { get; set; }

    // Constructor de la clase Libro
    public Libro(string nombre, string autor, int anioEdicion)
    {
        this.Nombre = nombre;
        this.Autor = autor;
        this.AnioEdicion = anioEdicion;
    }

    // Propiedades para acceder a los atributos
    public string nombre
    {
        get => Nombre;
        set => Nombre = value;
    }

    public string autor
    {
        get => Autor;
        set => Autor = value;
    }

    public int anioEdicion
    {
        get => AnioEdicion;
        set
        {
            if (value > 0)
            {
                AnioEdicion = value;
            }
            else
            {
                throw new ArgumentException("El año de edición debe ser válido.");
            }
        }
    }

    // Método para mostrar la información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Nombre}, Autor: {Autor}, Año de Edición: {AnioEdicion}");
    }

    // Método para evaluar si el libro tiene menos de un año de antigüedad
    public bool EsReciente()
    {
        int anioEdicion = 1997; // Valor por defecto para evitar errores
        int anioAntiguedad = DateTime.Now.Year;
        return (anioAntiguedad - anioEdicion) < 1;
    }
}

// Código para evaluar un libro según su año de edición
public class Program
{
    public static void Main(string[] args)
    {
        var miLibro = new Libro("Programación Moderna", "Ismael", 2025);
        miLibro.MostrarInformacion();

        if (miLibro.EsReciente())
        {
            Console.WriteLine("El libro es reciente (menos de un año de antigüedad).");
        }
        else
        {
            Console.WriteLine("El libro no es reciente.");
        }
    }
}