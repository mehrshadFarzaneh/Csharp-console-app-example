namespace ConsoleApplication1
{
  using System;
  using System.Collections.Generic;
  using Models;

  internal class Program
  {
    public static void Main(string[] args)
    {
      DisplayMenus();
    }

    static void DisplayMenus()
    {
      Console.WriteLine("Write your command:");
      Console.WriteLine("1 ====> calculate the Masahat");
      Console.WriteLine("2 ====> convert centigrade to farenhit");
      Console.WriteLine("3 ====> convert numbers to absolute");
      Console.WriteLine("4 ====> calculate yarane base of lenght of family :)");
      Console.WriteLine("5 ====> calculate end score of students");
      Console.WriteLine("6 ====> calculate phone charges");
      Console.WriteLine("7 ====> calculate phone charges");
      Console.WriteLine("8 ====> how long will it take to see Shayan?");
      Console.WriteLine("or press any other key to exit...");
      switch (Console.ReadKey(true).KeyChar)
      {
        case '1':
          Console.Clear();
          CalculateMasahat();
          break;
        case '2':
          Console.Clear();
          ConvertCentigradeToFarenhait();
          break;
        case '3':
          Console.Clear();
          GetAbsOfArray();
          break;
        case '4':
          Console.Clear();
          CalculateYaraneh();
          break;
          case '5':
            Console.Clear();
            CalculateEndScoreOfStudents();
            break;
          case '6':
            Console.Clear();
            CalculatePhoneCharge();
            break;
          case '7':
            Console.Clear();
            CalculateMaliat();
            break;
          case '8':
            Console.Clear();
            CalculationOfSeeingShayan();
            break;
        default:
          Console.WriteLine("\n ***** bye  ******** :->");
          break;
      }
    }

    /*
     * Task 1
     */
    static void CalculateMasahat()
    {
      Console.WriteLine("enter a height:");
      double height = Convert.ToDouble(Console.ReadLine());
      while (!IsPositiveNumber(height))
      {
        height = Convert.ToDouble(Console.ReadLine());
      }
      Console.WriteLine("enter a ghaede:");
      double ghaede = Convert.ToDouble(Console.ReadLine());
      while (!IsPositiveNumber(height))
      {
        ghaede = Convert.ToDouble(Console.ReadLine());
      }
      Console.WriteLine("Masahat is equal to " + (ghaede * height) / 2);
      ResetConsole();
    }

    /*
     * Task 2
     */
    static void ConvertCentigradeToFarenhait()
    {
      Console.WriteLine("enter temperature as centigrade:");
      double centigrade = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("temperature in farenhight type is equal to " + (centigrade * 1.8) + 32);
      ResetConsole();
    }

    /*
     * Task 3
     */
    static void GetAbsOfArray()
    {
      Console.WriteLine("Enter how many number do you have?");
      double n = Convert.ToDouble(Console.ReadLine());
      while (!IsPositiveNumber(n))
      {
        n = Convert.ToDouble(Console.ReadLine());
      }

      List<double> numberList = new List<double>();
      for (int i = 0; i <= n; i++)
      {
        Console.WriteLine("enter the " + i + "th number:");
        double absResult = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        numberList.Add(absResult);
      }
      Console.WriteLine("all abs result:");
      foreach (var d in numberList)
      {
        Console.WriteLine(d);
      }
      ResetConsole();
    }

    /*
     * Task 4
     */
    static void CalculateYaraneh()
    {
      Console.WriteLine("Number of family member:");
      int familyLenght = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("your yaraneh is equle to " + 45000 * familyLenght);
      ResetConsole();
    }

    /*
     * Task 5
     */
    static void CalculateEndScoreOfStudents()
    {
      List<Student> studentList = new List<Student>();
      bool skipAddingNewStudent = false;
      while (!skipAddingNewStudent)
      {
        Student newStudent = new Student();
        Console.WriteLine("** ADD NEW STUDENT ...");
        Console.WriteLine("Write Student Name:");
        newStudent.Name = Console.ReadLine();
        Console.WriteLine("Write that katbi score:");
        newStudent.Katbi = Convert.ToDouble(Console.ReadLine());
        while (!IsBetweenZeroAndHundred(newStudent.Katbi))
        {
          newStudent.Katbi = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Write that amali score:");
        newStudent.Amali = Convert.ToDouble(Console.ReadLine());
        while (!IsBetweenZeroAndHundred(newStudent.Amali))
        {
          newStudent.Amali = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Write that Taklif score:");
        newStudent.Taklif = Convert.ToDouble(Console.ReadLine());
        while (!IsBetweenZeroAndHundred(newStudent.Taklif))
        {
          newStudent.Taklif = Convert.ToDouble(Console.ReadLine());
        }
        studentList.Add(newStudent);
        Console.WriteLine("Do you want add new student? [y/n] \n" +
                          " ** if no I'm going to show you end score of each student");
        skipAddingNewStudent = !Confirm();
      }

      foreach (var aStudent in studentList)
      {
        Console.WriteLine(aStudent.Name + " score is equal to ====> " + aStudent.EndScoore);
      }

      ResetConsole();
    }
    
    /*
     * Task 6
     * 
     * call prices for each seconds:
     * 0 to 60 seconds = 10 t
     * 60 to 150 seconds = 15 t
     * 150 > = 20 t
     *
     * internet prices:
     * 7000 t
     *
     * abonman = 3000 t
     */
    static void CalculatePhoneCharge()
    {
      double sumPrice = 3000;
      Console.WriteLine("How many call do you have?");
      int callCount = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i <= callCount; i++)
      {
        Console.WriteLine("how long did you talk? * Write in seconds");
        int secondsCall = Convert.ToInt32(Console.ReadLine());
          if (secondsCall > 0 && secondsCall <= 60)
          {
            sumPrice += secondsCall * 10;
          } else if (secondsCall <= 150 && secondsCall > 60)
          {
            sumPrice += secondsCall * 15;
          }
          else
          {
            sumPrice += secondsCall * 20;
          }
      }
      Console.WriteLine("Did you buy internet? [y/n]");
      if (!Confirm())
      {
        sumPrice += 7000;
      }
      Console.WriteLine("The cost of your phone is equal to ====> \n    " +  sumPrice);
      ResetConsole();
    }
    
    /*
     * Task 7
     * maliat is equal to 3%
     */
    static void CalculateMaliat()
    {
      int maliatPercentage = 3;
      Console.WriteLine("Write your salary:");
      int salary = Convert.ToInt32(Console.ReadLine());
      int salaryAfterMaliat = salary - ((maliatPercentage * salary) / 100);
      Console.WriteLine("Your salary after maliat is equal to: " +
                        salaryAfterMaliat);
      ResetConsole();
    }
    
    /*
     * Task 8
     */
    static void CalculationOfSeeingShayan()
    {
      int distanceShayan = 300;
      double lightYearKm = 9460800000000;
      double hoursToSee = ((distanceShayan * lightYearKm) / (300000 * 3600));
      Console.WriteLine("It takes " + hoursToSee + " hour to see Shayan");
      ResetConsole();
    }

    
    /*
     * util methods
     */
    static bool IsPositiveNumber(double value)
    {
      if (value >= 0)
      {
        return true;
      }
      else
      {
        Console.WriteLine("your number is not correct. please enter a valid and positive number.");
        return false;
      }
    }

    static bool IsBetweenZeroAndHundred(double value)
    {
      if (value >= 0 && value <= 100)
      {
        return true;
      }
      else
      {
        Console.WriteLine("your number is not correct. please enter a valid, positive and between 0 to 100 number.");
        return false;
      }
    }
    static bool Confirm()
    {
      ConsoleKey response;
      do
      {
        response = Console.ReadKey(false).Key;  
        if (response != ConsoleKey.Enter)
        {
          Console.WriteLine();
        }
      } while (response != ConsoleKey.Y && response != ConsoleKey.N);

      return (response == ConsoleKey.Y);
    }

    static void ResetConsole()
    {
      Console.WriteLine("Press any key to display menus...");
      Console.ReadKey();
      Console.Clear();
      DisplayMenus();
    }
  }
}