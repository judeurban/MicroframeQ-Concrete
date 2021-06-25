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
            ReadUserSettings();
            TruckListBoxLoad();
        }
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
        private void ReadUserSettings()
        {
            Console.WriteLine(SaveFolder);
            if (!Directory.Exists(SaveFolder)) CreateUserSetings(SaveFolder);                            //make sure the directory actually exists before we read it 
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
    }
}
