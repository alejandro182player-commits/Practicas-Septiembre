/// <summary>
/// Esta actividad fue pensada para que practiques: 
/// Clases ✅
/// Propiedades de variables ✅
/// Funciones (metodos con parametros) ✅
/// Uso de operadores ✅
/// Bucles ✅
/// Y ya jeje
/// </summary>
class Contador
{

    public int Cuenta
    {
        get; //Lo puedes leer, donde quieras, cuando quieras 
        private set; //Solo lo puedes cambiar en ESTA CLASE
    }
    //void = vacio, un metodo que no necesita regresar nada, no tiene ningun tipo, ni ningun parametro.
    //Funcion --> Accion 
    // +=
    //Metodo --> Instruccion
    //Incrementar ¿qué es?  
    public void Incrementar(int Incre)
    {
        //NUNCA USE ++
        Cuenta += Incre;
        //Los parametros como "Incre" permiten que sea el usuario quien ponga el valor y no que tu se lo des estaticamente 
    }
    public void Decrementar(int Decre)
    {
        Cuenta -= Decre;
    }
    public void Reiniciar()
    {
        Cuenta = 0;
    }
    public void RepIncremento(int veces, int cantidad) //<-- es parametro cuando esta aca
    {
        for (int i = 0; i < veces; i++)
        {
            Incrementar(cantidad);//<-- es argumento cuando esta aca
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Contador cont = new Contador();
        Console.WriteLine("La cuenta es: " + cont.Cuenta);
        int valor1 = int.Parse(Console.ReadLine());
        cont.Incrementar(valor1);
        Console.WriteLine("La cuenta aumento a: " + cont.Cuenta);
        int valor2 = int.Parse(Console.ReadLine());
        cont.Decrementar(valor2);
        Console.WriteLine("La cuenta bajo a: " + cont.Cuenta);
        int valor3 = int.Parse(Console.ReadLine());
        cont.RepIncremento(valor3, 3);
        Console.WriteLine($"La cuenta incremento a {cont.Cuenta}"); //$ permite quitar el operador y poner el valor entre las comillas
        cont.Reiniciar();
        Console.WriteLine("La cuenta volvio a ser: " + cont.Cuenta);
    }
}