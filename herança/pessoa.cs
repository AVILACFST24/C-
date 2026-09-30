class Pessoa
{
   private string? _nome;
   private int _idade;
   public Pessoa(string nome ,  int idade)
    {
        _nome= nome;
        _idade = idade;
    }
   protected void apresentar()
    {
        Console.WriteLine($"seu nome e {_nome}");
        Console.WriteLine($"sua idade  e {_idade}");
    }
}