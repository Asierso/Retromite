using System;
using System.Collections.Generic;
using System.Threading;
namespace Retromite
{
    public class Window
    {
    	//This class are obsolete
        public static void CreateTextWindow(int posX,int posY,int size,string title,string content)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            for(int x = posX;x<posX + 40 + size;x++)
            {
                for(int y = posY;y<posY + 10+size;y++)
                {
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                }
            }
            //Draw shadow of window
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for(int x = posX + 2;x<posX + 42 + size;x++) 
            {
                Console.SetCursorPosition(x,posY + 10 + size);
                Console.WriteLine("*");

            }
            for(int y=posY + 1;y<posY + 10 + size;y++)
            {
                Console.SetCursorPosition(posX + 40 + size,y);
                Console.WriteLine("*"); 
                Console.SetCursorPosition(posX + 41 + size,y);
                Console.WriteLine("*"); 
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            //Draw borders of window
            for(int x = posX;x<posX + 40 + size;x++)
            {
                Console.SetCursorPosition(x,posY);
                Console.WriteLine("="); 
                Console.SetCursorPosition(x,posY + 9 + size);
                Console.WriteLine("="); 
            }
            for(int y = posY;y<posY + 10 + size;y++)
            {
                Console.SetCursorPosition(posX,y);
                Console.WriteLine("|"); 
                Console.SetCursorPosition(posX + 40 + size,y);
                Console.WriteLine("|"); 
            }
            //Draw Title and Content
            Console.SetCursorPosition(posX + 10 + size,posY + 2);
            Console.Write(title);
            Console.SetCursorPosition(posX + 6 + size,posY + 4);
            Console.Write(content);
            Console.SetCursorPosition(0,0);
            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        public static void CreateButtonWindow(int posX,int posY,int size,string title,string content,List<string> buttons)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            for(int x = posX;x<posX + 40 + size;x++)
            {
                for(int y = posY;y<posY + 10+size;y++)
                {
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                }
            }
            //Draw shadow of window
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for(int x = posX + 2;x<posX + 42 + size;x++) 
            {
                Console.SetCursorPosition(x,posY + 10 + size);
                Console.WriteLine("*");

            }
            for(int y=posY + 1;y<posY + 10 + size;y++)
            {
                Console.SetCursorPosition(posX + 40 + size,y);
                Console.WriteLine("*"); 
                Console.SetCursorPosition(posX + 41 + size,y);
                Console.WriteLine("*"); 
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            //Draw borders of window
            for(int x = posX;x<posX + 40 + size;x++)
            {
                Console.SetCursorPosition(x,posY);
                Console.WriteLine("="); 
                Console.SetCursorPosition(x,posY + 9 + size);
                Console.WriteLine("="); 
            }
            for(int y = posY;y<posY + 10 + size;y++)
            {
                Console.SetCursorPosition(posX,y);
                Console.WriteLine("|"); 
                Console.SetCursorPosition(posX + 40 + size,y);
                Console.WriteLine("|"); 
            }
            //Draw Title and Content
            Console.SetCursorPosition(posX + 10 + size,posY + 2);
            Console.Write(title);
            Console.SetCursorPosition(posX + 6 + size,posY + 4);
            Console.Write(content);
            Console.SetCursorPosition(0,0);
            int returnVal = 0;
            //Draw Buttons
            while(returnVal == 0)
            {
                int buttonNumberArraid = posX + 10;
                int i=0;
                int keyIterator = 0;
                foreach(string buttonN in buttons)
                {
                    if(buttons[i] == buttonN && keyIterator == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if(Console.ReadKey().Key == ConsoleKey.RightArrow)
                    {
                        keyIterator++;
                    }
                    if(Console.ReadKey().Key == ConsoleKey.LeftArrow)
                    {
                        keyIterator--;
                    }
                    Console.SetCursorPosition(buttonNumberArraid,posY + size + 6);
                    Console.Write("<" + buttonN + ">");
                    buttonNumberArraid = buttonNumberArraid + 15;
                    i++;
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0,0);
                    Console.Write(keyIterator.ToString() + " " + i.ToString());
                }
            }

            Console.BackgroundColor = oldBgColor;
            Console.ForegroundColor = oldFgColor;
        }
        
    }
}