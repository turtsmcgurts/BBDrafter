using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDrafter {
    public partial class Form1 : Form {
        #region Variables
        static bool saveLogs = true; //saves the console output to a file

        AutoCompleteStringCollection autoItems = new AutoCompleteStringCollection();
        List<string> teamDirectories = new List<string>();
        static string poolFileName = "characterPool.txt";
        static string poolFilePath = Application.StartupPath + "\\" + poolFileName;
        static string logFileDate = string.Format("{0:yyyy-MM-dd_hh-mm-tt}", DateTime.Now);
        static string logFilePath = Application.StartupPath + "\\Logs\\";
        static string[] defaultCharacters = { "Ambra", "Attikus", "Benedict", "Boldur", "Caldarius", "Deande", "El Dragon", "Galilea",
                                              "Ghalt", "Isic", "Kelvin", "Kleese", "Marquis", "Mellka", "Miko", "Montana", "Orendi",
                                              "Oscar Mike", "Phoebe", "Rath", "Reyna", "Shayne&Aurox", "Thorn", "Toby", "Whiskey Foxtrot"};


        #endregion

        #region Form Generated

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            RetrieveCharacterPool(); //populate the character pool from 'filePath'
            RetrieveTeamDirectories(); //populate autocomplete for opposing team name with known teams
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            if (!CanPick()) return;

            WriteLog(txtFriendlyName.Text + " picked " + listPool.SelectedItem.ToString());
            listFriendly.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);

        }

        private void btnRight_Click(object sender, EventArgs e) {
            if (!CanPick()) return;

            WriteLog(txtEnemyName.Text + " picked " + listPool.SelectedItem.ToString());
            listEnemy.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);

        }

        private void btnRemoveLeft_Click(object sender, EventArgs e) {
            if (listFriendly.Items.Count <= 0 || listFriendly.SelectedItem == null) return;

            WriteLog(txtFriendlyName.Text + " removed " + listFriendly.SelectedItem.ToString() + " pick");
            listPool.Items.Add(listFriendly.SelectedItem);
            listFriendly.Items.Remove(listFriendly.SelectedItem);

        }

        private void btnRemoveRight_Click(object sender, EventArgs e) {
            if (listEnemy.Items.Count <= 0 || listEnemy.SelectedItem == null) return;

            WriteLog(txtEnemyName.Text + " removed " + listEnemy.SelectedItem.ToString() + " pick");
            listPool.Items.Add(listEnemy.SelectedItem);
            listEnemy.Items.Remove(listEnemy.SelectedItem);

        }

        private void btnReset_Click(object sender, EventArgs e) {
            listFriendly.Items.Clear();
            listLeftBans.Items.Clear();
            listEnemy.Items.Clear();
            listRightBans.Items.Clear();
            rtbLog.Clear();

            RetrieveCharacterPool(); //populate the character pool from 'filePath'
            RetrieveTeamDirectories(); //populate autocomplete for opposing team name with known teams

        }

        private void btnLeftBan_Click(object sender, EventArgs e) {
            if (!CanPick()) return;

            WriteLog(txtFriendlyName.Text + " banned " + listPool.SelectedItem.ToString());
            listLeftBans.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);
        }

        private void btnRightBan_Click(object sender, EventArgs e) {
            if (!CanPick()) return;

            WriteLog(txtEnemyName.Text + " banned " + listPool.SelectedItem.ToString());
            listRightBans.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);
        }

        #endregion

        private void RetrieveCharacterPool() {
            //read the text file and put its contents into the listPool listbox.

            //if the file does not exist, create it and close the connection.
            if (!File.Exists(poolFilePath)) {
                File.Create(poolFilePath).Close();

                using (StreamWriter writer = new StreamWriter(poolFilePath)) {
                    foreach (string c in defaultCharacters) {
                        writer.WriteLine(c);
                    }
                }
            }

            List<string> characters = new List<string>();

            using (StreamReader reader = new StreamReader(poolFilePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    characters.Add(line);
                }
            }

            listPool.Items.Clear(); //remove current contents so we don't have duplicates.

            foreach (string c in characters) {
                listPool.Items.Add(c);
            }
        }

        private void RetrieveTeamDirectories() {
            Directory.CreateDirectory(logFilePath);
            string[] teams = Directory.GetDirectories(logFilePath);

            foreach (string t in teams) {
                string name = Path.GetFileName(t);
                teamDirectories.Add(name);
                autoItems.Add(name);
            }

            txtEnemyName.AutoCompleteCustomSource = autoItems;
        }

        private void WriteLog(string message) {
            if (message == null || message == "") return;
            rtbLog.AppendText(message + "\n");

            Directory.CreateDirectory(logFilePath + txtEnemyName.Text);

            if (!saveLogs) return;
            using (FileStream stream = new FileStream(logFilePath + txtEnemyName.Text + "\\" + logFileDate + ".txt", FileMode.Append, FileAccess.Write, FileShare.Write)) {
                using (StreamWriter sw = new StreamWriter(stream)) {
                    sw.WriteLine(message);
                }
            }
        }

        private bool CanPick() {
            if (listPool.Items.Count <= 0 || listPool.SelectedItem == null) return false;
            if (txtEnemyName.Text == null || txtEnemyName.Text == "") {
                MessageBox.Show("Enter enemy team name before picking.");
                return false;
            }

            return true;
        }

    }
}
