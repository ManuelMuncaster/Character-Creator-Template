using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class ViewScreen : UserControl
    {
        public ViewScreen()
        {
            InitializeComponent();
        }

        private void ViewScreen_Load(object sender, EventArgs e)
        {
            // add each Characters name to the dropdown box
            foreach (Character c in MainForm.characterDB)
            {
                heroSelect.Items.Add(c.name);
            }

            // below is a for loop that does the exact same thing as
            // the foreach loop above. It is here for reference only
            //
            //for (int i = 0; i < MainForm.characterDB.Count(); i++)
            //{
            //    heroSelect.Items.Add(MainForm.characterDB[i].name);
            //}
        }

        private void exitButton_Click(object sender, EventArgs e)
        {


            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        private void heroSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].name;
            classOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].charClass;
            dexterityOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].dexterity;
            strengthOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].strength;
            healthOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].health;
            perkOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].perk;

            if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Fighter")
            {
                heroImage.BackgroundImage = Properties.Resources.fighter;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Mage")
            {
                heroImage.BackgroundImage = Properties.Resources.mage2;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Ranger")
            {
                heroImage.BackgroundImage = Properties.Resources.ranger;
            }
        }
    }
}
