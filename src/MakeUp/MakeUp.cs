using System;

namespace MakeUp
{
    public static class MakeUp
    {
        public static void Write(this string? value,MakeUpColor color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteLine(this string? value,MakeUpColor color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
