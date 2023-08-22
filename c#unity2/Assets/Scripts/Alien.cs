namespace MyAlien {
    public struct Alien {

        public Alien(int points, int hitPoints, bool isAlive) : this() {
            this.Points = points;
            this.HitPoints = hitPoints;
            this.IsAlive = false;
        }
        public Alien(int points) : this(points, 1, false) {

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