namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddMethods.Add(4, 7));
            Console.WriteLine(AddMethods.Add(5.3, 8.6));
            Console.WriteLine(AddMethods.Add(1, 5, true));
        }
    }
}
