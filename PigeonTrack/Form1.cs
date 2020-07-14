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
using System.Xml.Linq;
using System.Xml.Serialization;
//Project AT 2 Start
namespace Video_Games_APP
{
    public partial class frmVGL : Form
    {
        public frmVGL()
        {
            InitializeComponent();
        }
        //===============================
        //create an mygames list of games
        //===============================
        List<Game> mygames = new List<Game>();
        //Start of btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //local variable to check if text box has data
            bool hasData = true;
            //new game
            Game m = new Game();
            //get game data from text box
            //check if text box has data
            //if null or empty set hasData to false
            m.GameName = textBoxName.Text;
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter Game Name");
                hasData = false;
                return;
            }
            m.GamePrice = textBoxPrice.Text;
            if (String.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Please enter Game Price");
                hasData = false;
                return;
            }
            m.DeveloperName = textBoxDeveloper.Text;
            if (String.IsNullOrEmpty(textBoxDeveloper.Text))
            {
                MessageBox.Show("Please enter Developer Name");
                hasData = false;
                return;
            }
            m.GamePlatform = comboBoxPlatfom.Text;
            if (String.IsNullOrEmpty(textBoxDeveloper.Text))
            {
                MessageBox.Show("Please enter Game Platform");
                hasData = false;
                return;
            }
            m.GameGenre = comboBoxGenre.Text;
            if (String.IsNullOrEmpty(textBoxDeveloper.Text))
            {
                MessageBox.Show("Please enter Game Genre");
                hasData = false;
                return;
            }

            if (radioButtonG.Checked == true)
            {
                m.GameRating = "General (G)";
            }
            else if (radioButtonPG.Checked == true)
            {
                m.GameRating = "Parental Guidance (PG)";
            }
            else if (radioButtonM.Checked == true)
            {
                m.GameRating = "Mature (M)";
            }
            else if (radioButtonMA.Checked == true)
            {
                m.GameRating = "Mature Audiences (MA)";
            }
            else if (radioButtonR.Checked == true)
            {
                m.GameRating = "Restricted (R)";
            }
            else if (radioButtonX.Checked == true)
            {
                m.GameRating = "Restricted (X)";
            }
            else
            {
                MessageBox.Show("Please enter Game Rating");
                hasData = false;
                return;
            }
            //if all data is valid and there are no duplicates
            //then add the record to the list
            bool duplicateFound = mygames.Exists(x => x.GameName == textBoxName.Text);
            if (hasData && !duplicateFound)
            {
                //add games to mygames List<>
                mygames.Add(m); 
                //empty the field 
                ClearFields(); 
                //display the games in the list box
                ShowList();
            }
            else
            {
                MessageBox.Show("Duplicate Game Name found");
            }

