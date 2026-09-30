using System.CodeDom.Compiler;


public class Pessoa
{
    public string? Nome;
    public int Idade;
    
    public string? Cargo;
    public double Salario;
public void apresentar()
    {
    
        Console.WriteLine($"Meu nome e {Nome}");
          Console.WriteLine($"Minha idade e {Idade}");
    }


    public void apresentarSalario()
    {
         if (Cargo == "Desenvolvedor")
        {
            Salario = 3000;
            Console.WriteLine($"sou desenvolvedor e meu salario e {Salario}");
        }
        else if (Cargo == "Gerente")
        {
            Salario = 5000;
            Console.WriteLine($"sou gerente e meu salario e {Salario}");
        }

    
         else if (Cargo == "estagiario")
        {
            Salario = 1000;
            Console.WriteLine($"sou estagiario e meu salario e {Salario}");
        }
    

}
}
