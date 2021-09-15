class Veiculo{
  private string cor;
  private string marca;
  private string modelo;
  private double valor;
  private int anoFabricacao;

  public void SetValor(double valorCalculado){
    valor=valorCalculado;
    Console.Out.WriteLine("valor alterado");
  }


  public virtual definirValorVeiculo(double custoFixo){

  }


}