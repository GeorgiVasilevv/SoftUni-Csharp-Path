namespace _12_RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int currEl = num;
                while (currEl > 0)
                {
                    sum += currEl % 10;
                    currEl = currEl / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecial);
            }

        }
    }
}
