using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string text = "Hello World";

    // Start is called before the first frame update
    void Start()
    {
        print(text);
        Test();
        print(text);
        print(Test1());
        print(Test2("My Name"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test() {
        text = "Updated inside Test()";
    }

    string Test1() {
        return "Return some string";
    }

    string Test2(string value) {
        return "Hi " + value;
    }    
}
