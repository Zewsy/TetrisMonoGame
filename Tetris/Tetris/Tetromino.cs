using System;

namespace Tetris
{
    public enum TetroLook { I, L, O, T, Z };
    public enum TetroColor { EMPTY, BLUE, GREEN, PINK, PURPLE, RAINBOW, RED, YELLOW, GREY };
    public class Tetromino
    {
        private const int looksNumber = 4;
        private const int colorsNumber = 8;

        //Top-left corner
        private int column;
        private int row;

        private int[][] data = new int[3][];
        private Table table;

        public Tetromino(Table table)
        {
            this.table = table;
            fillData(generateRandomLook(), (int)generateRandomColor());
            column = table.data[0].Length / 2 - 1;
            row = -2;
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

        public void AddOnTable()
        {
            for(int i1 = row, i2 = 0; i1 < row + 3; i1++)
            {
                if (i1 < 0)     //If we don't add the entire tetromino on the table
                    continue;
                for(int j1 = column, j2 = 0; j1 < column + 3; j1++, j2++)
                {
                    table.data[i1][j1] = data[i2][j2];
                }
                i2++;
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
            int number = rand.Next(colorsNumber) + 1;   //+1 because of EMPTY "color"

            return (TetroColor)number;
        }

        public void Fall()
        {
            row++;
        }

        public void MoveLeft()
        {
            column--;
        }

        public void MoveRight()
        {
            column++;
        }
    }
}

