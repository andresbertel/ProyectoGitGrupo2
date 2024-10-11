namespace TestGitGrupo2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
          
        }

         private void Button_Clicked2(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new Page2());
        }
    }

}
