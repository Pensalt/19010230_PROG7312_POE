using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalApp
{
    public class IdentifyingAreasScores
    {
        private int streak;
        private string name;

        public int Streak { get => streak; set => streak = value; }
        public string Name { get => name; set => name = value; }

        public IdentifyingAreasScores(int streak, string name)
        {
            this.streak = streak;
            this.name = name;
        }

        public IdentifyingAreasScores()
        {
            // An empty constructor is required to instantiate an object of the class to use its methods without having the data for the object.
        }

        // Neatly displaying the scores in order.
        public string DisplayHighScores()
        {
            string highscores = "";
            int count = 1;
            List<IdentifyingAreasScores> hs = ReadHighScores(); ;

            foreach (IdentifyingAreasScores score in hs)
            {
                highscores += $"{count}. {score.name}: {score.streak}\n";
                count++;
            }
            return highscores;
        }

        // Reading high scores from the JSON file and deserializing into a list of type CallNumberGameScores.
        public List<IdentifyingAreasScores> ReadHighScores()
        {
            string jsonData = "";
            using (StreamReader reader = new StreamReader("IdentifyingAreasScores.json"))
            {
                jsonData = reader.ReadToEnd();
            }
            List<IdentifyingAreasScores> scores = JsonConvert.DeserializeObject<List<IdentifyingAreasScores>>(jsonData);
            return scores;
        }

        public void UpdateLeaderboard(List<IdentifyingAreasScores> inScores, IdentifyingAreasScores userScore)
        {
            inScores.Add(userScore);
            inScores = inScores.OrderByDescending(x => x.streak).ToList();

            if (inScores.Count == 6)
            {
                inScores.RemoveAt(5); // We only record the top 5 scores
            }

            using (StreamWriter writer = new StreamWriter("IdentifyingAreasScores.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, inScores);
            }
        }

        // This method is used to prepare a json file with existing values so the file will always be there.
        // It wont run in the production version it was used only in development.
        //[Obsolete]
        public void PrepareJsonFile()
        {
            // Creating objects to go in the JSON
            IdentifyingAreasScores score1 = new IdentifyingAreasScores(1, "Shlompie");
            IdentifyingAreasScores score2 = new IdentifyingAreasScores(2, "CoolLibrarian");
            IdentifyingAreasScores score3 = new IdentifyingAreasScores(3, "TheLegend27");
            IdentifyingAreasScores score4 = new IdentifyingAreasScores(4, "1337x");
            IdentifyingAreasScores score5 = new IdentifyingAreasScores(5, "B00kW0rm");

            // Adding the above scores to the list of highscores.
            List<IdentifyingAreasScores> scores = new List<IdentifyingAreasScores>
            {
                score1,
                score2,
                score3,
                score4,
                score5
            };

            // Writing the scores to the JSON file
            using (StreamWriter writer = new StreamWriter("IdentifyingAreasScores.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, scores);
            }
        }

        public bool IsScoreHigher(List<IdentifyingAreasScores> inScores, IdentifyingAreasScores userScore)
        {
            foreach (IdentifyingAreasScores numberGameScores in inScores)
            {
                // Only scores higher than existing scores are accepted.
                // Scores equalling the lowest score will not be accepted as they have not beaten a score on the scoreboard.
                if (userScore.streak > numberGameScores.streak)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
