using BodyMassIndexMaui.MVVM.ViewModels;

namespace BodyMassIndexMaui.MVVM.Views;

public partial class BodyMassIndexView : ContentPage
{
    public BodyMassIndexView()
    {
        InitializeComponent();
        BindingContext = new BodyMassIndexViewModel();
    }
}