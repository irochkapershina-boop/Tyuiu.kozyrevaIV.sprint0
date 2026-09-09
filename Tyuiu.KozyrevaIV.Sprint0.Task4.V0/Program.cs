using Tyuiu.KozyrevaIV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KozyrevaIV.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(7, 5));
            Console.WriteLine(DataService.Subtraction(7, 5));
            Console.WriteLine(DataService.Multiplication(7, 5));
            Console.WriteLine(DataService.Division(20, 5));

            Console.ReadKey();
        }
    }
}
