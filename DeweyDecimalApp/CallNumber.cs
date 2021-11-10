using System;
using System.Collections.Generic;
using System.Linq;

namespace DeweyDecimalApp
{
    public class CallNumber
    {
        private double classificationNum;
        private string authorName;

        public CallNumber(double classificationNum, string authorName)
        {
            this.ClassificationNum = classificationNum;
            this.AuthorName = authorName;
        }

        private Random randy;
        public CallNumber()
        {
            randy = new Random();
            // Empty constructor so the class can be instantiated to use its methods.
        }

        public double ClassificationNum { get => classificationNum; set => classificationNum = value; }
        public string AuthorName { get => authorName; set => authorName = value; }

        public CallNumber GenerateCallNumber()
        {
            double genNum = Math.Round((randy.NextDouble() * 1000), 3); // Creating a random number from 0 to 1000. ( 0 <= x < 1000) with 3 decimal places

            // The following code has been attributed from
            // https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
            // Author: Dan Rigby
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // All acceptable values.
            var stringChars = new char[3];
            //var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[randy.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            CallNumber genCallNum = new CallNumber(genNum, finalString);

            return genCallNum;
        }

        public override string ToString()
        {
            return $"{classificationNum} {authorName}";
        }

        public List<CallNumber> GenerateCallNumberList()
        {
            List<CallNumber> callNums = new List<CallNumber>();

            // Simple for loop to generate 10 call numbers.
            for (int i = 0; i < 10; i++)
            {
                callNums.Add(GenerateCallNumber());
                // This is a horrible solution but before using the random variable for each instance of the class it worked.
                //System.Threading.Thread.Sleep(10); // Adding a 0.005 second gap between generations to prevent duplication based on seed.
            }

            return callNums;
        }

        public List<CallNumber> SortCallNumbers(List<CallNumber> inNums)
        {
            inNums = inNums.OrderBy(x => x.classificationNum).ThenBy(y => y.authorName).ToList(); // Ordering the list numerically then alphabetically.
            return inNums;
        }

        public bool CompareLists(List<CallNumber> sortedNums, List<CallNumber> userNums)
        {
            // Code attribution
            // Available at: https://www.techiedelight.com/compare-two-lists-for-equality-csharp/
            // Author: Techie Delight
            return Enumerable.SequenceEqual(sortedNums, userNums);
        }


    }

}
