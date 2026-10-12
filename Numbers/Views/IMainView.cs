namespace Numbers.Views;

public interface IMainView
{
    string Input { get; }
    
    event EventHandler ValueChanged;
    
    void UpdateView(string value);
}