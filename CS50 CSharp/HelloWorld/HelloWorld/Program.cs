namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            Console.WriteLine("hello, " + GetString());
        }

        public static string GetString()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            return name;
        }
    }
}