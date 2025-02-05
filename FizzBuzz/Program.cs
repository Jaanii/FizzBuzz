public class FizzBuzz
{
    public static void Main(string[] args)                //Writes out all numbers from 1-100. 
    {
        for (int i = 1; i <= 100; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)            //If the number is divisible with 3 and 5 write fizzbuzz
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)                 //If it's divisible by 3 write fizz 
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)           //If it's divisible by 5 write buzz
            {
                Console.WriteLine("Buzz");

            }
            else                           //else print the number.
            {
                Console.WriteLine(i);
            }
        }
    }
}
