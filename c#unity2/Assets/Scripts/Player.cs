namespace Beginning.CSharp {

    public interface IPersistable {
        void Save(); 
    }
    public struct Player : IPersistable {

        private int lives;

        public Player(int lives, string name, int score) : this() {
            this.lives = lives;
            this.Name = name;
            this.Score = score;
        }

        public Player(int score) : this(3, "Unknown", score) {

        }

        public void Save() {
            //save
        }

        public int Lives {
            get {
                return lives;
            }
            set {
                lives = value + 1;
            }
        }
        public string Name {
            get;
            set;
        }
        public int Score {
            get;
            set;
        }

    }
}

//////////////
// Getters and Setters
// remember that when using getters and setters we want to use private so to secure the stability of our variable
        // public void SetScore(int score) {
        //     this.score = score + 1;
        // }
        // public int GetScore() {
        //     return score;
        // }