using System;

class MainClass {
  public static void Main (string[] args) {
   

   int opcao = 0;

   Console.WriteLine ("Escolha uma opção: ");
   Console.WriteLine ("1 - Maior número: ");
   Console.WriteLine ("2 - Menor número: ");
   opcao = int.Parse (Console.ReadLine());



    Console.WriteLine ("Digite 3 números: ");
  
    int num1 = int.Parse (Console.ReadLine());
    int num2 = int.Parse (Console.ReadLine());
    int num3 = int.Parse (Console.ReadLine());

    switch (opcao) {
      case 1:

      if (num1>num2 && num1>num3)
      {
      Console.WriteLine (" O maior número é: " + num1);
      }
      

      else if (num2 >num1 && num2>num3)
      {
        Console.WriteLine (" O maior número é: " + num2);
      }
      

      else if (num3>num2 && num3>num1) 
      {
        Console.WriteLine (" O maior número é: " + num3);
      }
      break;

      case 2:

      if (num1<num2 && num1 <num3)
      {
        Console.WriteLine ("Menor: " + num1);
      }

      else if (num2<num1 && num2<num3)
      {
        Console.WriteLine ("Menor: " + num2);
      }

      else if (num3<num2 && num3<num1)
      {
        Console.WriteLine ("Menor: " + num3);
      }
      break;

      

     

    }
      
    

  
  }
}