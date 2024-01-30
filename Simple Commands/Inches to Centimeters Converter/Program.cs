namespace inchesToCmConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inches = int.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine(cm);
        }
    }
}
