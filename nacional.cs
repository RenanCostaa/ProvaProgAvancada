class Nacional : Veiculo{

  public Nacional(string c, string mc, string mod, double val, int a):base(c,mc,mod,val,a){
  }
  
  public override void definirValorVeiculo(double custoFixo){
    double valorReal=(custoFixo*1.5)+(custoFixo*0.2)+(custoFixo/10);
    Veiculo.SetValor(valorReal);
  }
}
