namespace MindboxTestTask.Shapes
{
    public class Circle : BaseFigure
    {
        public double Radius { get; private set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
