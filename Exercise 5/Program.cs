namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Input the First Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("First Number: " + num1);  ;
            Console.WriteLine("Second Number: " + num2);

            
        }
    }
}
