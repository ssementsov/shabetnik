using System;

class BackGround
{
    public static void Main()
    {
        // Массив со значениями ConsoleColor
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        // Сохраняем текущие цвета
        ConsoleColor currentForeground = Console.ForegroundColor;

        // Отображаем все цвета переднего плана, кроме фонового

        // Отображаем все цвета заднего плана, кроме цвета текста

        foreach (var color in colors)
        {
            if (color == currentForeground) continue;

            Console.BackgroundColor = color;
            Console.WriteLine("\nThe background color is {0}.", color);
        }

        // Возращаем обычный цвет.
        Console.ResetColor();
        Console.WriteLine("\nThe background color is Normal");
    }
}
