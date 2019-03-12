using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ConditionTest();
        LoopTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ConditionTest() {
        string name = "Freeman";

        if (name=="Jessie") {
            print("Name is Jessie");
        } else if (name=="Freeman") {
            print("Name is Freeman");
        } else {
            print("Name is not Jessie");
        }

        int health = 5;
        bool isDead = (health <= 0);

        print("isDead : " + isDead);

        // curly brackets can be remove if there is only one statement 
        if (health < 0) {
            print("Game over.");
        }

        string mode = isDead ? "GameOver" : "isPlaying";
        print("Game mode : " + mode);
    }

    void LoopTest() {
        string[] names = new string[]{"Paul","John"};
        for(int i=0; i<names.Length; i++) {
            print(names[i]);
        }

        // Arrays
        foreach(string name in names) {
            print(name);
        }
        // Lists
        List<string> animals = new List<string>(){"dogs","cats"};
        foreach(string animal in animals) {
            print(animal);
        }
        // Dictionaries
        Dictionary<string,string> weapons = new Dictionary<string,string>()
        {
            {"slot0", "Gun"}
        };
        weapons.Add("slot1","Machete");
        weapons.Add("slot2","Knife");
        foreach(var item in weapons) {
            print(item.Key + " = " + item.Value);
        }
    }
}
