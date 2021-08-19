using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the Moose Speak!

MooseSays("HI, I'M E N T H U S I A S T I C!");
MooseSays("Im really enthusiatic");

// List of questions to use

string questionONE = "Are you alive?";
string answerOneTrue = "I dont belive you!";
string answerOneFalse = "I knew it!";

string questionTwo = "Are you crying?";
string answerTwoTrue = "It gonna be otay!";
string answerTwoFalse = "Im not crying! Your Crying!";

// Ask a question
MooseQuestion(questionONE,answerOneTrue, answerOneFalse );
MooseQuestion(questionTwo,answerTwoTrue, answerTwoFalse );

};

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

void MooseQuestion(string mooseQuestion, string mooseSaysTrue, string mooseSaysFalse)
{
    bool isTrue = MooseAsks(mooseQuestion);
    if (isTrue)
    {
        MooseSays(mooseSaysTrue);
    }
    else
    {
        MooseSays(mooseSaysFalse);
    }
}


