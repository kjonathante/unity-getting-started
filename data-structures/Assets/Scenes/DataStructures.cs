using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructures : MonoBehaviour
{
    // Arrays
    string[] test; // declaration only
    string[] labels = new string[5]; //initial value for each element is an empty string, size 5;
    string[] names = new string[]{ "Jane", "Jack"};
    // string[] entities = new string[5]{"First"}; // this produces an error

    // Lists
    // List<string> animals = new List<string>();
    List<string> animals = new List<string>(){"dogs", "cats"};

    // Dictionary
    Dictionary<string, string> weapons = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        // Arrays
        print( "labels[0] : " + labels[0] );
        labels[1] = "John";
        print( "labels[1] : " + labels[1] );
        print( "Total Names " + names.Length);
        
        //Lists
        animals.Add("parrots");
        animals.Add("monkey");
        animals.Remove("monkey");
        print("Total Animals " + animals.Count);
        print("Animal 1 " + animals[0]);
        print("Last Animal " + animals[animals.Count-1]);
        print("List to Array length " + animals.ToArray().Length);

        //Dictionary
        weapons.Add("slot1","Machine gun");
        print( "Weapon in slot 1 : " + weapons["slot1"]);
        print ( weapons.ContainsKey("slot2") );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
