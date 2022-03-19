using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healt = 5, maxHealth = 10;
            int mana = 3, maxMana = 10;
            while (true)
            {
                DrawBar(healt, maxHealth, ConsoleColor.Red, 0, '_');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '_');

                Console.SetCursorPosition(0, 4);

                Console.Write("изменение хп:");
                healt += Convert.ToInt32(Console.ReadLine());
                Console.Write("изменение маны:");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }
        static void DrawBar(int value, int maxValue, ConsoleColor color,int position,char symbol = ' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";
            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write($"{bar}]");
        }
    }
} 
