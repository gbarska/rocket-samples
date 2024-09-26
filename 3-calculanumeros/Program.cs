Console.WriteLine("Por favor digite um numero:");

double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor digite outro numero:");

double numero2 = Convert.ToDouble(Console.ReadLine());

var soma = numero1 + numero2;
var subtracao = numero1 - numero2;
var multiplicacao = numero1 * numero2;

Console.WriteLine($"{numero1} + {numero2} = {soma}");
Console.WriteLine($"{numero1} - {numero2} = {subtracao}");
Console.WriteLine($"{numero1} * {numero2} = {multiplicacao}");

if (numero2 != 0) Console.WriteLine($"{numero1} / {numero2} é {numero1 / numero2}");
else Console.WriteLine("Não foi possivel calcular a divisão pois o segundo numero é zero");

