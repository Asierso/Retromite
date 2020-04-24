using System;
using System.Collections.Generic;
using System.Threading;
namespace Retromite
{
	public class Draw
	{
		#region Normal Cube
		public static void DrawCube(int posX,int posY,int finalPosX,int finalPosY,ConsoleColor color = ConsoleColor.White) //draw cube 
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
        public static void DrawMatrixCube(int posX,int posY,int size,ConsoleColor color = ConsoleColor.White)
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
        public static void DrawCorrectedMatrixCube(int posX,int posY,int size,ConsoleColor color = ConsoleColor.White)
        {
			ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.BackgroundColor = color;
            Console.ForegroundColor = color;
            int finalPosX = posX + size + 3;
            for(int x=posX;x<finalPosX;x++)
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
        #endregion Normal Cube
        #region Screen Changes
        public static void BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public static void ForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void ClearScreenPart(int posX,int posY,int finalPosX,int finalPosY) //Clean part of CMD
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.ForegroundColor = oldBgColor;
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
        #endregion Screen Changes
        #region Textured Cube
        public static void DrawTextureCube(int posX,int posY,int finalPosX,int finalPosY,List<ConsoleColor> colorPalette) //draw cube 
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
        public static void DrawTextureMatrixCube(int posX,int posY,int size,List<ConsoleColor> colorPalette)
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
        #endregion Textured Cube
      	#region Animation
        public static void DrawAnimateCube(List<int> posXVariant,List<int> posYVariant,List<int> posXFinalVariant,List<int> posYFinalVariant,int frameTime,ConsoleColor color = ConsoleColor.White)
		{
			ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            for(int i=0;i<posXVariant.ToArray().Length;i++) //Position Array Runner
            {
            	Console.SetCursorPosition(posXVariant[i],posYVariant[i]);
            	Console.BackgroundColor = color;
            	Console.ForegroundColor = color;
            	for(int x=posXVariant[i];x<posXFinalVariant[i];x++) //Drawer Method
            	{ 
            		for (int y=posYVariant[i];y<posYFinalVariant[i];y++)
                	{
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                	}
            	}
            	Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldBgColor;
				Thread.Sleep(frameTime);
				for(int x=posXVariant[i];x<posXFinalVariant[i];x++) //Clear Method
            	{
            		for (int y=posYVariant[i];y<posYFinalVariant[i];y++)
                	{
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                	}
            	}
				Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldFgColor;

			}
				
		}
        public static void DrawAnimateMatrixCube(List<int> posXVariant,List<int> posYVariant,List<int> sizeVariant,int frameTime,ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            for(int i=0;i<posXVariant.ToArray().Length;i++) //Position Array Runner
            {
            	Console.BackgroundColor = color;
            	Console.ForegroundColor = color;
            	for(int x=posXVariant[i];x<posXVariant[i] + sizeVariant[i];x++) //Drawer Method
            	{
            		for (int y=posYVariant[i];y<posYVariant[i] + sizeVariant[i];y++)
                	{
                    	Console.SetCursorPosition(x,y);
                    	Console.WriteLine("*");
                	}
            	}
            	Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldBgColor;
            	Thread.Sleep(frameTime);
            	for(int x=posXVariant[i];x<posXVariant[i] + sizeVariant[i];x++) //Drawer Method
            	{
            		for (int y=posYVariant[i];y<posYVariant[i] + sizeVariant[i];y++)
                	{
                    	Console.SetCursorPosition(x,y);
                    	Console.WriteLine("*");
                	}
            	}
            	Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldFgColor;
            }

            
        }
        public static void DrawAnimateTextureCube(List<int> posXVariant,List<int> posYVariant,List<int> posXFinalVariant,List<int> posYFinalVariant,int frameTime,List<ConsoleColor> colorPalette) //draw cube 
        {
            ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            int colorArray = 0;
            for(int i=0;i<posXVariant.ToArray().Length;i++) //Position Array Runner
            {
            	for(int x=posXVariant[i];x<posXFinalVariant[i];x++) //Drawer Method
            	{
            		for (int y=posYVariant[i];y<posYFinalVariant[i];y++)
                	{
                    	Console.BackgroundColor = colorPalette[colorArray];
                    	Console.ForegroundColor = colorPalette[colorArray];
                    	Console.SetCursorPosition(x,y);
                    	Console.WriteLine("*");
                    	colorArray++;
                	}
            	}
            	Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldBgColor;
            	Thread.Sleep(frameTime);
            	for(int x=posXVariant[i];x<posXFinalVariant[i];x++) //Clear Method
            	{
            		for (int y=posYVariant[i];y<posYFinalVariant[i];y++)
                	{
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine("*");
                	}
            	}
				Console.BackgroundColor = oldBgColor;
            	Console.ForegroundColor = oldFgColor;
            	
            }

        }
        #endregion Animation
			
	}
}