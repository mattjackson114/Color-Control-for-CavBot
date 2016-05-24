using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Color_Control_for_CavBot
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1); //Go up by one every time
            if (progressBar1.Value == 45)
            {
                
                timer1.Stop();
                Color_Program newForm = new Color_Program(); //Calls the main program
                this.Hide(); //Hides the Splash Screen
                newForm.Show(); //Opens the main program
                this.Close(); //Closes the Splash Screen
            }
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string finalPath = @"\Color Control for CavBot";
            string path = filePath + finalPath;
            if (!Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            else
            {
            }
        }
    }
}
