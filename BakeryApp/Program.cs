namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      // Send intro msg
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("You can buy a loaf of bread for $5 (buy 2 get 1 free)");
      Console.WriteLine("You can buy a pastry for $2 (buy 2 get 1 half off)");

      // Get amounts
      int breadAmount = GetAmount("How many loaves of bread would you like?");
      int pastryAmount = GetAmount("How many pastries would you like?");

      // Get prices
      int breadPrice = Bread.GetPrice(breadAmount);
      int pastryPrice = Pastry.GetPrice(pastryAmount);

      // Print total
      Console.Write("Your order total is: ");
      Console.Write(String.Format("${0}", (breadPrice + pastryPrice)));
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
  }
}