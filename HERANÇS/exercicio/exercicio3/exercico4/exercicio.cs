public interface IVoar
{
    void Voar();
}

public interface INadar
{
    void Nadar();
}



class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando.");
    }
}

class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando.");
    }
}



class Peixe: INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando.");
    }
}  