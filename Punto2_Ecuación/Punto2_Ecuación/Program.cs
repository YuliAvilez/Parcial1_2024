public class Program
{
    static void Main(string[] args)
    {
     // Asignación de Variables
     double a, b, x=0;
     bool Solucion_Ecuación = false;

        //Pedir datos por teclado
        Console.Write("Por favor ingresa el valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingresa el valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());

        //Evaluación de los valores de X para determinar las soluciones de las ecuaciones
        if (a != 0)
        {
            x = -b / a;
            Solucion_Ecuación = true;
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("La ecuación tiene infinitas soluciones.");
            }
            else
            {
                Console.WriteLine("La ecuación no puede tener solución.");
            }
        }

        if (Solucion_Ecuación)
        {
            Console.WriteLine($"La solución única de la ecuación es x = {x}");
        }
    }
}

//Fin del Juego!!!
