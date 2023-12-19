using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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


    public class MazeGeneratorAldousBroder
    {


        private List<List<bool>> area;
        private bool hole = false;
        private bool wall = true;

        public List<List<bool>> Generate(int width, int height)
        {
            area = new List<List<bool>>(new List<bool>[height]);
            for (int i = 0; i < area.Count; i++)
            {
                area[i] = new List<bool>(Enumerable.Repeat(true,width));
            }

            int y = 0;
            int x = 0;

            int total_cells = (area.Count / 2) * (area[0].Count / 2);

            Random random_generator = new Random();

            int random_start_y = random_generator.Next(1, area.Count - 2);
            int random_start_x = random_generator.Next(1, area[0].Count - 2);

            int[] directions = { 0, 1, 2, 3 }; // north, south, west, east

            y = (random_start_y / 2 * 2 + 1);
            x = (random_start_x / 2 * 2 + 1);
            area[y][x] = hole;
            total_cells--;

            while (total_cells > 0)
            {
                int next_cell = directions[random_generator.Next(0, 4)];
                if (next_cell == 0) // north
                {
                    if (y >= 3)
                    {
                        y -= 2;
                        if (wall == area[y][x])
                        {
                            total_cells--;
                            area[y][x] = hole;
                            area[y + 1][x] = hole;
                        }
                    }
                }
                else if (next_cell == 1) // south
                {
                    if ((y + 2) <= area.Count - 2)
                    {
                        y += 2;
                        if (wall == area[y][x])
                        {
                            total_cells--;
                            area[y][x] = hole;
                            area[y - 1][x] = hole;
                        }
                    }
                }
                else if (next_cell == 2) // west
                {
                    if (x >= 3)
                    {
                        x -= 2;
                        if (wall == area[y][x])
                        {
                            total_cells--;
                            area[y][x] = hole;
                            area[y][x + 1] = hole;
                        }
                    }
                }
                else if (next_cell == 3) // east
                {
                    if ((x + 2) <= area[0].Count - 2)
                    {
                        x += 2;
                        if (wall == area[y][x])
                        {
                            total_cells--;
                            area[y][x] = hole;
                            area[y][x - 1] = hole;
                        }
                    }
                }
            }
            return area;
        }




        /*        public static int N = 1, S = 2, E = 4, W = 8;
                static Dictionary<int, int> DX = new Dictionary<int, int> { { E, 1 }, { W, -1 }, { N, 0 }, { S, 0 } };
                static Dictionary<int, int> DY = new Dictionary<int, int> { { E, 0 }, { W, 0 }, { N, -1 }, { S, 1 } };
                static Dictionary<int, int> OPPOSITE = new Dictionary<int, int> { { E, W }, { W, E }, { N, S }, { S, N } };
                public static int[][] Main(int widthOut = 1, int heightOut = 2, int seedOut = 0)
                {

                    int width = widthOut > 0 ? widthOut : 10;
                    int height = heightOut > 1? heightOut : width;
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
                    int countCol = grid.Max(arrIn => arrIn.Length);
                    char[][] array2D = new char[grid.Length][];
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(" " + new string('_', countCol * 2 - 1));

                    array2D[0] = Enumerable.Repeat('_', countCol).ToArray();
                    for (int y = 0; y < grid.Length; y++)
                    {

                        Console.Write("|");
                        for (int x = 0; x < grid[y].Length; x++)
                        {
                            if (cx == x && cy == y)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            else if (grid[y][x] == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                            }

                            Console.Write((grid[y][x] & S) != 0 ? " " : "_");
                            Console.ResetColor();
                            if ((grid[y][x] & E) != 0)
                            {

                                Console.Write(((grid[y][x] | grid[y][x + 1]) & S) != 0 ? " " : "_");
                            }
                            else
                            {
                                Console.Write("|");
                            }
                        }
                        Console.WriteLine();
                    }
                    return array2D;
                }*/
    }

}



