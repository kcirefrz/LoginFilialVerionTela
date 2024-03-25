using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace LoginFilialVerionTela;

public class CardButtonControl : Button
{
    public static readonly DirectProperty<CardButtonControl, Geometry> GeometryProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, Geometry>(
            nameof(Geometry),
            o => o.Geometry,
            (o, v) => o.Geometry = v);

    public static readonly DirectProperty<CardButtonControl, string> ButtonNameProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, string>(
            nameof(ButtonName),
            o => o.ButtonName,
            (o, v) => o.ButtonName = v);

    public static readonly DirectProperty<CardButtonControl, IBrush> SvgFillProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, IBrush>(
            nameof(SvgFill),
            o => o.SvgFill,
            (o, v) => o.SvgFill = v);

    private Geometry _geometry = new PathGeometry();
    private string _buttonName = string.Empty;
    private IBrush _svgFill = new SolidColorBrush();

    public CardButtonControl()
    {
        SvgFill = new SolidColorBrush(new Color(Byte.MaxValue, 0, Byte.MaxValue, 0));
        
        AddHandler(PointerPressedEvent, (_, _) => OnPointerPressedCard(), handledEventsToo: true);
        AddHandler(PointerReleasedEvent, (_, _) => OnPointerReleasedCard(), handledEventsToo: true);
    }

    public Geometry Geometry
    {
        get => _geometry;
        set => SetAndRaise(GeometryProperty, ref _geometry, value);
    }

    protected IBrush SvgFill
    {
        get => _svgFill;
        set => SetAndRaise(SvgFillProperty, ref _svgFill, value);
    }

    public string ButtonName
    {
        get => _buttonName;
        set => SetAndRaise(ButtonNameProperty, ref _buttonName, value);
    }
    
    private void OnPointerPressedCard()
    {
        SvgFill = new SolidColorBrush(new Color(Byte.MaxValue, Byte.MaxValue, 0, 0));
    }

    private void OnPointerReleasedCard()
    {
        SvgFill = new SolidColorBrush(new Color(Byte.MaxValue, 0, Byte.MaxValue, 0));
    }
}