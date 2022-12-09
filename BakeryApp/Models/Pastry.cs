namespace BakeryApp
{
  public class Pastry
  {
    public static float price { get; } = 2;
    public static string GetPrice(int amount)
    {
      int dealAmount = (int)(amount / 3);
      int normalPrice = (int)((amount - dealAmount) * price);
      int halfPrice = (int)(dealAmount * (price / 2));
      int resultPrice = normalPrice + halfPrice;
      return String.Format("${0}", resultPrice);
    }
  }
}