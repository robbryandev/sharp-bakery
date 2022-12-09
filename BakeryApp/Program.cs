using System;
using System.Threading;
using ConsoleTools;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      // Send intro msg
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Here is our bread deal (buy 2 get 1 free)(per type of bread and order sub item)");
      Console.WriteLine("Here is our pastry deal (buy 2 get 1 half off)(per type of pastry and order sub item)");
      Console.WriteLine("Press any key to continue");
      Console.ReadLine();

      bool close = false;
      int total = 0;
      while (!close)
      {
        string product = BuyMenu();
        switch (product) {
            case "bread":
                string breadType = OpenBreadMenu();
                int breadAmount = GetAmount("How many loaves of bread would you like?");
                total += Bread.GetPrice(breadAmount, breadType);
                break;
            case "pastry":
                string pastryType = OpenPastryMenu();
                int pastryAmount = GetAmount("How many pastries would you like?");
                total += Pastry.GetPrice(pastryAmount, pastryType);
                break;
            case "done":
                close = true;
                break;
        }
      }

      // Print total
      Console.Write("Your order total is: ");
      Console.Write(String.Format("${0}", total));
    }
    public static int GetAmount(string phrase)
    {
      // Ask phrase
      Console.WriteLine(phrase);

      // Validate user entered something
      string strInput = "";
      string? getInput = Console.ReadLine();
      if (getInput != null)
      {
        strInput = getInput;
      }

      // Validate user entered a number
      int input = 0;
      bool canParse = int.TryParse(strInput, out input);
      if (!canParse)
      {
        Console.WriteLine("Invalid amount");
        Environment.Exit(1);
      }
      return input;
    }
    public static string BuyMenu()
    {
      string result = "";
      Action<string> setResult = input => result = input;
      ConsoleMenu breadmenu = new ConsoleMenu()
          .Add("bread", (thisMenu) =>
          {
            setResult("bread");
            thisMenu.CloseMenu();
          })
          .Add("pastry", (thisMenu) =>
          {
            setResult("pastry");
            thisMenu.CloseMenu();
          })
          .Add("Done", (thisMenu) =>
          {
            setResult("done");
            thisMenu.CloseMenu();
          })
          .Configure(config =>
          {
            config.Selector = "--> ";
            config.Title = "What would you like to buy?";
            config.EnableWriteTitle = true;
          });
      breadmenu.Show();
      return result;
    }
    public static string OpenBreadMenu()
    {
      string result = "bread";
      Action<string> setResult = input => result = input;
      ConsoleMenu breadmenu = new ConsoleMenu()
          .Add("($5) bread", (thisMenu) =>
          {
            setResult("bread");
            thisMenu.CloseMenu();
          })
          .Configure(config =>
          {
            config.Selector = "--> ";
            config.Title = "What kind of bread would you like?";
            config.EnableWriteTitle = true;
          });
      breadmenu.Show();
      return result;
    }
    public static string OpenPastryMenu()
    {
      string result = "pastry";
      Action<string> setResult = input => result = input;
      ConsoleMenu breadmenu = new ConsoleMenu()
          .Add("($2) pastry", (thisMenu) =>
          {
            setResult("pastry");
            thisMenu.CloseMenu();
          })
          .Configure(config =>
          {
            config.Selector = "--> ";
            config.Title = "What kind of pastry would you like?";
            config.EnableWriteTitle = true;
          });
      breadmenu.Show();
      return result;
    }
  }
}