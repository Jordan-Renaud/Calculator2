using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //      First Program
            //In Rider, create a new .NET Core Console Application project
            // (File > New Solution, and select .NET Core > Console Application).
            // Give it a suitable name, like "Calculator".
            //You've got the Main method "for free". Write some code that just prints out
            //a welcome message for your calculator app - e.g. "Welcome to the calculator!".
            //Don't forget a ReadLine to make sure the program pauses at the end.
            //Run the program (Click the green 'Run Arrow' to the left of the Main method.

            Console.WriteLine("Welcome to the calculator!");

            //      Data Types and Variables
            // Prompt the user to enter one number
            // Prompt the user to enter a second number
            // Multiply the two numbers together and print out the result


            //      Branching
            // Let's enhance your Calculator a little further. We want to support
            // more operations than just multiplication. We'll do this by prompting
            // the user to enter an operator before they enter the numbers. So a typical program run might look like this:
            //To keep things simple, we’ll just use these 4 operators:
            //addition(+) subtraction(-) multiplication(*) division(/)


            string[] sassySayings1 = { "I should have been more specific, I meant an integer.",
                "Webster's Dictionary defines an intereger as: any of the natural numbers, the negatives of these numbers, or zero",
                "🤦‍♀️",
                "Ok so, don't type a letter, don't add decimal points.",
                "Honestly, I'm surprised you are functioning at all.",
                "Well done you did it!",
                "ha, you thought. But like actually though if you would type a number in that would be great.",
                "get fucked",
                "Alright you asked for it.",
                "Deleting System Data",
                "How do you like being fucked with?"
            };

            int trackingNum = 0;


            while (true)
            {
                //get operator
                Console.Write("Please enter an operator (+ - / *): ");
                string operatorType = Console.ReadLine();

                if (!"+-/*".Contains(operatorType))
                {
                    Console.WriteLine("Hey please enter either + or - or * or /");
                    continue;
                }

                //get number 1
                Console.Write("Please enter a number: ");
                string rawNum1 = Console.ReadLine();

                if (!int.TryParse(rawNum1, out int num1))
                {
                    Console.WriteLine(sassySayings1[trackingNum]);
                    if (trackingNum >= sassySayings1.Length - 1)
                    {
                        trackingNum = 0;
                    }
                    else
                    {
                        trackingNum++;
                    }
                    continue;
                }

                //get number 2
                Console.Write("Please enter a second number: ");
                string rawNum2 = Console.ReadLine();

                if (!int.TryParse(rawNum2, out int num2))
                {
                    Console.WriteLine("Well now we have to start again");
                }


                //handle operation
                switch (operatorType)
                {
                    case "*":
                        Console.WriteLine($"{num1} times {num2} equals {num1 * num2}");
                        continue;
                    case "/":
                        Console.WriteLine($"{num1} divided by {num2} equals {num1 / num2}");
                        continue;
                    case "+":
                        Console.WriteLine($"{num1} plus {num2} equals {num1 + num2}");
                        continue;
                    case "-":
                        Console.WriteLine($"{num1} minus {num2} equals {num1 - num2}");
                        continue;
                    default:
                        break;
                }
                
            }
        }
    }
}





