namespace TestWebView;

public partial class WebViewTest : ContentPage
{
    public WebViewTest()
    {
        InitializeComponent();
         TestWeb.Source = new Uri("https://go.microsoft.com/fwlink/?LinkID=521962").ToString();
#if ANDROID
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) => {
            handler.PlatformView.Settings.JavaScriptEnabled = true;
            handler.PlatformView.Settings.AllowFileAccess = true;
            handler.PlatformView.Settings.AllowFileAccessFromFileURLs = true;
            handler.PlatformView.Settings.AllowUniversalAccessFromFileURLs = true;
        });
        TestWeb.Source = new Uri("https://view.officeapps.live.com/op/view.aspx?src=https://go.microsoft.com/fwlink/?LinkID=521962").ToString();
#endif

    }

    private void OnNavigating(object sender, WebNavigatingEventArgs e)
    {

    }

    private void OnNavigated(object sender, WebNavigatedEventArgs e)
    {

    }
}
