using System;

class Importado : Veiculo{

  public Importado(string c, string mc, string mod, double val, int a):base(c,mc,mod,val,a){
  }
  
  public override void definirValorVeiculo(double custoFixo){
    double valorReal=(custoFixo*3.0)+(custoFixo*0.6)+(custoFixo/5);
    Veiculo.SetValor(valorReal);
  }

}