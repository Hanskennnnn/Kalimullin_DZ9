
namespace DZ.Interfaces
{
    public interface IFigure
    {
        string Color { get; set; } 
        bool IsVisible { get; set; } 

        void MoveHorizontal(int deltaX); 
        void MoveVertical(int deltaY); 
        void ChangeColor(string newColor); 
        void Display();
    }
}
