using Numbers.Views;

namespace Numbers.Presenters;

public class NumberPresenter: IDisposable
{
    private readonly IMainView _view;
    
    public NumberPresenter(IMainView view)
    {
        _view = view;
        _view.ValueChanged += OnValueChanged;
    }

    private void OnValueChanged(object? sender, EventArgs e)
    {
        _view.UpdateView("Value changed");
    }

    public void Dispose()
    {
        _view.ValueChanged -= OnValueChanged;
    }
}