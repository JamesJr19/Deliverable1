using System;

namespace Deliverable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        start:
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            Console.WriteLine("How many people are traveling in your group?");
            int groupSize = Convert.ToInt32(Console.ReadLine());


            string result = "Since you are traveling in a group of " + groupSize + " going on a " + vacationType + " vacation, I recommend taking a ";
            string destination1 = "New Orleans";
            string destination2 = "a beach vacation in Mexico";
            string destination3 = "go whitewater rafting the Grand Canyon";
            string travelSuggestion1 = "first class flight";
            string travelSuggestion2 = "helicopter";
            string travelSuggestion3 = "charter flight";

            if (groupSize <= 2 && vacationType == "musical")
            {
                Console.WriteLine(result + travelSuggestion1 + " to " + destination1 + ".");
            }
            else if (groupSize > 2 && groupSize <= 5 && vacationType == "musical")
            {
                Console.WriteLine(result + travelSuggestion2 + " to " + destination1 + ".");
            }
            else if (groupSize > 5 && vacationType == "musical")
            {
                Console.WriteLine(result + travelSuggestion3 + " to " + destination1 + ".");
            }


            else if (groupSize <= 2 && vacationType == "tropical")
            {
                Console.WriteLine(result + travelSuggestion1 + " to " + destination2 + ".");
            }
            else if (groupSize > 2 && groupSize <= 5 && vacationType == "tropical")
            {
                Console.WriteLine(result + travelSuggestion2 + " to " + destination2 + ".");
            }
            else if (groupSize > 5 && vacationType == "tropical")
            {
                Console.WriteLine(result + travelSuggestion3 + " to " + destination2 + ".");
            }


            else if (groupSize <= 2 && vacationType == "adventurous")
            {
                Console.WriteLine(result + travelSuggestion1 + " to " + destination3 + ".");
            }
            else if (groupSize > 2 && groupSize <= 5 && vacationType == "adventurous")
            {
                Console.WriteLine(result + travelSuggestion2 + " to " + destination3 + ".");
            }
            else if (groupSize > 5 && vacationType == "adventurous")
            {
                Console.WriteLine(result + travelSuggestion3 + " to " + destination3 + ".");
            }

            Console.ReadLine();

            goto start;
        }
    }
}



