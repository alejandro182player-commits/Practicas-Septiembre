public class Contacto
{
    public string Nombre { get; set; }
    public string Numero { get; set; }

    public Contacto(string nombre, string numero)
    {
        Nombre = nombre;
        Numero = numero;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre}, Numero: {Numero}");
    }
}
public class Agenda
{
    public List<Contacto> contactos = new List<Contacto>();

    public void Agregar()
    {
        Console.WriteLine("Escribe un nombre: ");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("Escribe un numero: ");
        string numero1 = Console.ReadLine();
        contactos.Add(new(nombre1, numero1));
        Console.WriteLine("Guardado.");
    }

    public void MostrarLista()
    {
        Console.WriteLine("Contactos Guardados");
        if (contactos.Count == 0)
        {
            Console.WriteLine("No hay contactos guardados");
            return;
        }
        Console.WriteLine("Tus contactos");
        foreach (var Lista in contactos)
        {
            //Tu quieres meter un valor de aquí en un lugar ¿que es perfecto para eso? Mostrar() solo tiene un Console.WriteLine que tiene solo
            //un valor por ciclo?
            Lista.Mostrar();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Agenda agen = new Agenda();
        bool volverMenu = true;

        while (volverMenu)
        {
            Console.WriteLine("¡¡AGENDA DE CONTACTOS!!");
            Console.WriteLine("1. Agregar contacto.");//le falta
            Console.WriteLine("2. Mostrar los contactos.");//Le falta mas jaja
            Console.WriteLine("3. Salir");//Completado
            Console.WriteLine("Elige una opcion");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    agen.Agregar();
                    break;
                case "2":
                    agen.MostrarLista();
                    break;
                case "3":
                    Console.WriteLine("Adios...");
                    volverMenu = false;
                    break;
                default:
                    Console.WriteLine("ERROR DE OPCION");
                    break;
            }
        }
    }
}