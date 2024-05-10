namespace Exercise_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("Vu Gia Khanh Dz", 0));
            Console.WriteLine(remove_char("Vu Gia Khanh Dz", 14));
            Console.WriteLine(remove_char("Vu Gia Khanh Dz", 1));

        }

        public static string remove_char(string str, int n)
        {
            return str.Remove(n,1);
        }
    }
    
}
