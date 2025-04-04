

Console.Clear();
double logaritmando, b, logaritmo;

Console.WriteLine("----------calculadora de logaritmo----------\n\n");

Console.Write("Base-----:");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");

Console.Write("logaritmando-----:");
logaritmando = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");
logaritmo = Math.Log(logaritmando,b);

Console.WriteLine($"resultado (logaritmo)= {logaritmo:N2}");