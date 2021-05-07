using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;


namespace ASCII_Image_Converter
{
    class AsciiConverter
    {
        readonly double WIGHT_KOF = 2;

        static readonly char[] AsciiCharBLACK = { '.', ',', ':', '-', '^', '+', '*', '?', '%', 'S', '#', '&', '@' };
        static readonly char[] AsciiCharWHITE = { '@', '&', '#', 'S', '%', '?', '*', '+', '^', '-', ':', ',', '.', };


        Bitmap bitmap;
        readonly int wight;
        readonly int height;


        public AsciiConverter(Bitmap bitmap, int wight)
        {
            WIGHT_KOF = (double)((double)Screen.PrimaryScreen.Bounds.Height / (double)Console.LargestWindowHeight) / ((double)(Screen.PrimaryScreen.Bounds.Width - 20) / (double)Console.LargestWindowWidth);
           
            this.bitmap = bitmap;
            this.wight = wight;

            height = (int)(bitmap.Height / WIGHT_KOF * wight / bitmap.Width);

            ResizePicture();
        }
        public AsciiConverter(Bitmap bitmap, int wight , double _WIGHT_KOF)
        {
            WIGHT_KOF = _WIGHT_KOF;

            this.bitmap = bitmap;
            this.wight = wight;

            height = (int)(bitmap.Height / WIGHT_KOF * wight / bitmap.Width);

            ResizePicture();
        }


        public char[][] GetCharMatrixBlack()
        {
            var result = new char[height][];

            for (int y = 0; y < height; y++)
            {
                result[y] = new char[wight];
                for (int x = 0; x < wight; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    result[y][x] = GetNecessaryCharBlack(color);
                }
            }

            return result;
        }
        public char[][] GetCharMatrixWhite()
        {
            var result = new char[height][];

            for (int y = 0; y < height; y++)
            {
                result[y] = new char[wight];
                for (int x = 0; x < wight; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    result[y][x] = GetNecessaryCharWhite(color);
                }
            }

            return result;
        }


        private void ResizePicture()
        {
            bitmap = new Bitmap(bitmap, wight, height);
        }
        private char GetNecessaryCharBlack(Color color)
        {
            double avgColor = (int)((color.R + color.G + color.B) / 3);
            int currIndex = (int)Math.Round((avgColor / 255) * (AsciiCharBLACK.Length - 1));
            return AsciiCharBLACK[currIndex];
        }
        private char GetNecessaryCharWhite(Color color)
        {
            double avgColor = (int)((color.R + color.G + color.B) / 3);
            int currIndex = (int)Math.Round((avgColor / 255) * (AsciiCharWHITE.Length - 1));
            return AsciiCharWHITE[currIndex];
        }

    }
}
