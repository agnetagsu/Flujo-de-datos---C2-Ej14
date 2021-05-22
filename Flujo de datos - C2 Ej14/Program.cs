using System;


namespace Flujo_de_datos___C2_Ej14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double radio;
            double area;

            Console.WriteLine("Introduce el radio:");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radio * radio;
            Console.WriteLine("El área es "+ area);
        }
    }
}
