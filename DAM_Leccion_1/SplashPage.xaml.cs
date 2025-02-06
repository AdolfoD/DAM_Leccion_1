using System.Threading.Tasks;
namespace DAM_Leccion_1;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
        InitializeComponent();
        StartTimer();
    }
    private async void StartTimer()
    {
        await Task.Delay(5000); // Espera 5 segundos
        Application.Current.MainPage = new MainPage();
    }
}