using System;
using System.Collections.Generic;
namespace retromite
{
    class draw
    {
        public static void drawCube(int posX,int posY,int finalPosX,int finalPosY,ConsoleColor color) //draw cube 
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.BackgroundColor = color;
            Console.ForegroundColor = color;
            for(int x=posX;x<finalPosX;x++)
            {
                for (int y=posY;y<finalPosY;y++) 
                {
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                }
            }
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        public static void drawSymetricCube(int posX,int posY,int size,ConsoleColor color)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.BackgroundColor = color;
            Console.ForegroundColor = color;
            for(int x=posX;x<posX + size;x++)
            {
                for (int y=posY;y<posY + size;y++)
                {
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                }
            }
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        public static void backgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public static void foregroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void drawTextureCube(int posX,int posY,int finalPosX,int finalPosY,List<ConsoleColor> colorPalette) //draw cube 
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            int colorArray = 0;
            for(int x=posX;x<finalPosX;x++)
            {
                for (int y=posY;y<finalPosY;y++) 
                {
                    Console.BackgroundColor = colorPalette[colorArray];
                    Console.ForegroundColor = colorPalette[colorArray];
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                    colorArray++;
                }
            }
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        public static void drawTextureSymetricCube(int posX,int posY,int size,List<ConsoleColor> colorPalette)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            int colorArray = 0;
            for(int x=posX;x<posX + size;x++)
            {
                    for (int y=posY;y<posY + size;y++)
                    {
                            Console.BackgroundColor = colorPalette[colorArray];
                            Console.ForegroundColor = colorPalette[colorArray];
                            Console.SetCursorPosition(x,y);
                            Console.WriteLine("*");
                            colorArray++;

                    }

            }
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
    }
}