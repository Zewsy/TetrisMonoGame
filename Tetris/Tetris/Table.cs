﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Table
    {
        //Temporary place
        private const int BLUE = 1;
        private const int GREEN = 2;
        private const int PINK = 3;
        private const int PURPLE = 4;
        private const int RAINBOW = 5;
        private const int RED = 6;
        private const int YELLOW = 7;
        private const int GREY = 8;

        private int[][] data;
        private  Texture2D squares { get; set; }

        private const int squaresColumns = 4;
        private const int squaresRows = 2;
        private int squareWidth;
        private int squareHeight;

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
                        case BLUE:
                            spriteBatch.Draw(squares, destination, new Rectangle(0, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case GREEN:
                            spriteBatch.Draw(squares, destination, new Rectangle(squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case PINK:
                            spriteBatch.Draw(squares, destination, new Rectangle(2 * squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case PURPLE:
                            spriteBatch.Draw(squares, destination, new Rectangle(3 * squareWidth, 0, squareWidth, squareHeight), Color.White);
                            break;
                        case RAINBOW:
                            spriteBatch.Draw(squares, destination, new Rectangle(0, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case RED:
                            spriteBatch.Draw(squares, destination, new Rectangle(squareWidth, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case YELLOW:
                            spriteBatch.Draw(squares, destination, new Rectangle(2 * squareWidth, squareHeight, squareWidth, squareHeight), Color.White);
                            break;
                        case GREY:
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
    }
}