namespace TestWebView;

public partial class WebViewTest : ContentPage
{
	public WebViewTest()
	{
		InitializeComponent();
        TestWeb.Source = new Uri("https://go.microsoft.com/fwlink/?LinkID=521962").ToString();

    }

    private void OnNavigating(object sender, WebNavigatingEventArgs e)
    {

    }

    private void OnNavigated(object sender, WebNavigatedEventArgs e)
    {

    }
}