﻿using System;

namespace MakeUp
{
    public static class Write
    {
        public static void Red(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Black(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Green(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void White(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Yellow(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Magenta(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Blue(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void Cyan(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkBlue(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkGray(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkCyan(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkGreen(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkRed(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkMagenta(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void DarkYellow(this string? value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(value);
            Console.ResetColor();
        }
    }
}
