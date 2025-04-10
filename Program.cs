
// Elora Smith, 4/7/25, Lab 10 Madlibs #2

using System.Collections;

class Program {
    static void Main (string[] filenames)
    {
        Dictionary <string, List <string>> wordCategories = new();
        wordCategories.Add("past-tense-verb", new List<string> {"ate", "loved", "studied", "walked", "cooked", "watched", "counted", "fought", "poked", "watered"});
        wordCategories.Add("Noun", new List<string> {"monster", "apple", "bug", "mob boss", "castle", "hunter", "flower", "mirror", "relic", "camel"});
        wordCategories.Add("adjective", new List<string> {"sleepy", "terrifying", "loose", "miniscule", "lumbering", "evil", "blue", "rabid", "golden", "difficult"});
        wordCategories.Add("plural-noun", new List<string> {"crows", "houses", "bugs", "cannons", "violins", "meetings", "waterbottles", "cucumbers", "gummies", "socks"});
        wordCategories.Add("Verb", new List<string> {"punch", "kiss", "drop", "open", "sing", "attack", "beat", "steal", "lay", "whistle"});
        wordCategories.Add("subject", new List<string> {"math", "history", "english", "french", "physics", "art", "debate", "chemistry", "geology", "music"});

        string[] stories = new string[2];
        for (int i = 0; i < filenames.Length; i++) 
        {
            stories[i] = File.ReadAllText(filenames[i]);
            //Console.WriteLine(stories[1]);
            string[] story = stories[i].Split(' ');
            for (int word = 0; word < story.Length; word++)
            {
                if (story[word].Contains("::"))
                {   
                    string newWord = FindCategory(story[word], ref wordCategories);
                    Console.Write($"{newWord}, ");
                }
                
                // NEXT, REPLACE WORD WITH NEW WORD (CHECK LAB 8 OR ASK SNAPCHAT)
                // WRITE STORY INTO ANOTHER FILE
                
            
            }
            Console.WriteLine("\n");
        }


        static string FindCategory(string word, ref Dictionary <string, List <string>> wordCategories)
        {
            Random rand = new Random();
            string newWord = "";
            if (word.Contains("past-tense-verb"))
                newWord = wordCategories["past-tense-verb"][rand.Next(10)];
            else if (word.Contains("Noun"))
                newWord = wordCategories["Noun"][rand.Next(10)];
            else if (word.Contains("adjective"))
                newWord = wordCategories["adjective"][rand.Next(10)];
            else if (word.Contains("plural-noun"))
                newWord = wordCategories["plural-noun"][rand.Next(10)];
            else if (word.Contains("Verb"))
                newWord = wordCategories["Verb"][rand.Next(10)];
            else if (word.Contains("subject"))
                newWord = wordCategories["subject"][rand.Next(10)];
            else
                newWord = word;
    
            return newWord;
        }     
    }
}

// story2 = 12 words to change
// story1 = 12 words to change
