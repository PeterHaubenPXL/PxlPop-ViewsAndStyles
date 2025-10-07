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

            //SetThemeImage(Application.Current.RequestedTheme);

            //Application.Current.RequestedThemeChanged += (s, e) =>
            //{
            //    MainThread.BeginInvokeOnMainThread(() =>
            //    {
            //        SetThemeImage(e.RequestedTheme);
            //    });
            //};
        }

        

        private void SetThemeImage(AppTheme theme)
        {
            lineUpButton.ImageSource = theme == AppTheme.Dark
                ? "music_solid_black.svg"
                : "music_solid_white.svg";
            favoriteButton.ImageSource = theme == AppTheme.Dark
                ? "heart_solid_black.svg"
                : "heart_solid_white.svg";
            userButton.ImageSource = theme == AppTheme.Dark
                ? "circle_user_solid_black.svg"
                : "circle_user_solid_white.svg";
            infoButton.ImageSource = theme == AppTheme.Dark
                ? "circle_info_solid_black.svg"
                : "circle_info_solid_white.svg";
            ticketsButton.ImageSource = theme == AppTheme.Dark
                ? "ticket_solid_black.svg"
                : "ticket_solid_white.svg";
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

        private async void userButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserPage());
        }

        
    }

}
