namespace StartWithMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DynamicMainPage();
	}
}
