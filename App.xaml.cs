namespace BMI_Calculator {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState) {
            var window = base.CreateWindow(activationState);
            window.Title = "BMI_Calculator";
            return window;
        }
    }
}