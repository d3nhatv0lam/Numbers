using Numbers.Models;
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
        var trimmedInput = _view.Input.Trim();
        var message = NumberValidator.GetNumberKind(trimmedInput) switch
        {
            NumberKind.Integer => "Là số nguyên",
            NumberKind.Decimal => "Là số thập phân",
            _ => "Không phải số"
        };
        _view.UpdateView(message);
    }

    public void Dispose()
    {
        _view.ValueChanged -= OnValueChanged;
    }
}