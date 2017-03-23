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
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //create code to close this screen and show the CreationScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CreationScreen cs = new CreationScreen();
            f.Controls.Add(cs);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //create code to close this screen and show the ViewScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ViewScreen vs = new ViewScreen();
            f.Controls.Add(vs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //create code to close whole program (Application.Exit())

            Application.Exit();
        }
    }
}
