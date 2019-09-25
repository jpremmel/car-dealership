namespace Dealership.Models
{
  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Details;


    public Car(string makeModel, int price, int miles, string details)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Details = details;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      if ((Price < maxPrice) && (Miles < maxMiles))
      {
      return true;   
      } 
      else 
      {
      return false;
      }
    }
  }
}