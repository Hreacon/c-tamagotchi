using Nancy;
using TamagotchiNS.Objects;
using System.Collections.Generic;
using System.Web;
using System;

namespace TamagotchiNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["showAllTama.cshtml", TamagotchiClass.GetAll()];
      };
      Get["/feed/{id}"] = x => {
        TamagotchiClass.GetTamaById(x.id).GiveFood();
        return View["redirect.cshtml", "/"];
      };
      Get["/water/{id}"] = x => {
        TamagotchiClass.GetTamaById(x.id).GiveWater();
        return View["redirect.cshtml", "/"];
      };
      Get["/attention/{id}"] = x => {
        TamagotchiClass.GetTamaById(x.id).GiveAttention();
        return View["redirect.cshtml", "/"];
      };
      Get["/remove/{id}"] = x => {
        TamagotchiClass.GetTamaById(x.id).ThrowAway();
        return View["redirect.cshtml", "/"];
      };
      Get["/addTama"] = _ => {
        new TamagotchiClass();
        return View["redirect.cshtml", "/"];
      };
      Get["/time"] = _ => {
        TamagotchiClass.TimePasses();
        return View["redirect.cshtml", "/"];
      };
      Get["/clearAll"] = _ => {
        TamagotchiClass.ClearAll();
        return View["redirect.cshtml", "/"];
      };
      Get["/clearDead"] = _ => {
        TamagotchiClass.ClearDead();
        return View["redirect.cshtml", "/"];
      };
    }
  }
}
