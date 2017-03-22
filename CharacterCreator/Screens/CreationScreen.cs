using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CharacterCreator
{
    public partial class CreationScreen : UserControl
    {
        //These variables will hold temporary values that are used to create
        //a hero object
        int dexterity, strength, health, points;
        string heroType, name, perk;

        public CreationScreen()
        {
            InitializeComponent();

            //each attribute and extra points value is set to 5 to start
            dexterity = strength = health = points = 5;

        }

        #region character type
        //TODO: For each button click set the image on screen and the heroType variable

        private void mageButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.mage2;
            heroType = "mage";
        }

        private void rangerButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.ranger;
            heroType = "ranger";
        }

        private void fighterButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.fighter;
            heroType = "fighter";
        }

        #endregion

        #region attributes
        //TODO: For each button click add or remove 1 from the appropriate attribute display on screen. 
        // Also either add or remove 1 to the points variable. Do not allow points to go below 0 
        // or for the user to be able to add more points if they have all been used up.

        private void dexPlus_Click(object sender, EventArgs e)
        {
            dexterity++;
            points--;

            dexInput.Text = dexterity.ToString();
            pointsLabel.Text = points.ToString();

            if (points <= 1)
            {
                dexPlus.Enabled = false;
            }
            if (points >= 1)
            {
                dexPlus.Enabled = true;
            }

            if (dexterity <= 1)
            {
                dexMinus.Enabled = true;
            }

        }

        private void dexMinus_Click(object sender, EventArgs e)
        {
            dexterity--;
            points++;

            dexInput.Text = dexterity.ToString();
            pointsLabel.Text = points.ToString();

            if (points >= 0)
            {
                dexPlus.Enabled = true;
            }

            if (dexterity <= 1)
            {
                dexMinus.Enabled = false;
            }
            if (dexterity >= 1)
            {
                dexMinus.Enabled = true;
            }

        }

        private void strengthPlus_Click(object sender, EventArgs e)
        {
            strength++;
            points--;

            strengthInput.Text = strength.ToString();
            pointsLabel.Text = points.ToString();
        }

        private void StregthMinus_Click(object sender, EventArgs e)
        {
            strength--;
            points++;

            strengthInput.Text = strength.ToString();
            pointsLabel.Text = points.ToString();
        }

        private void healthPlus_Click(object sender, EventArgs e)
        {
            health++;
            points--;

            healthInput.Text = health.ToString();
            pointsLabel.Text = points.ToString();
        }

        private void healthMinus_Click(object sender, EventArgs e)
        {
            health--;
            points++;

            healthInput.Text = health.ToString();
            pointsLabel.Text = points.ToString();
        }

        #endregion

        #region perks
        //TODO: set the perk variable based on the selected radio button

        private void sneakRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void charmRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void intuitionRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void speedRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion


        private void saveButton_Click(object sender, EventArgs e)
        {
            // used to temporarly hold values that will then be used to creat object
            string dex, str, hea;

            //TODO: get name from input and set dex, str, and hea

            //TODO: create character object and place it characterDB

            //TODO: close this screen and open the Home Screen

            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);

        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the Home Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }
    }
}
