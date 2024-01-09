using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MauiApp2;

namespace StartWithMaui;

public partial class DynamicMainPage : ContentPage
{
	public DynamicMainPage()
	{
		InitializeComponent();

		InitializeControls();

		Image img = InitializeImage();	
	}
    private void InitializeControlls()
    {
        AddLayout();
        AddLabels();
        Addbuttons();
    }

    private void Addbuttons()
    {
        throw new NotImplementedException();
    }

    private void AddLabels()
    {
        StackLayout stk = new StackLayout();
        stk.Orientation = StackOrientation.Vertical;
        stk.BackgroundColor = Colors.Beige;
    }

    private void AddLayout()
    {
        StackLayout stk = new StackLayout();
        stk.Orientation = StackOrientation.Vertical;
        stk.BackgroundColor = Colors.DarkViolet;
    }

    private Image InitializeImage()
    {
        Image image = new Image();  
        
    }

    private void InitializeControls()
    {
        StackLayout stk = new StackLayout();
		stk.Orientation = StackOrientation.Vertical;
		stk.BackgroundColor = Colors.Red;
    }
}