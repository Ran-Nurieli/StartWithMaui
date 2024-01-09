using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MauiApp2;
using static System.Net.Mime.MediaTypeNames;

namespace StartWithMaui;

public partial class DynamicPage : ContentPage
{
    public int place = 0;
    List<Monkey> monkeyList;
    public DynamicPage()
    {
        InitializeComponent();
        monkeyList = Monkey.GetMonkeys();
        InitializeControlls();

    }

    private void InitializeControlls()
    {
        StackLayout stk = InitializeLayout();
        List<Button> buttons = InitializeButtons();
        Image img = InitializeImage();
        stk.Children.Add(buttons[0]);
        stk.Children.Add(img);
        stk.Children.Add(buttons[1]);
        this.Content = stk;
    }

    private StackLayout InitializeLayout()
    {
        StackLayout stk = new StackLayout();
        stk.Orientation = StackOrientation.Vertical;
        stk.BackgroundColor = Colors.Beige;
        return stk;
    }
    private Image InitializeImage()
    {
        Image image = new Image();
        image.Source = monkeyList[place].Image;

        return image;
    }

    private List<Button> InitializeButtons()
    {
        List<Button> buttons = new List<Button>();
        buttons.Add(new Button());
        buttons.Add(new Button());
        buttons[0].Text = "Up";
        buttons[0].Clicked += ImageUp;
        buttons[1].Text = "Down";
        buttons[1].Clicked += ImageDown;
        return buttons;

    }
    private void ImageUp(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        place++;
        if (place > monkeyList.Count - 1)
            place = 0;
        StackLayout stk = (StackLayout)this.Content;
        ((Image)stk.Children[1]).Source = monkeyList[place].Image;
    }
    private void ImageDown(object sender, EventArgs e)
    {
        Button bt = (Button)sender;
        place--;
        if (place < 0)
            place = monkeyList.Count - 1;
        StackLayout stk = (StackLayout)this.Content;
        ((Image)stk.Children[1]).Source = monkeyList[place].Image;
    }
}