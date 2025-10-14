using MauiIcons.Core;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Labo4_PxlPop.Pages;

public partial class TicketPage : ContentPage
{
    public TicketPage()
    {
        InitializeComponent();

        _ = new MauiIcon();
    }


    private void DayTicketsStandard_Clicked(object sender, EventArgs e)
    {
        int Counter;
        if (sender is Button btn)
        {
            if (btn.Text == "-")
            {
                if (int.TryParse(DayTicketsStandardEntry.Text, out Counter))
                {
                    if (Counter > 0)
                    {
                        Counter--;
                    }
                }
            }
            else
            {
                if (int.TryParse(DayTicketsStandardEntry.Text, out Counter))
                {
                    Counter++;
                }
            }
            DayTicketsStandardEntry.Text = Counter.ToString();

            //HasOrder();
        }
    }

    private void DayTicketsVIP_Clicked(object sender, EventArgs e)
    {
        int Counter;
        if (sender is Button btn)
        {
            if (btn.Text == "-")
            {
                if (int.TryParse(DayTicketsVIPEntry.Text, out Counter))
                {
                    if (Counter > 0)
                    {
                        Counter--;
                    }
                }
            }
            else
            {
                if (int.TryParse(DayTicketsVIPEntry.Text, out Counter))
                {
                    Counter++;
                }
            }
            DayTicketsVIPEntry.Text = Counter.ToString();

            //HasOrder();
        }

    }

    private void CombiTicketsStandard_Clicked(object sender, EventArgs e)
    {
        int Counter;
        if (sender is Button btn)
        {
            if (btn.Text == "-")
            {
                if (int.TryParse(CombiTicketsStandardEntry.Text, out Counter))
                {
                    if (Counter > 0)
                    {
                        Counter--;
                    }
                }
            }
            else
            {
                if (int.TryParse(CombiTicketsStandardEntry.Text, out Counter))
                {
                    Counter++;
                }
            }
            CombiTicketsStandardEntry.Text = Counter.ToString();

            //HasOrder();
        }
    }

    private void CombiTicketsVIP_Clicked(object sender, EventArgs e)
    {
        int Counter;
        if (sender is Button btn)
        {
            if (btn.Text == "-")
            {
                if (int.TryParse(CombiTicketsVIPEntry.Text, out Counter))
                {
                    if (Counter > 0)
                    {
                        Counter--;
                    }
                }
            }
            else
            {
                if (int.TryParse(CombiTicketsVIPEntry.Text, out Counter))
                {
                    Counter++;
                }
            }
            CombiTicketsVIPEntry.Text = Counter.ToString();

            //HasOrder();
        }
    }

    //private void HasOrder()
    //{
    //    bool hasOrder =
    //    CombiTicketsVIPEntry.Text != "0" ||
    //    CombiTicketsStandardEntry.Text != "0" ||
    //    DayTicketsVIPEntry.Text != "0" ||
    //    DayTicketsStandardEntry.Text != "0";

    //    OrderButton.IsEnabled = hasOrder;
    //}

    private async void OrderButton_Clicked(object sender, EventArgs e)
    {
        bool hasOrder = false;

        if(int.TryParse(DayTicketsStandardEntry.Text, out int CounterDTS) &&
            int.TryParse(DayTicketsVIPEntry.Text, out int CounterDTV) &&
            int.TryParse(CombiTicketsStandardEntry.Text, out int CounterCTS) &&           
            int.TryParse(CombiTicketsVIPEntry.Text, out int CounterCTV))
        {
            if(CounterDTS + CounterDTV + CounterCTS + CounterCTV > 0)
            {
                hasOrder = true;
            }
        }
        else
        {
            await DisplayAlert("Foutieve ingave", "Er mogen enkel gehele getallen ingegeven worden", "OK");
            return;
        }

        if (hasOrder)
        {
            await Navigation.PushAsync(new OrderPage());
        }
        else
        {
            await DisplayAlert("Geen orders", "Er zijn geen orders ingegeven.", "OK");
        }

    }
}