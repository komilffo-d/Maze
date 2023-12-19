using System;
using System.Collections.Generic;
using System.Linq;

namespace Maze
{
    /*    public class MazeGeneratorAldousBroder
        {
            public int width { get; set; }
            public int height { get; set; }
            public bool[,] maze { get; set; }

            public MazeGeneratorAldousBroder(int width, int height)
            {
                this.width = width;
                this.height = height;
                maze = new bool[width, height];
                InitializeMaze();
            }
            public void InitializeMaze()
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        maze[i, j] = true;
                    }
                }
            }
            public void GenerateMaze()
            {


                Random rand = new Random();

                for (int i = 2; i < width - 1; i += 2)
                {
                    for (int j = 2; j < height - 1; j += 2)
                    {
                        maze[i, j] = false;
                    }
                }

                for (int i = 2; i < width - 1; i += 2)
                {
                    for (int j = 2; j < height - 1; j += 2)
                    {
                        int x = i;
                        int y = j;
                        List<int> neighbors = new List<int>();

                        if (x - 2 > 0) neighbors.Add(0);
                        if (y - 2 > 0) neighbors.Add(1);
                        if (x + 2 < width - 1) neighbors.Add(2);
                        if (y + 2 < height - 1) neighbors.Add(3);

                        int neighbor = neighbors[rand.Next(neighbors.Count)];

                        switch (neighbor)
                        {
                            case 0: maze[x - 1, y] = false; x -= 2; break;
                            case 1: maze[x, y - 1] = false; y -= 2; break;
                            case 2: maze[x + 1, y] = false; x += 2; break;
                            case 3: maze[x, y + 1] = false; y += 2; break;
                        }

                        maze[x, y] = false;
                    }
                }
            }
        }
    */


    public static class MazeGeneratorAldousBroder
    {
        public static int N = 1, S = 2, E = 4, W = 8;
        static Dictionary<int, int> DX = new Dictionary<int, int> { { E, 1 }, { W, -1 }, { N, 0 }, { S, 0 } };
        static Dictionary<int, int> DY = new Dictionary<int, int> { { E, 0 }, { W, 0 }, { N, -1 }, { S, 1 } };
        static Dictionary<int, int> OPPOSITE = new Dictionary<int, int> { { E, W }, { W, E }, { N, S }, { S, N } };
        public static int[][] Main(int widthOut = 1, int heightOut = 2, int seedOut = 0)
        {

            int width = widthOut > 0 ? widthOut : 10;
            int height = heightOut > 1 ? heightOut : width;
            int seed = seedOut > 2 ? seedOut : new Random().Next();
            Random rand = new Random(seed);
            int[][] grid = new int[height][];
            for (int i = 0; i < height; i++)
            {
                grid[i] = new int[width];
            }

            Console.Clear();
            int x = rand.Next(width);
            int y = rand.Next(height);
            int remaining = width * height - 1;
            while (remaining > 0)
            {
                List<int> directions = new List<int> { N, S, E, W };
                directions.Sort((a, b) => rand.Next(2) * 2 - 1);
                foreach (int dir in directions)
                {
                    int nx = x + DX[dir];
                    int ny = y + DY[dir];
                    if (nx >= 0 && ny >= 0 && nx < width && ny < height)
                    {
                        if (grid[ny][nx] == 0)
                        {
                            grid[y][x] |= dir;
                            grid[ny][nx] |= OPPOSITE[dir];
                            remaining--;
                        }
                        x = nx;
                        y = ny;
                        break;
                    }
                }
            }
            DisplayMaze(grid);

            return grid;
        }
        static public bool[,] DisplayMaze(int[][] grid, int cx = -1, int cy = -1)
        {

            bool[,] array2D = new bool[grid.Length * 2 + 1, grid.Max(arrIn => arrIn.Length) * 2 + 1];
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" " + new string('_', grid[0].Length * 2 - 1));

            for (int y = 0; y < grid.Length; y++)
            {
                int X = 0;
                int Y = 0;
                Console.Write("|");
                array2D[y, X] = true;
                X++;
                for (int x = 0; x < grid[y].Length; x++)
                {
                    if ((grid[y][x] & S) != 0)
                    {

                        array2D[y, X] = false;
                        X++;


                    }
                    else
                    {
                        array2D[y + 1, X] = true;
                        array2D[y + 1, X-1] = true;
                        array2D[y + 1, X + 1] = true;
                        X++;
                    }
                    /*                    array2D[y+1, X] = (grid[y][x] & S) != 0 ? false : true;*/
/*                    X++;*/
                    Console.Write((grid[y][x] & S) != 0 ? " " : "_");
                    Console.ResetColor();
                    if ((grid[y][x] & E) != 0)
                    {
                        if (((grid[y][x] | grid[y][x + 1]) & S) != 0)
                        {
                            array2D[y, X] = false;
                            X++;
                        }
                        else
                        {
                            array2D[y + 1, X] = true;
                            array2D[y + 1, X - 1] = true;
                            array2D[y + 1, X + 1] = true;
                            X++;
                        }

                        Console.Write(((grid[y][x] | grid[y][x + 1]) & S) != 0 ? " " : "_");
                    }
                    else
                    {
                        Console.Write("|");
                        array2D[y, X] = true;
                        X++;
                    }

                }
                array2D[y, X - 1] = true;
                Console.WriteLine();
            }
            for (int y = 0; y < array2D.GetLength(0); y++)
                if (y == 0 || y == array2D.GetLength(0) - 1)
                    for (int x = 0; x < array2D.GetLength(1); x++)
                        array2D[y, x] = true;

            return array2D;
        }
    }



}
