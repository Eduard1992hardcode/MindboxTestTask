using MindboxTestTask.Shapes;

namespace TestMindboxTestTask
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_5_5_9_Square_9_8()
        {
            //arrange
            var triangle = new Triangle("Triangle", 5, 5, 9);
            double expected = 9.8;

            //act
            var result = triangle.CalcSquare();

            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void isRectangleNotRectangleReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 2, 3, 4);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }
    }
}
