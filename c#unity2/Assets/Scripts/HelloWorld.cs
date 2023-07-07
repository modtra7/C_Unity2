using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string name = "Mo";
    string food = "Ramen";
    bool share = false;
    uint amount = 7;
    string gameName = "Final Fantasy XIV";
    int age = 25;

    public string game = "OverWatch";
    public int rating = 1;

    // (float)x or xf
    public float myFloat = 1.2f;
    bool likesGame = false;
    sbyte overflowError = 127;

    void OnDisable()
    {
        // Debug.Log("The game " + gameName + " is " + age + " years old?");
        // overflowError = (sbyte) (overflowError + 1);
        // Debug.Log("the result of the overflow error is: " + overflowError);
        Debug.Log("My name is " + name + ", and my favorite food is " + food + " and I like to eat it " + amount + " times a day and I like to share it with others: " + share);
    }
    void OnEnable()
    {
        Debug.Log("The game " + game + " is rated " + rating + " stars.");
    }
}


// type name = value;

// types //
// sbyte ==== 1 byte === -128 to 127
// byte ===== 1 byte === 0 to 255
// short ==== 2 bytes == -32,768 to 32, 767
// ushort === 2 bytes == 0 to 65,535
// int ====== 4 bytes == -2,147,483,648 to 2,147,483,647
// uint ===== 4 bytes == 0 to 4,294,967,295
// long ===== 8 bytes == -9,223,372,036,854,775 to 9,223,372,036,854,775,807
// ulong ==== 8 bytes == 0 to 18,446,744,073,709,551,615
// decimal == 16 bytes = a lot
// float ==== 4 bytes == a lot but not too precise, not necessarily dangerous. // (x)f
// double === 8 bytes == more precise than a float
// string === varies === up to 2 billion characters
// DateTime = 8 bytes == January 1, 0001 0:0:00 to December 31, 9999 11:59:59 pm
// char ===== 2 bytes == U+0000 to U+FFFF
// bool ===== 2 bytes == true or false