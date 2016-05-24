namespace Color_Control_for_CavBot
{
    partial class Custom_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom_Settings));
            this.addButton = new System.Windows.Forms.Button();
            this.buttonNameTextBox = new System.Windows.Forms.TextBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showColorButton = new System.Windows.Forms.Button();
            this.colorDialogButton = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setCOMPortButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(283, 76);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 36);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buttonNameTextBox
            // 
            this.buttonNameTextBox.AcceptsReturn = true;
            this.buttonNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonNameTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNameTextBox.Location = new System.Drawing.Point(117, 135);
            this.buttonNameTextBox.MaxLength = 100;
            this.buttonNameTextBox.Name = "buttonNameTextBox";
            this.buttonNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.buttonNameTextBox.Size = new System.Drawing.Size(150, 32);
            this.buttonNameTextBox.TabIndex = 4;
            this.buttonNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // redTextBox
            // 
            this.redTextBox.AcceptsReturn = true;
            this.redTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.redTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.redTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redTextBox.Location = new System.Drawing.Point(117, 20);
            this.redTextBox.MaxLength = 3;
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(150, 32);
            this.redTextBox.TabIndex = 1;
            this.redTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showColorButton);
            this.groupBox1.Controls.Add(this.colorDialogButton);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.G);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.blueTextBox);
            this.groupBox1.Controls.Add(this.greenTextBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.buttonNameTextBox);
            this.groupBox1.Controls.Add(this.redTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 192);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // showColorButton
            // 
            this.showColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.showColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showColorButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showColorButton.Location = new System.Drawing.Point(283, 126);
            this.showColorButton.Name = "showColorButton";
            this.showColorButton.Size = new System.Drawing.Size(129, 25);
            this.showColorButton.TabIndex = 46;
            this.showColorButton.TabStop = false;
            this.showColorButton.Text = "Color Preview";
            this.showColorButton.UseVisualStyleBackColor = false;
            this.showColorButton.Click += new System.EventHandler(this.showColorButton_Click);
            // 
            // colorDialogButton
            // 
            this.colorDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.colorDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorDialogButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.colorDialogButton.Location = new System.Drawing.Point(283, 157);
            this.colorDialogButton.Name = "colorDialogButton";
            this.colorDialogButton.Size = new System.Drawing.Size(129, 29);
            this.colorDialogButton.TabIndex = 45;
            this.colorDialogButton.Text = "Open Color Dialog";
            this.colorDialogButton.UseVisualStyleBackColor = false;
            this.colorDialogButton.Click += new System.EventHandler(this.colorDialogButton_Click);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.BackColor = System.Drawing.Color.Red;
            this.R.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(6, 22);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(42, 24);
            this.R.TabIndex = 44;
            this.R.Text = "Red";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.G.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(6, 60);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(61, 24);
            this.G.TabIndex = 42;
            this.G.Text = "Green";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.BackColor = System.Drawing.Color.Blue;
            this.B.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(6, 98);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(47, 24);
            this.B.TabIndex = 43;
            this.B.Text = "Blue";
            // 
            // blueTextBox
            // 
            this.blueTextBox.AcceptsReturn = true;
            this.blueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.blueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.blueTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueTextBox.Location = new System.Drawing.Point(117, 96);
            this.blueTextBox.MaxLength = 3;
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(150, 32);
            this.blueTextBox.TabIndex = 3;
            this.blueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenTextBox
            // 
            this.greenTextBox.AcceptsReturn = true;
            this.greenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.greenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.greenTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenTextBox.Location = new System.Drawing.Point(117, 58);
            this.greenTextBox.MaxLength = 3;
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(150, 32);
            this.greenTextBox.TabIndex = 2;
            this.greenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(10, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 118);
            this.listBox1.TabIndex = 42;
            this.listBox1.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(6, 145);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(119, 36);
            this.sendButton.TabIndex = 42;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "Send Values";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 193);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Defined Colors";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(131, 145);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 36);
            this.removeButton.TabIndex = 45;
            this.removeButton.TabStop = false;
            this.removeButton.Text = "Delete";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setCOMPortButton);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox3.Location = new System.Drawing.Point(230, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 64);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set COM Port";
            // 
            // setCOMPortButton
            // 
            this.setCOMPortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(13)))));
            this.setCOMPortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCOMPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setCOMPortButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCOMPortButton.Location = new System.Drawing.Point(26, 22);
            this.setCOMPortButton.Name = "setCOMPortButton";
            this.setCOMPortButton.Size = new System.Drawing.Size(133, 32);
            this.setCOMPortButton.TabIndex = 47;
            this.setCOMPortButton.Text = "Set COM Port";
            this.setCOMPortButton.UseVisualStyleBackColor = false;
            this.setCOMPortButton.Click += new System.EventHandler(this.setCOMPortButton_Click);
            // 
            // Custom_Settings
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(96)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(442, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 452);
            this.MinimumSize = new System.Drawing.Size(458, 452);
            this.Name = "Custom_Settings";
            this.Text = "Custom Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Custom_Settings_Closing);
            this.Load += new System.EventHandler(this.Custom_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox buttonNameTextBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sendButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorDialogButton;
        private System.Windows.Forms.Button showColorButton;
        private System.Windows.Forms.Button setCOMPortButton;
    }
}