namespace MyAlien {
    public struct Alien {
        private int points;
        private int hitPoints;
        private bool isAlive;

        public void SetPoints(int points) {
            this.points = points;
        }
        public int GetPoints() {
            return points;
        }

        public void SetHitPoints(int hitPoints) {
            this.hitPoints = hitPoints;
        }
        public int GetHitPoints() {
            return hitPoints;
        }


        public void SetIsAlive(bool isAlive) {
            this.isAlive = isAlive;
        }
        public  bool GetIsAlive() {
            return isAlive;
        }
}
}