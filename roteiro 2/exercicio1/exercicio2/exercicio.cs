class Carro
{
    private string? _modelo;
    private int velocidadeatual = 0;


  public Carro(string modelo)
    {
        _modelo = modelo;
        
        Console.WriteLine($"modelo : {_modelo}");
    }
    public void Acelerar(int novavelocidade)
    {
        velocidadeatual += novavelocidade;
    }
    


    public void Frear(int novavelocidade)
    {
        if (velocidadeatual - novavelocidade < 0)
        {
            velocidadeatual = 0;
        }
        else
        velocidadeatual -= novavelocidade;
    }



public void MostrarVelocidade()
    {
        Console.WriteLine($"A velocidade atual do carro é: {velocidadeatual} km/h");
    }
}