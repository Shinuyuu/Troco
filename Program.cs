void Shin (int fun)
{
     if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
}
void barra()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("<=============================>");
}
Console.Clear();


Console.WriteLine("Qual o valor que você tem no cartão?");
decimal valor_Usuario= Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Qual o valor do produto?");
decimal valor_Preco= Convert.ToDecimal(Console.ReadLine());
decimal Troco= valor_Usuario-valor_Preco;

Console.Clear();
barra();
Shin(0);
Console.WriteLine("|======   Nota  Fiscal  ======|");
barra();
Shin(0);
Console.WriteLine($"| Seu cartão de débito: {Convert.ToString(valor_Usuario).PadRight(5,'.')} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Preço do produto: {Convert.ToString(valor_Preco).PadRight(9,'.')} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Seu troco: {Convert.ToString(Troco).PadRight(16,'.')} |"); // 18 pontos.
barra(); 
Console.ResetColor();
