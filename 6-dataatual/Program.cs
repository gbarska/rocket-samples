
using System.Globalization;

CultureInfo cultura = new CultureInfo("pt-BR");
var data = DateTime.Now;

Console.WriteLine($"A data atual é {data.ToString("D", cultura)} {data.ToString("HH:mm:ss", cultura)}");
Console.WriteLine($"A data atual é {data.ToString("d", cultura)}");
Console.WriteLine($"A hora atual é {data.ToString("HH", cultura)}");
Console.WriteLine($"A data atual é {data.ToString("dd/MMMM/yyyy", cultura)}");