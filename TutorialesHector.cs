public class Contacto
{
    public string Nombre { get; set; }
    public string Numero { get; set; }

    public Contacto(string nombre, string numero)
    {
        Nombre = nombre;
        Numero = numero;
    }

    public void MostrarContacto()
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
}
class program
{
    static void Main(string[] args)
    {

        Contacto cont = new Contacto("pedro", "856542212");
        Agenda agen = new Agenda();
        Console.WriteLine("¡¡AGENDA DE CONTACTOS!!");
        Console.WriteLine("1. Agregar contacto.");
        Console.WriteLine("2. Mostrar los contactos.");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Elige una opcion");

        string opcion = Console.ReadLine();
    }
}