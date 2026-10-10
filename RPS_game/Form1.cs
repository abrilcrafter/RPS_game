using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_game
{
    public partial class RPS_Form : Form
    {
        // private GameDisplay _display = new GameDisplay();
        public RPS_Form()
        {
            InitializeComponent();
            buttonROCK.Enabled = false;
            buttonPAPER.Enabled = false;
            buttonSCISSORS.Enabled = false;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            buttonROCK.Enabled = true;
            buttonPAPER.Enabled = true;
            buttonSCISSORS.Enabled = true;




        }

        private void buttonROCK_Click(object sender, EventArgs e)
        {
            string result = GameDisplay.Gameplay(1);
            label2.Text = result;
        }
        private void buttonPAPER_Click(object sender, EventArgs e)
        {
            string result = GameDisplay.Gameplay(2);
            label2.Text = result;
        }
        private void buttonSCISSORS_Click(object sender, EventArgs e)
        {
            string result = GameDisplay.Gameplay(3);
            label2.Text = result;
        }

        
    }
}
