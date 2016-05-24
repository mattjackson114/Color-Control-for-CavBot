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
    public partial class Color_Program : Form
    {
        public Color_Program()
        {
            InitializeComponent();
        }

        string errorMessage = "Error, Please Check Connection and Try Again"; //Pre-determined error message.
        bool error = false; //A general error.
        string success = "COM port is set to: "; //A message saying a successful com port selection.
        string failure = "Error in setting COM port.";
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); //Gets the path of the desktop.
        string txtPath = @"\Color Control for CavBot\CCFCB_Data.txt"; //Path to the txt document.
        bool runAgain = true; //Prevents an infinite loop.

        void dataWrite(string dataInput) //Inserts data into text document
        {
            string path = filePath + txtPath;
            using (StreamWriter dataWrite = File.AppendText(path))
            {
                dataWrite.WriteLine(dataInput); //Writes whatever the input is.
            }
        }

        void writeToTextDoc(string input) //Determines what to write to the text document
        {
            string path = filePath + txtPath;
            if (!File.Exists(path)) //Creates thedocument
            {
                using (StreamWriter dataWrite = File.CreateText(path))
                {
                    dataWrite.WriteLine("Color Control for CavBot Data");
                }
            }
            if (error == false) //If no error is present
            {
                dataWrite(success + serialPort.PortName); //Send a success meaage plus the port name.
            }
            else if (error == true) //If error is present
            {
                dataWrite(failure); //Send an error message
            }
            dataWrite(input + " Button" + " " + DateTime.Now); //Sends time stamp and what the user sent
        }

        void setSerialPort() //Sets the serial port to what the user desires.
        {
            try
            {
                serialPort.PortName = Class.COMPort;
                serialPort.Open();
                serialPort.Close();
            }
            catch
            {
                MessageBox.Show(failure, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Class.COMPort = "COM1";
            }
        }

        void printToSerial(string input, string textBoxMessage) //Is passed in the letter to send and the phrase to but in to the output textbox.
        {
            if (error == false) //Checks to see if the setting of the COM resulted in an error.
            {
                if (!serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.Open();
                        serialPort.WriteLine(input);
                        serialPort.Close();
                        outputTextBox.Text = textBoxMessage;
                    }
                    catch
                    {
                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        outputTextBox.Text = "Error";
                    }
                }
            }
            writeToTextDoc(textBoxMessage); //Passes what the user selected.
            error = false; //Resets the error value to false.
            dataWrite("------------------------"); //Enters a line for wase of reading.
        }

        private void testButton_Click(object sender, EventArgs e) //Tests the selected COM port.
        {
            setSerialPort();
            if (error == false)
            {
                MessageBox.Show("You have selected a valid COM port.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            writeToTextDoc("COM Test");
            error = false; //Because we aren't running the printToSerial it wouldn't reset the error value.
        }

        private void redButton_Click(object sender, EventArgs e) //Red Button
        {
            setSerialPort();
            printToSerial("R", "Red Team");
        }

        private void blueButton_Click(object sender, EventArgs e) //Blue Button
        {
            setSerialPort();
            printToSerial("B", "Blue Team");
        }

        private void offButton_Click(object sender, EventArgs e) //Off Button
        {
            setSerialPort();
            printToSerial("O", "Off");
        }

        private void halloweenButton_Click(object sender, EventArgs e) //Halloween Button
        {
            setSerialPort();
            printToSerial("H", "Halloween Mode");
        }

        private void christmasButton_Click(object sender, EventArgs e) //Christmas Button
        {
            setSerialPort();
            printToSerial("C", "Christmas Mode");
        }

        private void thanksgivingButton_Click(object sender, EventArgs e) //Thanksgiving Button
        {
            setSerialPort();
            printToSerial("T", "Thanksgiving Mode");
        }

        private void patrioticButton_Click(object sender, EventArgs e) //Patriotic Button
        {
            setSerialPort();
            printToSerial("P", "Patriotic Mode");
        }

        private void SLButton_Click(object sender, EventArgs e) //South Lake Button
        {
            setSerialPort();
            printToSerial("S", "South Lake Mode");
        }

        private void sendButton_Click(object sender, EventArgs e) //Custom Values Button
        {
            setSerialPort();
            printToSerial(redTrackBar.Value + ", " + greenTrackBar.Value + ", " + blueTrackBar.Value, redTrackBar.Value + ", " + greenTrackBar.Value + ", " + blueTrackBar.Value);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //About 
        {
            MessageBox.Show("Written and debugged by: Matthew Jackson. 11/28/2014. Written for the use of Team 5214 and for the purpose of controlling LED light strips for different events.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) //Help 
        {
            MessageBox.Show("This is designed to be used as a color changer for a light strip. If you are expriencing issues make sure that the Arduino is plugged into a power source so that when you unplug from the device it will still have power. Make sure that you have the proper serial port, you can find out which one to use in Device Manager.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void howItWorksToolStripMenuItem_Click(object sender, EventArgs e) //How It Works 
        {
            MessageBox.Show("When you click the buttons the program sends a letter over serial to the Arduino or other compatible controller. The Arduino has code on it that tells it what to do when it recieves that information. That is how the light(s) change when you press the buttons.", "How it Works", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Exit 
        {
            this.Close();
        }

        private void openDataLogToolStripMenuItem_Click(object sender, EventArgs e) //Opens the text document for the user to review.
        {
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Team Website 
        {
            var result = MessageBox.Show("You will now leave Color Changer and travel to our team website.  Are you sure you want to leave?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://themightycavbots.weebly.com");
            }
        }

        private void openDataLogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string path = filePath + txtPath;
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch
            {
                MessageBox.Show("The data log contains no information or it could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        StreamReader fileToPrint;
        Font printFont;

        private void printDataLogToolStripMenuItem_Click(object sender, EventArgs e) //Sets what to print.
        {
            try //Try to access the file to print
            {
                string printPath = filePath;
                fileToPrint = new System.IO.StreamReader(printPath + txtPath);
            }
            catch
            {
                MessageBox.Show("No such file exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (error == true) //If there was an error stop running the code further.
            {
                return;
            }
            else //Otherwise continue with the print.
            {
                printFont = new System.Drawing.Font("Calibri", 10);
                printDocument1.Print();
                fileToPrint.Close();
            }
            error = false; //Reset the error value.
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //Prints what was set to it.
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }

        private void clearDataLogToolStripMenuItem_Click(object sender, EventArgs e) //Delete the file. 
        {
            try
            {
                File.Delete(filePath + txtPath);
                MessageBox.Show("Data log has been cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("The data log contains no information or it could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setcomportButton_Click(object sender, EventArgs e) //Opens a new form to allow the user to select a valid COM port.
        {
            Set_Serial_Port newForm = new Set_Serial_Port();
            newForm.Show();
        }

        private void interactiveDisplayToolStripMenuItem1_Click(object sender, EventArgs e) //Opensupa userfriendly interactive version
        {
            var leaving = MessageBox.Show("You have to set the COM port before opening. Have you already set the COM port?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.Yes)
            {
                Interactive_Display newForm = new Interactive_Display();
                newForm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else if(leaving == DialogResult.No) //If the user responds No then open the set serial port form so that they can set it.
            {
                Set_Serial_Port newForm = new Set_Serial_Port();
                newForm.Show();
            }
        }

        private void customSettingsToolStripMenuItem_Click(object sender, EventArgs e) //Opens the custom settingsform.
        {
            if (Class.open == false) //Checks to see if a window is already open.
            {
                Custom_Settings newForm = new Custom_Settings(); //Calls the main program
                newForm.Show(); //Opens the custom program
                this.WindowState = FormWindowState.Minimized; //Minimizes the current window.
                Class.open = true; //Says that the window is now open.
            }
        }
    }
}
