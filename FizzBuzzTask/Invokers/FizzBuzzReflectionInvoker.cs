using FizzBuzzTask.Interfaces;
using FizzBuzzTask.Models;

namespace FizzBuzzTask.Invokers
{
    public class FizzBuzzReflectionInvoker
    {
        private readonly IFizzBuzzService _service;

        public FizzBuzzReflectionInvoker(IFizzBuzzService service)
        {
            _service = service;
        }

        public StringReturnModel InvokeFizzBuzz(int number, string methodName)
        {
            throw new NotImplementedException();
        }
    }
}
