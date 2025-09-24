namespace CSP_Project;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnHelloClicked(object sender, EventArgs e)
    {
        var userName = NameEntry.Text?.Trim();

        if (string.IsNullOrWhiteSpace(userName))
            HelloLabel.Text = "Hello!";
        else
            HelloLabel.Text = $"Hello {userName}";
    }
}
