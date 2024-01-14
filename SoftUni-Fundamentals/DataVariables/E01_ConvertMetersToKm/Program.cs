namespace E01_ConvertMetersToKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float km = meters / 1000.0f;
            Console.WriteLine($"{km:f2}");
        }
    }
}
