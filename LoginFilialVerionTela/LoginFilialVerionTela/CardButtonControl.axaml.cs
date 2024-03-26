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

    public static readonly DirectProperty<CardButtonControl, double> CustomHeightProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, double>(
            nameof(CustomHeight),
            o => o.CustomHeight,
            (o, v) => o.CustomHeight = v);

    public static readonly DirectProperty<CardButtonControl, double> CustomWidthProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, double>(
            nameof(CustomWidth),
            o => o.CustomWidth,
            (o, v) => o.CustomWidth = v);

    public static readonly DirectProperty<CardButtonControl, IBrush> SvgFillProperty =
        AvaloniaProperty.RegisterDirect<CardButtonControl, IBrush>(
            nameof(SvgFill),
            o => o.SvgFill,
            (o, v) => o.SvgFill = v);

    private double _width = 0;
    private double _height = 58;
    private Geometry _geometry = new PathGeometry();
    private string _buttonName = string.Empty;
    private IBrush _svgFill = new SolidColorBrush();

    public CardButtonControl()
    {
        SvgFill = new SolidColorBrush(new Color(255,255,255,255));
        AddHandler(PointerPressedEvent, (_, _) => OnPointerPressedCard(), handledEventsToo: true);
        AddHandler(PointerReleasedEvent, (_, _) => OnPointerReleasedCard(), handledEventsToo: true);
    }

    public double CustomWidth
    {
        get => _width;
        set => SetAndRaise(CustomWidthProperty, ref _width, value);
    }

    public double CustomHeight
    {
        get => _height;
        set => SetAndRaise(CustomHeightProperty, ref _height, value);
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
        SvgFill = new SolidColorBrush(new Color(255,4,4,4));
    }

    private void OnPointerReleasedCard()
    {
        SvgFill = new SolidColorBrush(new Color(255,255,255,255));
    }
}