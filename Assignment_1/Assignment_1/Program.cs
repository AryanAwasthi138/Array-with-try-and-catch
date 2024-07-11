namespace Assignment_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] integer = new int[7];
                integer[0] = 7;
                integer[1] = 6;
                integer[2] = 5;
                integer[3] = 4;
                integer[4] = 3;
                integer[5] = 2;
                integer[6] = 1;

                Console.WriteLine(integer[4]);

                for (int i = 0; i <= integer.Length; i++)
                {
                    Console.WriteLine(integer[i]);
                }
            }
            catch (Exception e)

            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}