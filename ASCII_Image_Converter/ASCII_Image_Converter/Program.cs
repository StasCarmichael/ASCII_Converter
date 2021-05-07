using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;



namespace ASCII_Image_Converter
{
    class Program
    {
        
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ManagementForm form = new ManagementForm();
 
            Application.Run(form);


        }
    }
}
