using System;
// Stores journal prompts and returns one at random.
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
       "What challenge helped me grow today?",

    "What is one thing I am grateful for today?",

    "What goal did I make progress on today?",

    "What made today different from yesterday?",

    "What is something kind I did for someone today?",

    "What is one memory I want to keep from today?",

    "What inspired me today?",

    "How did I feel God's presence today?",

    "What blessing am I most grateful for today?",

    "Which Bible scripture inspired me today?",

    "How did I show kindness or Christ-like love today?",

    "What challenge did God help me overcome today?",

    "What prayer was on my heart today?",

    "What is one lesson God taught me today?",

    "How can I grow spiritually tomorrow?",

    "What act of faith strengthened me today?",

    "What scripture would I like to study more deeply?"
    };
    // Picks a random prompt from the list.
     public string GetRandomPrompt()

    {

        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];

    }
}