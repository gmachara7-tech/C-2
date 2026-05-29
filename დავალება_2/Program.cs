namespace დავალება_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sheiyvanet pirveli ricxvi");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Sheiyvanet me-2 ricxvi");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Sheiyvanet me-3 ricxvi");
            int third = int.Parse(Console.ReadLine());
            int big = first;
            if (second > big)
            {
                big = second;
            }
            if (third > big)
            {
                big = third;
            }
            Console.WriteLine("Udidesi ricxvia" + big);

            Console.ReadLine();
        }
    }
}
