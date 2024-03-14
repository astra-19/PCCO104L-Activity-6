using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Welcome to the game!");

    while (true) {
      Console.WriteLine("Select an activty from 1 - 5: ");
      Console.WriteLine("Act. #1 - PH Money Denomination");
      Console.WriteLine("Act. #2 - Number Divisibility");
      Console.WriteLine("Act. #3 - Input Message");
      Console.WriteLine("Act. #4 - Build a Pyramid");
      Console.WriteLine("Act. #5 - Sum vs. Append");
      Console.WriteLine("Type 'exit' to exit program.");

      Console.Write ("Activity: ");
      string activity = Console.ReadLine(); 

      switch (activity) {
      case "1":
        MoneyDenomination();
        break;
      case "2":
        NumberDivisibility();
        break;
      case "3":
        InputMessage();
        break;
      case "4":
        BuildPyramid();
        break;
      case "5":
        SumVsAppend();
        break;
      case "exit":
        Console.WriteLine ("Closing Program...");
        return;
      default:
        Console.WriteLine ("Activity does not exist");
        break;
        }
      }
    }
  static void MoneyDenomination () {
    Console.WriteLine("Act. #1 - PH Money Denomination");
    Console.WriteLine("Enter value: ");
    
    if (double.TryParse(Console.ReadLine(), out double denomination)) {
      string personality = banknotePersonality (denomination);
      if (personality != null) 
      Console.WriteLine ($"Personality found on {denomination} in PHP {personality}");
      else
      Console.WriteLine("No person was found on the banknote. ");
    }
    else {
      Console.WriteLine($"Invalid Denomination: {denomination}");
    }
  }

  
  static string banknotePersonality (double denomination) {
    string person = "";
    string value1 = "Jose Rizal is found in 1 php." ;
    string value5 = "Emilio Aguinaldo is found in 5 php." ;
    string value10 = "Andres Bonifacio & Apolinario Mabini are found in 10 php." ;
    string value20 = "Manuel L. Quezon is found in 20 php." ;
    string value50 = "Sergio Osmena is found in 50 php." ;
    string value100 = "Manuel Roxas is found in 100 php." ;
    string value200 = "Diosdado Macapagal is found in 200 php." ;
    string value500 = "Benigno Sr. & Corazon Aquino are found in 500 php." ;
    string value1000 = "Jose Abad Santos, Vicente Lim, & Josefa Llanes Escoda are found in 1000 php." ;
    
    switch (denomination) {
    case 1:
      person = value1;
      break;
    case 5:
      person = value5;
      break;
    case 10:
      person = value10;
      break;
    case 20:
      person = value20;
      break;
    case 50:
      person = value50;
      break;
    case 100:
      person = value100;
      break;
    case 200:
      person = value200;
      break;
    case 500:
      person = value500;
      break;
    case 1000:
      person = value1000;
      break;
    default:
      Console.WriteLine($"Invalid Denomination: {denomination}");
      break;
      }
    Console.WriteLine($"Personality Found: {person}");

    return person;
    }
  
  static void NumberDivisibility () {
    Console.WriteLine("Act. #2 - Number Divisibility");
    
    Console.Write("Enter Value: ");
    int m;
    if (!int.TryParse(Console.ReadLine(), out m)) {
      Console.WriteLine("Invalid input. Please enter a valid integer. "); 
    }

      for (int i = 1; i <= m; i++) {

        if (i % 3 == 0 && i %  5 == 0)
        {
          Console.WriteLine ($"{i} - FooBar");
        }
        else if ( i % 3 == 0)
        {
          Console.WriteLine($"{i} - Foo");
        }
        else if ( i % 5 == 0)
        {
          Console.WriteLine ($"{i} - Bar");
        }
        else
        {
          Console.WriteLine(i);
        }
    }
    }
  
  static void InputMessage () {
    Console.WriteLine ("Act. #3 - Input Message");
    
    string combinedWords = " ";
    int totalNum = 0;
    
    while (true) {
      Console.WriteLine("Enter something:  ");
      string inputWord = Console.ReadLine();
      
      if (inputWord.ToLower () == "exit") {
        Console.WriteLine("Closing program...");
        break;
        }
      
      if (int.TryParse(inputWord, out int num)) {
        totalNum += num;
        } else {
        combinedWords += inputWord;
        }
      Console.WriteLine($"Adding {num} = {totalNum}");
      Console.WriteLine($"Current message is: {combinedWords} ");
      }
    }

  static void BuildPyramid () {
    Console.WriteLine ("Act. #4 - Build a Pyramid");
    
    while (true) {
      Console.WriteLine ("Enter a number: ");
      string num = Console.ReadLine();
      
      if (int.TryParse(num, out int n) && n >= 0) {
        if (n == 0) {
          Console.WriteLine("Closing Program...");
          break;
          }
        for (int i = 0; i < n; i++) {
          for (int j = 0; j < n - i - 1; j++  ) {
          Console.Write(" ");
            }
          for (int j = 0; j < 2 * i + 1; j++ ) {
            Console.Write("*");
            }
          Console.WriteLine();
          }
        } else {
        Console.WriteLine("Invalid Value: ");
        }
      }
    }

  static void SumVsAppend () {
    Console.WriteLine ("Act. #5 - Sum vs. Append");
    
    string combinedWords = " ";
    int totalNum = 0;
    
    while (true) {
      Console.WriteLine("Enter something:  ");
      string inputWord = Console.ReadLine();
      
      if (inputWord.ToLower () == "exit") {
        Console.WriteLine("Closing program...");
        break;
        }
      if (int.TryParse(inputWord, out int num)) {
        totalNum += num;
        } else {
        combinedWords += inputWord;
        }
      
      Console.WriteLine($"Adding {num} = {totalNum}");
      Console.WriteLine($"Current message is: {combinedWords}");
      }
    }
  }

      
  
          
  