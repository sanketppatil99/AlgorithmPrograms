namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            PalindromChecker checker = new PalindromChecker();
            
            Console.WriteLine("Enter the lowe limit");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the higher limit");
            int num2 = Convert.ToInt32(Console.ReadLine());
            checker.palindrom(num1, num2);
        }
    }
}
