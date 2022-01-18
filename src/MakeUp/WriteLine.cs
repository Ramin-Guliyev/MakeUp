using System;
namespace MakeUp
{
    public static class WriteLine
    {
        public static void RedLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void BlackLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void GreenLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void WhiteLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void YellowLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void MagentaLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void BlueLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void CyanLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkBlueLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkGrayLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkCyanLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkGreenLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkRedLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkMagentaLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void DarkYellowLine(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
