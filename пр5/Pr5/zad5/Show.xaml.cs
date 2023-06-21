using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Show : ContentPage
    {
        public Show(string selectedPickerItem, double sliderValue)
        {
            var pickerLabel = new Label
            {
                Text = $"Выбран элемент: {selectedPickerItem}",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var sliderLabel = new Label
            {
                Text = $"Вы выбрали: {sliderValue}",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Children = { pickerLabel, sliderLabel }
            };
        }
    }
}