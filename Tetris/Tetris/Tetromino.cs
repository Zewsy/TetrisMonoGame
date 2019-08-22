using System;

namespace Tetris
{
    public class Tetromino
    {
        public enum Tetro { I, L, O, T, Z };    //Place?

        private int[][] data;

        public Tetromino(Tetro look, int color)
        {
            data = new int[3][];
            switch (look)
            {
                case Tetro.I:
                    data[0] = new int[3]{ 0, color, 0};
                    data[1] = new int[3]{ 0, color, 0};
                    data[2] = new int[3]{ 0, color, 0};
                    break;
                case Tetro.L:
                    data[0] = new int[3] { color, 0, 0 };
                    data[1] = new int[3] { color, 0, 0 };
                    data[2] = new int[3] { color, color, 0 };
                    break;
                case Tetro.O:
                    data[0] = new int[3] { color, color, 0 };
                    data[1] = new int[3] { color, color, 0 };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
                case Tetro.T:
                    data[0] = new int[3] { color, color, color };
                    data[1] = new int[3] { 0, color, 0 };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
                case Tetro.Z:
                    data[0] = new int[3] { color, color, 0 };
                    data[1] = new int[3] { 0, color, color };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
            }
        }
    }
}

