using System;
using System.Collections.Generic;
using System.Linq;

namespace DeweyDecimalApp
{
    public class IdentifyingAreas
    {
        // Dictionary with call numbers and their descriptions
        // Method to pull out random entries from the dictionary - use randomiser
        //
        private static Random randy; // Used for getting random dictionary entries.
        public IdentifyingAreas()
        {
            // Empty constructor to initialise the class in IdentifyingAreasForm.cs
            randy = new Random();
        }

        public Dictionary<string, string> QuestionType1Data()
        {
            // Dictionary containing data for the 'match the column question'
            // for matching call numbers to classification areas.
            Dictionary<string, string> qData = new Dictionary<string, string>
            {
                {"000-99","General Works"},
                {"100-199","Philosophy & Psychology"},
                {"200-299","Religion"},
                {"300-399","Social Sciences"},
                {"400-499","Language"},
                {"500-599","Natural Sciences & Mathematics"},
                {"600-699","Technology"},
                {"700-799","The Arts"},
                {"800-899","Literature & Rhetoric"},
                {"900-999","History, Biography, & Geography"},
            };
            return qData;
        }

        public Dictionary<string, string> QuestionType2Data()
        {
            // Dictionary containing data for the 'match the column question'
            // for matching classification areas to call numbers.
            Dictionary<string, string> qData = new Dictionary<string, string>
            {
                {"General Works","000-99"},
                {"Philosophy & Psychology","100-199"},
                {"Religion","200-299"},
                {"Social Sciences","300-399"},
                {"Language","400-499"},
                {"Natural Sciences & Mathematics","500-599"},
                {"Technology","600-699"},
                {"The Arts","700-799"},
                {"Literature & Rhetoric","800-899"},
                {"History, Biography, & Geography","900-999"},
            };
            return qData;
        }


        // Selecting 7 random key value pairs from the dictionary containing all the question data.
        public Dictionary<string, string> RandomDict(Dictionary<string, string> qData)
        {
            Dictionary<string, string> rDict = new Dictionary<string, string>();

            // While loop to enforce 7 unique entries into the random dictionary
            while (rDict.Count < 7)
            {
                int index = randy.Next(qData.Count);
                KeyValuePair<string, string> kvp = qData.ElementAt(index);

                // Only unique entries will be added.
                if (!rDict.ContainsKey(kvp.Key))
                {
                    rDict.Add(kvp.Key, kvp.Value);
                }
            }
            return rDict;
        }

        // Selecting the right question type to be used as the data for the random dictionary and returning the random dictionary.
        public Dictionary<string, string> ReturnQuestionType(int qType)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (qType == 1) // Question type 1 (call numbers matched to descriptions)
            {
                dict = RandomDict(QuestionType1Data());
            }
            else // Question type 2 (descriptions to call numbers)
            {
                dict = RandomDict(QuestionType2Data());
            }
            return dict;
        }

        // Method to check if the user matched the columns correctly.
        public bool CheckAnswers(string q1, string q2, string q3, string q4, string a1, string a2, string a3, string a4, Dictionary<string, string> data)
        {
            // Getting the value associated with each key and checking if it is the same as the users answer.
            if (data.TryGetValue(q1, out string correctAnswer1))
            {
                // If statement will only be hit if the user has the wrong answer.
                if (!correctAnswer1.Equals(a1))
                {
                    return false;
                }
            }

            if (data.TryGetValue(q2, out string correctAnswer2))
            {
                if (!correctAnswer2.Equals(a2))
                {
                    return false;
                }
            }

            if (data.TryGetValue(q3, out string correctAnswer3))
            {
                if (!correctAnswer3.Equals(a3))
                {
                    return false;
                }
            }

            if (data.TryGetValue(q4, out string correctAnswer4))
            {
                if (!correctAnswer4.Equals(a4))
                {
                    return false;
                }
            }
            return true; // This will only be hit if all answers are correct.
        }
    }
}
