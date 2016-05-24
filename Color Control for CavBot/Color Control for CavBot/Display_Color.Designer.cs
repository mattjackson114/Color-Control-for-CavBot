namespace Color_Control_for_CavBot
{
    partial class Display_Color
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_Color));
            this.N = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.N.AutoSize = true;
            this.N.BackColor = System.Drawing.Color.White;
            this.N.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(6, 235);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(259, 17);
            this.N.TabIndex = 29;
            this.N.Text = "Note: Colors may appear differently on LEDs.";
            // 
            // Display_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 261);
            this.Controls.Add(this.N);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Display_Color";
            this.Text = "Color Preview";
            this.Load += new System.EventHandler(this.Display_Color_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label N;
    }
}