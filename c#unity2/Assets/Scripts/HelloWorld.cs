using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string name = "Mo";
    string gameName = "Final Fantasy XIV";
    int age = 25;

    public string game = "OverWatch";
    public int rating = 1;

    void OnDisable()
    {
        Debug.Log("The game " + gameName + " is " + age + " years old?");
    }
    void OnEnable()
    {
        Debug.Log("The game " + game + " is rated " + rating);
    }
}


// type name = value;