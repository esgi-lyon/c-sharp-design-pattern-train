using System;

public class VendeurProcess
{
  static void Main(string[] args)
  {
    Vendeur seller = Vendeur.Instance();
    seller.sellTobacco();

  }
}
