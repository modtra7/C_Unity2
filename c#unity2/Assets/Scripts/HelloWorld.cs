using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void OnDisable()
    {
        Debug.Log("Hello World!");
    }
    void OnEnable()
    {
        Debug.Log("See you, bye bye.");
    }
}
