using BodyMassIndexMaui.MVVM.Models;

namespace BodyMassIndexMaui.MVVM.ViewModels;

internal class BodyMassIndexViewModel
{
    public BodyMassIndex BodyMassIndex { get; set; }

    public BodyMassIndexViewModel()
    {
        BodyMassIndex = new BodyMassIndex
        {
            Height = 175,
            Weight = 80
        };
    }
}