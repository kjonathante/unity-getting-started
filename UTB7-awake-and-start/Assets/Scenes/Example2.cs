using UnityEngine;

public class Example2 : MonoBehaviour
{
    // GO has Example1 script assigned to it so is Cube1
    public GameObject GO;

    void Start()
    {
        Debug.Log("Example2 Start");
    }

    // allow Cube1 to activated just once
    private bool activateGO = true;

    void Update()
    {
        if (activateGO == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("space key was pressed");
                GO.SetActive(true);
                activateGO = false;
            }
        }
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Example2 : MonoBehaviour
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
