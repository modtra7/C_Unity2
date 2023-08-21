namespace Beginning.CSharp {
    public struct Player {

        public int Lives;
        public string Name;

        private int score;

        public void SetScore(int score) {
            this.score = score + 1;
        }
        public int GetScore() {
            return score;
        }
    }
}