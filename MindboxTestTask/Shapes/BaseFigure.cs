namespace MindboxTestTask.Shapes
{
    public abstract class BaseFigure
    {
        public string FigureName { get; private set; }

        public BaseFigure(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double CalcSquare();
    }
}