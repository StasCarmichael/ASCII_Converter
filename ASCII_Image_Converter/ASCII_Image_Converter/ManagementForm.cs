using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ASCII_Image_Converter
{
    public partial class ManagementForm : Form
    {
        private const string WARNING_MSG = "Перевірте коректність даних";
        private const string DONWLOAD_MSG = "Файл успішно завантажений";
        private const double CONSOLE_KOF = 0.989582;
        private const double FILE_KOF = 3;
        private const int MAX_WIGHT = 1000;


        private Bitmap myBitmap;


        public ManagementForm()
        {
            InitializeComponent();

            textBoxWight.Text = "600";

            ActiveControl = buttonСhoice;
        }



        private void PrintMatrix(char[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
        private void PrintImage(Bitmap _bitmap, int _wight, bool isBlack)
        {
            try
            {
                Console.BufferWidth = Console.LargestWindowWidth;
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

                if (isBlack)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.Clear();
                Console.SetCursorPosition(0, 0);


                Bitmap bitmap = _bitmap;
                int wight = _wight;

                if (wight > (int)(Console.LargestWindowWidth * CONSOLE_KOF))
                {
                    wight = (int)(Console.LargestWindowWidth * CONSOLE_KOF);
                }
                AsciiConverter asciiConverter = new AsciiConverter(bitmap, wight);


                char[][] matrix;
                if (isBlack)
                {
                    matrix = asciiConverter.GetCharMatrixBlack();
                }
                else
                {
                    matrix = asciiConverter.GetCharMatrixWhite();
                }


                PrintMatrix(matrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadMatrix(char[][] matrix)
        {
            DateTime time = DateTime.Now;
            // запись в файл
            using (FileStream fstream = new FileStream($"Image_{time.Year}_{time.Month}_" +
                $"{time.Day}_{time.Hour}_{time.Minute}_{time.Second}.txt", FileMode.Create))
            {
                foreach (var item in matrix)
                {
                    // преобразуем строку в байты
                    byte[] array = Encoding.UTF8.GetBytes(item);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                    fstream.Write(Encoding.UTF8.GetBytes("\n"), 0, 1);
                }
            }
        }
        private void DownloadImage(Bitmap _bitmap, int _wight, bool isBlack, double WIGHT_KOF)
        {
            try
            {
                Bitmap bitmap = _bitmap;
                int wight = _wight;

                if (wight > MAX_WIGHT) { wight = MAX_WIGHT; }
                AsciiConverter asciiConverter = new AsciiConverter(bitmap, wight, WIGHT_KOF);


                char[][] matrix;
                if (isBlack)
                {
                    matrix = asciiConverter.GetCharMatrixBlack();
                }
                else
                {
                    matrix = asciiConverter.GetCharMatrixWhite();
                }


                DownloadMatrix(matrix);

                MessageBox.Show(DONWLOAD_MSG);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxWight.Text != string.Empty)
            {
                if (uint.TryParse(textBoxWight.Text, out uint wight))
                {
                    PrintImage(myBitmap, (int)wight, checkBoxBlack.Checked);
                }
                else { MessageBox.Show(WARNING_MSG); }
            }
            else { MessageBox.Show(WARNING_MSG); }
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
                    buttonStart.Visible = true;
                    buttonDownload.Visible = true;

                    checkBoxBlack.Visible = true;
                }
            }
        }
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (textBoxWight.Text != string.Empty)
            {
                if (uint.TryParse(textBoxWight.Text, out uint wight))
                {
                    DownloadImage(myBitmap, (int)wight, checkBoxBlack.Checked, FILE_KOF);
                }
                else { MessageBox.Show(WARNING_MSG); }
            }
            else { MessageBox.Show(WARNING_MSG); }
        } 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
