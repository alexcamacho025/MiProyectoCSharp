Console.Write("Ingresa tu año de nacimiento: ");
int aÑoNacimiento = int.Parse(Console.ReadLine());
Console.Write("Ingresa el año actual: ");
int aÑoActual = int.Parse(Console.ReadLine());
int edad = aÑoActual - aÑoNacimiento;
Console.WriteLine("Tu edad es: " + edad + " años.");