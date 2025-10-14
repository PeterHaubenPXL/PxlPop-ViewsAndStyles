using MauiIcons.Core;

namespace Labo4_PxlPop.Pages;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();

        _ = new MauiIcon();
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}