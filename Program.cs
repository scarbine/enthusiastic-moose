using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

void MooseSays(string message) => Console.WriteLine($@"
                                      _.--^^^--,git
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

MooseSays("HI, I'M E N T H U S I A S T I C!");
MooseSays("Im really enthusiatic");

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N):");
        answer = Console.ReadLine().ToLower();
    }
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

// bool isTrue = MooseAsks("Are you alive?");
// Console.WriteLine(isTrue);

AliveQuestion();

void AliveQuestion()
{
    bool isTrue = MooseAsks("Are you alive?");
    if (isTrue)
    {
        MooseSays("I dont belive you!");
    }
    else
    {
        MooseSays("I knew it!");
    }
}

CryingQuestion();

void CryingQuestion()
{
    bool isTrue = MooseAsks("Are you crying?");
    if(isTrue)
    {
        MooseSays("It gonna be otay!");
    }
    else
    {
        MooseSays("Im not crying. You're Crying!");
    }
}