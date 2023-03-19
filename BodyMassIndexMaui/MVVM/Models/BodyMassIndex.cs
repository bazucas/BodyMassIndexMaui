using PropertyChanged;

namespace BodyMassIndexMaui.MVVM.Models;

[AddINotifyPropertyChangedInterface]
public class BodyMassIndex
{
    //private float result;

    public float Height { get; set; }
    public float Weight { get; set; }
    public float Result => Weight / Height / Height * 10000;

    public string ResultText
    {
        get
        {
            const string template = "BMI: #";
            switch (Result)
            {
                case <= 16:
                    return template.Replace("#", "Severe Thinness");
                case > 16 and <= 17:
                    return template.Replace("#", "Moderate Thinness");
                case > 17 when Result <= 18.5:
                    return template.Replace("#", "Mild Thinness");
                default:
                    {
                        if (Result > 18.5 && Result <= 25)
                        {
                            return template.Replace("#", "Normal");
                        }
                        else
                            return Result switch
                            {
                                > 25 and <= 30 => template.Replace("#", "Overweight"),
                                > 30 and <= 35 => template.Replace("#", "Obese Class I"),
                                > 35 and <= 40 => template.Replace("#", "Obese Class II"),
                                _ => template.Replace("#", "Obese Class III")
                            };
                    }
            }
        }
    }
}