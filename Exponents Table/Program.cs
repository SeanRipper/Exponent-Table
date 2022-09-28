namespace Exponents_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Welcome to the Powers Table! Please enter an integer between 1 and 1,290.");
                int input = int.Parse(Console.ReadLine());
                if (input >= 1 && input <= 1290)
                {
                    int square = CalcSquare(input);
                    int cube = square * input;

                    Console.WriteLine("You entered: " + input);
                    Console.WriteLine("Number: \n");
                    for (int i = 1; i <= input; i++)
                    {
                        Console.WriteLine(i);
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Squared: \n");
                    for (int c = 1; c <= input; c++)
                    {
                        Console.WriteLine(c * c);
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Cubed: \n");
                    for (int s = 1; s <= input; s++)
                    {
                        Console.WriteLine(s * s * s);
                   
                    }
                    Console.WriteLine("");
                } 
                else
                {
                    Console.WriteLine("That number is not between 1 and 1,290.");
                }


            
                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to go again? Y/N?");
                    string input2 = Console.ReadLine().ToLower();
                    if (input2 == "y")
                    {
                        goOn = true;
                        askAgain = false;
                    }
                    else if (input2 == "n")
                    {
                        Console.WriteLine("Goodbye.");
                        goOn = false;
                        askAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I did not understand that. \n");
                        askAgain = true;
                    }
                }
            }
        }
        public static int CalcSquare(int input)
        {
            int x = input * input;
                return x;
        }
    }
}