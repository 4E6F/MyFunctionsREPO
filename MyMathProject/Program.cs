namespace MyMathProject
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Gebe eine positive natürliche Zahl ein");
            Console.WriteLine($"Input Value: {program.ReadInt()}");
            Console.WriteLine("");
            program.ShowResult(12, 16);
            Console.WriteLine("");
            Console.WriteLine("Max: " + MyMath.Calc_max(new int[] { 7, 5, 32, 6 }));
            Console.WriteLine("Min: " + MyMath.Calc_min(new int[] { 8, 5, 32, 6 }));
            Console.WriteLine("Mean: " + MyMath.Calc_mean(new int[] { 9, 5, 32, 6 }));
            Console.WriteLine("");
            program.InteractWithGgtKgvCalculator();

            
            
        }


        public void InteractWithGgtKgvCalculator()
        {
            Program programm = new Program();
            int a = 0;
            int b = 0;
            do
            {
                Console.WriteLine("Gebe eine positive natürliche Zahl ein für GGT, KGV");
                a = programm.ReadInt();
                b = programm.ReadInt();
                programm.ShowResult(a,b);
                Console.WriteLine("Leave == Escape Key");
                Console.WriteLine("Continue == random Key");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
        public void ShowResult(int a, int b)
        {
            Console.WriteLine($"ggT von {a} und  {b} ist {MyMath.Calc_ggT(a,b)}");
            Console.WriteLine($"kgV von {a} und  {b} ist {MyMath.Calc_kgV(a,b)}");
        }

        public int parseWrittenInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return result;
            }

        }

        public int ReadInt()
        {
            string writtenInput = "";
            int inputVal = 0;
            do
            {
                Console.Write("KeyInput: ");
                writtenInput = Console.ReadLine();
                inputVal = parseWrittenInput(writtenInput);
            } while (inputVal <= 0);
            return inputVal;
        }
    }
}