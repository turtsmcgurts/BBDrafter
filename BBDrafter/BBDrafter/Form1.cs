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

        static string poolFileName = "characterPool.txt";
        static string poolFilePath = Application.StartupPath + "\\" + poolFileName;
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
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            if (listPool.Items.Count <= 0 || listPool.SelectedItem == null) return;

            listFriendly.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);
        }

        private void btnRight_Click(object sender, EventArgs e) {
            if (listPool.Items.Count <= 0 || listPool.SelectedItem == null) return;
            
            listEnemy.Items.Add(listPool.SelectedItem.ToString());
            listPool.Items.Remove(listPool.SelectedItem);
        }

        private void btnRemoveLeft_Click(object sender, EventArgs e) {
            if (listFriendly.Items.Count <= 0 || listFriendly.SelectedItem == null) return;

            listPool.Items.Add(listFriendly.SelectedItem);
            listFriendly.Items.Remove(listFriendly.SelectedItem);
        }

        private void btnRemoveRight_Click(object sender, EventArgs e) {
            if (listEnemy.Items.Count <= 0 || listEnemy.SelectedItem == null) return;

            listPool.Items.Add(listEnemy.SelectedItem);
            listEnemy.Items.Remove(listEnemy.SelectedItem);
        }

        private void btnReset_Click(object sender, EventArgs e) {
            listFriendly.Items.Clear();
            listEnemy.Items.Clear();
            RetrieveCharacterPool();

        }

        #endregion

        private void RetrieveCharacterPool() {
            //read the text file and put its contents into the listPool listbox.

            //if the file does not exist, create it and close the connection.
            if (!File.Exists(poolFilePath)) {
                File.Create(poolFilePath).Close();

                using (StreamWriter writer = new StreamWriter(poolFilePath)) {
                    foreach(string c in defaultCharacters) {
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


    }
}
