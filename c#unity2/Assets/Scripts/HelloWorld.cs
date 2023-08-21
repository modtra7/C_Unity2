using System.Collections;
using System.Collections.Generic;
using Beginning.CSharp;
using MyAlien;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Player playerOne;
    Alien alien;

    void Start()
    {
        playerOne = new Player();
        playerOne.Name = "Kode";
        playerOne.Score = 100;
        playerOne.Lives = 3;

        alien = new Alien();
        alien.Points = 100;
        alien.HitPoints = 1;
        alien.IsAlive = true;
    }
    void OnDisable()
    {
        Debug.Log("Name: " + playerOne.Name + ", Score: " + playerOne.Score + ", Lives: " + playerOne.Lives);

        Debug.Log("Is Alive: " + alien.IsAlive + ", Hit Points: " + alien.HitPoints + ", Point Value: " + alien.Points);
    }
}

// create alien struct
// give variables  
// point value int 
// hitpoints int
// alive bool







//////////////////////
// foreach(string title in referenceCollection){
//     Debug.Log(title); // prints out the titles
// }

//////////////////////
//type[] myArray = new type[length];
//type[,] myArray = new type[2][3];


//////////////////////
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


    // public string name = "Mo";
    // public string food = "Ramen";
    // public bool likeToShare;
    // public uint amount = 7;
    // string gameName = "Final Fantasy XIV";
    // int age = 25;

    // public string game = "OverWatch";
    // public int rating = 1;

    // // (float)x or xf
    // public float myFloat = 1.2f;
    // bool likesGame = false;
    // sbyte overflowError = 127;

    // public int totalAmount;
    // public float tipPercentage;

    // void OnDisable()
    // {
    //     int tip = (int) ((float) totalAmount * tipPercentage);
    //     Debug.Log("Yoyr total balance is " + (tip + totalAmount));

    //     // Debug.Log("The game " + gameName + " is " + age + " years old?");
    //     // overflowError = (sbyte) (overflowError + 1);
    //     // Debug.Log("the result of the overflow error is: " + overflowError);
    //     // Debug.Log("My name is " + name + ", and my favorite food is " + food + " and I like to eat it " + amount + " times a day and I like to share it with others: " + likeToShare);
    //     // x = x + 1;
    //     // Debug.Log("x = x + 1 is " + x);
    //     // x += 1;
    //     // Debug.Log("x += 1 is " + x);
    //     // ++x;
    //     // Debug.Log("++x is " + x);
    //     // Debug.Log("x++ is " + x++);
    //     // Debug.Log("x is " + x);

    //     // int x = 100;
    //     // int y = 20;
    //     // byte z = (byte) (x + y);
    //     // Debug.Log("z is " + z);
    // }
    // void OnEnable()
    // {
    //     Debug.Log("The game " + game + " is rated " + rating + " stars.");
    // }

        // public int[] lives;
    // int[] scores = new int[3];
    // string[] names = { "Mike", "James", "Pete" };

    // public int[] points;

    // void OnEnable()
    // {

    // }

    // void OnDisable()
    // {
    //     scores[0] = 403;
    //     scores[1] = 200;
    //     scores[2] = 500;

    //     int combinedPoints = points[0] + points[1] + points[2] + points[3] + points[4];
    //     int average = combinedPoints / 5;

    //     Debug.Log("The average is " + average);
    // }
     // public int myGuess = 0;
    // private int previousGuess = 0;
    // private int secretNumber;

    // void Start()
    // {
    //     secretNumber = Random.Range(1, 10);
    // }
    // void Update()
    // {
    //     if (myGuess != previousGuess)
    //     {
    //         if (myGuess == secretNumber)
    //         {
    //             Debug.Log("You win!");
    //         }
    //         else if (myGuess > secretNumber)
    //         {
    //             Debug.Log("Too high");
    //         }
    //         else 
    //         {
    //             Debug.Log("Too low");
    //         }
    //         previousGuess = myGuess;
    //     }
    // }
    // bool[] isAlive = new bool[] {true, false, true};
        // string[] names = new string[] { "Ted", "Frank", "Tim" };
        // int[] scores = new int[] { Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10) };

        // int person = 0;

        // if ( isAlive[person] == true)
        // {
        //     if (scores[person] >= 5)
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Great job!");
        //     }
        //     else
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Terrible job!");
        //     }
        // }
        // else
        // {
        //     Debug.Log("Unfortunately, " + names[person] + " is dead.");
        // }
        // person += 1;
        // if ( isAlive[person] == true)
        // {
        //     if (scores[person] >= 5)
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Great job!");
        //     }
        //     else
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Terrible job!");
        //     }
        // }
        // else
        // {
        //     Debug.Log("Unfortunately, " + names[person] + " is dead.");
        // }
        // person += 1;
        // if ( isAlive[person] == true)
        // {
        //     if (scores[person] >= 5)
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Great job!");
        //     }
        //     else
        //     {
        //         Debug.Log(names[person] + " scored " + scores[person] + " points. Terrible job!");
        //     }
        // }
        // else
        // {
        //     Debug.Log("Unfortunately, " + names[person] + " is dead.");
        // }
        
