using System;

public class VendeurProcess
{
  static void Main(string[] args)
  {
    Vendeur seller = Vendeur.Instance(new List<string>{"jojo"});
    seller.sellTobaccoTo("jojo");

  }
}
