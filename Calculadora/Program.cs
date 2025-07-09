// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese operador (+, -, *, /):");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool error = false;

            switch (op)
            {
                case '+': resultado = num1 + num2; break;
                case '-': resultado = num1 - num2; break;
                case '*': resultado = num1 * num2; break;
                case '/':
                    if (num2 != 0) resultado = num1 / num2;
                    else { Console.WriteLine("Error: División por cero."); error = true; }
                    break;
                default: Console.WriteLine("Operador inválido."); error = true; break;
            }

            if (!error) Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine("¿Continuar? (s/n)");
            continuar = Console.ReadLine().ToLower() == "s";
        }
    }
}
