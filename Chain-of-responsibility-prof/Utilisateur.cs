using System;

public class Utilisateur
{
  public static void Main(string[] args)
  {
    ObjetBase vehicule1 = new Vehicule(
      "Auto++ KT500 V�hicule d'occasion en bon �tat ");
    Console.WriteLine(vehicule1.donneDescription());
    ObjetBase modele1 = new Modele("KT400", 
      "Le v�hicule spacieux et confortable");
    ObjetBase vehicule2 = new Vehicule(null);
    vehicule2.suivant = modele1;
    Console.WriteLine(vehicule2.donneDescription());
    ObjetBase marque1 = new Marque("Auto++", 
      "La marque des autos", "de grande qualit�");
    ObjetBase modele2 = new Modele("KT700", null);
    modele2.suivant = marque1;
    ObjetBase vehicule3 = new Vehicule(null);
    vehicule3.suivant = modele2;
    Console.WriteLine(vehicule3.donneDescription());
    ObjetBase vehicule4 = new Vehicule(null);
    Console.WriteLine(vehicule4.donneDescription());
  }
}
