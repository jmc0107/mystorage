namespace Intro_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("GoodMorning, Manager!")
            
            for(;;)
            {
                Console.WriteLine();
                Console.WriteLine("************* Menu *************");
                Console.WriteLine();
                Console.WriteLine("1. Cheeseburger");
                Console.WriteLine("2. Hamburger");
                Console.WriteLine("3. Chicken Burger");
                Console.WriteLine("4. Veggie Bruger");
                Console.WriteLine();
                
                Console.Write("Your Choice (Q to Quit) ==> ");
                string answer - Console.ReadLine();
                
                Console.writeLine();
                
                if (answer == "Q" || answer == "q")
                {
                    break;
                }
                if (answer == "Q" || answer == "q")
                {
                    break;
                }
                if (answer == "1")
                {
                    Console.WriteLine("Cheeseburger: $7.99");
                }
                else if (answer == "2")
                {
                    Console.WriteLine("Hanburger: $6.99");
                }
                else if (answer == "3")
                {
                    Console.WriteLine("Chicken Burger: $6.50");
                }
                else if (answer == "4")
                {
                    Console.WriteLine("Veggie Burger: $6.00");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input");
                }
        }
    }
}
