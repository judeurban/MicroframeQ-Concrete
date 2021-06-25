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
            this.SuspendLayout();
            // 
            // truckListBox
            // 
            this.truckListBox.FormattingEnabled = true;
            this.truckListBox.Location = new System.Drawing.Point(334, 79);
            this.truckListBox.Name = "truckListBox";
            this.truckListBox.Size = new System.Drawing.Size(131, 277);
            this.truckListBox.TabIndex = 0;
            // 
            // towerBox1
            // 
            this.towerBox1.FormattingEnabled = true;
            this.towerBox1.Location = new System.Drawing.Point(60, 79);
            this.towerBox1.Name = "towerBox1";
            this.towerBox1.Size = new System.Drawing.Size(131, 277);
            this.towerBox1.TabIndex = 1;
            // 
            // towerBox2
            // 
            this.towerBox2.FormattingEnabled = true;
            this.towerBox2.Location = new System.Drawing.Point(605, 79);
            this.towerBox2.Name = "towerBox2";
            this.towerBox2.Size = new System.Drawing.Size(131, 277);
            this.towerBox2.TabIndex = 2;
            // 
            // moveTower1
            // 
            this.moveTower1.Location = new System.Drawing.Point(217, 212);
            this.moveTower1.Name = "moveTower1";
            this.moveTower1.Size = new System.Drawing.Size(75, 23);
            this.moveTower1.TabIndex = 3;
            this.moveTower1.Text = "Tower 1 <--";
            this.moveTower1.UseVisualStyleBackColor = true;
            this.moveTower1.Click += new System.EventHandler(this.MoveTower1_Click);
            // 
            // moveTower2
            // 
            this.moveTower2.Location = new System.Drawing.Point(504, 212);
            this.moveTower2.Name = "moveTower2";
            this.moveTower2.Size = new System.Drawing.Size(75, 23);
            this.moveTower2.TabIndex = 4;
            this.moveTower2.Text = "--> Tower 2";
            this.moveTower2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveTower2);
            this.Controls.Add(this.moveTower1);
            this.Controls.Add(this.towerBox2);
            this.Controls.Add(this.towerBox1);
            this.Controls.Add(this.truckListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox truckListBox;
        private System.Windows.Forms.ListBox towerBox1;
        private System.Windows.Forms.ListBox towerBox2;
        private System.Windows.Forms.Button moveTower1;
        private System.Windows.Forms.Button moveTower2;
    }
}

