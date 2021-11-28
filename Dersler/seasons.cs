using System;
 
class MainClass {
  public static void Main (string[] args) {
    int ay= 3;
    if(ay < 1 || ay >12)
    {
      Console.WriteLine("Şərtiniz səhvdir");
    }
    else if(ay <= 2 || ay == 12 )
    {
      Console.WriteLine("Qış mövsümü");
    }
    else if(ay < 6)
    {
      Console.WriteLine("Yaz mövsümü");
    }
    else if ( ay < 9)
    {
      Console.WriteLine("Yay mövsümü");
    }
    else
    {
      Console.WriteLine("Payız mövsümü");
    }
  }
}
 