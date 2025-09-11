# Practicas-Septiembre
# Practicas-Septiembre
# Practicas-Septiembre
Usare este como el lugar donde agregar las areas en las que notamos que te falta entendimiento;

------------------------------------------------------------------RETURN-----------------------------------------------------
Primero, o al menos de lo que recuerdo, *el return*
Me gustaría que si tuvieras que pensar en una traducción directa, no pensaras en "regresar" o "retornar" 
si no en escupir, escupir un resultado, Para explicar mejor, me aproximare de manera mas técnica.
 * *return* devuelve (escupe) un valor desde los metodos/funciones o las propiedades.
   Un ejemplo sencillo sería
int Sumar(int a, int b)
{
    return a + b;  // devuelve el resultado
}
Aquí return hace que él metodo escupa su resultado
int resultado = Sumar(3, 4); 
el resultado ahora vale 7
Dato a tomar en cuenta; cuando llega un return, el método termina inmediatamente. No ejecuta nada más que esté después.

-----------------------------------------------------------------ARRAY----------------------------------------------------------
1. Declaracion
   // Declaración vacía (sin tamaño aún)
   int[] numeros;

   // Declaración con tamaño fijo (pero vacío) ¿recuerdas? esta ya la usamos
   int[] numeros = new int[5]; // tiene 5 elementos inicializados en 0

2. Inicializacion (maneras de meter valores)
   * La primera y mas usada, es la de meter manualmente los valores y jugar con
   ellos uno por uno, accediando a ellos con numero de celda
   int[] numeros = new int[3]; <-- Aquí estoy declarando, no forma parte de la
   inicialiazacion
   numeros[0] = 10; -|
   numeros[1] = 20;  | Esto sí, así se les asigna valores manualmente
   numeros[2] = 30; -|

   * Inicializacion directa con llaves
      int[] numeros = { 10, 20, 30 };

   *Inicializacion en el new
      int[] numeros = new int[] { 10, 20, 30 };

   3. Las maneras de reccorerlo o acceder/llamar a todas sus celdas de una

---------------------------------------------------------------GET---------------------------------------------------------------
Veras en propiedades mas avanzadas que tanto get como set son muy parecidos a metodos, de hecho como toque el tema antes, 
también son capaces de usar el return. 
La propiedad que describe mejor a las propiedades en si mismas es la de ser metodos que pueden calcular, validar o transformar datos 
antes de devolverlos. Tu solo haz visto get; 
pero se pueden hacer cosas bastantes cool con eso, por ejemplo, calcular desde la propiedad: 
public class Rectangulo
{
    public double Ancho { get; set; }
    public double Alto { get; set; }
°
    public double Area
    {
        get { return Ancho * Alto; } // se calcula cada vez que se pide
    }
}

Ya vimos hacer calculos, ahora podemos usarlo para simplemente modificar datos: 
public class Usuario
{
    private string nombre;
°
    public string Nombre
    {
        get { return nombre.ToUpper(); } // siempre en mayúsculas
        set { nombre = value; }
    }
}
Hay realmente muchos usos, bastantes, digo, casi cualquier comportamiento especial de una variable, solo quiero que sepas que puedes meter cosas 
ahí, for, condicionales, hacer que todo sean mayusculas, por ejemplo: 
public class Persona
{
    public DateTime FechaNacimiento { get; set; }
°
    public int Edad
    {
        get
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }
    }
   var p = new Persona { FechaNacimiento = new DateTime(2000, 9, 10) };
   Console.WriteLine(p.Edad); // calcula automáticamente la edad
}
Esto esta complejo, no pretendo que lo super entiendas en sí, si no que entiendas todo lo que se puede hacer con Get
   

