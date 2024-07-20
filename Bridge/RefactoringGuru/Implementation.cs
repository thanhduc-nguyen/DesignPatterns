namespace Bridge.RefactoringGuru
{
    /// <summary>
    /// Abstraction.
    /// </summary>
    public abstract class Shape
    {
        protected IColor _color;
        public abstract void Paint();
    }

    /// <summary>
    /// Implementation.
    /// </summary>
    public interface IColor
    {
        string Coloring();
    }

    /// <summary>
    /// Refinded Abstraction 1.
    /// </summary>
    public class Circle : Shape
    {
        public Circle(IColor color)
        {
            _color = color;
        }

        public string Color { get; set; }

        public override void Paint()
        {
            Color = _color.Coloring();
        }
    }

    /// <summary>
    /// Refinded Abstraction 2.
    /// </summary>
    public class Square : Shape
    {
        public Square(IColor color)
        {
            _color = color;
        }

        public string Color { get; set; }

        public override void Paint()
        {
            Color = _color.Coloring();
        }
    }

    /// <summary>
    /// Concreate Implementation 1.
    /// </summary>
    public class RedColor : IColor
    {
        public string Coloring()
        {
            return "Red";
        }
    }

    /// <summary>
    /// Concreate Implementation 2.
    /// </summary>
    public class BlueColor : IColor
    {
        public string Coloring()
        {
            return "Blue";
        }
    }
}
