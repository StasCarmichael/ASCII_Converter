using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Image_Converter
{
    public partial class ManagementForm : Form
    {
        private const string MSG = "Перевірте коректність даних";
        private const string DONWLOAD_MSG = "Виберіть будь ласка файл";
        private const double CONSOLE_KOF = 0.989583;
        private const int MAX_WIGHT = 950;


        private Bitmap myBitmap;


        public ManagementForm()
        {
            InitializeComponent();
        }



        private void PrintMatrix(char[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
        private void PrintImage(Bitmap _bitmap, int _wight)
        {
            try
            {
                Console.BufferWidth = Console.LargestWindowWidth;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

                Console.Clear();
                Console.SetCursorPosition(0, 0);

                Bitmap bitmap = _bitmap;
                int wight = _wight;

                if (wight > (int)(Console.LargestWindowWidth * CONSOLE_KOF))
                {
                    wight = (int)(Console.LargestWindowWidth * CONSOLE_KOF);
                }
                AsciiConverter asciiConverter = new AsciiConverter(bitmap, wight);

                var matrix = asciiConverter.GetCharMatrixBlack();

                PrintMatrix(matrix);

                Console.WriteLine();

                matrix = asciiConverter.GetCharMatrixWhite();
                PrintMatrix(matrix);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxWight.Text != "")
            {
                if (int.TryParse(textBoxWight.Text, out int wight))
                {
                    PrintImage(myBitmap, wight);
                }
                else { MessageBox.Show(MSG); }
            }
            else { MessageBox.Show(MSG); }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonСhoice_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image | *bmp; *jpg; *png; *JPEG;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    myBitmap = new Bitmap(filePath);
                }
                else { MessageBox.Show(DONWLOAD_MSG); }
            }
        }



    }
}
