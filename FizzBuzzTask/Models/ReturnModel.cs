namespace FizzBuzzTask.Models
{
    public class ReturnModel
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}