            ShowList();
        }
        //if (hasData && noDuplicates)
        //End of btnAdd_Click btnAdd

        //Start of btnDelete_Click
        //Check if a game has been selected from the list box
        //then remove the record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a record from the List Box");
            }
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int index = listGames.FindString(curItem);
                mygames.RemoveAt(index);
                ClearFields();
                ShowList();
            }
        }
        //End of btnDelete_Click

        //Start of btnDisplay_Click
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //get game data from list box
            //check if list box has been selected
            //if not MessageBox show No Item has been selected from List
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("No Item has been selected from List");
            }
            //Display selected game
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int index = listGames.FindString(curItem);
                listGames.SetSelected(index, true);
                textBoxName.Text = mygames[index].GameName;
                textBoxPrice.Text = mygames[index].GamePrice;
                textBoxDeveloper.Text = mygames[index].DeveloperName;
                comboBoxPlatfom.Text = mygames[index].GamePlatform;
                comboBoxGenre.Text = mygames[index].GameGenre;
                if (mygames[index].GameRating == "General (G)")
                {
                    radioButtonG.Checked = true;
                    return;
                }
                else if (mygames[index].GameRating == "Parental Guidance (PG)")
                {
                    radioButtonPG.Checked = true;
                    return;
                }
                else if (mygames[index].GameRating == "Mature (M)")
                {
                    radioButtonM.Checked = true;
                    return;
                }
                else if (mygames[index].GameRating == "Mature Audiences (MA)")
                {
                    radioButtonMA.Checked = true;
                    return;
                }
                else if (mygames[index].GameRating == "Restricted (R)")
                {
                    radioButtonR.Checked = true;
                    return;
                }
                else if (mygames[index].GameRating == "Restricted (X)")
                {
                    radioButtonX.Checked = true;
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //End of btnDisplay_Click
        
        //Start of btnUpdate_Click, update the fields in a game
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if game has been selected from List Box
            //if not MessageBox show Select a game from the List Box.
            Game updateGame = new Game();
            updateGame.GameName = textBoxName.Text;
            updateGame.GamePrice = textBoxPrice.Text;
            updateGame.DeveloperName = textBoxDeveloper.Text;
            updateGame.GamePlatform = comboBoxPlatfom.Text;
            updateGame.GameGenre = comboBoxGenre.Text;
            if (listGames.SelectedIndex == -1)
            {
                MessageBox.Show("Select a game from the List Box.");
            }
            else
            {
                string curItem = listGames.SelectedItem.ToString();
                int index = listGames.FindString(curItem);

                mygames[index].GameName = updateGame.GameName;
                mygames[index].GamePrice = updateGame.GamePrice;
                mygames[index].DeveloperName = updateGame.DeveloperName;
                mygames[index].GamePlatform = updateGame.GamePlatform;
                mygames[index].GameGenre = updateGame.GameGenre;

                if (radioButtonG.Checked == true)
                {
                    mygames[index].GameRating = "General (G)";
                }
                else if (radioButtonPG.Checked == true)
                {
                    mygames[index].GameRating = "Parental Guidance (PG)";
                }
                else if (radioButtonM.Checked == true)
                {
                    mygames[index].GameRating = "Mature (M)";
                }
                else if (radioButtonMA.Checked == true)
                {
                    mygames[index].GameRating = "Mature Audiences (MA)";
                }
                else if (radioButtonR.Checked == true)
                {
                    mygames[index].GameRating = "Restricted (R)";
                }
                else if (radioButtonX.Checked == true)
                {
                    mygames[index].GameRating = "Restricted (X)";
                }
                else
                {
                    return;
                }

                ClearFields();
                ShowList();
            }

        }
        //End of btnUpdate_Click

        //Start of btnLoad_Click
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists("C:\\"))
                Directory.CreateDirectory("C:\\");
            if (!File.Exists("C:\\mygames.xml"))
                File.Create("C:\\mygames.xml").Close();


            mygames = ReadFromXmlFile<List<Game>>("C:\\mygames.xml");
            ShowList();
        }
        //End of btnLoad_Click

        //Start of btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToXmlFile<List<Game>>("C:\\mygames.xml", mygames);
            MessageBox.Show("ALL GAMES ON THE LIST HAS BEEN SAVED", "Saving games", MessageBoxButtons.OK);
        }
        //End of btnSave_Click

        //Start of ClearFields()
        //ClearFields() method after btn_Add and btn_Update
        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxDeveloper.Text = "";
            comboBoxPlatfom.Text = "";
            comboBoxGenre.Text = "";
            radioButtonG.Checked = false;
            radioButtonPG.Checked = false;
            radioButtonM.Checked = false;
            radioButtonMA.Checked = false;
            radioButtonR.Checked = false;
            radioButtonX.Checked = false;

        }
        //End of ClearFields()

        public void ShowList()
        {
            listGames.Items.Clear();

            mygames.Sort(delegate (Game game1, Game game2)
            {
                return game1.GameName.CompareTo(game2.GameName);
            });

            foreach (var x in mygames)
            {
                listGames.Items.Add(x.GameName + " : " + x.GamePlatform);
            }

        }
        //method after using btn_Save
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }

            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }


        }

        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    //class of Game fields
    public class Game
    {
        [XmlElement("GameName")]
        public string GameName
        {
            get;
            set;
        }
        [XmlElement("Gameprice")]
        public string GamePrice
        {
            get;
            set;
        }
        [XmlElement("DeveloperName")]
        public string DeveloperName
        {
            get;
            set;
        }
        [XmlElement("GamePlatform")]
        public string GamePlatform
        {
            get;
            set;
        }
        [XmlElement("GameGenre")]
        public string GameGenre
        {
            get;
            set;
        }
        [XmlElement("GameRating")]
        public string GameRating
        {
            get;
            set;
        }
    }
}
//Project AT 2 End
    


