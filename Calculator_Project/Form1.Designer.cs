namespace Calculator_Project
{
    partial class Form1
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
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.LightSteelBlue;
            this.display.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(13, 22);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(456, 69);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.display.TextChanged += new System.EventHandler(this.afisaj_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(243, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LemonChiffon;
            this.button4.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(359, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(358, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 80);
            this.button5.TabIndex = 8;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LemonChiffon;
            this.button6.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(242, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 80);
            this.button6.TabIndex = 7;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LemonChiffon;
            this.button7.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(126, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 80);
            this.button7.TabIndex = 6;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button8_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LemonChiffon;
            this.button8.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(10, 210);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 80);
            this.button8.TabIndex = 5;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LemonChiffon;
            this.button9.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(359, 296);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 80);
            this.button9.TabIndex = 12;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LemonChiffon;
            this.button10.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(243, 296);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 80);
            this.button10.TabIndex = 11;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button6_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LemonChiffon;
            this.button11.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(127, 296);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(110, 80);
            this.button11.TabIndex = 10;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button5_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LemonChiffon;
            this.button12.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(11, 296);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 80);
            this.button12.TabIndex = 9;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button4_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LemonChiffon;
            this.button13.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(360, 382);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(110, 166);
            this.button13.TabIndex = 16;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LemonChiffon;
            this.button14.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(242, 382);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 80);
            this.button14.TabIndex = 15;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button3_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LemonChiffon;
            this.button15.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(126, 382);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(110, 80);
            this.button15.TabIndex = 14;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button2_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LemonChiffon;
            this.button16.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(10, 382);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(110, 80);
            this.button16.TabIndex = 13;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button1_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LemonChiffon;
            this.button17.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(12, 469);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(226, 80);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button0_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LemonChiffon;
            this.button18.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(244, 468);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(110, 80);
            this.button18.TabIndex = 18;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(486, 568);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roby\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

