using MauiIcons.Core;

namespace Labo4_PxlPop.Pages;

public partial class LineupPage : ContentPage
{
	public LineupPage()
	{
		InitializeComponent();

        _ = new MauiIcon();
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if 
    }

}
