using System;

namespace Tetris
{
    public enum TetroLook { I, L, O, T, Z };
    public enum TetroColor { BLUE, GREEN, PINK, PURPLE, RAINBOW, RED, YELLOW, GREY };
    public class Tetromino
    {
        private const int looksNumber = 4;
        private const int colorsNumber = 8;

        private int[][] data = new int[3][];

        public Tetromino(TetroLook look, int color)
        {
            fillData(look, color);
        }

        public Tetromino()
        {
            fillData(generateRandomLook(), (int)generateRandomColor());
        }

        public void fillData(TetroLook look, int color)
        {
            switch (look)
            {
                case TetroLook.I:
                    data[0] = new int[3] { 0, color, 0 };
                    data[1] = new int[3] { 0, color, 0 };
                    data[2] = new int[3] { 0, color, 0 };
                    break;
                case TetroLook.L:
                    data[0] = new int[3] { color, 0, 0 };
                    data[1] = new int[3] { color, 0, 0 };
                    data[2] = new int[3] { color, color, 0 };
                    break;
                case TetroLook.O:
                    data[0] = new int[3] { color, color, 0 };
                    data[1] = new int[3] { color, color, 0 };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
                case TetroLook.T:
                    data[0] = new int[3] { color, color, color };
                    data[1] = new int[3] { 0, color, 0 };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
                case TetroLook.Z:
                    data[0] = new int[3] { color, color, 0 };
                    data[1] = new int[3] { 0, color, color };
                    data[2] = new int[3] { 0, 0, 0 };
                    break;
            }
        }
        public static TetroLook generateRandomLook()
        {
            Random rand = new Random();
            int number = rand.Next(looksNumber);

            return (TetroLook)number;
        }

        public static TetroColor generateRandomColor()
        {
            Random rand = new Random();
            int number = rand.Next(colorsNumber);

            return (TetroColor)number;
        }
    }
}

