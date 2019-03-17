using UnityEngine;
using System.Collections;

public class SelfCreate : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // public Material selfMat;

    private GameObject cube1;

    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        //cube1.GetComponent<Renderer>().material = selfMat;
        cube1.name = "Self";
    }

    // void Update()
    // {
    //     cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    //     cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    // }
    
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            cube1.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            cube1.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            cube1.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            cube1.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SelfCreate : MonoBehaviour
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
