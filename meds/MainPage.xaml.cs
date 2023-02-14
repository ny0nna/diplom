using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace meds
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Counter",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor= Color.White,
            };
            button.Clicked += ButtonClicked;
        }

        int i = 0;
        public void ButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Какое-то сообщение", "АОоаОАОоаоАо","Закрыть нахер");
            
        }
    }
}
