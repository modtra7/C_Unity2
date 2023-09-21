using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beginning.CSharp;
using MyAlien;
using Beginning.CSharp;

public class GameManager : MonoBehaviour
{
    void OnDisable() {
        Boss monster = new Boss();
        monster.Name = "Frank";
        monster.PointValue = 1000;

        monster = null;
    }
    
}




// Alien alien = new Alien();
        // alien.HitPoints = 100;

        // Alien anotherAlien = alien;
        // anotherAlien.HitPoints = 150;

        // Debug.Log("Alien 1 Hit Points: " + alien.HitPoints);
        // Debug.Log("Alien 2 Hit Points: " + anotherAlien.HitPoints);

        // Player playerOne = new Player();
        // playerOne.Name = "Micheal";
        // Player playerTwo = playerOne;
        // playerTwo.Name = "Dwight";

        // Debug.Log("Player 1's Name: " + playerOne.Name);
        // Debug.Log("Player 2's Name: " + playerTwo.Name);

        // playerOne = null;


// private IShootable[] enemies = new IShootable[4];
//     private IPersistable[] savedItems = new IPersistable[3];
//     void Start()
//     {
//         Alien alienOne = new Alien();
//         Player player = new Player();
//         Turret turret = new Turret();

//         savedItems[0] = alienOne;
//         savedItems[1] = turret;
//         savedItems[2] = player;
//     }

//     void OnDisable() {
//         foreach (IPersistable persistable in savedItems) {
//             persistable.Save();
//         }
//     }