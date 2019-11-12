using System;
					
namespace Calc
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {

        Console.Clear();
        double firstValue, secondValue;
        string action;
	
        try
        {
          Console.WriteLine("Введите число 1");
          firstValue = double.Parse(Console.ReadLine());

          Console.WriteLine("Введите число 2");
          secondValue = double.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Ошибка! Допускается ввод только числовых значений");
          Console.ReadLine();
          continue;
        }

        Console.WriteLine("Выберите операцию: '+', '-', '*', '/'.");
        action = Console.ReadLine();

        if (action == "+")
        {
          Console.WriteLine("Результат действия:", firstValue + secondValue);
        }
        else if (action == "-")
        {
          Console.WriteLine("Результат действия:", firstValue - secondValue);
        }
        else if (action == "*")
        {
          Console.WriteLine("Результат действия:", firstValue * secondValue);
        }
        else if (action == "/")
        {
          if (secondValue == 0)
             Console.WriteLine("Ошибка! Нельзя делить на 0");

          else 
             Console.WriteLine("Результат действия:", firstValue / secondValue);
        }
        else
        {
          Console.WriteLine("Ошибка! Неизвестное действие!");
        }
	   Console.ReadLine();
      }
    }
  }
}