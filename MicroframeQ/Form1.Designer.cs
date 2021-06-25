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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.truckListBox = new System.Windows.Forms.ListBox();
            this.towerBox1 = new System.Windows.Forms.ListBox();
            this.towerBox2 = new System.Windows.Forms.ListBox();
            this.moveTower1 = new System.Windows.Forms.Button();
            this.moveTower2 = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.newTruck_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsDropDown = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTrucksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsDropDown.SuspendLayout();
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
            // SettingsDropDown
            // 
            this.SettingsDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.SettingsDropDown.Location = new System.Drawing.Point(0, 0);
            this.SettingsDropDown.Name = "SettingsDropDown";
            this.SettingsDropDown.Size = new System.Drawing.Size(1008, 25);
            this.SettingsDropDown.TabIndex = 12;
            this.SettingsDropDown.Text = "Settings";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfToolStripMenuItem,
            this.clearTrucksToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsToolStripMenuItem});
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dfToolStripMenuItem.Text = "df";
            // 
            // dsToolStripMenuItem
            // 
            this.dsToolStripMenuItem.Name = "dsToolStripMenuItem";
            this.dsToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.dsToolStripMenuItem.Text = "ds";
            // 
            // clearTrucksToolStripMenuItem
            // 
            this.clearTrucksToolStripMenuItem.Name = "clearTrucksToolStripMenuItem";
            this.clearTrucksToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.clearTrucksToolStripMenuItem.Text = "Clear Trucks...";
            this.clearTrucksToolStripMenuItem.Click += new System.EventHandler(this.ClearTrucksToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 646);
            this.Controls.Add(this.SettingsDropDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newTruck_textbox);
            this.Controls.Add(this.NextButton1);
            this.Controls.Add(this.NextButton2);
            this.Controls.Add(this.moveTower2);
            this.Controls.Add(this.moveTower1);
            this.Controls.Add(this.towerBox2);
            this.Controls.Add(this.towerBox1);
            this.Controls.Add(this.truckListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SettingsDropDown.ResumeLayout(false);
            this.SettingsDropDown.PerformLayout();
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
        private System.Windows.Forms.TextBox newTruck_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip SettingsDropDown;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTrucksToolStripMenuItem;
    }
}

