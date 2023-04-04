using System;

class Program {
  public static void Main (string[] args) {
    Builder b = new Builder();
    Director d = new Director();
    d.Builder = b;
    d.BuildFullFeaturedProduct();

    b.GetSmartphone().ListPieces();
  }
}