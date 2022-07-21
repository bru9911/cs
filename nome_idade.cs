Console.Write("Digite seu nome :");
string name = Console.ReadLine();
Console.WriteLine($"Olá " {name});
Console.Write("Digie o ano de seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Você tem {age} anos.");


if (age >= 18) Console.WriteLine("Você é maior de idade.");
else if (age == 12) Console.WriteLine("Você tem 12 anos.");
else Console.WriteLine("Você é menor de idade.");
