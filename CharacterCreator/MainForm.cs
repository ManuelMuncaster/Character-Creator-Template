using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        //create a object list, (call it characterDB), to hold your character information.
        //NOTE: You will need to create the Character class first.
       public static List<Character> characterDB = new List<Character>();

        public MainForm()
        {
            InitializeComponent();
            loadHero();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);

            //create code to launch the HomeScreen when the program starts

        }

        public void loadHero()
        {
            //Temp variables to store heroes stats
            string newName = "";
            string newClass = "";
            string newDex = "";
            string newStr = "";
            string newHea = "";
            string newPerk = "";

            int items = 1;

            XmlTextReader reader = new XmlTextReader("heroes.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    switch (items)
                    {
                        case 1:
                            newName = reader.Value;
                            break;
                        case 2:
                            newClass = reader.Value;
                            break;
                        case 3:
                            newDex = reader.Value;
                            break;
                        case 4:
                            newStr = reader.Value;
                            break;
                        case 5:
                            newHea = reader.Value;
                            break;
                        case 6:
                            newPerk = reader.Value;
                            Character newCharacter = new Character(newName, newClass, newDex, newStr, newHea, newPerk);
                            MainForm.characterDB.Add(newCharacter);
                            items = 0;
                            break;
                    }

                    items++;
                }
            }
            reader.Close();

        }
    }
}
