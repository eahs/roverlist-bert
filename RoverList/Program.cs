using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            // TODO:  Implement the RoverList class
            
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("bert");
            list.Add("skirt");
            list.Add("dirt");
            list.Add("flirt");
            list.Add("shirt");
            list.Add("exert");
            list.Add("concert");
            list.Add("hurt");
            list.Add("alert");
            list.Add("kurt");
            list.Add("introvert");
            list.Add("dessert");
            list.Add("yogurt");
            list.Add("divert");
            list.Add("burnt");
            list.Add("assert");
            // TODO:  Print out the list
            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            Console.WriteLine("Enter a word to be added to the list. Enter 'done' when complete.");
            
            // TODO:  Print out the list
            String input = "";
            while(input != "done")
            {
                if(input == "done")
                {
                    break;
                }
                else 
                { 
                    list.Add(input);
                    input = Console.ReadLine();
                }
            }
            
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine("Enter a word to be added to the FRONT of the list. Enter 'done' when complete.");
            
            // TODO:  Print out the list
            input = "";
            while (input != "done")
            {
                if (input == "done")
                {
                    break;
                }
                else
                {
                    list.Add(0, input);
                    input = Console.ReadLine();
                }
            }
            list.ListNodes();

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
