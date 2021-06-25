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
using static System.Windows.Forms.ToolStripItem;

namespace MicroframeQ
{
    public partial class Form1 : Form
    {
        public static List<int> GlobalTruckCatalog = new List<int> { };
        public static List<int> Tower1List = new List<int> { };
        public static List<int> Tower2List = new List<int> { };
        public static List<int> TempTruckList = new List<int> { };

        public static string SaveFolder;
        public static string UserSettingsPath;
        public static string TruckListPath;
        public Form1()
        {
            InitializeComponent();

            try
            {
                SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MicroframeQ";
                UserSettingsPath = SaveFolder + "\\UserSettings.txt";
                TruckListPath = SaveFolder + "\\trucklist.txt";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            GlobalTruckCatalog.Clear();

            //Read User Setings
            if (!Directory.Exists(SaveFolder)) CreateUserSetings(SaveFolder);                            //make sure the directory actually exists before we read it 
            TruckListBoxLoad();
            COMSettingsLoad();
        }

        //      RECORD KEEPING      //
        private void TruckListBoxLoad()
        {
            //add all items of .txt file to catalog
            string[] import_string = File.ReadAllLines(TruckListPath);

            for (int i = 0; i < (int)import_string.Length; i++)
            {
                GlobalTruckCatalog.Add(int.Parse(import_string[i]));
            }

            GlobalTruckCatalog.Sort();

            //set data source of listbox to global truck catalog
            truckListBox.DataSource = GlobalTruckCatalog;

            //copy the globaltruckcatalog into the temp list
            foreach(int i in GlobalTruckCatalog)
            {
                TempTruckList.Add(i);
            }
        }

        private void COMSettingsLoad()
        {
            string[] settings = File.ReadAllLines(UserSettingsPath);
            UInt16 s = UInt16.Parse(settings[0]);
            switch (s)
            {
                case 1:
                    display1_com1.PerformClick();
                    break;
                case 2:
                    display1_com2.PerformClick();
                    break;
                case 3:
                    display1_com3.PerformClick();
                    break;
                case 4:
                    display1_com4.PerformClick();
                    break;
                case 5:
                    display1_com5.PerformClick();
                    break;
                case 6:
                    display1_com6.PerformClick();
                    break;
                case 7:
                    display1_com7.PerformClick();
                    break;
                case 8:
                    display1_com8.PerformClick();
                    break;
                case 9:
                    display1_com9.PerformClick();
                    break;
            }
            s = UInt16.Parse(settings[1]);
            switch (s)
            {
                case 1:
                    display2_com1.PerformClick();
                    break;
                case 2:
                    display2_com2.PerformClick();
                    break;
                case 3:
                    display2_com3.PerformClick();
                    break;
                case 4:
                    display2_com4.PerformClick();
                    break;
                case 5:
                    display2_com5.PerformClick();
                    break;
                case 6:
                    display2_com6.PerformClick();
                    break;
                case 7:
                    display2_com7.PerformClick();
                    break;
                case 8:
                    display2_com8.PerformClick();
                    break;
                case 9:
                    display2_com9.PerformClick();
                    break;
            }
        }

        private void WriteUserSettings()
        {
            var myTruckFile = File.CreateText(TruckListPath);
            foreach (int i in GlobalTruckCatalog)
            {
                myTruckFile.WriteLine(i);
            }
            myTruckFile.Close();
        }

        private void UpdateTruckListBox()
        {
            truckListBox.DataSource = null;
            if (TempTruckList.Count == 0)
            {
                truckListBox.Items.Clear();
                return;
            }
            if(truckListBox.Items.Count != 0)  truckListBox.Items.Clear();
            foreach(int i in TempTruckList)
            {
                truckListBox.Items.Add(i.ToString());
            }
        }

        private void UpdateTower1ListBox()
        {
            towerBox1.DataSource = null;
            if (towerBox1.Items.Count != 0) towerBox1.Items.Clear();
            foreach (int i in Tower1List)
            {
                towerBox1.Items.Add(i.ToString());
            }
        }
        private void UpdateTower2ListBox()
        {
            towerBox2.DataSource = null;
            if (towerBox2.Items.Count != 0) towerBox2.Items.Clear();
            foreach (int i in Tower2List)
            {
                towerBox2.Items.Add(i.ToString());
            }
        }

        private void CreateUserSetings(string SaveFolder)
        {
            //Try to create the directory at SaveFolder

            DirectoryInfo di = Directory.CreateDirectory(SaveFolder);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(SaveFolder));

            var myTruckFile = File.CreateText(TruckListPath);
            var myUserSettingsFile = File.CreateText(UserSettingsPath);
            myTruckFile.Close();
            myUserSettingsFile.Close();

            //Console.WriteLine("create trucklist file at " + trucklistpath);
            //Console.WriteLine("create usersettings file at " + usersettingspath);

            File.WriteAllText(TruckListPath, "");
            File.WriteAllText(UserSettingsPath, "1\n1");

            MessageBox.Show("Using " + SaveFolder + " data sucessfully stored");
            MessageBox.Show("To change the serial COM port settings, use the dropdown menu above this message.");

            myTruckFile.Close();
            myUserSettingsFile.Close();
            myUserSettingsFile.Close();

        }
        
