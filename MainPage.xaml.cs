using System;

namespace Maui_Clock;

public partial class MainPage : ContentPage
{
    [Obsolete]
    public MainPage()
	{
		InitializeComponent();

        /* из кода создаем элемент
        _timeLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
        };

        Content = new StackLayout
        {
            Children = { _timeLabel }
        };
        */

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            _timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }

	

	
}

