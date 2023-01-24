using System;
using CircleObjects;
using static System.Net.Mime.MediaTypeNames;
//The application prompts the user to enter a radius; the user may enter a decimal number.


int x = 1;
bool goProgram = true;
while (goProgram)
{
    Console.WriteLine("Please enter a radius.  You may use a decimal number.");
    double i = int.Parse(Console.ReadLine());

    //The application displays an error if the user enters invalid data and asks the user again for a radius
    bool numverify = true;
    while (numverify)
    {
        if (i < 0)
        {
            //Console.WriteLine($"You have entered {radi} as a radius for the cirle.");
            //numverify = false;

            Console.WriteLine("Please enter a number greater than 0");
            return;
        }
        else
        {
            //Console.WriteLine("Please enter a number ");
            Console.WriteLine($"You have entered {i} as a radius for the cirle.");
            numverify = false;

        }
        //  When the user enters valid data, the application calculates the area and circumference of the circle and rounds to the nearest 2 decimal places and prints out both.
        Circle myCircle = new Circle(i);
        Console.WriteLine();
        Console.WriteLine($"With a radius of {i}, the circumfrence is:  ");
        Console.WriteLine(myCircle.CalculateCircumference());
        Console.WriteLine();
        Console.WriteLine("The formatted circumference results in:");
        Console.WriteLine(myCircle.CalculateFormattedCircumference());
        Console.WriteLine();
        Console.WriteLine($"With a radius of {i}, the area of the circle is:  ");
        Console.WriteLine(myCircle.CalculateArea());
        Console.WriteLine();
        Console.WriteLine("The formatted area results in:");
        Console.WriteLine(myCircle.CalculateFormattedArea());
        Console.WriteLine();



        while (true)

        {
            Console.WriteLine("Do you want to go again? y/n");
            string answr = Console.ReadLine().ToLower().Trim();

            if (answr == "y")
            {
                goProgram = true;
                x = x + 1;
                break;


            }
            else if (answr == "n")
            {
                Console.WriteLine();
                Console.WriteLine($"Thank you for playing {x} times!");                
                goProgram = false;
                break;

            }
            else
            {
                Console.WriteLine("That was not a valid answer.  Please enter y/n");
            }



        }






        //The application asks the user whether they want to do another.
    }

}

