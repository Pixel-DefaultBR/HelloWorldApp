namespace HelloWorld
{
    public partial class MainPage : TabbedPage
    {
        string username = string.Empty;
        public MainPage()
        {
            InitializeComponent();
        }
        public async void OnShowMessage(object sender, EventArgs e)
        {
            username = await DisplayPromptAsync("Nome", "Digite seu nome", "Ok");

        }
    }
}
