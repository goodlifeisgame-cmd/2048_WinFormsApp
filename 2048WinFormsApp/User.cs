namespace _2048WinFormsApp
{
    public class User
    {
        public string Name;
        public int Score;

        public User(string name, int score = 0)
        {
            Name = name;
            Score = score;
        }
    }
}
