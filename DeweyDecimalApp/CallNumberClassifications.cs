using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeweyDecimalApp
{
    public class CallNumberClassifications
    {
        private string description;
        private int classificationNumber;

        public CallNumberClassifications(string description, int classificationNumber)
        {
            this.description = description;
            this.classificationNumber = classificationNumber;
        }

        private Random randy;
        public CallNumberClassifications()
        {
            randy = new Random();

            // Empty constructor.
        }

        public override string ToString()
        {
            return $"{description} {classificationNumber}";
        }

        public string Description { get => description; set => description = value; }
        public int ClassificationNumber { get => classificationNumber; set => classificationNumber = value; }


        // I would rather type out the file in code to create it, that way I can always recover/replicate the file.
        // This method is used to prepare a json file with existing values so the file will always be there.
        // It wont run in the production version it was used only in development.
        // It is also here for the marker to see exactly how I made the Json file.
        [Obsolete]
        public void PrepareJsonFile()
        {
            // Creating objects to go in the JSON

            // General works (000-99).
            CallNumberClassifications cn1 = new CallNumberClassifications("General Works", 000);
            CallNumberClassifications cn2 = new CallNumberClassifications("Bibliography", 010);
            CallNumberClassifications cn3 = new CallNumberClassifications("Bibliography of individuals", 012);
            CallNumberClassifications cn4 = new CallNumberClassifications("General subject catalogues", 017);
            CallNumberClassifications cn5 = new CallNumberClassifications("General organisation & museology", 060);
            CallNumberClassifications cn6 = new CallNumberClassifications("General organisation & museology in North America", 061);
            CallNumberClassifications cn7 = new CallNumberClassifications("General organisation & museology in other areas", 068);
            CallNumberClassifications cn8 = new CallNumberClassifications("General collections", 080);
            CallNumberClassifications cn9 = new CallNumberClassifications("General collections in English", 082);
            CallNumberClassifications cn10 = new CallNumberClassifications("General collections in Slavic languages", 087);
            CallNumberClassifications cn11 = new CallNumberClassifications("Manuscripts & rare books", 090);
            CallNumberClassifications cn12 = new CallNumberClassifications("Block books", 092);
            CallNumberClassifications cn13 = new CallNumberClassifications("Incunabula", 093);

            // Philosophy & psychology (100-200).
            CallNumberClassifications cn14 = new CallNumberClassifications("Philosophy & pyschology", 100);
            CallNumberClassifications cn15 = new CallNumberClassifications("Metaphysics", 110);
            CallNumberClassifications cn16 = new CallNumberClassifications("Space", 114);
            CallNumberClassifications cn17 = new CallNumberClassifications("Time", 115);
            CallNumberClassifications cn18 = new CallNumberClassifications("Psychology", 150);
            CallNumberClassifications cn19 = new CallNumberClassifications("Comparative psychology", 156);
            CallNumberClassifications cn20 = new CallNumberClassifications("Applied psychology", 158);
            CallNumberClassifications cn21 = new CallNumberClassifications("Logic", 160);
            CallNumberClassifications cn22 = new CallNumberClassifications("Deduction", 162);
            CallNumberClassifications cn23 = new CallNumberClassifications("Hypotheses", 167);
            CallNumberClassifications cn24 = new CallNumberClassifications("Ancient, medievel, & oriental philosophy", 180);
            CallNumberClassifications cn25 = new CallNumberClassifications("Oriental philosophy", 181);
            CallNumberClassifications cn26 = new CallNumberClassifications("Platonic philosophy", 184);

            // Religion (200-299).
            CallNumberClassifications cn27 = new CallNumberClassifications("Religion", 200);
            CallNumberClassifications cn28 = new CallNumberClassifications("Natural theology", 210);
            CallNumberClassifications cn29 = new CallNumberClassifications("Good & evil", 216);
            CallNumberClassifications cn30 = new CallNumberClassifications("Humankind", 218);
            CallNumberClassifications cn31 = new CallNumberClassifications("Christian theology", 230);
            CallNumberClassifications cn32 = new CallNumberClassifications("God", 231);
            CallNumberClassifications cn33 = new CallNumberClassifications("Spiritual beings", 235);
            CallNumberClassifications cn34 = new CallNumberClassifications("Christian church history", 270);
            CallNumberClassifications cn35 = new CallNumberClassifications("Heresies in church history", 273);
            CallNumberClassifications cn36 = new CallNumberClassifications("Christian church in Africa", 276);
            CallNumberClassifications cn37 = new CallNumberClassifications("Other & comparative religions", 290);
            CallNumberClassifications cn38 = new CallNumberClassifications("Classical (Greek & Roman) religion", 292);
            CallNumberClassifications cn39 = new CallNumberClassifications("Judaisim", 296);

            // Social Sciences (300-399).
            CallNumberClassifications cn40 = new CallNumberClassifications("Social Sciences", 300);
            CallNumberClassifications cn41 = new CallNumberClassifications("General statistics", 310);
            CallNumberClassifications cn42 = new CallNumberClassifications("General statistics of Europe", 314);
            CallNumberClassifications cn43 = new CallNumberClassifications("General statistics of Africa", 316);
            CallNumberClassifications cn44 = new CallNumberClassifications("Political science", 320);
            CallNumberClassifications cn45 = new CallNumberClassifications("Civil & political rights", 323);
            CallNumberClassifications cn46 = new CallNumberClassifications("International relations", 327);
            CallNumberClassifications cn47 = new CallNumberClassifications("Law", 340);
            CallNumberClassifications cn48 = new CallNumberClassifications("Private law", 346);
            CallNumberClassifications cn49 = new CallNumberClassifications("Civil procedure & courts", 347);
            CallNumberClassifications cn50 = new CallNumberClassifications("Education", 372);
            CallNumberClassifications cn51 = new CallNumberClassifications("Elementary education", 372);
            CallNumberClassifications cn52 = new CallNumberClassifications("Higher education", 378);

            // Language (400-499)
            CallNumberClassifications cn53 = new CallNumberClassifications("Language", 400);
            CallNumberClassifications cn54 = new CallNumberClassifications("Linguistics", 410);
            CallNumberClassifications cn55 = new CallNumberClassifications("Writing systems", 411);
            CallNumberClassifications cn56 = new CallNumberClassifications("Etymology", 412);
            CallNumberClassifications cn57 = new CallNumberClassifications("English & Old English", 420);
            CallNumberClassifications cn58 = new CallNumberClassifications("English etymology", 422);
            CallNumberClassifications cn59 = new CallNumberClassifications("English grammar", 425);
            CallNumberClassifications cn60 = new CallNumberClassifications("Spanish & Portuguese languages", 460);
            CallNumberClassifications cn61 = new CallNumberClassifications("Spanish etymology", 462);
            CallNumberClassifications cn62 = new CallNumberClassifications("Portuguese", 469);
            CallNumberClassifications cn63 = new CallNumberClassifications("Other languages", 490);
            CallNumberClassifications cn64 = new CallNumberClassifications("African languages", 496);
            CallNumberClassifications cn65 = new CallNumberClassifications("Miscellaneous languages", 499);

            // Natural Science & Mathematics (500-599).
            CallNumberClassifications cn66 = new CallNumberClassifications("Natural science & mathematics", 500);
            CallNumberClassifications cn67 = new CallNumberClassifications("Mathematics", 510);
            CallNumberClassifications cn68 = new CallNumberClassifications("Topology", 514);
            CallNumberClassifications cn69 = new CallNumberClassifications("Analysis", 515);
            CallNumberClassifications cn70 = new CallNumberClassifications("Physics", 530);
            CallNumberClassifications cn71 = new CallNumberClassifications("Gas mechanics", 533);
            CallNumberClassifications cn72 = new CallNumberClassifications("Magnetism", 538);
            CallNumberClassifications cn73 = new CallNumberClassifications("Botanical sciences", 580);
            CallNumberClassifications cn74 = new CallNumberClassifications("Botany", 581);
            CallNumberClassifications cn75 = new CallNumberClassifications("Bryophyta", 588);
            CallNumberClassifications cn76 = new CallNumberClassifications("Zoological sciences", 590);
            CallNumberClassifications cn77 = new CallNumberClassifications("Invertebrates", 592);
            CallNumberClassifications cn78 = new CallNumberClassifications("Aves (Birds)", 598);

            // Technology (600-699).
            CallNumberClassifications cn79 = new CallNumberClassifications("Technology", 600);
            CallNumberClassifications cn80 = new CallNumberClassifications("Engineering & allied operations", 620);
            CallNumberClassifications cn81 = new CallNumberClassifications("Civil engineering", 624);
            CallNumberClassifications cn82 = new CallNumberClassifications("Hydraulic engineering", 627);
            CallNumberClassifications cn83 = new CallNumberClassifications("Home economics & family living", 640);
            CallNumberClassifications cn84 = new CallNumberClassifications("Food & drink", 641);
            CallNumberClassifications cn85 = new CallNumberClassifications("Housekeeping", 648);
            CallNumberClassifications cn86 = new CallNumberClassifications("Management & auxiliary services", 650);
            CallNumberClassifications cn87 = new CallNumberClassifications("Shorthand", 653);
            CallNumberClassifications cn88 = new CallNumberClassifications("Accounting", 657);
            CallNumberClassifications cn89 = new CallNumberClassifications("Manufacturing", 670);
            CallNumberClassifications cn90 = new CallNumberClassifications("Nonferrous materials", 673);
            CallNumberClassifications cn91 = new CallNumberClassifications("Textiles", 677);

            // The Arts (700-799).
            CallNumberClassifications cn92 = new CallNumberClassifications("The arts", 700);
            CallNumberClassifications cn93 = new CallNumberClassifications("Architecture", 720);
            CallNumberClassifications cn94 = new CallNumberClassifications("Public structures", 725);
            CallNumberClassifications cn95 = new CallNumberClassifications("Design & decoration", 729);
            CallNumberClassifications cn96 = new CallNumberClassifications("Drawing & decorative arts", 740);
            CallNumberClassifications cn97 = new CallNumberClassifications("Textile arts", 746);
            CallNumberClassifications cn98 = new CallNumberClassifications("Glass", 748);
            CallNumberClassifications cn99 = new CallNumberClassifications("Photography & photographs", 770);
            CallNumberClassifications cn100 = new CallNumberClassifications("Pigment processes of printing", 773);
            CallNumberClassifications cn101 = new CallNumberClassifications("Holography", 774);
            CallNumberClassifications cn102 = new CallNumberClassifications("Music", 780);
            CallNumberClassifications cn103 = new CallNumberClassifications("Vocal music", 782);
            CallNumberClassifications cn104 = new CallNumberClassifications("Chamber music", 785);

            // Literature & Rhetoric (800-899).
            CallNumberClassifications cn105 = new CallNumberClassifications("Literature & rhetoric", 800);
            CallNumberClassifications cn106 = new CallNumberClassifications("American literature in English", 810);
            CallNumberClassifications cn107 = new CallNumberClassifications("Speeches", 815);
            CallNumberClassifications cn108 = new CallNumberClassifications("Letters", 816);
            CallNumberClassifications cn109 = new CallNumberClassifications("English & Old English literature", 820);
            CallNumberClassifications cn110 = new CallNumberClassifications("English poetry", 821);
            CallNumberClassifications cn111 = new CallNumberClassifications("English satire & humour", 827);
            CallNumberClassifications cn112 = new CallNumberClassifications("Literatures of romance languages", 840);
            CallNumberClassifications cn113 = new CallNumberClassifications("French Canadian", 847);
            CallNumberClassifications cn114 = new CallNumberClassifications("Provencal", 848);
            CallNumberClassifications cn115 = new CallNumberClassifications("Hellenic literatures classical Greek", 880);
            CallNumberClassifications cn116 = new CallNumberClassifications("Greek authors", 881);
            CallNumberClassifications cn117 = new CallNumberClassifications("Literature in medieval and modern Greek", 162);

            // History, Biography, & Geography (900-999).
            CallNumberClassifications cn118 = new CallNumberClassifications("History, Biography, & Geography", 900);
            CallNumberClassifications cn119 = new CallNumberClassifications("Geography & travel", 910);
            CallNumberClassifications cn120 = new CallNumberClassifications("Europe", 914);
            CallNumberClassifications cn121 = new CallNumberClassifications("Africa", 916);
            CallNumberClassifications cn122 = new CallNumberClassifications("History of the ancient world", 930);
            CallNumberClassifications cn123 = new CallNumberClassifications("History of the ancient world India", 934);
            CallNumberClassifications cn124 = new CallNumberClassifications("History of the ancient world Greece", 938);
            CallNumberClassifications cn125 = new CallNumberClassifications("General history of Africa", 960);
            CallNumberClassifications cn126 = new CallNumberClassifications("General history of Africa Ethiopia", 963);
            CallNumberClassifications cn127 = new CallNumberClassifications("General history of Africa Sourthern Africa", 968);
            CallNumberClassifications cn128 = new CallNumberClassifications("General history of other areas", 990);
            CallNumberClassifications cn129 = new CallNumberClassifications("General history of other areas Australia", 994);
            CallNumberClassifications cn130 = new CallNumberClassifications("Extra-terrestrial worlds", 999);


            // Adding the above scores to the list of highscores.
            List<CallNumberClassifications> entries = new List<CallNumberClassifications>
            {
                cn1,
                cn2,
                cn3,
                cn4,
                cn5,
                cn6,
                cn7,
                cn8,
                cn9,
                cn10,
                cn11,
                cn12,
                cn13,

                cn14,
                cn15,
                cn16,
                cn17,
                cn18,
                cn19,
                cn20,
                cn21,
                cn22,
                cn23,
                cn24,
                cn25,
                cn26,

                cn27,
                cn28,
                cn29,
                cn30,
                cn31,
                cn32,
                cn33,
                cn34,
                cn35,
                cn36,
                cn37,
                cn38,
                cn39,

                cn40,
                cn41,
                cn42,
                cn43,
                cn44,
                cn45,
                cn46,
                cn47,
                cn48,
                cn49,
                cn50,
                cn51,
                cn52,

                cn53,
                cn54,
                cn55,
                cn56,
                cn57,
                cn58,
                cn59,
                cn60,
                cn61,
                cn62,
                cn63,
                cn64,
                cn65,

                cn66,
                cn67,
                cn68,
                cn69,
                cn70,
                cn71,
                cn72,
                cn73,
                cn74,
                cn75,
                cn76,
                cn77,
                cn78,

                cn79,
                cn80,
                cn81,
                cn82,
                cn83,
                cn84,
                cn85,
                cn86,
                cn87,
                cn88,
                cn89,
                cn90,
                cn91,

                cn92,
                cn93,
                cn94,
                cn95,
                cn96,
                cn97,
                cn98,
                cn99,
                cn100,
                cn101,
                cn102,
                cn103,
                cn104,

                cn105,
                cn106,
                cn107,
                cn108,
                cn109,
                cn110,
                cn111,
                cn112,
                cn113,
                cn114,
                cn115,
                cn116,
                cn117,

                cn118,
                cn119,
                cn120,
                cn121,
                cn122,
                cn123,
                cn124,
                cn125,
                cn126,
                cn127,
                cn128,
                cn129,
                cn130
            };

            // Writing the entries to the JSON file
            using (StreamWriter writer = new StreamWriter("Classifications.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, entries);
            }
        }
         
        // Reading high scores from the JSON file and deserializing into a list of type CallNumberGameScores.
        public List<CallNumberClassifications> ReadDataset()
        {
            string jsonData = "";
            using (StreamReader reader = new StreamReader("Classifications.json"))
            {
                jsonData = reader.ReadToEnd();
            }
            List<CallNumberClassifications> dataset = JsonConvert.DeserializeObject<List<CallNumberClassifications>>(jsonData);
            return dataset;
        }

        public List<CallNumberClassifications> GetRandomQA()
        {
            List<CallNumberClassifications> qaList = new List<CallNumberClassifications>();
            Tree<CallNumberClassifications> tree = PopulateTree();
            CallNumberClassifications c = new CallNumberClassifications();

            int randomTop = randy.Next(0, 10);
            int randomSecond = randy.Next(0, 4);
            int randomThird = randy.Next(0, 2);
            c = tree.Root.Children[randomTop].Children[randomSecond].Children[randomThird].Data;
             qaList.Add(c); // This value is the third level question.

            List<int> randomTopLevels = new List<int>();
            randomTopLevels.Add(randomTop); // Ensuring the correct top level for the question will be there.

            // Loop to get 3 other top levels.
            while (randomTopLevels.Count < 4)
            {
                int randomTopLevel = randy.Next(0, 10);

                if (!randomTopLevels.Contains(randomTopLevel))
                {
                    randomTopLevels.Add(randomTopLevel);
                }
            }

            randomTopLevels.Sort(); // Ordering the list by ascending value.

            // Getting the actual data for the random top level indices.
            foreach (int rnd in randomTopLevels)
            {
                c = tree.Root.Children[rnd].Data;
                qaList.Add(c);
            }

            // Getting the correct four second levels from the appropriate top level.
            for (int i = 0; i < 4; i++)
            {
                c = tree.Root.Children[randomTop].Children[i].Data;

                qaList.Add(c);
            }

            return qaList;
        }

        // Code Attribution
        // Author: Tim Corey (Youtube: IAmTimCorey)
        // Available at: https://www.youtube.com/watch?v=QC6hpl2iU0c
        public (string message, bool correct) CheckAnswerTopLevel(CallNumberClassifications answer, CallNumberClassifications question)
        {
            string message;
            bool correct;

            // CHecking if the user got the correct answer and telling them the correct answer if they didn't get it.
            if (question.ClassificationNumber > answer.classificationNumber && question.classificationNumber < answer.classificationNumber + 100)
            {
                correct = true;
                message = "Correct!";
            }
            else
            {
                int correctTopLevel = RoundToNearest(question.classificationNumber - 50, 100); // Rounding to the nearest 100.
                correct = false;
                message = $"Incorrect! The correct top level classification was {correctTopLevel}.";
            }

            return (message, correct);
        }

        public (string message, bool correct) CheckAnswerSecondLevel(CallNumberClassifications answer, CallNumberClassifications question)
        {
            string message;
            bool correct;

            if (question.ClassificationNumber > answer.classificationNumber && question.classificationNumber < answer.classificationNumber + 10)
            {
                correct = true;
                message = "Correct!";
            }
            else
            {
                int correctSecondLevel = RoundToNearest(question.classificationNumber - 5, 10); // Rounding to the nearest 10.
                correct = false;
                message = $"Incorrect! The correct second level classification was {correctSecondLevel}.";
            }

            return (message, correct);
        }


        // Code Attribution.
        // The following code has been adapted from:
        // Author: Jason Larke
        // Available at: https://stackoverflow.com/questions/13153616/how-to-round-a-integer-to-the-close-hundred
        public int RoundToNearest(int i, int nearest)
        {
            if (nearest <= 0 || nearest % 10 != 0)
                throw new ArgumentOutOfRangeException("nearest", "Must round to a positive multiple of 10");

            return (i + 5 * nearest / 10) / nearest * nearest;
        }

        public Tree<CallNumberClassifications> PopulateTree()
        {
            List<CallNumberClassifications> dataset = ReadDataset(); // Reading all the tree data from the data file so that it can be put into the data tree.

            Tree<CallNumberClassifications> tree = new Tree<CallNumberClassifications>(); // Declaring the tree that will house the data.

            CallNumberClassifications root = new CallNumberClassifications("root", 9999); // This is the root value of the whole tree and is not used in the game.
            tree.Root = new DataTree<CallNumberClassifications>() {Data = root}; // Inserting the main parent root of the tree.

            // My data set is split up into 10 blocks of 13 entries of Dewey Decimal classifications. The structure is as follows:
            // 1. Top level.
            // 2. Second Level.
            // 3. Third level.
            // 4. Third level.
            // 5. Second Level.
            // 6. Third level.
            // 7. Third level.
            // 8. Second Level.
            // 9. Third level.
            // 10. Third level.
            // 11. Second Level.
            // 12. Third level.
            // 13. Third level.

            int counter = 0; // This counter tracks the overall progress through the list.
                             // I did't want to loop 130 times as its slow.

            // Loop to insert the data correctly into the tree.
            // Top level loop to insert the top level data entries
            for (int i = 0; i < 10; i++)
            {
                // Creating the list of children if it does not exisit, updating it if it does.
                if (tree.Root.Children is null)
                {
                    tree.Root.Children = new List<DataTree<CallNumberClassifications>>
                    {
                        new DataTree<CallNumberClassifications>() {Data = dataset.ElementAt(counter), Parent = tree.Root}
                    };
                }
                else
                {
                    tree.Root.Children.Add(new DataTree<CallNumberClassifications> { Data = dataset.ElementAt(counter), Parent = tree.Root });
                }

                counter++;

                // Adding to second level.
                for (int j = 0; j < 4; j++)
                {
                    if (tree.Root.Children[i].Children is null)
                    {
                        tree.Root.Children[i].Children = new List<DataTree<CallNumberClassifications>>
                        {
                            new DataTree<CallNumberClassifications>() {Data = dataset.ElementAt(counter), Parent = tree.Root.Children[i]}
                        };
                    }
                    else
                    {
                        tree.Root.Children[i].Children.Add(new DataTree<CallNumberClassifications> { Data = dataset.ElementAt(counter), Parent = tree.Root.Children[i]});
                    }

                    counter++;

                    // Adding to third level.
                    for (int k = 0; k < 2; k++)
                    {
                        if (tree.Root.Children[i].Children[j].Children is null)
                        {
                            tree.Root.Children[i].Children[j].Children = new List<DataTree<CallNumberClassifications>>
                            {
                                new DataTree<CallNumberClassifications>() {Data = dataset.ElementAt(counter), Parent = tree.Root.Children[i].Children[j]},
                            };
                        }
                        else
                        {
                            tree.Root.Children[i].Children[j].Children.Add(new DataTree<CallNumberClassifications> { Data = dataset.ElementAt(counter), Parent = tree.Root.Children[i].Children[j] });
                        }

                        counter++;
                    }
                }
            }
            return tree;
        }
    }
}
