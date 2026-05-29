namespace დავალება_3
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Sheiyvanet pirveli ricxvi");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sheiyvanet me-2 ricxvi:");
                int num2 = int.Parse(Console.ReadLine());
                int jami = num1 + num2;
                if (num1 == num2)
                {
                    jami = jami * 3;
                }
                Console.WriteLine("Shedegi: " + jami);

                Console.ReadLine();
            }
        }
    }
    