        private void MoveTower1_Click(object sender, EventArgs e)
        {
            if (truckListBox.Items.Count == 0)
            {
                return;
            }
            //if nothing is selected
            if (truckListBox.SelectedItem == null)
            {
                MessageBox.Show("No item selected.");
                return;
            }
            if (TempTruckList.Count == 0)
            {
                return;
            }
            //find selected item
            //remove item from temptrucklist
            //add item to tower1 listbox
            //reset data source

            int item_index;
            string item_value;
            //there's only one item, so we don't need to select a truck. Just remove the top item
            if (truckListBox.Items.Count == 1)
            {
                item_index = 0;
                item_value = (string)truckListBox.Items[0].ToString();
            }
            else
            {
                //define selected item to move
                item_index = truckListBox.SelectedIndex;
                item_value = truckListBox.SelectedItem.ToString();
            }

            //move from TempTruckList to Tower1List
            TempTruckList.RemoveAt(item_index);
            TempTruckList.Sort();
            Tower1List.Add(int.Parse(item_value));

            UpdateTruckListBox();
            UpdateTower1ListBox();
            UpdateLiveQueue(1);

            if (truckListBox.Items.Count == 0)
            {
                return;
            }
            else if (item_index == truckListBox.Items.Count)
            {
                truckListBox.SelectedIndex = item_index - 1;
            }
            else if (truckListBox.Items.Count > 0)
            {
                truckListBox.SelectedIndex = item_index;
            } 
            else
            {
                return;
            }
        }

        private void MoveTower2_Click_1(object sender, EventArgs e)
        {
            if (truckListBox.Items.Count == 0)
            {
                return;
            }
            //if nothing is selected
            if (truckListBox.SelectedItem == null)
            {
                MessageBox.Show("No item selected.");
                return;
            }
            if (TempTruckList.Count == 0)
            {
                return;
            }
            //find selected item
            //remove item from temptrucklist
            //add item to tower1 listbox
            //reset data source

            int item_index;
            string item_value;
            //there's only one item, so we don't need to select a truck. Just remove the top item
            if (truckListBox.Items.Count == 1)
            {
                item_index = 0;
                item_value = (string)truckListBox.Items[0].ToString();
            }
            else
            {
                //define selected item to move
                item_index = truckListBox.SelectedIndex;
                item_value = truckListBox.SelectedItem.ToString();
            }

            //move from TempTruckList to Tower1List
            TempTruckList.RemoveAt(item_index);
            TempTruckList.Sort();
            Tower2List.Add(int.Parse(item_value));

            UpdateTruckListBox();
            UpdateTower2ListBox();
            UpdateLiveQueue(2);

            if (truckListBox.Items.Count == 0)
            {
                return;
            }
            else if (item_index == truckListBox.Items.Count)
            {
                truckListBox.SelectedIndex = item_index - 1;
            }
            else if (truckListBox.Items.Count > 0)
            {
                truckListBox.SelectedIndex = item_index;
            }
            else
            {
                return;
            }
        }

