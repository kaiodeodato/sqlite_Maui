namespace MauiApp1
{
    public partial class App : Application
    {
        public App(MainPage mainPage)
        {
            try
            {
                InitializeComponent();
                MainPage = mainPage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

    }
}
