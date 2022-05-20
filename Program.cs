using System;
using System.Collections.Generic;

void MooseSays(string message)
{
    Console.WriteLine($@"
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

//Random numbers baby!
int GetARandomNumber(){
    Random r = new Random();
    int fortuneNumber = r.Next(0,20);
    return fortuneNumber;
}


//A list of fortunes
List<string> listOfFortunes = new List<string> {"As I see it, yes", "Ask again later","Better not tell you now", "Cannot predict now","Concentrate and ask again"," Don’t count on it", "It is certain", "It is decidedly so", "Most Likely", "My reply is no", "My sources say no", "Outlook not so good", "Outlook good", "Reply Hazy, try again", "Signs point to Yes", "Very Doubtful", "Without a doubt","Yes", "Yes - Definitely", "You may rely on it"};

//This will take in the user's question, we dont' really do anything with it
//It just mimics the feel of asking a question
string Hear()
{
    Console.WriteLine("My Question:");
    string question = Console.ReadLine();
    if(question == "exit")
    {
        string fortune = "exit";
        return fortune;
    }
    else
    {
        string myfortune = Reply();
        return myfortune;
    }
}
string Reply()
{
    string fortune = listOfFortunes[GetARandomNumber()+1];
    Console.WriteLine(fortune);
    return fortune;
}

//This will allow for many questions to be asked until the user no loner wants to ask questions

void AskQuestions()
{   
    string response = "";
    do{
        MooseSays("Ask me a question and recieve my Wisdom or leave my presence by typing 'exit'");
        response = Hear();
        Console.WriteLine("Push enter to proceed");
        string ReadyToProceedFeedBack = Console.ReadLine();
    }
    while(response != "exit");
}




//This directs the program
void Main()
{
    Console.WriteLine("Behold the Magic Moose");
    Console.WriteLine("-----------------------");
    Console.WriteLine();
    AskQuestions();
}

Main();
