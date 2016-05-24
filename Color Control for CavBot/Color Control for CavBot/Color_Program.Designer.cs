namespace Color_Control_for_CavBot
{
    partial class Color_Program
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color_Program));
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Label();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.CuC = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howItWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLogTooStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDataLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactiveDisplayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.SLButton = new System.Windows.Forms.Button();
            this.patrioticButton = new System.Windows.Forms.Button();
            this.thanksgivingButton = new System.Windows.Forms.Button();
            this.christmasButton = new System.Windows.Forms.Button();
            this.halloweenButton = new System.Windows.Forms.Button();
            this.setcomportButton = new System.Windows.Forms.Button();
            this.SE = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.outputTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(557, 486);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(220, 32);
            this.outputTextBox.TabIndex = 9;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.outputTextBox, "Output");
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.redButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.Location = new System.Drawing.Point(12, 66);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(220, 65);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Red Team";
            this.toolTip.SetToolTip(this.redButton, "Red");
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.blueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blueButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.Location = new System.Drawing.Point(12, 137);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(220, 65);
            this.blueButton.TabIndex = 1;
            this.blueButton.Text = "Blue Team";
            this.toolTip.SetToolTip(this.blueButton, "Blue");
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.offButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton.Location = new System.Drawing.Point(12, 208);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(220, 65);
            this.offButton.TabIndex = 8;
            this.offButton.Text = "Off";
            this.toolTip.SetToolTip(this.offButton, "All Off");
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.BackColor = System.Drawing.Color.White;
            this.CC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(12, 39);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(181, 24);
            this.CC.TabIndex = 10;
            this.CC.Text = "Competition Control";
            // 
            // redTrackBar
            // 
            this.redTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(96)))), ((int)(((byte)(173)))));
            this.redTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redTrackBar.Location = new System.Drawing.Point(6, 371);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(473, 45);
            this.redTrackBar.TabIndex = 17;
            this.redTrackBar.TickFrequency = 15;
            this.toolTip.SetToolTip(this.redTrackBar, "Red Trackbar");
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueTrackBar.Location = new System.Drawing.Point(6, 473);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(473, 45);
            this.blueTrackBar.TabIndex = 18;
            this.blueTrackBar.TickFrequency = 15;
            this.toolTip.SetToolTip(this.blueTrackBar, "Blue Trackbar");
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenTrackBar.Location = new System.Drawing.Point(6, 422);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(473, 45);
            this.greenTrackBar.TabIndex = 19;
            this.greenTrackBar.TickFrequency = 15;
            this.toolTip.SetToolTip(this.greenTrackBar, "Green Trackbar");
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.G.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(485, 422);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(61, 24);
            this.G.TabIndex = 21;
            this.G.Text = "Green";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.BackColor = System.Drawing.Color.Blue;
            this.B.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(485, 473);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(47, 24);
            this.B.TabIndex = 22;
            this.B.Text = "Blue";
            // 
            // CuC
            // 
            this.CuC.AutoSize = true;
            this.CuC.BackColor = System.Drawing.Color.White;
            this.CuC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuC.Location = new System.Drawing.Point(14, 337);
            this.CuC.Name = "CuC";
            this.CuC.Size = new System.Drawing.Size(124, 24);
            this.CuC.TabIndex = 23;
            this.CuC.Text = "Custom Color";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(557, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(220, 65);
            this.sendButton.TabIndex = 26;
            this.sendButton.Text = "Send Custom Values";
            this.toolTip.SetToolTip(this.sendButton, "Apply All the Changes From the Trackbars");
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Team 5214 Logo");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 32);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.howItWorksToolStripMenuItem,
            this.dataLogTooStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // howItWorksToolStripMenuItem
            // 
            this.howItWorksToolStripMenuItem.Name = "howItWorksToolStripMenuItem";
            this.howItWorksToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.howItWorksToolStripMenuItem.Text = "How It Works";
            this.howItWorksToolStripMenuItem.Click += new System.EventHandler(this.howItWorksToolStripMenuItem_Click);
            // 
            // dataLogTooStripMenuItem
            // 
            this.dataLogTooStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataLogToolStripMenuItem,
            this.clearDataLogToolStripMenuItem,
            this.printDataLogToolStripMenuItem});
            this.dataLogTooStripMenuItem.Name = "dataLogTooStripMenuItem";
            this.dataLogTooStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.dataLogTooStripMenuItem.Text = "Data Log";
            // 
            // openDataLogToolStripMenuItem
            // 
            this.openDataLogToolStripMenuItem.Name = "openDataLogToolStripMenuItem";
            this.openDataLogToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.openDataLogToolStripMenuItem.Text = "Open Data Log";
            this.openDataLogToolStripMenuItem.Click += new System.EventHandler(this.openDataLogToolStripMenuItem_Click_1);
            // 
            // clearDataLogToolStripMenuItem
            // 
            this.clearDataLogToolStripMenuItem.Name = "clearDataLogToolStripMenuItem";
            this.clearDataLogToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.clearDataLogToolStripMenuItem.Text = "Clear Data Log";
            this.clearDataLogToolStripMenuItem.Click += new System.EventHandler(this.clearDataLogToolStripMenuItem_Click);
            // 
            // printDataLogToolStripMenuItem
            // 
            this.printDataLogToolStripMenuItem.Name = "printDataLogToolStripMenuItem";
            this.printDataLogToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.printDataLogToolStripMenuItem.Text = "Print Data Log";
            this.printDataLogToolStripMenuItem.Click += new System.EventHandler(this.printDataLogToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customSettingsToolStripMenuItem,
            this.interactiveDisplayToolStripMenuItem1});
            this.modesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // customSettingsToolStripMenuItem
            // 
            this.customSettingsToolStripMenuItem.Name = "customSettingsToolStripMenuItem";
            this.customSettingsToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.customSettingsToolStripMenuItem.Text = "Custom Settings";
            this.customSettingsToolStripMenuItem.Click += new System.EventHandler(this.customSettingsToolStripMenuItem_Click);
            // 
            // interactiveDisplayToolStripMenuItem1
            // 
            this.interactiveDisplayToolStripMenuItem1.Name = "interactiveDisplayToolStripMenuItem1";
            this.interactiveDisplayToolStripMenuItem1.Size = new System.Drawing.Size(233, 28);
            this.interactiveDisplayToolStripMenuItem1.Text = "Interactive Display";
            this.interactiveDisplayToolStripMenuItem1.Click += new System.EventHandler(this.interactiveDisplayToolStripMenuItem1_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.Black;
            this.linkLabel.Location = new System.Drawing.Point(141, 4);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(172, 24);
            this.linkLabel.TabIndex = 30;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Team 5214 Website";
            this.toolTip.SetToolTip(this.linkLabel, "Click to Travel to Our Team Website");
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // SLButton
            // 
            this.SLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.SLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SLButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SLButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLButton.Location = new System.Drawing.Point(330, 66);
            this.SLButton.Name = "SLButton";
            this.SLButton.Size = new System.Drawing.Size(220, 65);
            this.SLButton.TabIndex = 16;
            this.SLButton.Text = "South Lake Colors";
            this.toolTip.SetToolTip(this.SLButton, "Blue and Yellow");
            this.SLButton.UseVisualStyleBackColor = false;
            this.SLButton.Click += new System.EventHandler(this.SLButton_Click);
            // 
            // patrioticButton
            // 
            this.patrioticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.patrioticButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patrioticButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patrioticButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patrioticButton.Location = new System.Drawing.Point(556, 137);
            this.patrioticButton.Name = "patrioticButton";
            this.patrioticButton.Size = new System.Drawing.Size(220, 65);
            this.patrioticButton.TabIndex = 15;
            this.patrioticButton.Text = "Patriotic";
            this.toolTip.SetToolTip(this.patrioticButton, "Red and Blue");
            this.patrioticButton.UseVisualStyleBackColor = false;
            this.patrioticButton.Click += new System.EventHandler(this.patrioticButton_Click);
            // 
            // thanksgivingButton
            // 
            this.thanksgivingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.thanksgivingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thanksgivingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thanksgivingButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksgivingButton.Location = new System.Drawing.Point(330, 208);
            this.thanksgivingButton.Name = "thanksgivingButton";
            this.thanksgivingButton.Size = new System.Drawing.Size(220, 65);
            this.thanksgivingButton.TabIndex = 13;
            this.thanksgivingButton.Text = "Thanksgiving";
            this.toolTip.SetToolTip(this.thanksgivingButton, "Orange, Yellow, and Red");
            this.thanksgivingButton.UseVisualStyleBackColor = false;
            this.thanksgivingButton.Click += new System.EventHandler(this.thanksgivingButton_Click);
            // 
            // christmasButton
            // 
            this.christmasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.christmasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.christmasButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.christmasButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.christmasButton.Location = new System.Drawing.Point(556, 66);
            this.christmasButton.Name = "christmasButton";
            this.christmasButton.Size = new System.Drawing.Size(220, 65);
            this.christmasButton.TabIndex = 12;
            this.christmasButton.Text = "Christmas";
            this.toolTip.SetToolTip(this.christmasButton, "Green and Red");
            this.christmasButton.UseVisualStyleBackColor = false;
            this.christmasButton.Click += new System.EventHandler(this.christmasButton_Click);
            // 
            // halloweenButton
            // 
            this.halloweenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.halloweenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.halloweenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.halloweenButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halloweenButton.Location = new System.Drawing.Point(330, 137);
            this.halloweenButton.Name = "halloweenButton";
            this.halloweenButton.Size = new System.Drawing.Size(220, 65);
            this.halloweenButton.TabIndex = 14;
            this.halloweenButton.Text = "Halloween";
            this.toolTip.SetToolTip(this.halloweenButton, "Yellow and Orange");
            this.halloweenButton.UseVisualStyleBackColor = false;
            this.halloweenButton.Click += new System.EventHandler(this.halloweenButton_Click);
            // 
            // setcomportButton
            // 
            this.setcomportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.setcomportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setcomportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setcomportButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setcomportButton.Location = new System.Drawing.Point(12, 287);
            this.setcomportButton.Name = "setcomportButton";
            this.setcomportButton.Size = new System.Drawing.Size(138, 32);
            this.setcomportButton.TabIndex = 35;
            this.setcomportButton.Text = "Set COM Port";
            this.setcomportButton.UseVisualStyleBackColor = false;
            this.setcomportButton.Click += new System.EventHandler(this.setcomportButton_Click);
            // 
            // SE
            // 
            this.SE.AutoSize = true;
            this.SE.BackColor = System.Drawing.Color.White;
            this.SE.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE.Location = new System.Drawing.Point(330, 39);
            this.SE.Name = "SE";
            this.SE.Size = new System.Drawing.Size(128, 24);
            this.SE.TabIndex = 11;
            this.SE.Text = "Special Events";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.BackColor = System.Drawing.Color.Red;
            this.R.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(485, 371);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(42, 24);
            this.R.TabIndex = 31;
            this.R.Text = "Red";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.BackColor = System.Drawing.Color.White;
            this.N.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(138, 344);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(329, 17);
            this.N.TabIndex = 28;
            this.N.Text = "Note: The increments go up by 15 and the range is 0-255.";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Color_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(96)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(789, 530);
            this.Controls.Add(this.setcomportButton);
            this.Controls.Add(this.R);
            this.Controls.Add(this.G);
            this.Controls.Add(this.B);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.SE);
            this.Controls.Add(this.halloweenButton);
            this.Controls.Add(this.christmasButton);
            this.Controls.Add(this.thanksgivingButton);
            this.Controls.Add(this.patrioticButton);
            this.Controls.Add(this.SLButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.N);
            this.Controls.Add(this.CuC);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 569);
            this.MinimumSize = new System.Drawing.Size(805, 569);
            this.Name = "Color_Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Control for CavBot";
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label CuC;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howItWorksToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button SLButton;
        private System.Windows.Forms.Button patrioticButton;
        private System.Windows.Forms.Button thanksgivingButton;
        private System.Windows.Forms.Button christmasButton;
        private System.Windows.Forms.Button halloweenButton;
        private System.Windows.Forms.Label SE;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.ToolStripMenuItem dataLogTooStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem openDataLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDataLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataLogToolStripMenuItem;
        private System.Windows.Forms.Button setcomportButton;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactiveDisplayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customSettingsToolStripMenuItem;
    }
}

