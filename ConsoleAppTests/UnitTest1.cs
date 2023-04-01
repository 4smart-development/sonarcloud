namespace ConsoleAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void Action_XBelowZero_ReturnNegative()
        {
            // arrange
            var service = new ConsoleApp1.Service();

            // act
            var result = service.Action(-5, 0);

            // assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Action_YBelowZero_ReturnNegative()
        {
            // arrange
            var service = new ConsoleApp1.Service();

            // act
            var result = service.Action(10, -10);

            // assert
            Assert.Equal(-1, result);
        }
    }
}