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
    public partial class Money :ContentPage
    {
        private Entry usdLabel;
        private Label eurLabel;
        private Label date;
        private Label date2;
        private Button myButton;
        private Button myButton2;
        private Button myButton3;
        private Button myButton4;
        private Button myButton5;
        private Button myButton6;
        private Button myButton7;
        private Button myButton8;
        private Button myButton9;
        private Picker myPicker;
        private Switch CheckBox;
        private Switch CheckBox2;
        private Switch CheckBox3;
        private Switch CheckBox4;
        private Switch CheckBox5;
        private Switch CheckBox6;
        private Slider interestRateSlider1;
        private Slider interestRateSlider2;
        private Slider interestRateSlider3;
        private Slider interestRateSlider4;
        private Slider interestRateSlider5;

        public Money(string username)
        {
            InitializeComponent();
            double usd = 70.000;
            usdLabel = new Entry
            {
                TextColor = Color.Black,
                Text = $"{usd}",
                FontAttributes = FontAttributes.Bold,
                StyleId = "styleforIvansk2",
                Margin = new Thickness(0, 0, 0, 0),

            };
            double ada = double.Parse(usdLabel.Text);
            eurLabel = new Label
            {
                TextColor = Color.Black,
                Text = $"EUR  {ada * 1.075}",
                FontAttributes = FontAttributes.Bold,
                TextDecorations = TextDecorations.Underline,
                Margin = new Thickness(0, 0, 0, 0)
            };

            var usernameLabel = new Label
            {
                TextColor = Color.Black,
                Text = $"Добро пожаловать, {username}!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            date2 = new Label
            {
                TextColor = Color.Black,
                Text = $"Вы выбрали {10}"
            };
            date = new Label
            {
                TextColor = Color.Black,
                Text = DateTime.Today.ToString(),
                HorizontalTextAlignment = TextAlignment.End,
                FontAttributes = FontAttributes.Bold,
                TextDecorations = TextDecorations.Underline,
                Margin = new Thickness(0, 0, 0, 0)
            };

            myButton = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut",
                WidthRequest = 120
            };
            myButton.Clicked += MyButton_Clicked;

            myButton2 = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut2",
                WidthRequest = 120
            };
            myButton2.Clicked += MyButton_Clicked;

            myButton3 = new Button
            {
                Text = "STATIC",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut3",
                WidthRequest = 120
            };
            myButton3.Clicked += MyButton_Clicked;

            myButton4 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut4",
                WidthRequest = 120
            };
            myButton4.Clicked += MyButton_Clicked;

            myButton5 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut5",
                WidthRequest = 120
            };
            myButton5.Clicked += MyButton_Clicked;

            myButton6 = new Button
            {
                Text = "HOVER",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut6",
                WidthRequest = 120
            };
            myButton6.Clicked += MyButton_Clicked;
            CheckBox = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            CheckBox.Toggled += (sender, e) =>
            {
                if (CheckBox.IsToggled)
                {
                    CheckBox.BackgroundColor = Color.Red;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.Red;
                }
                else
                {
                    CheckBox.BackgroundColor = Color.Gray;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.White;
                }
            };
            CheckBox2 = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            CheckBox2.Toggled += (sender, e) =>
            {
                if (CheckBox2.IsToggled)
                {
                    CheckBox2.BackgroundColor = Color.Red;
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.Red;
                }
                else
                {
                    CheckBox2.BackgroundColor = Color.Gray;
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.White;
                }
            };
            CheckBox3 = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            CheckBox3.Toggled += (sender, e) =>
            {
                if (CheckBox3.IsToggled)
                {
                    CheckBox3.BackgroundColor = Color.Red;
                    CheckBox3.ThumbColor = Color.White;
                    CheckBox3.OnColor = Color.Red;
                }
                else
                {
                    CheckBox3.BackgroundColor = Color.Gray;
                    CheckBox3.ThumbColor = Color.White;
                    CheckBox3.OnColor = Color.White;
                }
            };
            CheckBox4 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            CheckBox4.Toggled += (sender, e) =>
            {
                if (CheckBox4.IsToggled)
                {
                    CheckBox4.ThumbColor = Color.Red;
                    CheckBox4.OnColor = Color.Black;
                }
                else
                {
                    CheckBox4.ThumbColor = Color.Gray;
                    CheckBox4.OnColor = Color.Black;
                }
            };
            CheckBox5 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,

            };

            CheckBox5.Toggled += (sender, e) =>
            {
                if (CheckBox5.IsToggled)
                {
                    CheckBox5.ThumbColor = Color.Red;
                    CheckBox5.OnColor = Color.Black;
                }
                else
                {
                    CheckBox5.ThumbColor = Color.Gray;

                }
            };
            CheckBox6 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,

            };

            CheckBox6.Toggled += (sender, e) =>
            {
                if (CheckBox6.IsToggled)
                {
                    CheckBox6.ThumbColor = Color.Red;
                    CheckBox6.OnColor = Color.Black;
                }
                else
                {
                    CheckBox6.ThumbColor = Color.Gray;

                }
            };
            myButton7 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut7",
                WidthRequest = 120
            };
            myButton7.Clicked += MyButton_Clicked;

            myButton8 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut8",
                WidthRequest = 120
            };
            myButton8.Clicked += MyButton_Clicked;

            myButton9 = new Button
            {
                Text = "PRESSED",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut9",
                WidthRequest = 120
            };
            myButton9.Clicked += MyButton_Clicked;

            myPicker = new Picker
            {
                Title = "DROPDOWN",
                Margin = new Thickness(5, 0, 200, 0)
            };
            myPicker.Items.Add("Select One");
            myPicker.Items.Add("Select Two");
            myPicker.Items.Add("Select Three");
            myPicker.Items.Add("Select Four");
            myPicker.SelectedIndexChanged += MyPicker_SelectedIndexChanged;

            interestRateSlider1 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            interestRateSlider1 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider2 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider3 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider4 = new Slider
            {
                Minimum = 0,
                Maximum = 100,

                Value = 60,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider5 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.Gray,
                HeightRequest = 20,
                MinimumTrackColor = Color.White,
                Margin = new Thickness(30, 0, 150, 0),
            };



            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Padding = new Thickness(10, 10, 10, 0),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton,
                            myButton2,
                            myButton3
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton4,
                            myButton5,
                            myButton6
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton7,
                            myButton8,
                            myButton9
                        }
                    },
                    myPicker,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        { 
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    CheckBox,
                                    CheckBox2,
                                    CheckBox3,
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    CheckBox4,
                                    CheckBox5,
                                    CheckBox6,
                                }
                            }
                        }
                    },
                    interestRateSlider1,
                    interestRateSlider2,
                    interestRateSlider3,
                    new Grid
                    {
                        Children =
                        {
                            { interestRateSlider4, 0, 0 },
                            { interestRateSlider5, 0, 0 }
                        }
                    },

                    date2,
                    usernameLabel,
                    new Label { Text = "Центробанк РФ: " },
                    new Label { Text = "Текущая дата: ", HorizontalTextAlignment = TextAlignment.End, Margin = new Thickness(0,0,10,0)},
                    date,
                    usdLabel,
                    eurLabel
                }
            };

        }
        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPickerItem = myPicker.SelectedItem as string;


            interestRateSlider1.IsVisible = false;
            interestRateSlider2.IsVisible = false;
            interestRateSlider3.IsVisible = false;
            interestRateSlider4.IsVisible = false;
            interestRateSlider5.IsVisible = false;

            switch (selectedPickerItem)
            {
                case "Select One":
                    interestRateSlider1.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider1.Value}";
                    break;
                case "Select Two":
                    interestRateSlider2.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider2.Value}";
                    break;
                case "Select Three":
                    interestRateSlider3.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider3.Value}";
                    break;
                case "Select Four":
                    interestRateSlider4.IsVisible = true;
                    interestRateSlider5.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider4.Value}";
                    break;
                default:
                    break;
            }
        }




        private void MyButton_Clicked(object sender, EventArgs e)
        {
            string selectedPickerItem = myPicker.SelectedItem as string;
            double sliderValue = interestRateSlider1.Value;

            Show page1 = new Show(selectedPickerItem, sliderValue);
            Navigation.PushAsync(page1);
        }
    }
}