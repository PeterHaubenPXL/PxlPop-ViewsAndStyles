namespace Labo4_PxlPop.Views;

public partial class HeaderView : ContentView
{
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(HeaderView), string.Empty, propertyChanged: OnTitleChanged);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public HeaderView()
    {
        InitializeComponent();
    }

    private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is HeaderView header && newValue is string title)
            header.TitleLabel.Text = title;
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(".."); // Navigatie terug
    }
}