using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class ResultStorage
    {
        private const string path = @".\UsersScore.txt";


        public static int GetBestUser()
        {
            if (!FileManager.Exists(path))
            {
                return 0;
            }

            var users = GetAll();
            var maxScore = 0;

            foreach (var user in users)
            {
                maxScore = Math.Max(maxScore, user.Score);
            }

            return maxScore;
        }


        public static List<User> GetAll()
        {
            if (!FileManager.Exists(path))
            {
                return new List<User>();
            }

            var data = FileManager.GetData(path);
            var usersResult = JsonConvert.DeserializeObject<List<User>>(data);
            return usersResult;
        }


        public static void Added(User user)
        {
            var users = GetAll();
            users.Add(user);
            var data = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileManager.Record(path, data);
        }
    }
}
