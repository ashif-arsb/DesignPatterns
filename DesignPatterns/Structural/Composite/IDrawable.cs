namespace DesignPatterns.Structural.Composite
{
    public interface IDrawable
    {
        void Draw();
        void Move(int x, int y);
        void ChangeColor(string color);
    }
}
