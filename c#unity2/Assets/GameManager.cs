using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beginning.CSharp;
using MyAlien;
using Beginning.CSharp;

public class GameManager : MonoBehaviour
{
    private IShootable[] enemies = new IShootable[4];
    private IPersistable[] savedItems = new IPersistable[3];
    void Start()
    {
        Alien alienOne = new Alien();
        Player player = new Player();
        Turret turret = new Turret();

        savedItems[0] = alienOne;
        savedItems[1] = turret;
        savedItems[2] = player;
    }

    void OnDisable() {
        foreach (IPersistable persistable in savedItems) {
            persistable.Save();
        }
    }
}
