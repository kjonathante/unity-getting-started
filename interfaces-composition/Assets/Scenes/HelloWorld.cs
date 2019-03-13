using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGame;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Health cc = new Health();
        print(cc.health +"/"+ cc.maxHealth);
        print("Health : " +  cc.CurrentHealthPercent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
