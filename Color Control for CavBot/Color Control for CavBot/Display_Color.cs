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
    public partial class Display_Color : Form
    {
        public Display_Color()
        {
            InitializeComponent();
        }
        int red = 0;
        int green = 0;
        int blue = 0;

        private void Display_Color_Load(object sender, EventArgs e)
        {
            red = Class.red;
            green = Class.green;
            blue = Class.blue;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(red)))), ((int)(((byte)(green)))), ((int)(((byte)(blue)))));
        }
    }
}
