namespace trycatch_and_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number!");
            string userInput = Console.ReadLine();
            int num1 = 5;
            int num2 = 0;
            int result;

            result = num1/num2

            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {

                Console.WriteLine( "please enter a correct format");
            }
            catch (OverflowException)
            {
                Console.WriteLine( "your number is too long for int32.");
            }
            finally { Console.WriteLine("this is called anyways"); }

            
            Console.ReadKey();
        }
    }
}
