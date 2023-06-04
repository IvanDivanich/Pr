namespace Пр8
{
    partial class Colors
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.HScrollBar();
            this.GreenBar = new System.Windows.Forms.HScrollBar();
            this.BlueBar = new System.Windows.Forms.HScrollBar();
            this.numericUpDown_red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_blue = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OtherColorsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // RedBar
            // 
            this.RedBar.LargeChange = 1;
            this.RedBar.Location = new System.Drawing.Point(75, 32);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(170, 20);
            this.RedBar.TabIndex = 3;
            this.RedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedBar_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.LargeChange = 1;
            this.GreenBar.Location = new System.Drawing.Point(75, 79);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(170, 20);
            this.GreenBar.TabIndex = 4;
            this.GreenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.LargeChange = 1;
            this.BlueBar.Location = new System.Drawing.Point(75, 126);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(170, 20);
            this.BlueBar.TabIndex = 5;
            this.BlueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueBar_Scroll);
            // 
            // numericUpDown_red
            // 
            this.numericUpDown_red.Location = new System.Drawing.Point(267, 32);
            this.numericUpDown_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_red.Name = "numericUpDown_red";
            this.numericUpDown_red.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown_red.TabIndex = 6;
            this.numericUpDown_red.ValueChanged += new System.EventHandler(this.numericUpDown_red_ValueChanged);
            // 
            // numericUpDown_green
            // 
            this.numericUpDown_green.Location = new System.Drawing.Point(267, 79);
            this.numericUpDown_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_green.Name = "numericUpDown_green";
            this.numericUpDown_green.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown_green.TabIndex = 7;
            this.numericUpDown_green.ValueChanged += new System.EventHandler(this.numericUpDown_green_ValueChanged);
            // 
            // numericUpDown_blue
            // 
            this.numericUpDown_blue.Location = new System.Drawing.Point(267, 126);
            this.numericUpDown_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_blue.Name = "numericUpDown_blue";
            this.numericUpDown_blue.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown_blue.TabIndex = 8;
            this.numericUpDown_blue.ValueChanged += new System.EventHandler(this.numericUpDown_blue_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(338, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(32, 263);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 10;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(125, 263);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 11;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // OtherColorsButton
            // 
            this.OtherColorsButton.Location = new System.Drawing.Point(338, 263);
            this.OtherColorsButton.Name = "OtherColorsButton";
            this.OtherColorsButton.Size = new System.Drawing.Size(100, 23);
            this.OtherColorsButton.TabIndex = 12;
            this.OtherColorsButton.Text = "Other Colors";
            this.OtherColorsButton.UseVisualStyleBackColor = true;
            this.OtherColorsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 311);
            this.Controls.Add(this.OtherColorsButton);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown_blue);
            this.Controls.Add(this.numericUpDown_green);
            this.Controls.Add(this.numericUpDown_red);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Colors";
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar RedBar;
        private System.Windows.Forms.HScrollBar GreenBar;
        private System.Windows.Forms.HScrollBar BlueBar;
        private System.Windows.Forms.NumericUpDown numericUpDown_red;
        private System.Windows.Forms.NumericUpDown numericUpDown_green;
        private System.Windows.Forms.NumericUpDown numericUpDown_blue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OtherColorsButton;
    }
}