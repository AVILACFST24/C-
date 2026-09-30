public interface IVeiculo
{
    void mover();
}

class Carro : IVeiculo
{
    public void mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }

}
class Bicicleta : IVeiculo
{
    public void mover()
    {
        Console.WriteLine("A bicicleta está se movendo.");
    }
}