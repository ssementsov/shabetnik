using System;

class Foreground
{
    public static void Main()
    {
        // Массив со значениями ConsoleColor
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        // Сохраняем текущие цвета
        ConsoleColor currentBackground = Console.BackgroundColor;
        ConsoleColor currentForeground = Console.ForegroundColor;

        // Отображаем все цвета переднего плана, кроме фонового

        foreach (var color in colors)
        {
            if (color == currentBackground) continue;

            Console.ForegroundColor = color;
            Console.WriteLine("   The foreground color is {0}.", color);
        }
        Console.WriteLine();
        // Возвращаем обычный цвет
        Console.ForegroundColor = currentForeground;

    }
}