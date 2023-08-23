using UnityEngine;

namespace MyAlien {

    public struct Alien : IShootable {

        public Alien(int points, int hitPoints, bool isAlive) : this() {
            this.Points = points;
            this.HitPoints = hitPoints;
            this.IsAlive = isAlive;
        }
        public Alien(int points) : this(points, 1, true) {

        }
        public void Fire() {
            Debug.Log("Alien fires");
        }
        public int Points {
            get;
            set;
        }
        public int HitPoints {
            get;
            set;
        }
        public bool IsAlive {
            get;
            set;
        }

      
    }
}