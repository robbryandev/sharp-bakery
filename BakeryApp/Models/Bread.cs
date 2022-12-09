using System.Collections.Generic;

namespace BakeryApp
{
  public class Bread
  {
    public static Dictionary<string, int> prices = new Dictionary<string, int> {
      {"bread", 5}
    };
    public static int GetPrice(int amount, string type = "bread")
    {
      int price = prices[type];
      int dealAmount = (int)(amount / 3);
      int resultPrice = (int)((amount - dealAmount) * price);
      return resultPrice;
    }
  }
}