using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeweyDecimalApp
{
    public class CallNumberGameScores
    {
        private double time;
        private string name;

        public double Time { get => time; set => time = value; }
        public string Name { get => name; set => name = value; }

        public CallNumberGameScores(double time, string name)
        {
            this.time = time;
            this.name = name;
        }

        public CallNumberGameScores()
        {
            // An empty constructor is required to instantiate an object of the class to use its methods without having the data for the object.
        }

        // Neatly displaying the scores in order.
        public string DisplayHighScores()
        {
            string highscores = "";
            int count = 1;
            List<CallNumberGameScores> hs = ReadHighScores(); ;

            foreach (CallNumberGameScores score in hs)
            {
                highscores += $"{count}. {score.name}: {score.time}s\n";
                count++;
            }
            return highscores;
        }

        // Reading high scores from the JSON file and deserializing into a list of type CallNumberGameScores.
        public List<CallNumberGameScores> ReadHighScores()
        {
            string jsonData = "";
            using (StreamReader reader = new StreamReader("CallNumberGameScores.json"))
            {
                jsonData = reader.ReadToEnd();
            }
            List<CallNumberGameScores> scores = JsonConvert.DeserializeObject<List<CallNumberGameScores>>(jsonData);
            return scores;
        }

        public void UpdateLeaderboard(List<CallNumberGameScores> inScores, CallNumberGameScores userScore)
        {
            inScores.Add(userScore);
            inScores = inScores.OrderBy(x => x.time).ToList();

            if (inScores.Count == 6)
            {
                inScores.RemoveAt(5); // We only record the top 5 scores
            }

            using (StreamWriter writer = new StreamWriter("CallNumberGameScores.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, inScores);
            }
        }

        // This method is used to prepare a json file with existing values so the file will always be there.
        // It wont run in the production version it was used only in development.
        [Obsolete]
        public void PrepareJsonFile()
        {
            // Creating objects to go in the JSON
            CallNumberGameScores score1 = new CallNumberGameScores(120, "Shlompie");
            CallNumberGameScores score2 = new CallNumberGameScores(138, "CoolLibrarian");
            CallNumberGameScores score3 = new CallNumberGameScores(111, "TheLegend27");

            // Adding the above scores to the list of highscores.
            List<CallNumberGameScores> scores = new List<CallNumberGameScores>
            {
                score1,
                score2,
                score3
            };

            // Writing the scores to the JSON file
            using (StreamWriter writer = new StreamWriter("CallNumberGameScores.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, scores);
            }
        }

        public bool IsScoreHigher(List<CallNumberGameScores> inScores, CallNumberGameScores userScore)
        {
            foreach (CallNumberGameScores numberGameScores in inScores)
            {
                if (userScore.time < numberGameScores.time)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
