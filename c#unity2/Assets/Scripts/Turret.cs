using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Turret : IShootable, IPersistable
{
    public void Fire() {
        Debug.Log("Turret fires");
    }

    public void Save() {
        Debug.Log("turret Saves");
    }
}
