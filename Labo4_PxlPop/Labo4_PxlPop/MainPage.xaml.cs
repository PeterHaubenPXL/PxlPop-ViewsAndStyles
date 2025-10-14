using Labo4_PxlPop.Pages;
using MauiIcons.Core;

namespace Labo4_PxlPop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _ = new MauiIcon();

        }


        private async void lineUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LineupPage());
        }

        private async void infoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private async void favoriteButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavoritePage());
        }

        private async void ticketsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TicketPage());
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }

    }

}
