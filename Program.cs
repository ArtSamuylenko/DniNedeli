
namespace DniNedeli

{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число которое будет соответствовать определенному дню недели:");

                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Это понедельник!");
                        break;
                    case 2:
                        Console.WriteLine("Это вторник!");
                        break;
                    case 3:
                        Console.WriteLine("Это среда!");
                        break;
                    case 4:
                        Console.WriteLine("Это четверг!");
                        break;
                    case 5:
                        Console.WriteLine("Это пятница!");
                        break;
                    case 6:
                        Console.WriteLine("Это суббота!");
                        break;
                    case 7:
                        Console.WriteLine("Это воскресенье!");
                        break;
                    default:
                        Console.WriteLine("Это число не соответсвует никакому из дней недели!");
                        break;
                }
            }
        }
    }
}