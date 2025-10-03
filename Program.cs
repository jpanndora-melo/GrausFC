Console.Write("Digite a temperatura em Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());
double celsius = (fahrenheit - 32) / 1.8;
Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");

