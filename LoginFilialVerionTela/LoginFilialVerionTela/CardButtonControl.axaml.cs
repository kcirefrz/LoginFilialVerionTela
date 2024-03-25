using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace LoginFilialVerionTela;

public class CardButtonControl : Button
{
    public static readonly DirectProperty<CardButtonControl, Geometry> GeometryProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, Geometry>(
            nameof(Geometry),
            o => o.Geometry,
            (o, v) => o.Geometry = v);

    private Geometry _geometry = new PathGeometry();
    public Geometry Geometry
    {
        get => _geometry;
        set => SetAndRaise(GeometryProperty, ref _geometry, value);
    }

    public static readonly DirectProperty<CardButtonControl, string> ButtonNameProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, string>(
            nameof(ButtonName),
            o => o.ButtonName,
            (o, v) => o.ButtonName = v);

    private string _buttonName = string.Empty;
    public string ButtonName
    {
        get => _buttonName;
        set => SetAndRaise(ButtonNameProperty, ref _buttonName, value);
    }
}