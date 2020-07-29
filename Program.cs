using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja 1 - Calcular a temperatura de Celsius para Fahrenheit \r\n ou \r\n 2 - Calcular a temperatura de Fahrenheit para Celsius");

            if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Qual a temperatura em Celcius?");
                    int tc = Convert.ToInt32(Console.ReadLine());
                    double resultf = (1.8 * tc) + 32;
                    resultf = Math.Round(resultf, 0);
                    Console.WriteLine($"A temperatura de {tc} ºC é {resultf} ºF.");

                }

            else
                {
                    Console.WriteLine("Qual a temperatura em Fahrenheit?");
                    int tf = Convert.ToInt32(Console.ReadLine());
                    double resultc = (tf - 32) / 1.8;
                    resultc = Math.Round(resultc, 0);
                    Console.WriteLine($"A temperatura de {tf} ºF é {resultc} ºC.");
                }


        }
    }
}
