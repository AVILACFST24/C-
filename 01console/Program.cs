Pesssoa p1 = new Pesssoa();
p1.Nome = "Paulo";
//p1.Apresentacao();

Pesssoa p2 = new Pesssoa();
p2.Nome = "ricardo";
//p2.Apresentacao();

Pesssoa p3  = new Pesssoa()
{
  Nome = "JOSE",
  Idade = 28 
};

String retorno = p3.VerificarID();

Console.WriteLine(retorno);