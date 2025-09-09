public class Alumnos
{
    public string Nombre { get; set; }
    public float Calificacion1 { get; set; }
    public float Calificacion2 { get; set; }
    public float Calificacion3 { get; set; }

    public Alumnos(string nombre, float calificacion1, float calificacion2, float calificacion3)
    {
        Nombre = nombre;
        Calificacion1 = calificacion1;
        Calificacion2 = calificacion2;
        Calificacion3 = calificacion3;
    }

    public void AlumCalif()
    {
        Console.WriteLine($"Nombre: {Nombre}, Español: {Calificacion1}, Matematicas: {Calificacion2}, Ingles: {Calificacion3}");
        float CaliFinal = (Calificacion1 + Calificacion2 + Calificacion3) / 3;
        Console.WriteLine("Calificacion Final: " + CaliFinal);
    }
}
public class Calificaciones
{
    public List<Alumnos> alumnos = new List<Alumnos>();

    public void Registrar()
    {
        Console.WriteLine("Nombre del alumno:");
        string Nombre1 = Console.ReadLine();
        Console.WriteLine("Calificacion de Español:");
        float Calificacion_1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Calificacion de Matematicas:");
        float Calificacion_2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Calificacion de Ingles:");
        float Calificacion_3 = float.Parse(Console.ReadLine());
        alumnos.Add(new(Nombre1, Calificacion_1, Calificacion_2, Calificacion_3));
        Console.WriteLine("Guardado.");
    }

    public void MostrarAlumnos()
    {
        Console.WriteLine("Alumnos registrados");
        if (alumnos.Count == 0)
        {
            Console.WriteLine("No hay alumnos regsitrados");
            return;
        }
        foreach (var Lista in alumnos)
        {
            Lista.AlumCalif();
        }
    }
    public void AprobYReprob()
    {
        
    }
}
class Program
{
    static void Main(string[] argm)
    {
        Calificaciones calif = new Calificaciones();
        bool volverMenu = true;
        while (volverMenu)
        {
            Console.WriteLine("PORTAL DE ALUMNOS");
            Console.WriteLine("1. Registro");
            Console.WriteLine("2. Alumnos y Calificaciones");
            Console.WriteLine("3. Aprobados y Reprobrados");
            Console.WriteLine("4. Salir");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    calif.Registrar();
                    break;
                case "2":
                    calif.MostrarAlumnos();
                    break;
                case "3":

                    break;
                case "4":
                    Console.Write("Saliendo...");
                    volverMenu = false;
                    break;
                default:
                    Console.WriteLine("No es una opcion");
                    break;
            }
        }
    }
}