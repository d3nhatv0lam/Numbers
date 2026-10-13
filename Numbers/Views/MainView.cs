namespace Numbers.Views;

public partial class MainView : Form, IMainView
{
    public string Input => txtNumber.Text;

    public event EventHandler? ValueChanged;

    public MainView()
    {
        InitializeComponent();
    }

    public void UpdateView(string value)
    {
        CheckStatus.Text = value;
    }

    private void input_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Input)) CheckStatus.Text = string.Empty;
        else
            ValueChanged?.Invoke(this, EventArgs.Empty);
    }
}