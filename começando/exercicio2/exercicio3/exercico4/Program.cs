ContaBancaria c1 = new ContaBancaria();
c1.Titular = "paulo";
c1.Depositar(50000); 
c1.Sacar(40000);
c1.ExibirSaldo();

ContaBancaria c2 = new ContaBancaria();
c2.Titular = "paulo";
c2.Depositar(50000); 
c2.Sacar(100);
c2.ExibirSaldo();


ContaBancaria c3 = new ContaBancaria();
c3.Titular = "paulo";
c3.Depositar(50000); 
c3.Sacar(500);
c3.ExibirSaldo();