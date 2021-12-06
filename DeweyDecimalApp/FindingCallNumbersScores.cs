using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalApp
{
    class FindingCallNumbersScores
    {
        private int streak;
        private string name;

        public FindingCallNumbersScores(int streak, string name)
        {
            this.streak = streak;
            this.name = name;
        }

        public FindingCallNumbersScores()
        {

        }

        public int Streak { get => streak; set => streak = value; }
        public string Name { get => name; set => name = value; }

        // Neatly displaying the scores in order.
        public string DisplayHighScores()
        {
            string highscores = "";
            int count = 1;
            List<FindingCallNumbersScores> hs = ReadHighScores(); ;

            foreach (FindingCallNumbersScores score in hs)
            {
                highscores += $"{count}. {score.name}: {score.streak}\n";
                count++;
            }
            return highscores;
        }

        // Reading high scores from the JSON file and deserializing into a list of type CallNumberGameScores.
        public List<FindingCallNumbersScores> ReadHighScores()
        {
            string jsonData = "";
            using (StreamReader reader = new StreamReader("FindingCallNumbersScores.json"))
            {
                jsonData = reader.ReadToEnd();
            }
            List<FindingCallNumbersScores> scores = JsonConvert.DeserializeObject<List<FindingCallNumbersScores>>(jsonData);
            return scores;
        }

        public void UpdateLeaderboard(List<FindingCallNumbersScores> inScores, FindingCallNumbersScores userScore)
        {
            inScores.Add(userScore);
            inScores = inScores.OrderByDescending(x => x.streak).ToList();

            if (inScores.Count == 6)
            {
                inScores.RemoveAt(5); // We only record the top 5 scores
            }

            using (StreamWriter writer = new StreamWriter("FindingCallNumbersScores.json", false))
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
            FindingCallNumbersScores score1 = new FindingCallNumbersScores(1, "Shlompie");
            FindingCallNumbersScores score2 = new FindingCallNumbersScores(2, "CoolLibrarian");
            FindingCallNumbersScores score3 = new FindingCallNumbersScores(3, "TheLegend27");
            FindingCallNumbersScores score4 = new FindingCallNumbersScores(4, "1337x");
            FindingCallNumbersScores score5 = new FindingCallNumbersScores(5, "B00kW0rm");

            // Adding the above scores to the list of highscores.
            List<FindingCallNumbersScores> scores = new List<FindingCallNumbersScores>
            {
                score1,
                score2,
                score3,
                score4,
                score5
            };

            // Writing the scores to the JSON file
            using (StreamWriter writer = new StreamWriter("FindingCallNumbersScores.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, scores);
            }
        }

        public bool IsScoreHigher(List<FindingCallNumbersScores> inScores, FindingCallNumbersScores userScore)
        {
            foreach (FindingCallNumbersScores numberGameScores in inScores)
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
