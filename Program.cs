Console.WriteLine("Digite o texto a ser soletrado:");

Console.WriteLine();

string TextoSoletrado = Console.ReadLine()!;

Console.WriteLine("\nSoletrado fica:\n");

Console.WriteLine(string.Join("-",TextoSoletrado.ToUpper().ToCharArray()));

Console.WriteLine();