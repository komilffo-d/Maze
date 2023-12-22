using System;
using System.Collections.Generic;

namespace Maze
{
    public class HandSolver
    {
  
        public static List<(int,int)> SolveMaze(int[,] maze, int[] start, int[] end)
        {
            List<(int, int)> result = new List<(int, int)>();
            int rows = maze.GetLength(0);
            int cols = maze.GetLength(1);

            int startX = start[0];
            int startY = start[1];

            int endX = end[0];
            int endY = end[1];

            int currentX = startX;
            int currentY = startY;

            int direction = 0; 

            while (currentX != endX || currentY != endY)
            {

                if (CanMove(maze, currentX, currentY, (direction + 1) % 4))
                {
                    direction = (direction + 1) % 4;

                    currentX += GetDeltaX(direction);
                    currentY += GetDeltaY(direction);


                    result.Add((currentX, currentY));
                }
                else if(CanMove(maze, currentX, currentY, direction))
                {
                    currentX += GetDeltaX(direction);
                    currentY += GetDeltaY(direction);

                    result.Add((currentX, currentY));
                }
                else
                {
                    direction = (direction + 3) % 4;
                }
            }


            return result;
        }

        static bool CanMove(int[,] maze, int x, int y, int direction)
        {
            int newX = x + GetDeltaX(direction);
            int newY = y + GetDeltaY(direction);

            return newX >= 0 && newX < maze.GetLength(0) && newY >= 0 && newY < maze.GetLength(1) && maze[newX, newY] == 0;
        }

        static int GetDeltaX(int direction)
        {
            return direction == 2 ? 1 : direction == 0 ? -1 : 0;
        }

        static int GetDeltaY(int direction)
        {
            return direction == 1 ? 1 : direction == 3 ? -1 : 0;
        }


    }

}
