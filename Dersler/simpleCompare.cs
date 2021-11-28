using System;
class HelloWorld {
  static void Main() {
      
    // BU SAYINI DƏYİŞİB YOXLAMAQ LAZIMDIR
    
    int count = 15;
    
    
    int counter = 0;
    
    for (int i = 2; i < count; i++) 
    {
       if (count % i == 0) {
           counter++;
       }
    }
    
    if (counter == 0) {
         Console.WriteLine("Sadə ədəd");
    }
    else{
        Console.WriteLine("Mürəkkəb ədəd");
    }
    
  }
}
