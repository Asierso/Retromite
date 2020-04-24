using System;
using System.Collections.Generic;
namespace retromite
{
    class player
    {
        public static int playerPosX = 0,playerPosY = 0;
        public static void useMold(string mold,List<string> texture,bool pixelArt)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            switch(mold)
            {   
                case "plane":
                int drawIterator = 0;
                if(pixelArt==true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                foreach(string character in texture)
                {
                    Console.SetCursorPosition(playerPosX,playerPosY + drawIterator);
                    Console.Write(character);
                    drawIterator++;
                }
                Console.BackgroundColor = oldBgColor;
                Console.ForegroundColor = oldBgColor;
                if(Console.ReadKey().Key == ConsoleKey.D)
                {
                    playerPosX++;
                }
                if(Console.ReadKey().Key == ConsoleKey.A)
                {
                    playerPosX--;
                }
                if(Console.ReadKey().Key == ConsoleKey.W)
                {
                    playerPosY--;
                }
                if(Console.ReadKey().Key == ConsoleKey.S)
                {
                    playerPosY++;
                }
                if(Console.ReadKey().Key == ConsoleKey.A || Console.ReadKey().Key == ConsoleKey.W || Console.ReadKey().Key == ConsoleKey.S || Console.ReadKey().Key == ConsoleKey.D)
                {
                    Console.Clear();
                }
                break;
            }
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
    }
}