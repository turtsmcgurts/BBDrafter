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

        static string fileName = "characterPool.txt";
        static string filePath = Application.StartupPath + "\\" + fileName;
        static string[] defaultCharacters = { "Ambra", "Attikus", "Benedict", "Boldur", "Caldarius", "Deande", "El Dragon", "Galilea" +
                                              "Ghalt", "Isic", "Kelvin", "Kleese", "Marquis", "Mellka", "Miko", "Montana", "Orendi" +
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

        }

        private void btnRight_Click(object sender, EventArgs e) {

        }

        private void btnRemoveLeft_Click(object sender, EventArgs e) {

        }

        private void btnRemoveRight_Click(object sender, EventArgs e) {

        }

        private void btnReset_Click(object sender, EventArgs e) {

        }

        #endregion

        private void RetrieveCharacterPool() {
            //read the text file and put its contents into the listPool listbox.

            //if the file does not exist, create it and close the connection.
            if (!File.Exists(filePath)) {
                File.Create(filePath).Close();

                using (StreamWriter writer = new StreamWriter(filePath)) {
                    foreach(string c in defaultCharacters) {
                        writer.WriteLine(c);
                    }
                }
            }

            List<string> characters = new List<string>();

            using (StreamReader reader = new StreamReader(filePath)) {
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
