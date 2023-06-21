using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zad5
{
    public partial class MainPage :ContentPage
    {
        private Entry loanAmountEnrty;
        private Entry loanTermEnrty;
        private Picker paymentTypePicker;
        private Slider interestRateSlider;
        private Label monthlyPaymentLabel;
        private Label totalAmountLabel;
        private Label overpaymentLabel;
        public MainPage (string username)
        {
            
            InitializeComponent( );

            var usernameLabel = new Label
            {
                Text = $"Добро пожаловать, {username}!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            loanAmountEnrty = new Entry
            {
                Placeholder = "Сумма кредита",
                Margin = new Thickness(30, 0, 0, 0),
                StyleId = "styleMe"

            };
            loanTermEnrty = new Entry
            {
                Placeholder = "Срок (месяцев)",
                Margin = new Thickness(30, -8, 0, 0),
                StyleId = "styleMe"
            };
            paymentTypePicker = new Picker
            {
                Title = "Вид платежа",
                Margin = new Thickness(40, -16, 0, 0),
                StyleId = "styleMe"
            };
            paymentTypePicker = new Picker
            {
                Title = "Вид платежа",
                Margin = new Thickness(30, -16, 0, 0),
                StyleId = "styleMe"
            };
            paymentTypePicker.Items.Add("Аннуитетный");
            paymentTypePicker.Items.Add("Дифференцированный");
            paymentTypePicker.Items.Add("Однократный");

            interestRateSlider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                Margin = new Thickness(30, 0, 0, 0)
            };
            monthlyPaymentLabel = new Label
            {
                Text = "Ежемесячный платеж: ",
                Margin = new Thickness(30, 0, 0, 0)
            };
            totalAmountLabel = new Label
            {
                Text = "Общая сумма: ",
                Margin = new Thickness(30, 0, 0, 0)
            };
            var interestRateLabel = new Label
            {
                Text = $"Выбранный процент: {interestRateSlider.Value}%",
                Margin = new Thickness(30, 0, 0, 0)
            };
            overpaymentLabel = new Label
            {
                Text = "Переплата: ",
                Margin = new Thickness(30, 0, 0, 0)
            };
            interestRateSlider.ValueChanged += (s, e) =>
            {
                double selectedInterestRate = interestRateSlider.Value;
                interestRateLabel.Text = $"Выбранный процент: {selectedInterestRate}%";
                UpdateCalculation(s, e);
            };

            loanAmountEnrty.TextChanged += UpdateCalculation;
            loanTermEnrty.TextChanged += UpdateCalculation;
            paymentTypePicker.SelectedIndexChanged += UpdateCalculation;
            interestRateSlider.ValueChanged += UpdateCalculation;
            Content = new StackLayout
            {
                Children =
                {
                    usernameLabel,
                    loanAmountEnrty,
                    loanTermEnrty,
                    paymentTypePicker,
                    new Label {Text = "Процентная ставка: ",Margin = new Thickness(30, 0, 0, 0)},
                    interestRateSlider,
                    interestRateLabel, 
                    monthlyPaymentLabel,
                    totalAmountLabel,
                    overpaymentLabel
                }
            };
        }
        private void UpdateCalculation (object sender, EventArgs e)
        {
            Back(loanAmountEnrty.Text);
            double loanAmount;
            double.TryParse(loanAmountEnrty.Text, out loanAmount);
            int loanTerm;
            int.TryParse(loanAmountEnrty.Text, out loanTerm);
            double interestRate = interestRateSlider.Value;
            double monthlyPayment = 0;
            double totalAmount = 0;
            double overpayment = 0;
            if (paymentTypePicker.SelectedIndex == 0)
            {
                double monthlyInterestRate = interestRate / 100 / 12;
                double factor = Math.Pow(1 + monthlyInterestRate, loanTerm);
                monthlyPayment = loanAmount * monthlyInterestRate * factor / (factor - 1);
                totalAmount = monthlyPayment * loanTerm;
                overpayment = totalAmount - loanAmount;
            }
            else if (paymentTypePicker.SelectedIndex == 1)
            {
                monthlyPayment = loanAmount / loanTerm;
                double monthlyInterest = loanAmount * (interestRate / 100) / 12;
                totalAmount = loanAmount + (monthlyInterest * loanTerm);
                overpayment = totalAmount - loanAmount;
            }
            else if (paymentTypePicker.SelectedIndex == 2)
            {
                monthlyPayment = loanAmount;
                totalAmount = loanAmount;
                double totalInterest = loanAmount * (interestRate / 100);
                overpayment = totalInterest;
            }
            monthlyPaymentLabel.Text = $"Ежемесячный платеж: {monthlyPayment:C}";
            totalAmountLabel.Text = $"Общая сумма: {totalAmount:C}";
            overpaymentLabel.Text = $"Переплата: {overpayment:C}";
        }
        private void Back (string a)
        {
            try
            {
                if ( Convert.ToInt64(a) > 25000 )
                {
                    DisplayAlert("Ошибка", "Сумма кредита не может быть больше 25000", "ОK");
                }
            }
            catch
            {
                DisplayAlert("Ошибка", "Слишком большое число или неправильный тип даннхы", "ОK");
            }
        }
    }
}
