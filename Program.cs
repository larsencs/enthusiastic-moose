using System;

namespace Moose
{
class Meese
{
    static void Main(string[] args)
    {
        Greeting();
        runProgram();
    }

    static void runProgram()
    {
        Greeting();
        MooseSays("What do you want to do?");
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1. Enthusiastic Moose");
        Console.WriteLine("2. Magic Moose");
        Console.WriteLine("Any other key to exit");

        string answer = Console.ReadLine();
        
        //TryParse returns true or false
        if(int.TryParse(answer, out int num))
        {
            switch(num)
            {
                case 1:
                    runEnthusiasticMoose();
                    break;
                case 2:
                    runMagicMoose();
                    break;
            }
        }
        
    }

    static void runMagicMoose()
    {
        MooseSays("Ask a question");
        Console.WriteLine("What is your question?");
        string question = Console.ReadLine();
        MooseSays($"In regards to {question}, {Fortune()}");

        while(!String.IsNullOrWhiteSpace(question))
        {
            MooseSays("Ask a question");
            Console.WriteLine("What is your question?");
            question = Console.ReadLine();
            MooseSays($"In regards to {question}, {Fortune()}");
        }
    }

    static void runEnthusiasticMoose()
    {
        MooseSays("Hello!");
        hasQuestion("Is Canada real?", "true");
        hasQuestion("Are you enthusiastic?", "enthusiastic");
        hasQuestion("Do you love C# yet?", "cSharp");
        hasQuestion("Do you want to know a secret?", "secret");
    }

    static void Greeting()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Sim!");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }

    static void MooseSays(string message)
    {
            Console.WriteLine(@$"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    static bool MooseAsks(string question)
    {
        Console.WriteLine($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while(answer != "y" && answer != "n")
        {
            Console.WriteLine($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        if(answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void hasQuestion(string question, string mood)
    {
        switch(mood)
        {
            case "enthusiastic":
                if(MooseAsks(question))
                 {
                    MooseSays("Yay!");
                }
                else
                {
                    MooseSays("You should try it!");
                }
                break;
            case "cSharp":
                if(MooseAsks(question))
                 {
                    MooseSays("Good job sucking up to your instructor!");
                }
                else
                {
                    MooseSays("You will...oh, yes, you will...");
                }
                break;
            case "secret":
                if(MooseAsks(question))
                 {
                    MooseSays("ME TOO!!!! I love secrets...tell me one!");
                }
                else
                {
                    MooseSays("Oh, no...secrets are the best, I love to share them!");
                }
                break;
            case "true":
                if(MooseAsks(question))
                 {
                    MooseSays("Really? It seems very unlikely");
                }
                else
                {
                    MooseSays("I knew it!");
                }
                    break;
        }
    }

    static string Fortune()
    {
        List<string> fortunes = new List<string>()
        {
            "As I see it, yes."
            , "Ask again later."
            , "Better not tell you now."
            , "Cannot predit now."
            , "Concentrate and ask again."
            , "Don't count on it."
            , "It is certain."
            , "It is decidedly so."
            , "Most likely."
            , "My reply is no."
            , "My sources say no."
            , "Outlook is not so good."
            , "Reply hazy, try again."
            , "Signs point to yes."
            , "Very doubtful."
            , "Without a doubt."
            , "Yes."
            , "Yes -- definitely."
            , "You may rely on it."
        };

        Random rnd = new Random();
        int index = rnd.Next(fortunes.Count);
        return fortunes[index];
    }




    
}
}

