using System;

class Program
{
    
    static void Main(string[] args)
    {
      Fraction f1 = new Fraction();
      Console.WriteLine(f1.FractionToString());
      Console.WriteLine(f1.GetDecimalValue());

      Fraction f2 = new Fraction(5);
      Console.WriteLine(f2.FractionToString());
      Console.WriteLine(f2.GetDecimalValue());

      Fraction f3 = new Fraction(6, 7);
      Console.WriteLine(f3.FractionToString());
      Console.WriteLine(f3.GetDecimalValue());

      Fraction f4 = new Fraction(3,4);
      Console.WriteLine(f4.FractionToString());
      Console.WriteLine(f4.GetDecimalValue());
      
    }
}
 