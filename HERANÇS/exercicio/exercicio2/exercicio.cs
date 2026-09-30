class Pessoa
{
  public string? nome;
  
}

class Casa  
{
  public Pessoa morador;

  public Casa()
  {
    morador = new Pessoa();
  }

    public void exibirmorador(){

    
    Console.WriteLine($"Nome: {morador.nome}");
  }
  
}
