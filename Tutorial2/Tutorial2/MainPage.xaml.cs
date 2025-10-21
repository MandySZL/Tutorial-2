namespace Tutorial2
{
    public partial class MainPage : ContentPage
    {
        private bool isLoved = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAdoptionClicked(object sender, EventArgs e)
        {
            // Example action: Show an alert
            DisplayAlert("Adoption", "Adopted Successfully!", "OK");

            // You can add navigation or other logic here
        }

        private void OnLoveClicked(object sender, TappedEventArgs e)
        {
            isLoved = !isLoved; // Toggle the state

            if (isLoved)
            {
                // Change to a filled heart and a different color
                LoveButtonLabel.Text = "❤️";
                LoveButtonLabel.TextColor = Colors.Red;
            }
            else
            {
                // Change back to the outline heart and original color
                LoveButtonLabel.Text = "♡";
                LoveButtonLabel.TextColor = (Color)Application.Current.Resources["Gray500"];
            }
        }
    }
}