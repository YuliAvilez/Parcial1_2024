using System;

public class Program
{
    static void Main(string[] args)
    {
        //Asignación de Variables
        double sueldoBase = 2000000, VlorTotalVenta, ValorVenta1, ValorVenta2,ValorVenta3, VentaMayor, PromedioComisiones, totalRecibido;
        double Beneficioextra = 100000, objetivo = 1000000;
        double Comision = 0.10; 
        bool Beneficio = false;


        //Ingreso de Ventas por teclado
        Console.Write("Ingrese el valor de la primera venta: $");
        ValorVenta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la segunda venta: $");
        ValorVenta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la tercera venta: $");
        ValorVenta3 = Convert.ToDouble(Console.ReadLine());

        //Calculo de comisiones
        double Comision1 = ValorVenta1 * Comision;
        double Comision2 = ValorVenta2 * Comision;
        double Comision3 = ValorVenta3 * Comision;

        //Calculo yotal Comisiones
        double TotalComisiones = Comision1 + Comision2 + Comision3;  
        
        //Calculo total sueldo Vendedor
        totalRecibido = sueldoBase + TotalComisiones;

        // Evaluación de la venta Mayor
        if (ValorVenta1 > ValorVenta2)
        {
            if (ValorVenta1 > ValorVenta3)
            {
                VentaMayor = ValorVenta1;
            }
            else
            {
                VentaMayor = ValorVenta3;
            }
        }
        else
        {
            if (ValorVenta2 > ValorVenta3)
            {
                VentaMayor = ValorVenta2;
            }
            else
            {
                VentaMayor = ValorVenta3;

            }
        }

        PromedioComisiones = Comision1 + Comision2 + Comision3 / 3;
        Console.WriteLine($"Comisión por Venta 1: {Comision1}");
        Console.WriteLine($"Comisión por Venta 2: {Comision2}");
        Console.WriteLine($"Comisión por Venta 3: {Comision3}");

        Console.WriteLine($"Total dinero por comisiones:  {TotalComisiones}");
        Console.WriteLine($"Total recibido en el mes (sueldo Base + comisiones): {totalRecibido}");
        Console.WriteLine($"Venta que generó mayor comisión:  {VentaMayor}");
        Console.WriteLine($"Promedio de comisiones por venta: {PromedioComisiones}");

        VlorTotalVenta= ValorVenta1 + ValorVenta2 + ValorVenta3;
        if (VlorTotalVenta >= objetivo)
        {
            Beneficio = true;
        }

        if (Beneficio)
        {
            Console.WriteLine($"Has ganado un beneficio de: ${Beneficioextra}");
        }
        else
        {
            Console.WriteLine("No ganaste beneficio.");
        }

    }
}