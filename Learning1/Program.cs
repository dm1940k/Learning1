
using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string[] pronoun = { "he", "she", "they" };
            // assigns the gender he, she, or they to the variable pronoun, which will later be called to pick names
            string randomPronoun = StringRandomizer(pronoun);
            string pronoun2;

            if (randomPronoun.Contains("they"))
            {
                pronoun2 = "their";
            }
            else if (randomPronoun.Contains("she"))
            {
                pronoun2 = "her";
            }
            else
            {
                pronoun2 = "his";
            }
            // assigns his, her, their depending on the value in pronoun variable

            string pronoun3;

            if (randomPronoun.Contains("they"))
            {
                pronoun3 = "them";
            }
            else if (randomPronoun.Contains("she"))
            {
                pronoun3 = "her";
            }
            else
            {
                pronoun3 = "him";
            }
            // assigns him, her, them depending on the value in pronoun variable

            string isare;

            if (randomPronoun.Contains("they"))
            {
                isare = "are";
            }
            else
            {
                isare = "is";
            }
            // assigns are or is, depending on the pronoun variable

            int raceNumber = NumberRandomizer(0, 9);
            // picks a number at random for use assigning a race from raceArray.

            string[] raceArray = { "dragonborn", "dwarf", "elf", "gnome", "half-elf", "halfling", "half-orc", "human", "tiefling" };
            int[,] raceStatArray = new int[,] {
                //dragonborn
                { 2, 0, 0, 0, 0, 1, 30 },
                //dwarf
                { 0, 0, 3, 0, 0, 0, 25 },
                //elf
                { 0, 2, 0, 0, 0, 0, 30 },
                //gnome
                { 0, 0, 0, 2, 0, 0, 25 },
                //half-elf
                { 0, 0, 0, 0, 0, 2, 30 },
                //halfling
                { 0, 2, 0, 0, 0, 0, 25 },
                //half-orc
                { 2, 0, 1, 0, 0, 0, 30 },
                //human
                { 1, 1, 1, 1, 1, 1, 30 },
                //tiefling
                { 0, 0, 0, 1, 0, 2, 30 }
            };
            // creates the stat block for each race, referenced heavily below;

            int statRoll = DiceRoll(1, 7);

            string charRace = raceArray[raceNumber];
            int str = statRoll + raceStatArray[raceNumber, 0];
            double strMath = (str - 10) / 2;
            double strMod = Math.Floor(strMath);
            int dex = statRoll + raceStatArray[raceNumber, 1];
            double dexMath = (dex - 10) / 2;
            double dexMod = Math.Floor(dexMath);
            int con = statRoll + raceStatArray[raceNumber, 2];
            double conMath = (con - 10) / 2;
            double conMod = Math.Floor(conMath);
            int intel = statRoll + raceStatArray[raceNumber, 3];
            double intelMath = (intel - 10) / 2;
            double intelMod = Math.Floor(intelMath);
            int wis = statRoll + raceStatArray[raceNumber, 4];
            double wisMath = (wis - 10) / 2;
            double wisMod = Math.Floor(wisMath);
            int cha = statRoll + raceStatArray[raceNumber, 5];
            double chaMath = (cha - 10) / 2;
            double chaMod = Math.Floor(chaMath);



            string[] firstNameArrayHumMal = {
                "Anlow",
                "Arando",
                "Bram",
                "Cale",
                "Dalkon",
                "Daylen",
                "Dodd",
                "Dungarth",
                "Dyrk",
                "Eandro",
                "Falken",
                "Feck",
                "Fenton",
                "Gryphero",
                "Hagar",
                "Jeras",
                "Krynt",
                "Lavant",
                "Leyten",
                "Madian",
                "Malfier",
                "Markus",
                "Meklan",
                "Namen",
                "Navaren",
                "Nerle",
                "Nilus",
                "Ningyan",
                "Norris",
                "Quentin",
                "Semil",
                "Sevenson",
                "Steveren",
                "Talfen",
                "Tamond",
                "Taran",
                "Tavon",
                "Tegan",
                "Vanan",
                "Vincent"
            };
            // the name array from which a human male name is picked

            string firstNameHumMal = StringRandomizer(firstNameArrayHumMal);
            // samples a name from firstNameArrayHumMal, because I can't figure out how to combine multiple arrays and then sample them.

            string[] firstNameArrayHumFem = {
                "Azura",
                "Brey",
                "Hallan",
                "Kasaki",
                "Lorelei",
                "Mirabel",
                "Pharana",
                "Remora",
                "Rosalyn",
                "Sachil",
                "Saidi",
                "Tanika",
                "Tura",
                "Tylsa",
                "Vencia",
                "Xandrilla"
            };
            //the name array from which a human female name is picked

            string firstNameHumFem = StringRandomizer(firstNameArrayHumFem);
            //samples a name from first_name_array_hum_fem

            string firstName;
            string[] bothFirstNames = { firstNameHumFem, firstNameHumMal };
            if (randomPronoun.Contains("they"))
            {
                firstName = StringRandomizer(bothFirstNames);
            }
            else if (randomPronoun.Contains("she"))
            {
                firstName = firstNameHumFem;
            }
            else
            {
                firstName = firstNameHumMal;
            }
            //determines if first name needs to be pulled from the male array, female array, or both.

            string[] lastNameArrayHum = {
                "Arkalis",
                "Armanci",
                "Bilger",
                "Blackstrand",
                "Brightwater",
                "Carnavon",
                "Caskajaro",
                "Coldshore",
                "Coyle",
                "Cresthill",
                "Cuttlescar",
                "Daargen",
                "Dalicarlia",
                "Danamark",
                "Donoghan",
                "Drumwind",
                "Dunhall",
                "Ereghast",
                "Falck",
                "Fallenbridge",
                "Faringray",
                "Fletcher",
                "Fryft",
                "Goldrudder",
                "Grantham",
                "Graylock",
                "Gullscream",
                "Hindergrass",
                "Iscalon",
                "Kreel",
                "Kroft",
                "Lamoth",
                "Leerstrom",
                "Lynchfield",
                "Moonridge",
                "Netheridge",
                "Oakenheart",
                "Pyncion",
                "Ratley",
                "Redraven",
                "Revenmar",
                "Roxley",
                "Sell",
                "Seratolva",
                "Shanks",
                "Shattermast",
                "Shaulfer",
                "Silvergraft",
                "Stavenger",
                "Stormchapel",
                "Strong",
                "Swiller",
                "Talandro",
                "Targana",
                "Towerfall",
                "Umbermoor",
                "Van Devries",
                "Van Gandt",
                "Van Hyden",
                "Varcona",
                "Varzand",
                "Voortham",
                "Vrye",
                "Webb",
                "Welfer",
                "Wilxes",
                "Wintermere",
                "Wygarthe",
                "Zatchet",
                "Zethergyll"
            };
            // the name array from which a human last name is picked 

            string lastName = StringRandomizer(lastNameArrayHum);
            //samples a last name from the lastNameArrayHum
            
            int charLevel = rnd.Next(1, 21);
            //randomly assigns a number between 1 and 20 to the variable level

            string[] classNameArray = { "artificer", "barbarian", "bard", "cleric", "druid", "fighter", "monk", "paladin", "ranger", "rogue", "sorcerer", "warlock", "wizard" };
            int[] classHPArray = { 8, 12, 8, 8, 8, 10, 8, 10, 10, 8, 6, 8, 6 };
            //2 arrays that contains all the avialable classes, in individual arrays that also contain the hit die value for that class. Currently used by charClass, firstLevelHitpoints, and hitDice.


            int classNumber = rnd.Next(0, 12);
            //picks a random array from class_array

            string charClass = classNameArray[classNumber];
            //samples a class from the classNameArray

            int firstLevelHitpoints = (int)(classHPArray[classNumber] + conMod);
            //pulls the base HP from class_array and adds the con mod, giving you the first level hp which is always the highest number.

            int hitDice = classHPArray[classNumber];
            //uses the number picked by class_number to grab the HP number that correlates with char_class from class_array.

            double hitpoints = 0;
            //establishes hitpoints as a variable with a value of 0

            for (int i = 1; i < charLevel; i++)
            {
                hitpoints += rnd.Next(1, hitDice) + conMod;
            }
            //runs a for loop to add a set of random numbers + con_mod, the amount of times based on the level variable, the range for the random number based on the hitDice variable. Starts at 1 instead of 0 so the first level is left out, since that level will be the max dice value + con_mod. This is added in later.

            double totalHitpoints = hitpoints + firstLevelHitpoints;
            //establishes the total hitpoints, based on the hitpoints variable plus first_level_hitpoints

            string[] raceArrayPlur = {
                            "dragonborn",
                            "dwarves",
                            "elves",
                            "gnomes",
                            "half-elves",
                            "halflings",
                            "half-orcs",
                            "humans",
                            "tieflings"
                            };
            //the race plural array from which a plural race is picked

            string racePlural = StringRandomizer(raceArrayPlur);
            //samples a race from race_array_plur

            string[] alignArray = {
                            "lawful good",
                            "nuetral good",
                            "chaotic good",
                            "lawful nuetral",
                            "true nuetral",
                            "chaotic nuetral",
                            "lawful evil",
                            "nuetral evil",
                            "chaotic evil",
                            };
            //the alignment array from which an alignment is picked

            string alignment = StringRandomizer(alignArray);
            //samples an alignment from align_array

            string[] characteristicArray = {
              "a big grouch",
              "very friendly",
              "pretty shy",
              "talkative",
              "a religious zealot",
              "not a fan of fish",
              "an orphan",
              "an idiot",
              "supremely aware of #{pronoun2} lack in the romance department",
            };
            //rray of random characteristics

            //reads the adjectives.csv file to the characteristics_array2 variable. Doesn't seem to work the way I want. When called later on, it prints the whole array. 

            string[] characteristicArray2 = {
              "bigoted",
              "bitchy",
              "blunt",
              "boisterous",
              "bossy",
              "brave",
              "callous",
              "cautious",
              "charming",
              "cheerful",
              "churlish",
              "cold",
              "composed",
              "conceited",
              "condescending",
              "confident",
              "conscientious",
              "cool-headed",
              "courageous",
              "crabby",
              "crass",
              "critical",
              "cruel",
              "cunning",
              "curious",
              "cynical",
              "decisive",
              "dependable",
              "determined",
              "driven",
              "fearless",
              "flamboyant",
              "flirtatious",
              "friendly",
              "gruff",
              "headstrong",
              "hot-headed",
              "lazy",
              "loud",
              "Machiavellian",
              "moody",
              "philosophical",
              "pompous",
              "pretty chill",
              "romantic",
              "selfish",
              "sensitive",
              "tactless",
              "thoughtful",
              "wary",
              "depressed",
              "delightful",
              "demure",
              "diligent",
              "disruptive",
              "discerning",
              "dramatic",
              "dutiful",
              "frank",
              "funny",
              "fussy",
              "generous",
              "gentle",
              "gloomy",
              "grave",
              "grouchy",
              "guarded",
              "hateful",
              "helpful",
              "hot-headed",
              "hypercritical",
              "level-headed",
              "mean",
              "methodical",
              "meticulous",
              "miserable",
              "motivated",
              "morose",
              "naive",
              "nosy",
              "peaceful",
              "pensive",
              "plain-speaking",
              "playful",
              "plucky",
              "positive",
              "proud",
              "prejudiced",
              "quick-tempered",
              "reliable",
              "reluctant",
              "resentful",
              "resourceful",
              "respectful",
              "restless",
              "sassy",
              "sentimental",
              "short-tempered",
              "snobby",
              "sombre",
              "sophisticated",
              "spiteful",
              "soulless",
              "stern",
              "stoic",
              "surly",
              "sweet",
              "suspicious",
              "talented",
              "warm-hearted",
              "wary",
              "well-intentioned",
              "adventurous",
              "agreeable",
              "ambitious",
              "anxious",
              "apathetic",
              "argumentative",
              "assertive",
              "attentive",
              "impulsive",
              "intolerant",
              "inventive",
              "overemotional",
              "unpredictable",
              "eager",
              "easy-going",
              "egotistical",
              "emotional",
              "enterprising",
              "enthusiastic",
              "excitable",
              "impatient",
              "impetuous",
              "inconsiderate",
              "insensitive",
              "irritable",
              "obnoxious",
              "old-fashioned",
              "outgoing",
              "outspoken",
              "unbalanced",
              "unstable",
              "absent minded",
              "melodramatic",
              "paranoid",
              "chipper",
              "passive-aggressive",
              "amicable",
              "broad-minded",
              "compassionate",
              "considerate",
              "diplomatic",
              "faithful",
              "hard-working",
              "modest",
              "a big grouch",
              "very friendly",
              "pretty shy",
              "talkative",
              "a religious zealot",
              "not a fan of fish",
              "an orphan",
              "an idiot",
              "supremely aware of #{pronoun2} lack in the romance department"
            };
            //(list taken from whothefuckismydndcharacter.com to save time while proofing. Be careful if publishing to remove this list and use only own work.)second array of random characteristics



            //string[] allChar = StringRandomizer(characteristicArray), + characteristicArray2;

            string char1 = StringRandomizer(characteristicArray2);
            //allChar.delete(char_1);
            //picks a characteristic from characteristic_array

            string char2 = StringRandomizer(characteristicArray2);
            //picks a second characteristic from characteristic_array

            double armorClass = 10 + dexMod;

            int moveSpeed = raceStatArray[raceNumber,6];

            int profBonus = 2;

            if (charLevel <= 4)
            {
                profBonus += 0;
            }
            else if (charLevel <= 8)
            {
                profBonus += 1;
            }
            else if (charLevel <= 12)
            {
                profBonus += 2;
            }
            else if (charLevel <= 16)
            {
                profBonus += 3;
            }
            else if (charLevel <= 20)
            {
                profBonus += 4;
            }
            //proficiency bonus loop. prof_bonus is established at a baseline of 2, the lowest it can be. Looks at level int and adds to prof_bonus depending on the level.


            //plus = if wis_mod > 0 then "+" else "" end
            // if/then/else argument to add a + or not. Replaced by "+" if wis_mod > 0, which is cleaner
            //used in the ability score modifier section to include a + if the number is above 0. 

            string[] likeHate = { "likes", "hates" };


            //                    #---   print section   ---#

            Console.WriteLine($"Your character is {firstName} {lastName}, a level 5 {Capitalizer(charRace)} {Capitalizer(charClass)}.\n{firstName} has an alignment of {alignment}, and really {StringRandomizer(likeHate)} {Capitalizer(racePlural)}.");
            Console.WriteLine($"\n{Capitalizer(randomPronoun)} {isare} {char1} and {char2}.");
            Console.WriteLine($"\n");
            Console.WriteLine($"{firstName}'s ability scores are:");
            Console.WriteLine($"\n{str} Strength ({strMod})");
            Console.WriteLine($"\n{dex} Dexterity ({dexMod})");
            Console.WriteLine($"\n{con} Constitution ({conMod})");
            Console.WriteLine($"\n{intel} Intelligence ({intelMod})");
            Console.WriteLine($"\n{wis} Wisdom ({wisMod})");
            Console.WriteLine($"\n{cha} Charisma ({chaMod})");

            //print "\n#{dex} Dexterity (#{" + " if dex_mod > 0}#{dex_mod})" figure out how to get a " + " to print if the int is above 0

            Console.WriteLine($"\n"); 
            Console.WriteLine($"\n");
            Console.WriteLine($"{firstName} has 20 hitpoints and an AC of 20");
            Console.WriteLine($"\n");
            Console.WriteLine($"{Capitalizer(randomPronoun)} can move {moveSpeed} feet per round.");
            Console.WriteLine($"\n{Capitalizer(pronoun2)} proficiency bonus is +{profBonus}.");
            //the user facing part of the code. Takes all of the variables defined above and slaps together some sort of character.
             
        }

       
        public static string StringRandomizer(string[] arrayToRandomize)
        {
            Random rand = new Random();

            int index = rand.Next(arrayToRandomize.Length);

            return arrayToRandomize[index];

            //picks a string at random from the input string array. Used to pick things like pronouns, adjectives, etc at random

        }
        public static int NumberRandomizer(int numToRandomize1, int numToRandomize2)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(numToRandomize1, numToRandomize2);

            return randomNumber;

            //picks an interger at random from a provided range.
        }
        public static int DiceRoll(int bottomOfRange, int topOfRange)
        {

		Random rnd = new Random();
        List<int> diceRolls = new List<int>();
        for (int i = 0; i<4; i++)
            //rolls picks 4 ("i<4") numbers at random based on the int range in the following ".Next(int, int)"
            {
                diceRolls.Add(rnd.Next(bottomOfRange,topOfRange));
            }
            diceRolls.Sort();
            diceRolls.RemoveAt(0);
            return diceRolls.Sum();
        }
        public static string Capitalizer(string wordToCapitalize)
        {
            string firstLetter = wordToCapitalize.Substring(0, 1);
            string restOfWord = wordToCapitalize.Substring(1);
            string capitalizedFirstLetter = firstLetter.ToUpper();
            string capitalizedWord = $"{capitalizedFirstLetter}{restOfWord}";
            return capitalizedWord;

        }
        
    }
}
