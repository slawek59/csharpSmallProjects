namespace MarioLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int heigth = GetHeight();

            PrintPyramid(heigth);
            
        }

        public static int GetHeight()
        {
            var input = "";

            do
            {
                Console.Write("Height: ");
                input = Console.ReadLine();
            }
            while (String.IsNullOrWhiteSpace(input) || Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 8);

            var height = Convert.ToInt32(input);

            return height;
        }

        public static void PrintPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0 + i; j > 0; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine("#");
            }
        }
    }
}