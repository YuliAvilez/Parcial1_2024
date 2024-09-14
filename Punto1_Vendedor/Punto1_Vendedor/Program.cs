using System;

public class Program
{
    static void Main(string[] args)
    {
        //Asignación de Variables
        double sueldoBase = 2000000, Comision = 0.10, Comision1 = 0, Comision2 = 0, Comision3, TotalComisiones, VlorTotalVenta, ValorVenta1, ValorVenta2,ValorVenta3, VentaMayor, PromedioComisiones, totalRecibido;
        double Beneficioextra = 100.000, objetivo = 1000000;
        bool False;


        Console.Write("Ingrese el valor de la primera venta: $");
        ValorVenta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la segunda venta: $");
        ValorVenta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la tercera venta: $");
        ValorVenta3 = Convert.ToDouble(Console.ReadLine());

        Comision1 = ValorVenta1 * Comision;
        Comision2 = ValorVenta2 * Comision;
        Comision3 = ValorVenta3 * Comision;

        TotalComisiones = Comision1 + Comision2 + Comision3;  
        
        totalRecibido = sueldoBase + TotalComisiones;



        














    }
}