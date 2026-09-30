class Pessoa
{
    public Pessoa() {
        Console.WriteLine("HELLO , WORD");
    }

    public Pessoa (string nome)
    {
        Console.WriteLine($"ola,{nome}");
    }


    public Pessoa (string nome , int idade)
    {
        Console.WriteLine($" ola seu nome e {nome} e sua idade e {idade}");
    }
}
