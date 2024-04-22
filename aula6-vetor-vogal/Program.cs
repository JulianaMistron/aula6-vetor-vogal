char[] caracteres = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

Console.WriteLine("Vogais: ");

for (int i = 0; i < 10; i++)
{

    if (caracteres[i] == 'a' || caracteres[i] == 'e' || caracteres[i] == 'i' || caracteres[i] == 'o' || caracteres[i] == 'u')
        Console.Write(caracteres[i] + " ");
}
Console.WriteLine("\n");

Console.WriteLine("Consoantes: ");
for (int i = 0; i < 10; i++)
{

    if (caracteres[i] != 'a' && caracteres[i] != 'e' && caracteres[i] != 'i' && caracteres[i] != 'o' && caracteres[i] != 'u')
        Console.Write(caracteres[i] + " ");
}
