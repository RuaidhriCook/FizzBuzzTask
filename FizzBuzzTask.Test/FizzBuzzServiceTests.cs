using FizzBuzzTask.Interfaces;
using FizzBuzzTask.Services;

namespace FizzBuzzTask.Test
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        [TestCase(18, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        [TestCase(35, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(90, "FizzBuzz")]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        public void Should_Return_ExpectedResult(int number, string expectedResult)
        {
            //Arrange

            //Act
            string result = _fizzBuzzService.GetFizzBuzzResult(number);
            
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}