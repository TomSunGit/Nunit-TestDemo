namespace Nunit_TestDemo
{
    public class Tests
    {
        [Test]
        public void Addition_Test()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            int result = a + b;

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiplication_Test()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a * b;

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