        private void TruckListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Left)
            {
                moveTower1.PerformClick();
            }
            else if (e.KeyValue == (char)Keys.Right)
            {
                moveTower2.PerformClick();
            }
        }

        private void TowerBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                NextButton2_Click(sender, e);
                return;
            }
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            if(Tower1List.Count == 0) return;

            //move from Tower1List to TempTruckList  
            TempTruckList.Add(int.Parse(towerBox1.Items[0].ToString()));
            TempTruckList.Sort();
            Tower1List.RemoveAt(0);

            //update boxes
            UpdateTower1ListBox();
            UpdateTruckListBox();
            UpdateLiveQueue(1);
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            if (Tower2List.Count == 0) return;

            //move from Tower1List to TempTruckList  
            TempTruckList.Add(int.Parse(towerBox2.Items[0].ToString()));
            TempTruckList.Sort();
            Tower2List.RemoveAt(0);

            //update boxes
            UpdateTower2ListBox();
            UpdateTruckListBox();
            UpdateLiveQueue(2);
        }

        private void TowerBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                NextButton1_Click(sender, e);
                return;
            }
        }

        private void NewTruck_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)                                                             //new entry on enter event
            {   
                if (newTruck_textbox.Text == "")                                                            //blank statement. pop up warning for nothing there was annoying me.
                {
                    return;
                }
                else if (int.TryParse(newTruck_textbox.Text, out int value))                                //item is a valid integer
                {
                    if (GlobalTruckCatalog.Contains(int.Parse(newTruck_textbox.Text)))                       //catch a valid integer that is in the trucklist_temp
                    {
                        MessageBox.Show("Item already added.");
                        return;
                    }
                    else if (TempTruckList.Contains(int.Parse(newTruck_textbox.Text)))                //catch a valid integer that is in the catalog. no duplicates!
                    {
                        MessageBox.Show("That item is already in the truck list.");
                        return;
                    }
                    else
                    {
                        GlobalTruckCatalog.Add(int.Parse(newTruck_textbox.Text));                            //the item passed the test. add it to global catalog
                        TempTruckList.Add(int.Parse(newTruck_textbox.Text));                                //add to the temp list
                        newTruck_textbox.Clear();

                        GlobalTruckCatalog.Sort();
                        TempTruckList.Sort();

                        UpdateTruckListBox();
                        return;
                    }
                }
                else
                {                                                                               //catch any special symbols. I don't want a " & " crashing my precious program.
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                return;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void ClearTrucksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all\nitems from the list?", "Remove All Items", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GlobalTruckCatalog.Clear();
                TempTruckList.Clear();
                UpdateTruckListBox();
                var myTruckFile = File.CreateText(TruckListPath);                       //rewrite the .txt file
                myTruckFile.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        //      SERIAL COMMUNICATION        //

        private void UpdateLiveQueue(int towerswitch)
        {
            try
            {
                switch (towerswitch)
                {
                    case 1:
                        if (towerBox1.Items.Count == 0)
                        {
                            TowerBox1_live.Text = "Now Displaying:\n";
                            SendBlank1(); return;                                   //catch the bug before it 
                        }
                        else
                        {
                            TowerBox1_live.Text = "Now Displaying:\n" + towerBox1.Items[0].ToString();            //update the live queue one
                            Disp1_SendMessage(towerBox1.Items[0].ToString());                                            //update display 1
                        }
                        break;
                    case 2:
                        if (towerBox2.Items.Count == 0)
                        {
                            TowerBox2_live.Text = "Now Displaying:\n";
                            SendBlank2(); return;                                   //catch the bug before it crashes
                        }
                        else
                        {
                            TowerBox2_live.Text = "Now Displaying:\n" + towerBox2.Items[0].ToString();            //update the live queue one
                            Disp2_SendMessage(towerBox2.Items[0].ToString());                                      //update display 1
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) SendBlank1(); serialPort1.Close();                                      //close any open serial ports
            if (serialPort2.IsOpen) SendBlank2(); serialPort2.Close();

            //update the txt file
            WriteUserSettings();
        }

        private void SetupSerial1(String portname)
        {
            if (serialPort1.IsOpen) serialPort1.Close();

            serialPort1.PortName = portname;

            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void SetupSerial2(String portname)
        {
            if (serialPort2.IsOpen) serialPort2.Close();

            serialPort2.PortName = portname;

            try
            {
                serialPort2.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void SendBlank1()
        {
            //open communication, and return just in case it's not open yet.
            Disp1_OpenCommunication();
            if (!serialPort1.IsOpen) serialPort1.Open();

            //send message
            serialPort1.Write(Environment.NewLine);
        }
        private void SendBlank2()
        {
            //open communication, and return just in case it's not open yet.
            Disp2_OpenCommunication();
            if (!serialPort2.IsOpen) serialPort2.Open();

            //send message
            serialPort2.Write(Environment.NewLine);
        }
        private void Disp1_OpenCommunication()
        {
            try
            {
                if (!serialPort1.IsOpen) serialPort1.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Disp2_OpenCommunication()
        {
            try
            {
                if (!serialPort2.IsOpen) serialPort2.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Disp1_SendMessage(String s)
        {
            Disp1_OpenCommunication();
            if (!serialPort1.IsOpen) return;

            serialPort1.Write(s + Environment.NewLine);
        }

        private void Disp2_SendMessage(String s)
        {
            Disp2_OpenCommunication();
            if (!serialPort2.IsOpen) return;

            serialPort2.Write(s + Environment.NewLine);
        }
        private void ClearChecks1()
        {
            display1_com1.Checked = false;
            display1_com2.Checked = false;
            display1_com3.Checked = false;
            display1_com4.Checked = false;
            display1_com5.Checked = false;
            display1_com6.Checked = false;
            display1_com7.Checked = false;
            display1_com8.Checked = false;
            return;
        }
        private void ClearChecks2()
        { 
            display2_com1.Checked = false;
            display2_com2.Checked = false;
            display2_com3.Checked = false;
            display2_com4.Checked = false;
            display2_com5.Checked = false;
            display2_com6.Checked = false;
            display2_com7.Checked = false;
            display2_com8.Checked = false;
            return;
        }

        private void COMcheck1(object sender, EventArgs e)
        {
            ClearChecks1();
            if (serialPort1.IsOpen) serialPort1.Close();
            if (!(sender is ToolStripMenuItem stripMenuItem)) return;
            stripMenuItem.Checked = true;

            SetupSerial1(sender.ToString());
            UpdateLiveQueue(1);
            WriteCOMSettings(1, sender.ToString()[3]);
        }

        private void COMcheck2(object sender, EventArgs e)
        {
            ClearChecks2();
            if (serialPort2.IsOpen) serialPort2.Close();
            if (!(sender is ToolStripMenuItem stripMenuItem)) return;
            stripMenuItem.Checked = true;

            SetupSerial2(sender.ToString());
            UpdateLiveQueue(2);
            WriteCOMSettings(2, sender.ToString()[3]);
        }
        
        private void WriteCOMSettings(UInt16 s, char c)
        {
            string[] oldfile = File.ReadAllLines(UserSettingsPath);

            switch (s)
            {
                case 1:                                     //update display 1
                    oldfile[0] = c.ToString();
                break;
                case 2:                                     //update display 1
                    oldfile[1] = c.ToString();
                    break;
            }
            File.WriteAllText(UserSettingsPath, oldfile[0] + "\n" + oldfile[1]);
        }

        private void BackgroundFocusColorChange(object sender, EventArgs e)
        {
            if (!(sender is ListBox listbox)) return;

            //gray uninteresting boxes
            foreach (var box in Controls.OfType<ListBox>())
            {
                box.BackColor = Color.LightGray;
            }

            //reset the box of interest to be white
            listbox.BackColor = Color.White;

        }
    }
}
