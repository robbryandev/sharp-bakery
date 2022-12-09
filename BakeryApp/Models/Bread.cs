namespace BakeryApp
{
  public class Bread
  {
    public static float price { get; } = 5;
    public static int GetPrice(int amount)
    {
      int dealAmount = (int)(amount / 3);
      int resultPrice = (int)((amount - dealAmount) * price);
      return resultPrice;
    }
  }
}