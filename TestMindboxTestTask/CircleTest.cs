using MindboxTestTask.Shapes;

namespace TestMindboxTestTask
{
    public class CircleTest
    {
        [Fact]
        public void Radius8Square201_1()
        {
            //arrange
            var circle = new Circle("Circle", 8);
            double expected = 201.1;

            //act
            double result = circle.CalcSquare();

            //assert
            Assert.Equal(expected, result);
        }
    }
    
}