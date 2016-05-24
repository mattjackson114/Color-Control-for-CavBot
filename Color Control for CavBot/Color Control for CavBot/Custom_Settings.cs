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
using Color_Control_for_CavBot;

namespace Color_Control_for_CavBot
{
    public partial class Custom_Settings : Form
    {
        public Custom_Settings()
        {
            InitializeComponent();
        }

        string[] RGBVal = new string[20]; //An array to hold the RGB values.
        string[] RGBTitle = new string[20]; //An array to hold the titles.
        string lineTitle;
        string lineValue;
        int arrayElements = 0; //Tells what index to put the RGB value into.
        string errorMessage = "Error, Please Check Connection and Try Again";
        string rgbString;
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); //Gets the path of the desktop.
        string valuesTextPath = @"\Color Control for CavBot\RGB Values.txt"; //The specific path for the RGB Values text file.
        string nameTextPath = @"\Color Control for CavBot\RGB Titles.txt"; //THe path for the RGB Titles text document.
        bool runAgain = true; //Prevents from an infinite loop. 

        void setSerialPort() //Sets the serial port
        {
           try
           {
               serialPort.PortName = Class.COMPort;
               serialPort.Open();
               serialPort.Close();
           }
            catch
           {
               Class.COMPort = "COM1";
               MessageBox.Show("Error in setting COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        void rgbStringGenerator() //Generates the string of RGB values to send 
        {
            rgbString = redTextBox.Text + ", " + greenTextBox.Text + ", " + blueTextBox.Text; //R, G, B
        }

        bool validInputCheck() //Checks to see if the number you entered is within reason 
        {
            try
            {
                int redVal = Convert.ToInt16(redTextBox.Text);
                int greenVal = Convert.ToInt16(greenTextBox.Text);
                int blueVal = Convert.ToInt16(blueTextBox.Text);
                if (redVal <= 255 && redVal >= 0 && greenVal <= 255 && greenVal >= 0 && blueVal <= 255 && blueVal >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void addButton_Click(object sender, EventArgs e) //Adds info to the list box. 
        {
            if (validInputCheck() == false || string.IsNullOrWhiteSpace(buttonNameTextBox.Text) || string.IsNullOrWhiteSpace(redTextBox.Text) || string.IsNullOrWhiteSpace(greenTextBox.Text) || string.IsNullOrWhiteSpace(blueTextBox.Text))
            {
                MessageBox.Show("All fields must be filled and with valid inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rgbStringGenerator();
                if (arrayElements < 20) //Make sure it doesn't exceed the array limit
                {
                    listBox1.Items.Add(buttonNameTextBox.Text + " " + "(" + rgbString + ")");
                    RGBVal[arrayElements] = rgbString;
                    RGBTitle[arrayElements] = buttonNameTextBox.Text;
                    arrayElements++;
                }
                else if (arrayElements >= 20) //If it exceeds the limit give an error
                {
                    MessageBox.Show("You have exceeded the max amount of custom values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                redTextBox.Text = "";
                greenTextBox.Text = "";
                blueTextBox.Text = "";
                buttonNameTextBox.Text = "";
            }
            redTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e) //Remove inputs.
        {
            int selectedValue = listBox1.SelectedIndex;
            if (selectedValue >= 0 && RGBTitle[selectedValue] != String.Empty) //Checks to see if you clicked on something valid.
            {
                listBox1.Items.Insert(selectedValue, "Deleted"); //Adds in a blank entry to still hold a place.
                listBox1.Items.RemoveAt(selectedValue + 1);
                RGBTitle[selectedValue] = String.Empty; //Sets both as empty 
                RGBVal[selectedValue] = String.Empty;
            }
        }

        private void sendButton_Click(object sender, EventArgs e) //Sends the RGB value of whatever the user selected from the ListBox
        {
            setSerialPort();
            if (listBox1.SelectedIndex > -1 && !String.IsNullOrEmpty(RGBTitle[listBox1.SelectedIndex]) && !serialPort.IsOpen) //Then checks to see if they have valid things before sending.
            {
                try
                {
                    serialPort.Open();
                    serialPort.WriteLine(RGBVal[listBox1.SelectedIndex]);
                    serialPort.Close();
                }
                catch
                {
                }
            }
        }

        private void Custom_Settings_Load(object sender, EventArgs e) //When custom settings is loaded add their custom settings. 
        {
            serialPort.PortName = Class.COMPort;
            string namePath = filePath + nameTextPath;
            string valuePath = filePath + valuesTextPath;
            try
            {
                StreamReader nameFile = new StreamReader(namePath);
                StreamReader valueFile = new StreamReader(valuePath);
                int lineNumbers = File.ReadLines(valuePath).Count();
                string stringLineNumbers = Convert.ToString(lineNumbers);
                while ((lineTitle = nameFile.ReadLine()) != null)
                {
                    if (arrayElements < lineNumbers) //Prevent from loading too many things.
                    {
                        lineValue = valueFile.ReadLine();
                        //Assign the array information from the text file.
                        RGBVal[arrayElements] = lineValue;
                        RGBTitle[arrayElements] = lineTitle;
                        //Add them to the list box.
                        listBox1.Items.Add(lineTitle + " " + "(" + lineValue + ")");
                        arrayElements++;
                    }
                }
                nameFile.Close();
                valueFile.Close();
            }
            catch
            {
            }
        }

        private void Custom_Settings_Closing(object sender, System.ComponentModel.CancelEventArgs e) //On close save everything. 
        {
            var reply = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
            {
                //Create the file destinations for both name and value path locations.
                string namePath = filePath + nameTextPath;
                string valuePath = filePath + valuesTextPath;
                int totalLinesName = 0;
                int totalLinesValue = 0;

                if (!File.Exists(namePath) && !File.Exists(valuePath)) //If the document doesn't exist then create a new one.
                {
                    StreamWriter nameWrite = File.CreateText(namePath);
                    StreamWriter valueWrite = File.CreateText(valuePath);
                    //CLOSING IS NECESSARY! Otherwise the program will already think it is open.
                    nameWrite.Close();
                    valueWrite.Close();
                }
                try
                {
                    using (StreamWriter file = new StreamWriter(namePath)) //Saves the names.
                    {
                        while (arrayElements > totalLinesName) //Prevent from writing too many things.
                        {
                            if (RGBTitle[totalLinesName] != String.Empty) //Only save things that are still there.
                            {
                                file.WriteLine(RGBTitle[totalLinesName]);
                            }
                            totalLinesName++;
                        }
                    }
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(valuePath)) //Saves the RGB Values
                    {
                        while (arrayElements > totalLinesValue)
                        {
                            if (RGBVal[totalLinesValue] != String.Empty)
                            {
                                file.WriteLine(RGBVal[totalLinesValue]);
                            }
                            totalLinesValue++;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error connecting with file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Class.open = false; //Says that there is no window open.
        }

        private void colorDialogButton_Click(object sender, EventArgs e) //Allows the user to select a custom color from a color dialog.
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Color clr = cd.Color;
            string r = String.Empty;
            string g = String.Empty;
            string b = String.Empty;
            try
            {
                r = clr.R.ToString();
                g = clr.G.ToString();
                b = clr.B.ToString();
                int redVal = Convert.ToInt16(r);
                int greenVal = Convert.ToInt16(g);
                int blueVal = Convert.ToInt16(b);
                if (redVal + greenVal + blueVal != 0)
                {
                    redTextBox.Text = r;
                    greenTextBox.Text = g;
                    blueTextBox.Text = b;
                    buttonNameTextBox.Focus();
                }
            }
            catch { }
        }

        private void showColorButton_Click(object sender, EventArgs e) //Previews the color. 
        {
            try
            {
                int red = Convert.ToInt16(redTextBox.Text);
                int green = Convert.ToInt16(greenTextBox.Text);
                int blue = Convert.ToInt16(blueTextBox.Text);
                if (red >= 0 && green >= 0 && blue >= 0 && red <= 255 && green <= 255 && blue <= 255) //Ensures proper input.
                {
                    Class.red = red;
                    Class.green = green;
                    Class.blue = blue;
                    Display_Color newForm = new Display_Color();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid input! You must have numbers for each of the color text boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid input! You must have numbers for each of the color text boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setCOMPortButton_Click(object sender, EventArgs e) //Opens a new window that allows the user to select a valid COM port.
        {
            Set_Serial_Port newForm = new Set_Serial_Port();
            newForm.Show();
        }
    }
}

