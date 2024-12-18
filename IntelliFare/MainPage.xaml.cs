using DotNetEnv;
namespace IntelliFare
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DotNetEnv.Env.Load();
        }
    }
}
