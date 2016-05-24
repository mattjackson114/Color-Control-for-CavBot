using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Control_for_CavBot
{
    public partial class Interactive_Display : Form
    {
        public Interactive_Display()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adjust the sliders and press Send to adjust the colors on CavBot!");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    serialPort.WriteLine(redTrackBar.Value + ", " + greenTrackBar.Value + ", " + blueTrackBar.Value);
                    serialPort.Close();
                }
                catch
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
