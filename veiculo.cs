using System;

public class Veiculo{
  private string cor;
  private string marca;
  private string modelo;
  private double valor;
  private int anoFabricacao;

  public static void SetValor(double valorCalculado){
    valor=valorCalculado;
    Console.Out.WriteLine("valor alterado");
  }

  public Veiculo(string c, string mc, string mod, double val, int a){
    cor = c;
    marca = mc;
    modelo = mod;
    valor = val;
    anoFabricacao = a;
  }


  public virtual void definirValorVeiculo(double custoFixo){

  }
}