public class Pesssoa
{
    public string? Nome;
    public int Idade;

    public void Apresentacao()
    {
    Console.WriteLine($"meu nome é {Nome}");
    }

    public string VerificarID()
    {
        return Idade >=18 ? "Maior de idade " : "Menor de idade";
    }
}