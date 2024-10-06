using FizzBuzzTask.Interfaces;

namespace FizzBuzzTask.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuzzResult(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
