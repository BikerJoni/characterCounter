using System;
namespace NumberCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoise;
            do
            {

            
                Print("Welcome to app");
                Console.Write("Enter the text: ");
                string userInput = Console.ReadLine();

                int count = 0;
                int count1 = 0;
                int count2 = 0;
                
            

                foreach (char item in userInput)
                {
                    if (!char.IsLetterOrDigit(item))
                    {
                        count2++;
                    }
                    else if (char.IsDigit(item)) //(item is >= '0' and  <= '9')
                    {
                        count++;
                    }
                    else if (char.IsLetter(item))//(item >= 'a' && item <= 'z' || item >= 'A' && item <= 'Z')
                    {
                        count1++;
                    }
                }
                Print($"There are  {count1} letters\nThere are {count} numbers\nThere are {count2} characters");
                Console.WriteLine("do you want to repead one more time ? (if yes press + , or any bottom to exit )");
                userChoise = Console.ReadLine();
            } 
            while (userChoise is "+");


            static void Print(string text)
            {
                Console.WriteLine(text);
            }

        }

    }
}
