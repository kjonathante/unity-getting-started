using System;
using UnityEngine;

namespace MyGame
{
  public class Player : Health
  {
    public Player ()  // constructor function
    {
      RestoreHealth();
    }

    public override void RestoreHealth() {
      //base.RestoreHealth(); // how to call parent functions

      for(int i=health; i<=maxHealth; i++) {
        health=i;
        Debug.Log("Health : "+health);
      }
    }

  }

}