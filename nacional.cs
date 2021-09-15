class Nacional : veiculo{

  public Nacional(string c, string mc, string mod, double val, int a):base(c,mc,mod,val,a){
  }
  
  public override definirValorVeiculo(double custoFixo){
    valor=(custoFixo*1.5)+(custoFixo*0.2)+(custoFixo/10);
    veiculo.SetValor(valor);
  }
}

/*
  private string cor;
  private string marca;
  private string modelo;
  private double valor;
  private int anoFabricacao;
*/