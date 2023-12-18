using Maze;
using System;
using System.Collections.Generic;

namespace MazeGenerator
{
    class MazeGeneratorEuler : IMazeGenerator
    {
        public int width { get; set; }
        public int height { get; set; }
        public bool[,] maze { get; set; }


        public MazeGeneratorEuler(int width, int height)
        {
            this.width = width;
            this.height = height;
            maze = new bool[height, width];
            InitializeMaze();
        }

        public void InitializeMaze()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
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


    }
}
