using System;
using System.Collections.Generic;

namespace Maze
{
    public class MazeGeneratorAldousBroder: IMazeGenerator
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
}
