using System.Globalization;
using UnityEngine;


public class Util
{
    public static int HexStringToInt(string hex)
    {
        return int.Parse(hex, NumberStyles.HexNumber);
    }

    public static int ColorToInt(Color color)
    {
        return HexStringToInt(ColorUtility.ToHtmlStringRGB(color));
    }

    public static Color IntToColor(int value)
    {
        ColorUtility.TryParseHtmlString("#" + value.ToString("X"), out Color color);
        return color;
    }
}
