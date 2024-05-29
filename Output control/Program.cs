namespace Output_control
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasStop = false;
            string userInput;
            string exitWord = "exit";

            while (hasStop == false)
            {
                userInput = Console.ReadLine();

                if (userInput == exitWord)
                {
                    hasStop = true;
                    Console.WriteLine("Программа остановлена!");
                    return;
                }
            }
        }
    }
}