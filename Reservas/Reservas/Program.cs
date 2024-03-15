// See https://aka.ms/new-console-template for more information



using Reservas;

try
{
    string[] nomes = new string[2];

    nomes[0] = "guilherme";
    nomes[1] = "lucas";

    if (nomes.Length == 2)
    {
        throw new LimiteDeReservasException("Limite maximo de reservas");
    }
    nomes[2] = "Mathues";
}

catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    string nome = null;

    Console.WriteLine(nome.Length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Erro ao executar programa");
}

try
{
    Console.WriteLine("Digite um valor");
    string input = Console.ReadLine();
    int valor = 10 / int.Parse(input);
    Console.WriteLine(valor);

}
catch (Exception)
{
    Console.WriteLine("Erro");
}
finally
{
    Console.WriteLine("Fluxo que segue");
}





