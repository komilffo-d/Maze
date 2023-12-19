using Maze;
using System;
using System.Collections.Generic;

namespace MazeGenerator
{
/*    class MazeGeneratorEuler : IMazeGenerator
    {
        public int width { get; set; }
        public int height { get; set; }
        public bool[,] maze { get; set; }


        public MazeGeneratorEuler(int width, int height)
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
                    maze[i, j] = false;
                }
            }
        }

        public void GenerateMaze()
        {
            Random random = new Random();
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            int x = random.Next(0, width);
            int y = random.Next(0, height);
            stack.Push(new Tuple<int, int>(x, y));
            while (stack.Count > 0)
            {
                Tuple<int, int> current = stack.Peek();
                x = current.Item1;
                y = current.Item2;
                List<Tuple<int, int>> neighbors = new List<Tuple<int, int>>();

                if (x > 1 && !maze[x - 2, y])
                    neighbors.Add(new Tuple<int, int>(x - 2, y));
                if (x < width - 2 && !maze[x + 2, y])
                    neighbors.Add(new Tuple<int, int>(x + 2, y));
                if (y > 1 && !maze[x, y - 2])
                    neighbors.Add(new Tuple<int, int>(x, y - 2));
                if (y < height - 2 && !maze[x, y + 2])
                    neighbors.Add(new Tuple<int, int>(x, y + 2));

                if (neighbors.Count > 0)
                {
                    int index = random.Next(neighbors.Count);
                    Tuple<int, int> next = neighbors[index];
                    int nextX = next.Item1;
                    int nextY = next.Item2;

                    // Carve a passage
                    if (nextX != x)
                        maze[(x + nextX) / 2, y] = true;
                    else
                        maze[x, (y + nextY) / 2] = true;

                    maze[nextX, nextY] = true;
                    stack.Push(next);
                }
                else
                {
                    stack.Pop();
                }

            }
        }


    }*/


    public static class MazeGeneratorEuler
    {

        public static List<List<bool>> GenerateMaze(uint width, uint height)
        {
            if (width < 1 || height < 1)
                return null;

            const uint top_limit = uint.MaxValue;

            if ((top_limit - 1) / 2 <= width || (top_limit - 1) / 2 <= height)
                return null;

            uint output_height = height * 2 + 1;
            uint output_width = width * 2 + 1;

            List<List<bool>> maze = new List<List<bool>>();
            maze.Capacity = (int)output_height;

            for (uint i = 0; i < output_height; ++i)
            {
                List<bool> row = new List<bool>();
                row.Capacity = (int)output_width;

                for (uint j = 0; j < output_width; ++j)
                {
                    if (i % 2 == 1 && j % 2 == 1)
                        row.Add(false);
                    else if ((i % 2 == 1 && j % 2 == 0 && j != 0 && j != output_width - 1) ||
                             (j % 2 == 1 && i % 2 == 0 && i != 0 && i != output_height - 1))
                        row.Add(false);
                    else
                        row.Add(true);
                }

                maze.Add(row);
            }

            List<uint> row_set = new List<uint>();
            row_set.Capacity = (int)width;

            for (uint i = 0; i < width; ++i)
                row_set.Add(0);

            uint set = 1;

            Random rd = new Random();

            for (uint i = 0; i < height; ++i)
            {
                for (uint j = 0; j < width; ++j)
                {
                    if (row_set[(int)j] == 0)
                        row_set[(int)j] = set++;
                }

                for (uint j = 0; j < width - 1; ++j)
                {
                    int right_wall = rd.Next(0, 3);

                    if (right_wall == 1 || row_set[(int)j] == row_set[(int)(j + 1)])
                        maze[(int)(i * 2 + 1)][(int)(j * 2 + 2)] = true;
                    else
                    {
                        uint changing_set = row_set[(int)(j + 1)];

                        for (uint l = 0; l < width; ++l)
                        {
                            if (row_set[(int)l] == changing_set)
                                row_set[(int)l] = row_set[(int)j];
                        }
                    }
                }

                for (uint j = 0; j < width; ++j)
                {
                    int bottom_wall = rd.Next(0, 3);
                    uint count_current_set = 0;

                    for (uint l = 0; l < width; ++l)
                    {
                        if (row_set[(int)j] == row_set[(int)l])
                            count_current_set++;
                    }

                    if (bottom_wall == 1 && count_current_set != 1)
                        maze[(int)(i * 2 + 2)][(int)(j * 2 + 1)] = true;
                }

                if (i != height - 1)
                {
                    for (uint j = 0; j < width; ++j)
                    {
                        uint count_hole = 0;

                        for (uint l = 0; l < width; ++l)
                        {
                            if (row_set[(int)l] == row_set[(int)j] && maze[(int)(i * 2 + 2)][(int)(l * 2 + 1)] == false)
                                count_hole++;
                        }

                        if (count_hole == 0)
                            maze[(int)(i * 2 + 2)][(int)(j * 2 + 1)] = false;
                    }

                    for (uint j = 0; j < width; ++j)
                    {
                        if (maze[(int)(i * 2 + 2)][(int)(j * 2 + 1)] == true)
                            row_set[(int)j] = 0;
                    }
                }
            }

            for (uint j = 0; j < width - 1; ++j)
            {
                if (row_set[(int)j] != row_set[(int)(j + 1)])
                    maze[(int)(output_height - 2)][(int)(j * 2 + 2)] = false;
            }

            return maze;
        }

        public static void Print(bool[,] maze)
        {
            if (maze == null)
                return;

            for (uint i = 0; i < maze.GetLength(0); ++i)
            {
                for (uint j = 0; j < maze.GetLength(1); ++j)
                    Console.Write(maze[(int)i,(int)j]);

                Console.WriteLine();
            }
        }

         static MazeGeneratorEuler() { }
    }



}
