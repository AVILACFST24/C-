class Produto
{
    public string? Nome;
    public int Quantidade;
    public double Preco;



    public void exibirProduto()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Preço: {Preco}");
    }

    public void calcularValorTotal()
    {
        double valorTotal = Quantidade * Preco;
        Console.WriteLine($"Valor total do produto: {valorTotal}");
    }
}