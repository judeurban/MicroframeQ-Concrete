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
        BindingSource Tower1BS = new BindingSource();
        BindingSource Tower2BS = new BindingSource();
        BindingSource TempTruckListBS = new BindingSource();

        public static string SaveFolder;
        public static string UserSettingsPath;
        public static string TruckListPath;
        public Form1()
        {
            InitializeComponent();
            Tower1BS.DataSource = Tower1List;
            Tower2BS.DataSource = Tower2List;
            TempTruckListBS.DataSource = TempTruckList;

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
            TempTruckListBS.RemoveAt(item_index);
            TempTruckList.Sort();
            truckListBox.DataSource = TempTruckListBS;

            Tower1BS.Add(Int32.Parse(item_value));
            towerBox1.DataSource = Tower1BS;
            //truckListBox.DataSource = TempTruckList;
            //towerBox1.DataSource = Tower1List;

        }
    }
}
