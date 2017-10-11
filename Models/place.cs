using System.Collections.Generic;

namespace FavPlace.Models
{
  public class Place
  {
    private string _placefav;
    private string _city;
    private int _stay;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string placefav,string city,int stay)
    {
      _placefav = placefav;
      _city = city;
      _stay = stay;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetPlacefav()
    {
      return _placefav;
    }
    public void SetPlacefav(string newPlacefav)
    {
      _placefav = newPlacefav;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public int GetStay()
    {
      return _stay;
    }
    public void SetStay(int newStay)
    {
      _stay = newStay;
    }
    public int GetId()
   {
     return _id;
   }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
