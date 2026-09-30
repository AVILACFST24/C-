class Produto 
{
    private string? _nome;
    private decimal _preço;

    
public Produto(string  Nome , decimal Preço) 
    {
        _nome = Nome;
        _preço = Preço;

        if (Preço < 0)
        {
            Console.WriteLine($"insira um valor diferente de 0");
        }
    }




public void exibirdetalhes()
    {
        Console.WriteLine($"nome : {_nome}");
        Console.WriteLine($"preço : {_preço}");
    }

    public void alterarpreço(decimal novoPreço)
    {
        if (novoPreço < 0)
        {
            Console.WriteLine($"insira um valor diferente de 0");
        }
        else
        {
            _preço = novoPreço;
        }
    }
}

