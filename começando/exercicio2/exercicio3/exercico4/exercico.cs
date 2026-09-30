class ContaBancaria
{
    public string? Titular;
    public double Saldo;

    public int NumeroConta;


    public void Depositar(double valordepositado)
    {
      
        Console.WriteLine($"foram depositados{valordepositado} ");

        Saldo = Saldo + valordepositado;
        
        
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
        else
        {
            Saldo -= valor;
        }

        Console.WriteLine($"Foram sacados {valor}");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo}");
    }

   
}