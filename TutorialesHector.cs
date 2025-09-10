public class Alumnos
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; } /*Cuando llamemos la variable "Nombre", mostrara para lectura, el
        contenido de "nombre". "Nombre" crea una copia inmediata de lo que hay en "nombre" y 
        esta es la que se modifica y lee, get y set son propiedades, como puertas para el 
        acceso a la lectura y sobre escritura de la variable original, algo así como un 
        clon desechable, pero que pueden poner trabas y en general maneras dd*/

        set
        {
            if (value == null)
            {
                Console.WriteLine("El nombre no puede estar vació.");
            }
            else
            {
                nombre = value.Trim();
            }
        }
    }
    private List<double> calificaciones = new List<double>();

    public List<double> Calificaciones
    {
        get { return calificaciones; }
    }
    //Promedio mas que ser un valor pedido antes de la ejecucion, es un valor creado DURANTE
    //la ejecucion, no necesita que haya datos guardados de antes
    public double Promedio
    {
        get
        {
            if (calificaciones.Count == 0) return 0; //Si la lista de calificaciones es 0, o sea nula, lo unico que imprimira es 0
            
        }
    }
}
public class Calificaciones
    {
        public List<Alumnos> alumnos = new List<Alumnos>();

        public void Registrar()
        {
            Console.WriteLine("Nombre del alumno:");
            string Nombre1 = Console.ReadLine();
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