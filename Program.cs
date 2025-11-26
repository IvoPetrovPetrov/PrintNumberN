namespace PrintNumberN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number;
            do
            {
                Console.WriteLine("Please enter a number between -1000 and 999:");
                number = int.Parse(Console.ReadLine());
            }
            while (number < -1000 || number > 999);

            for (int i = number; i <= 999; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
