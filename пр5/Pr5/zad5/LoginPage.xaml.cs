using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage :ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var welcomeLabel = new Label
            {
                Text = "Добро пожаловать",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                Margin = new Thickness(0,0,0,40)
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Ваш логин",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "styleMe"

            };

            var passwordEntry = new Entry
            {
                Placeholder = "Ваш пароль",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "styleMe",
                Margin = new Thickness(0,-8,0,0)
            };

            var rememberMeCheckBox = new CheckBox
            {
                HorizontalOptions = LayoutOptions.Start,
                StyleId = "styleMe2"
            };
            var textRemember = new Label
            {
                Text = "запомнить меня",
                StyleId = "styleMe2",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(40, -35, 0, 0)
            };
            var RememberBox = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    rememberMeCheckBox,
                    textRemember
                }
            };
            var signInButton = new Button
            {
                Text = "Войти",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var signInLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    signInButton,
                    new Label{ Text = "Я забыл!", HorizontalOptions = LayoutOptions.End }
                }
            };

            var errorMessageLabel = new Label
            {
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center
            };
            var moneyBut = new Button
            {
                Text = "Деньги",
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };

            moneyBut.Clicked += (sender, e) =>
            {
                string username = usernameEntry.Text;
                Navigation.PushAsync(new Money(username));
            };

            signInButton.Clicked += (sender, e) =>
            {

                if ( string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text) )
                {
                    DisplayAlert("Ошибка входа","введите логин и пароль","OK");
                }
                else
                {
                    string username = usernameEntry.Text;
                    string password = passwordEntry.Text;

                    Navigation.PushAsync(new MainPage(username));
                }
            };
            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(30),
                Children =
                {
                    welcomeLabel,
                    usernameEntry,
                    passwordEntry,
                    signInButton,
                    rememberMeCheckBox,
                    textRemember,
                    signInLayout,
                    moneyBut,
                    errorMessageLabel
                }
            };
            Content = stackLayout;
        }
    }
}