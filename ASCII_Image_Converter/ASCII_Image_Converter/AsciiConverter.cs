using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ASCII_Image_Converter
{
    class AsciiConverter
    {
        const double WIGHT_KOF = 2.5;

        static readonly char[] AsciiCharBLACK = { '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };
        static readonly char[] AsciiCharWHITE = { '@', '#', 'S', '%', '?', '*', '+', ':', ',', '.', };


        Bitmap bitmap;
        readonly int wight;
        readonly int height;



        public AsciiConverter(Bitmap bitmap, int wight)
        {
            this.bitmap = bitmap;
            this.wight = wight;

            height = (int)(bitmap.Height / WIGHT_KOF * wight / bitmap.Width);

            CropPicture();
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


        private void CropPicture()
        {
            bitmap = new Bitmap(bitmap, wight, height);
        }
        private char GetNecessaryCharBlack(Color color)
        {
            double avgColor = (int)((color.R + color.G + color.B) / 3);
            int currIndex = (int)((avgColor / 255) * (AsciiCharBLACK.Length - 1));
            return AsciiCharBLACK[currIndex];
        }
        private char GetNecessaryCharWhite(Color color)
        {
            double avgColor = (int)((color.R + color.G + color.B) / 3);
            int currIndex = (int)((avgColor / 255) * (AsciiCharBLACK.Length - 1));
            return AsciiCharWHITE[currIndex];
        }

    }
}
