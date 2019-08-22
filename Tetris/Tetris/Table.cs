using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Table
    {
        public int[][] data { get; set; }
        private  Texture2D squares { get; set; }

        private const int squaresColumns = 4;
        private const int squaresRows = 2;
        private int squareWidth;
        private int squareHeight;
        private int height;
        private int width;

        public Table(int height, int width, Texture2D _squares)
        {
            data = new int[height][];
            for(int i = 0; i < height; i++)
            {
                data[i] = new int[width];
            }
            //data[5][10] = BLUE; //TESTLINE
            squares = _squares;
            squareWidth = squares.Width / squaresColumns;
            squareHeight = squares.Height / squaresRows;
            this.height = height;
            this.width = width;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destination = new Rectangle(20, 20, squareWidth, squareHeight);
            spriteBatch.Begin();
            foreach(int[] arr in data)
            {
                foreach(int element in arr)
                {
                    switch (element)
                    {
                        case (int)TetroColor.BLUE:
                            spriteBatch.Draw(squares, destination, new Rectangle(0, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.GREEN:
                            spriteBatch.Draw(squares, destination, new Rectangle(squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.PINK:
                            spriteBatch.Draw(squares, destination, new Rectangle(2 * squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.PURPLE:
                            spriteBatch.Draw(squares, destination, new Rectangle(3 * squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.RAINBOW:
                            spriteBatch.Draw(squares, destination, new Rectangle(0, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.RED:
                            spriteBatch.Draw(squares, destination, new Rectangle(squareWidth, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.YELLOW:
                            spriteBatch.Draw(squares, destination, new Rectangle(2 * squareWidth, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case (int)TetroColor.GREY:
                            spriteBatch.Draw(squares, destination, new Rectangle(3 * squareWidth, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                    }
                    destination.X += squareWidth;
                }
                destination.X = 20;
                destination.Y += squareHeight;
            }
            spriteBatch.End();
        }

        public void Update()
        {

        }

        public void Clear()
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    data[i][j] = 0;
                }
            }
        }
    }
}
