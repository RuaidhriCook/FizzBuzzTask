using FizzBuzzTask.Interfaces;

namespace FizzBuzzTask.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuzzResult(int number)
        {            
            return number.ToString();
        }
    }
}
