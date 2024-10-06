using Moq;
using FizzBuzzTask.Interfaces;
using FizzBuzzTask.Invokers;

namespace FizzBuzzTask.Test
{
    [TestFixture]
    public class FizzBuzzReflectionInvokerTests
    {
        private Mock<IFizzBuzzService> _fizzBuzzServiceMock;
        private FizzBuzzReflectionInvoker _invoker;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzServiceMock = new Mock<IFizzBuzzService>();
            _invoker = new FizzBuzzReflectionInvoker(_fizzBuzzServiceMock.Object);
        }

        [Test]
        [TestCase(3, "GetFizzBuzzResult", "Fizz")]
        [TestCase(5, "GetFizzBuzzResult", "Buzz")]
        [TestCase(15, "GetFizzBuzzResult", "FizzBuzz")]
        public void InvokeFizzBuzz_Should_Call_Correct_Method(int number, string methodName, string expected)
        {
            //Arrange
            _fizzBuzzServiceMock
                .Setup(s => s.GetFizzBuzzResult(number))
                .Returns(expected);

            //Act
            var result = _invoker.InvokeFizzBuzz(number, methodName);

            //Assert
            Assert.That(result.IsSuccess, Is.EqualTo(true));
            Assert.That(result.Value, Is.EqualTo(expected));
        }

        [Test]
        public void InvokeFizzBuzz_Should_ThrowException_When_Method_Not_Found()
        {
            //Arrange

            //Act
            var result = _invoker.InvokeFizzBuzz(3, "NonExistentMethod");

            //Assert
            Assert.That(result.IsSuccess, Is.EqualTo(false));
            Assert.That(result.ErrorMessage, Is.EqualTo("Method 'NonExistentMethod' not found on IFizzBuzzService."));
        }
    }

}

