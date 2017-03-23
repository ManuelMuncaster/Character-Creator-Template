using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);

            //create code to launch the HomeScreen when the program starts

        }
    }
}
