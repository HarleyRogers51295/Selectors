using System;

namespace Selectionstatments_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            //guess the number game. if else-if statement
             var r = new Random();
             var favNumber = r.Next(1, 10);

             var userInput = int.Parse(Console.ReadLine());


             if(userInput > favNumber){
                 Console.WriteLine("Too High!");
             }
             else if(userInput < favNumber){ 
                 Console.WriteLine("Too Low!");
             }
             else{
                 Console.WriteLine("You Win!");
             }

             //switch statment
            Console.WriteLine("What is your favorate school subject?");
            var favSchoolSub = Console.ReadLine();

            switch (favSchoolSub)
            {
                case "math":
                    Console.WriteLine("Nerd");
                    break;
                case "science":
                    Console.WriteLine("Blow Jank Up!");
                    break;
                case "reading":
                    Console.WriteLine("Cool!");
                    break;
                case "Gym":
                    Console.WriteLine("jock");
                    break;
                case "english":
                    Console.WriteLine("Pinkies out!");
                    break;
                default:
                    Console.WriteLine("Did you even go to school?");
                    break;


            }

        }
    }
}
