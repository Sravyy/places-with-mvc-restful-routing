using System.Collections.Generic;

namespace FavPlace.Models
{
  public class Place
  {
    private string _placefav;
    private string _city;
    private int _stay;
    private string _pic;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string placefav,string city,int stay,string pic)
    {
      _placefav = placefav;
      _city = city;
      _stay = stay;
      _pic = pic;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetPlacefav()
    {
      return _placefav;
    }
    public string GetCity()
    {
      return _city;
    }
    public int GetStay()
    {
      return _stay;
    }
    public string GetPic()
    {
      return _pic;
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
