using System;
using System.Collections.Generic;

// below is main program code doing all the talking
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // this part provides text encoding to display emojis
        EmojiAdapter adapter = new EmojiAdapter();
        //creating emoji adapter class 

        Console.WriteLine("I think minions are cute. Use an emoji code to :fire,:lol, :love or :agree");

        string input = Console.ReadLine()!;//added ! to fix warning about null
        string result = adapter.Convert(input);//to convert input, use this specific adapter

        Console.WriteLine("You think minions are " + result);
    }
}

// adapter code: connects to emoji library
class EmojiAdapter
{
    private EmojiLibrary library = new EmojiLibrary();

    public string Convert(string input)
    {
        string code = input.Replace(":", "");
        return library.emojis[code];
    }
    //convert takes the users text, deletes :,
    // then looks for that word in the libary, returns emoji
}

// adaptee: this part has the emojis
class EmojiLibrary //creates variable called emojis
//emojis holds dictionary, key and value are strings
// both are strings because emojis are actually special text codes
{
    public Dictionary<string, string> emojis = new Dictionary<string, string>
    {
        { "fire",  "🔥" },
        { "lol",   "😂" },
        { "love",  "❤️" },
        { "agree", "👍" }
    };
}