namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FeetToInches(30));

            Console.ReadLine();
        }

        public static int FeetToInches(int n)
        {
            return n * 12;
        }
    }
}
