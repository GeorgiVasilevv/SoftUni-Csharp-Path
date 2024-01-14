namespace _10_LowerToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inpChar = char.Parse(Console.ReadLine());
            if (char.IsUpper(inpChar))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
