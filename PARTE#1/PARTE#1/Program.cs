int numero;
double numeroDecimal;
string texto;
bool booleano;

Console.WriteLine();
Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite un decimal: ");
numeroDecimal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite un texto: ");
texto = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Digite un booleano: ");
booleano = Convert.ToBoolean(Console.ReadLine());


