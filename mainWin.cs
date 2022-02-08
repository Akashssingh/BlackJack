using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Group 19 - Justina Le and Akash Singh

namespace G19BlackJack
{
    public partial class mainWin : Form
    {
        int seed = 999;
        public mainWin()
        {
            InitializeComponent();
        }
        private void mainWinSeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                seed = int.Parse(mainWinSeed.Text);
            }
            catch
            {
                //if the user enters an empty string or characters then the seed default is 999
                seed = 999;
            }
        }

        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            //the user cannot go out of bounds 
            if (deckCB.SelectedIndex > -1 && deckCB.SelectedIndex < 8)
            {
                int numDecks = Convert.ToInt32(deckCB.SelectedItem);
                //the user must select s17 or h17 before beginning
                if (s17RadioBtn.Checked)
                {
                    //parameter true passed to identify that S17 was checked
                    playerForm newPlayerForm = new playerForm(seed, true, numDecks);
                    newPlayerForm.ShowDialog();
                }
                else if (h17RadioBtn.Checked)
                {
                    //parameter false passed to identify that H17 was checked
                    playerForm newPlayerForm = new playerForm(seed, false, numDecks);
                    newPlayerForm.ShowDialog();
                }
            }
            
        }

        
    }
}
