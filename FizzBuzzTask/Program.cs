using FizzBuzzTask.Interfaces;
using FizzBuzzTask.Invokers;
using FizzBuzzTask.Services;

class Program
{
    static void Main(string[] args)
    {
        IFizzBuzzService fizzBuzzService = new FizzBuzzService();
        var invoker = new FizzBuzzReflectionInvoker(fizzBuzzService);

        var fizzBuzzMethodName = "GetFizzBuzzResult";

        for (int i = 1; i <= 100; i++)
        {
            var result = invoker.InvokeFizzBuzz(i, fizzBuzzMethodName);
            if (result.IsSuccess)
                Console.WriteLine(result.Value);
            else
                Console.WriteLine("Error Getting Result");
        }

        Console.ReadLine();
    }
}
