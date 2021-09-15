class Importado : veiculo{
  
  public override definirValorVeiculo(double custoFixo){
    valor=(custoFixo*3.0)+(custoFixo*0.6)+(custoFixo/5);
    veiculo.SetValor(valor);
}