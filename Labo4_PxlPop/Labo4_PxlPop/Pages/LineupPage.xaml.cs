namespace Labo4_PxlPop.Pages;

public partial class LineupPage : ContentPage
{
	public LineupPage()
	{
		InitializeComponent();
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}
