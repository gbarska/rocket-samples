Console.WriteLine("Por favor digite a placa de um veiculo:");

var placa = Console.ReadLine();

if (placa != null && placa.Length != 7)
    Console.WriteLine("Placa inválida, o padrão brasileiro de 2018 estabelece qua a placa dever ter 7 caracteres alfanumericos!");
else
for (int i = 0; i < placa.Length; i++)
{
    var caracter = placa[i];

    if(i < 3)
    {
        if (!Char.IsLetter(caracter))
        {
            Console.WriteLine("Placa inválida, o padrão brasileiro de 2018 estabelece qua os 3 primeiros caracteres devem ser letras!");
            break;
        }

    } else
    {
        if (!Char.IsDigit(caracter))
        {
            Console.WriteLine("Placa inválida, o padrão brasileiro de 2018 estabelece qua os 4 ultimos caracteres devem ser numeros!");
            break;
        }
    }

    if(i == 6) Console.WriteLine("A placa é valida de acordo com o padrão brasileiro de 2018");
}
