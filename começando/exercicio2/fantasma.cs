class Fantasma
{
    public string? nickname;
    public string? cor;
    public string? habilidade;



    public void gerarFantasma()
    {
        Console.WriteLine($"nickname:  {nickname}");
        Console.WriteLine($"cor:  {cor}");
        Console.WriteLine($"habilidade:  {habilidade}");
    }


    public void moverFantasma(string direcao)
    {
        Console.WriteLine($"O fantasma {nickname} está se movendo para {direcao}");
    }
}
