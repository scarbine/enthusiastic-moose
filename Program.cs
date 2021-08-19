using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// =List of answers that the moose can say

string[] answers = {"As i see it, yes", "Ask again later" , "Better not tell you now" , "Dont Count on it", "Most Likely"};
int answersLength = answers.Length;

string HumanQuestion()
{
   Console.WriteLine("Ask the Magic Moose a question.");
    string HQ = Console.ReadLine();
    return HQ;
};

string mooseAnswer()
{
Random r = new Random();
int genRand = r.Next(0,answersLength);
string mooseAnswer = answers[genRand];
return mooseAnswer;
}

MooseSays(HumanQuestion() , mooseAnswer());

};

void MooseSays(string askedQuestion, string message ) => Console.WriteLine($@"
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
                      \ / o| |o \ /   {askedQuestion}
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