// int[] numbers = new int[] { Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)};
        // string numberText;

        // numberText = (numbers[0] % 2 == 0) ? "even" : "odd";
        // Debug.Log(numbers[0] + " is " + numberText);
        // numberText = (numbers[1] % 2 == 0) ? "even" : "odd";
        // Debug.Log(numbers[1] + " is " + numberText);
        // numberText = (numbers[2] % 2 == 0) ? "even" : "odd";
        // Debug.Log(numbers[2] + " is " + numberText);

        // name = (name != "") ? name : "Player One";
        // Debug.Log("Hello, " + name);
        // int[] coin = new int[] { Random.Range(1, 3) };
        // string flip;
        // flip = (coin[0] == 1) ? "Heads" : "Tails";
        // Debug.Log("your coin landed on " + flip);

// public enum CompassDirection
// {
//     North, South, East, West
// }
// public enum PlayerSelect
// {
//     NoneSelected, PlayerOne, PlayerTwo
// }
// public class HelloWorld : MonoBehaviour
// {
//         public int direction;
//         public CompassDirection playerMovement;
//         public PlayerSelect selectPlayer;

//         const int months = 12;
//         const int weeks = 52;
//         const int days = 365;
//    void OnDisable()
//    {
//         string dir = "";

//         switch(selectPlayer)
//         {
//             case PlayerSelect.PlayerOne:
//                 Debug.Log("Begin Player One");
//                 break;
//             case PlayerSelect.PlayerTwo:
//                 Debug.Log("Begin Player Two");
//                 break;
//             case PlayerSelect.NoneSelected:
//                 Debug.Log("Please select player");
//                 break;
//         }

//         switch(playerMovement)
//         {
//             case CompassDirection.North:
//                 dir = "north";
//                 break;
//             case CompassDirection.East:
//                 dir = "east"; 
//                 break;
//             case CompassDirection.South:
//                 dir = "south";
//                 break;
//             case CompassDirection.West:
//                 dir = "west";
//                 break;
//             default:
//                 dir = "nowhere";
//                 break;
//         }
//         Debug.Log("You moved " + dir);
//    }
// }

        // string player = "";
        // for (int i = 0; i < names.Length; i++)
        // {
        //     player += names[i] + " ";
        // }
        // Debug.Log("Players: " + player);


    // public int[] scores;
    // public string[] names;
    // void OnDisable()
    // {
    //     // int average = 0;
    //     // int increment = 0;
    //     // do
    //     // {
    //     //     average += scores[increment];
    //     //     increment++;
    //     // }while (increment < scores.Length);

    //     // foreach (int score in scores)
    //     // {
    //     //     average = average + score;
    //     //     increment += 1;
    //     // }
    //     // Debug.Log("The average is " + average / scores.Length);
    //     // Debug.Log("The loop repeated " + increment + " times");

    //     int nameIncrement = 0;
    //     string existingNames = "";
    //     while (nameIncrement < names.Length)
    //     {
    //         existingNames += names[nameIncrement] + " ";
    //         nameIncrement += 1;
    //     }
    //     // foreach (string name in names)
    //     // {
    //     //     existingNames = existingNames + name + " ";
    //     // }
    //     Debug.Log("Existing names: " + existingNames);
    // }


    //         public static void main(string[] args)
    // {
    //     //with stack we have 5 unique methods
    //     // pop, push, peek, empty, search // -- stack.method() --
    //     Stack<string> stack = new Stack<string>();
    //     // push will add the element to the top of the stack
    //     stack.Push("God of War");
    //     stack.Push("Skyrim");
    //     stack.Push("Gta");
    //     stack.Push("FFXVI");
    //     stack.Push("Hades");
    //     // pop will remove the element from the top of the stack
    //     stack.Pop();
    //     // peek will look at the element at the top of the stack
    //     stack.Peek();

    //     stack.Search("Hades");
    // }