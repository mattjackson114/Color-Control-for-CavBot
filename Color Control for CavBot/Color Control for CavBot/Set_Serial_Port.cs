using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Color_Control_for_CavBot
{
    public partial class Set_Serial_Port : Form
    {
        public Set_Serial_Port()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach(string item in SerialPort.GetPortNames())
            {
                listBox.Items.Add(item);
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1) //Checks to see if they clicked on anything.
            {
                Class.COMPort = listBox.GetItemText(listBox.SelectedItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Serial_Port_Load(object sender, EventArgs e) //Re Searches the COM ports
        {
            foreach(string item in SerialPort.GetPortNames())
            {
                listBox.Items.Add(item);
            }
        }
    }
}
