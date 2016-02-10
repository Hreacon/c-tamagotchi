using System.Collections.Generic;

namespace TamagotchiNS.Objects
{
  public class TamagotchiClass
  {
    private int _food;
    private int _id;
    private int _attention;
    private int _water;
    private static List<TamagotchiClass> _tamaList = new List<TamagotchiClass>(){};
    private static int _totalTama = 0;

    public TamagotchiClass()
    {
      int startVal = 5;
      _food = startVal;
      _attention = startVal;
      _water = startVal;
      _tamaList.Add(this);
      _id = _totalTama;
      _totalTama += 1;
    }
    public int GetId() {
      return _id;
    }
    public int GetFood()
    {
        return _food;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public int GetWater()
    {
      return _water;
    }
    public void GiveFood()
    {
      _food += 3;
    }
    public void GiveAttention()
    {
      _attention += 3;
    }
    public void GiveWater()
    {
      _water += 3;
    }
    public bool IsDead()
    {
      bool output = false;
      if(_food <= 0 || _attention <= 0 || _water <= 0)
      {
        output = true;
      }
      return output;
    }
    public void PassTime() {
      int timeval = -1;
      _food += timeval;
      _attention += timeval;
      _water += timeval;
    }
    public void SetId(int id) {
      _id = id;
    }
    public void ThrowAway() {
      _tamaList.Remove(this);
    }
    public static void TimePasses()
    {
      foreach( TamagotchiClass tama in _tamaList ) {
        tama.PassTime();
      }
    }
    public static void ClearAll()
    {
      _tamaList = new List<TamagotchiClass>(){};
    }
    public static void ClearDead()
    {
      List<TamagotchiClass> liveTama = new List<TamagotchiClass>(){};
      foreach(TamagotchiClass tama in _tamaList)
      {
        if(tama.IsDead() == false)
        {
          liveTama.Add(tama);
          //add to list();
        }
      }
      _tamaList = liveTama;
    }
    public static List<TamagotchiClass> GetAll()
    {
      return _tamaList;
    }
    public static TamagotchiClass GetTamaById(int id)
    {
      foreach(TamagotchiClass tama in _tamaList) {
        if( tama.GetId() == id )
          return tama;
      }
      return new TamagotchiClass();
    }

  }
}
