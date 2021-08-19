using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

string HumanQuestion()
{
   Console.WriteLine("Ask the Magic Moose a question.");
    string HQ = Console.ReadLine();
    return HQ;
};

string mooseAnswer()
{
string mooseAnswer = "This is my house.";
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





