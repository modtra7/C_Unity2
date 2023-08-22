namespace Beginning.CSharp {
    public struct Player {

        private int lives;

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