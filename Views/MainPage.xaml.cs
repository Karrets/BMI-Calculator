namespace BMI_Calculator.Views {
    public partial class MainPage : ContentPage {
        private string _morseToBe = "";

        public MainPage() {
            InitializeComponent();
        }

        private void OnTextChange(object? sender, TextChangedEventArgs e) {
            var weight = (Entry)FindByName("UserWeight");
            var height = (Entry)FindByName("UserHeight");
            var output = (Label)FindByName("OutputLabel");

            var successWeight = int.TryParse(weight.Text, out var parsedWeight);
            var successHeight = int.TryParse(height.Text, out var parsedHeight);

            if (successWeight && successHeight) {
                output.Text = $"Your BMI is: {parsedWeight / (parsedHeight * parsedHeight)}";
            }
        }

        private void DotButton_OnClicked(object? sender, EventArgs e) {
            _morseToBe += ".";
        }

        private void DashButton_OnClicked(object? sender, EventArgs e) {
            _morseToBe += "-";
        }

        private void SpaceButton_OnClicked(object? sender, EventArgs e) {
            MorseOutput.Text += Morse.MorseCoder(_morseToBe);

            _morseToBe = "";
        }
    }
}