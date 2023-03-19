using BodyMassIndexMaui.MVVM.Views;

namespace BodyMassIndexMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new BodyMassIndexView();
    }
}
