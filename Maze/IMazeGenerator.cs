using System.Collections.Generic;
using System;

namespace Maze
{
    internal interface IMazeGenerator
    {

        int width { get; set; }
        int height { get; set; }
        bool[,] maze { get; set; }

        void InitializeMaze();

        void GenerateMaze();

/*         List<Tuple<int, int>> this[int x,int y] { get; }*/


    }
}
