// for the extra creativity, I have created a List of Dictionaries to have multiple scriptures that the program will pull from at random.  They may be single verses or multiple, and the Hide function filters to only replace unhidden words with underscores.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Dictionary<string, string>> scriptureList = new List<Dictionary<string, string>>();
        Dictionary<string, string> Nephi = new Dictionary<string, string>()
        {
            {"book", "2 Nephi"},
            {"chapter", "2"},
            {"verse", "25"},
            {"verseHigh", null},
            {"text", "Adam fell that men might be; and men are, that they might have joy."}
        };
        Dictionary<string, string> Moroni = new Dictionary<string, string>()
        {
            {"book", "Moroni"},
            {"chapter", "7"},
            {"verse", "16"},
            {"verseHigh", null},
            {"text", "For behold, the Spirit of Christ is given to every man, that he may know good from evil; wherefore, I show unto you the way to judge; for every thing which inviteth to do good, and to persuade to believe in Christ, is sent forth by the power and gift of Christ; wherefore ye may know with a perfect knowledge it is of God."}
        };
        Dictionary<string, string> Alma = new Dictionary<string, string>()
        {
            {"book", "Alma"},
            {"chapter", "32"},
            {"verse", "14"},
            {"verseHigh", "15"},
            {"text", "And now, as I said unto you, that because ye were compelled to be humble ye were blessed, do ye not suppose that they are more blessed who truly humble themselves because of the word?  Yea, he that truly humbleth himself, and repenteth of his sins, and endureth to the end, the same shall be blessed—yea, much more blessed than they who are compelled to be humble because of their exceeding poverty."}
        };

        scriptureList.Add(Nephi);
        scriptureList.Add(Moroni);
        scriptureList.Add(Alma);

        Random choice = new Random();
        Dictionary<string, string> randomScripture = scriptureList[choice.Next(0, 3)];

        Reference newReference = new Reference(randomScripture["book"], randomScripture["chapter"], randomScripture["verse"], randomScripture["verseHigh"]);
        
        Scripture newScripture = new Scripture(newReference, randomScripture["text"]);
        newScripture.GetDisplayText();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string answer = "";
        answer = Console.ReadLine();
        if (answer == "quit")
        {
            return;
        }
        while (newScripture.IsComplete() == false)
        {
            newScripture.HideText();
            newScripture.GetDisplayText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            if (answer == "quit")
            {
                return;
            }
        }
        return;
    }
}