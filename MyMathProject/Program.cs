namespace MyMathProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static double parseWrittenInput(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                return result;
            }

        }

        public static int ReadInt()
        {
            string writtenInput ="";
            double valInput = 0;
            do
            {
                Console.WriteLine("Gebe eine positive Zahl ein ");
                writtenInput = Console.ReadLine();
                valInput = parseWrittenInput(writtenInput);
                if (valInput == 0)
                {
                    Console.WriteLine("Flasche eingabe ");
                }
                
            } while ();
        }
    }
}