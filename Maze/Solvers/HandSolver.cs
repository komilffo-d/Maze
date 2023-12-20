using System.Collections.Generic;
using System.Drawing;

namespace Maze
{
    internal static class HandSolver
    {
        public static List<int[]> SolveMaze(int[,] maze, int[] enter, int[] exit)
        {
            var points = new List<int[]>();

            var coordinates = enter;

            Direction dir = Direction.Default;
            if (enter[0] == 0)
                dir = Direction.Down;
            else if (enter[0] == maze.GetLength(0) - 1)
                dir = Direction.Up;
            else if (enter[1] == 0)
                dir = Direction.Right;
            else if (enter[1] == maze.GetLength(1) - 1)
                dir = Direction.Left;

            while (coordinates[0] != exit[0] || coordinates[1] != exit[1])
            {
                switch (dir)
                {
                    case Direction.Right:
                        {
                            while (true)
                            {
                                if (maze[coordinates[0] + 1, coordinates[1]] == 1 ||
                                maze[coordinates[0] + 1, coordinates[1]] == 2)
                                {
                                    if (maze[coordinates[0], coordinates[1] + 1] == 0 ||
                                    maze[coordinates[0], coordinates[1] + 1] == 4)
                                    {
                                        coordinates[1] += 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                    }
                                    else if (maze[coordinates[0], coordinates[1] + 1] == 3)
                                    {
                                        coordinates[1] += 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                        break;
                                    }
                                    else
                                    {
                                        dir = Direction.Up;
                                        break;
                                    }
                                }
                                else
                                {
                                    dir = Direction.Down;
                                    coordinates[0] += 1;
                                    points.Add(new int[] { coordinates[0], coordinates[1] });
                                    break;
                                }
                            }

                            break;
                        }
                    case Direction.Down:
                        {
                            while (true)
                            {
                                if (maze[coordinates[0], coordinates[1] - 1] == 1 ||
                                maze[coordinates[0], coordinates[1] - 1] == 2)
                                {
                                    if (maze[coordinates[0] + 1, coordinates[1]] == 0 ||
                                    maze[coordinates[0] + 1, coordinates[1]] == 4)
                                    {
                                        coordinates[0] += 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                    }
                                    else if (maze[coordinates[0] + 1, coordinates[1]] == 3)
                                    {
                                        coordinates[0] += 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                        break;
                                    }
                                    else
                                    {
                                        dir = Direction.Right;
                                        break;
                                    }
                                }
                                else
                                {
                                    dir = Direction.Left;
                                    coordinates[1] -= 1;
                                    points.Add(new int[] { coordinates[0], coordinates[1] });
                                    break;
                                }
                            }

                            break;
                        }
                    case Direction.Left:
                        {
                            while (true)
                            {
                                if (maze[coordinates[0] - 1, coordinates[1]] == 1 ||
                                maze[coordinates[0] - 1, coordinates[1]] == 2)
                                {
                                    if (maze[coordinates[0], coordinates[1] - 1] == 0 ||
                                    maze[coordinates[0], coordinates[1] - 1] == 4)
                                    {
                                        coordinates[1] -= 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                    }
                                    else if (maze[coordinates[0], coordinates[1] - 1] == 3)
                                    {
                                        coordinates[1] -= 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                        break;
                                    }
                                    else
                                    {
                                        dir = Direction.Down;
                                        break;
                                    }
                                }
                                else
                                {
                                    dir = Direction.Up;
                                    coordinates[0] -= 1;
                                    points.Add(new int[] { coordinates[0], coordinates[1] });
                                    break;
                                }
                            }

                            break;
                        }
                    case Direction.Up:
                        {
                            while (true)
                            {
                                if (maze[coordinates[0], coordinates[1] + 1] == 1 ||
                                maze[coordinates[0], coordinates[1] + 1] == 2)
                                {
                                    if (maze[coordinates[0] - 1, coordinates[1]] == 0 ||
                                    maze[coordinates[0] - 1, coordinates[1]] == 4)
                                    {
                                        coordinates[0] -= 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                    }
                                    else if (maze[coordinates[0] - 1, coordinates[1]] == 3)
                                    {
                                        coordinates[0] -= 1;
                                        points.Add(new int[] { coordinates[0], coordinates[1] });
                                        break;
                                    }
                                    else
                                    {
                                        dir = Direction.Left;
                                        break;
                                    }
                                }
                                else
                                {
                                    dir = Direction.Right;
                                    coordinates[1] += 1;
                                    points.Add(new int[] { coordinates[0], coordinates[1] });
                                    break;
                                }
                            }

                            break;
                        }
                }
            }

            return points;
        }
        enum Direction
        {
            Default,
            Right,
            Left,
            Down,
            Up
        }












        /*   public static int[,] SolveMaze(int[,] maze, int[] start, int[] end)
           {
               int rows = maze.GetLength(0);
               int cols = maze.GetLength(1);

               int[,] distances = new int[rows, cols];
               for (int i = 0; i < rows; i++)
                   for (int j = 0; j < cols; j++)
                       distances[i, j] = -1;

               Queue<int[]> queue = new Queue<int[]>();
               queue.Enqueue(start);
               distances[start[0], start[1]] = 0;

               int[] dx = { 0, 0, 1, -1 };
               int[] dy = { 1, -1, 0, 0 };

               while (queue.Count > 0)
               {
                   int[] current = queue.Dequeue();

                   for (int i = 0; i < 4; i++)
                   {
                       int newRow = current[0] + dx[i];
                       int newCol = current[1] + dy[i];

                       if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
                           maze[newRow, newCol] == 0 && distances[newRow, newCol] == -1)
                       {
                           distances[newRow, newCol] = distances[current[0], current[1]] + 1;
                           queue.Enqueue(new int[] { newRow, newCol });
                       }
                   }
               }

               if (distances[end[0], end[1]] == -1)
               {
                   return null; // Путь не найден
               }

               int[,] path = new int[distances[end[0], end[1]] + 1, 2];
               int pathRow = distances[end[0], end[1]];

               path[pathRow, 0] = end[0];
               path[pathRow, 1] = end[1];

               while (pathRow > 0)
               {
                   int currentRow = path[pathRow, 0];
                   int currentCol = path[pathRow, 1];

                   for (int i = 0; i < 4; i++)
                   {
                       int newRow = currentRow + dx[i];
                       int newCol = currentCol + dy[i];

                       if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
                           distances[newRow, newCol] == distances[currentRow, currentCol] - 1)
                       {
                           path[--pathRow, 0] = newRow;
                           path[pathRow, 1] = newCol;
                           break;
                       }
                   }
               }

               return path;
           }

           public class Point
           {
               public int X { get; set; }
               public int Y { get; set; }

               public Point(int x, int y)
               {
                   X = x;
                   Y = y;
               }
           }*/
    }
}
