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
            var invokeReturnValue = new StringReturnModel();

            try
            {
                var method = typeof(IFizzBuzzService).GetMethod(methodName);
                var invokeMethodResult = (string)method.Invoke(_service, new object[] { number });

                invokeReturnValue.Value = invokeMethodResult;                
            }
            catch (Exception ex)
            {
                invokeReturnValue.ErrorMessage = ex.Message;
            }

            return invokeReturnValue;
        }
    }
}
