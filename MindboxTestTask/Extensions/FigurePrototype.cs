using MindboxTestTask.Shapes;

namespace MindboxTestTask.Extensions
{
    public static class FigurePrototype
    {
        public static double CalcSquare(this BaseFigure figure) => figure.CalcSquare();
    }
}
