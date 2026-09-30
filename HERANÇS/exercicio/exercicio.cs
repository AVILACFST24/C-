class Veiculo
{
    public string? marca;
    public string? modelo;
    public int numeroDeRodas;
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Número de Rodas: {numeroDeRodas}");
    }
}


    class Carro : Veiculo
    {
        public int numeroDePortas;
        public void ExibirInformacoesCarro()
        {
            ExibirInformacoes();
            Console.WriteLine($"Número de Portas: {numeroDePortas}");
        }
    }



    class Moto : Veiculo
    {
        public bool possuibagageiro;
        public void ExibirInformacoesMoto()
        {
            ExibirInformacoes();
            Console.WriteLine($"Possui Bagageiro: {possuibagageiro}");
        }
        
    }
