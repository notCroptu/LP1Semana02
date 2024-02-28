using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, response;

            do
            {
                Console.Write("What is your question? ");
                question = Console.ReadLine();

                if (question == "Is tomato a fruit?")
                {
                    response = "Yes!";
                }
                else if (question == "What's your name?")
                {
                    response = "My name is Mr. BMO.";
                }
                else if (question == "What's your favorite food?")
                {
                    response = "Microchips!";
                }
                else if (question == "What is your opinion about spiders?")
                {
                    response = "They bug me!";
                }
                else if (question == "EXIT")
                {
                    break;
                }
                else
                {
                    response = "Our communication skills are in different levels.";
                }
            
                Console.WriteLine(response);

            }   while (true);
        }
    }
}
