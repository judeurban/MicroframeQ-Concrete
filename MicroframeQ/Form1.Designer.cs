namespace MicroframeQ
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
            this.truckListBox = new System.Windows.Forms.ListBox();
            this.towerBox1 = new System.Windows.Forms.ListBox();
            this.towerBox2 = new System.Windows.Forms.ListBox();
            this.moveTower1 = new System.Windows.Forms.Button();
            this.moveTower2 = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.clearTrucksButton = new System.Windows.Forms.LinkLabel();
            this.newTruck_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // truckListBox
            // 
            this.truckListBox.FormattingEnabled = true;
            this.truckListBox.Location = new System.Drawing.Point(387, 126);
            this.truckListBox.Name = "truckListBox";
            this.truckListBox.Size = new System.Drawing.Size(131, 277);
            this.truckListBox.TabIndex = 0;
            this.truckListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TruckListBox_KeyDown);
            // 
            // towerBox1
            // 
            this.towerBox1.FormattingEnabled = true;
            this.towerBox1.Location = new System.Drawing.Point(74, 126);
            this.towerBox1.Name = "towerBox1";
            this.towerBox1.Size = new System.Drawing.Size(131, 277);
            this.towerBox1.TabIndex = 1;
            this.towerBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TowerBox1_KeyDown);
            // 
            // towerBox2
            // 
            this.towerBox2.FormattingEnabled = true;
            this.towerBox2.Location = new System.Drawing.Point(709, 126);
            this.towerBox2.Name = "towerBox2";
            this.towerBox2.Size = new System.Drawing.Size(131, 277);
            this.towerBox2.TabIndex = 2;
            this.towerBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TowerBox2_KeyDown);
            // 
            // moveTower1
            // 
            this.moveTower1.Location = new System.Drawing.Point(258, 251);
            this.moveTower1.Name = "moveTower1";
            this.moveTower1.Size = new System.Drawing.Size(75, 23);
            this.moveTower1.TabIndex = 3;
            this.moveTower1.Text = "Tower 1 <--";
            this.moveTower1.UseVisualStyleBackColor = true;
            this.moveTower1.Click += new System.EventHandler(this.MoveTower1_Click);
            // 
            // moveTower2
            // 
            this.moveTower2.Location = new System.Drawing.Point(583, 251);
            this.moveTower2.Name = "moveTower2";
            this.moveTower2.Size = new System.Drawing.Size(75, 23);
            this.moveTower2.TabIndex = 4;
            this.moveTower2.Text = "--> Tower 2";
            this.moveTower2.UseVisualStyleBackColor = true;
            this.moveTower2.Click += new System.EventHandler(this.MoveTower2_Click_1);
            // 
            // NextButton2
            // 
            this.NextButton2.Location = new System.Drawing.Point(709, 423);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(131, 23);
            this.NextButton2.TabIndex = 5;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            this.NextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // NextButton1
            // 
            this.NextButton1.Location = new System.Drawing.Point(74, 423);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(131, 23);
            this.NextButton1.TabIndex = 6;
            this.NextButton1.Text = "Next";
            this.NextButton1.UseVisualStyleBackColor = true;
            this.NextButton1.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // clearTrucksButton
            // 
            this.clearTrucksButton.AutoSize = true;
            this.clearTrucksButton.Location = new System.Drawing.Point(209, 44);
            this.clearTrucksButton.Name = "clearTrucksButton";
            this.clearTrucksButton.Size = new System.Drawing.Size(67, 13);
            this.clearTrucksButton.TabIndex = 7;
            this.clearTrucksButton.TabStop = true;
            this.clearTrucksButton.Text = "Clear Trucks";
            this.clearTrucksButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // newTruck_textbox
            // 
            this.newTruck_textbox.Location = new System.Drawing.Point(401, 423);
            this.newTruck_textbox.Name = "newTruck_textbox";
            this.newTruck_textbox.Size = new System.Drawing.Size(100, 20);
            this.newTruck_textbox.TabIndex = 8;
            this.newTruck_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewTruck_textbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Truck";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newTruck_textbox);
            this.Controls.Add(this.clearTrucksButton);
            this.Controls.Add(this.NextButton1);
            this.Controls.Add(this.NextButton2);
            this.Controls.Add(this.moveTower2);
            this.Controls.Add(this.moveTower1);
            this.Controls.Add(this.towerBox2);
            this.Controls.Add(this.towerBox1);
            this.Controls.Add(this.truckListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox truckListBox;
        private System.Windows.Forms.ListBox towerBox1;
        private System.Windows.Forms.ListBox towerBox2;
        private System.Windows.Forms.Button moveTower1;
        private System.Windows.Forms.Button moveTower2;
        private System.Windows.Forms.Button NextButton2;
        private System.Windows.Forms.Button NextButton1;
        private System.Windows.Forms.LinkLabel clearTrucksButton;
        private System.Windows.Forms.TextBox newTruck_textbox;
        private System.Windows.Forms.Button button1;
    }
}

