namespace HelloWorld.Pages;

public partial class HelloPage : ContentPage
{
    int countClicked = 0;
    public HelloPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        countClicked++;

        var prefix = countClicked <= 1
            ? "Voc� clicou "
            : "Voc� clicou ";
        var suffix = countClicked <= 1
            ? " vez!"
            : " vezes!";

        var color = Colors.Black;
        if (countClicked >= 500 && countClicked < 1000)
        {
            suffix = " vezes! Voc� tem certeza que est� bem?!";
            color = Colors.Red;
        }

        lblTexto.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = prefix },
                new Span { Text = countClicked.ToString(), TextColor = color },
                new Span { Text = suffix }
            }
        };
    }
}