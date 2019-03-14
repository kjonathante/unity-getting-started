using UnityEngine;

// Make sure that Cube1 is assigned this script and is inactive at the start of the game.

public class Example1 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Example1 Awake");
    }

    void Start()
    {
        Debug.Log("Example1 Start");
    }

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            print("b key was pressed");
        }
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Example1 : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
