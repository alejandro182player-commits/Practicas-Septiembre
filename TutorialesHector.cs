class Persona
{
    public string Contenido
    {
        get;
        set;
    }

    //El constructor siempre se busca que se llame como la clase
    public Persona(string contenido)
    {
        Contenido = contenido;
        //Los constructores casi siempre se usan para asignar valores al inicializar en un objeto.
        /*Aquí le estamos diciendo que al ser convertido en un objeto (o mas bien, cuando se intente hacer una copia de el, guarde el
        contenido del parametro "contenido" en la variable "Contenido")*/
    }
    public int TextoAnalizar(char caracter) 
    {
        int cuenta = 0;

        foreach (char r in Contenido)
        {
            if (r == caracter)
            {
                cuenta++;
            }
        }
        return cuenta;
    }   
}

class Pepe
{
    //Funcion Main (sting[] args)
    public static void Main(string[] args)
    {
        Persona p = new Persona("Hola a todos");
        /*Un parametro, es como la declaracion de una variable Y un argumento el valor que se le da
        Entonces string contenido <-- PARAMETRO || = "" sería el <-- ARGUMENTO*/
        int LetraConteo = p.TextoAnalizar('r');
        if (LetraConteo >= 1)
        {
            Console.WriteLine($"La letra r se repite {LetraConteo} veces");
        }
        else
        {
            Console.WriteLine("El texto no contiene la letra r");
            Console.WriteLine("Fin");
        }
    }
} //dotnet build

