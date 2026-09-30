using System.Diagnostics.Contracts;

class Elevador
{
    private int andarAtual = 0;
    private int totaldeandares = 0 ;



  public Elevador(int numerototaldeandares){

    totaldeandares = numerototaldeandares;

  }
public void  subir()
    {
        andarAtual = andarAtual + 1 ;
        if(andarAtual > totaldeandares)
        {
            Console.WriteLine("Não e possivel subir mais");
        }
    }
    public void descer()
    {
        andarAtual = andarAtual - 1;
        if(andarAtual < 0)
        {
            Console.WriteLine("Não e possivel descer mais");

            andarAtual = 0;
        }
    }


public void exibirandarAtual()
{
    Console.WriteLine($"Andar atual: {andarAtual}"); 
}
}
