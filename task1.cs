using System;
class HelloWorld {
  public static void Main() {
      Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
      
      bool result = Exercise(num1, num2);
      Console.WriteLine(result);
      
  }
      
      
      static bool Exercise(int num1,int num2)
      {
          int difference =(num1 - num2);
          
          if (difference % 2 == 0)
          
          {
              return true;
          }
          else
          {
              return false;
          }
          
  
}
    
  }
