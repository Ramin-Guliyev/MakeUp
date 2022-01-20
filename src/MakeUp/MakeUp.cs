using System;

namespace MakeUp
{
    public static class MakeUp
    {
        public static void Write(this string? value,Color color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteLine(this string? value,Color color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void Write(this string? value, BackgroundColor color)
        {
            Console.BackgroundColor = (ConsoleColor)color;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteLine(this string? value, BackgroundColor color)
        {
            Console.BackgroundColor = (ConsoleColor)color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void Write(this string? value, BackgroundColor backgroundColor, Color textColor)
        {
            Console.BackgroundColor = (ConsoleColor)backgroundColor;
            Console.ForegroundColor = (ConsoleColor)textColor;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteLine(this string? value, BackgroundColor backgroundColor,Color textColor)
        {
            Console.BackgroundColor = (ConsoleColor)backgroundColor;
            Console.ForegroundColor = (ConsoleColor)textColor;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
