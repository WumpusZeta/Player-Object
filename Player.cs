using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class Form1 : Form
    {
        private Player plr;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            plr = new Player();
            plr.addArrow();
            label1.Text = "Arrows: " + plr.getNumberOfArrows();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            plr.addArrow();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plr.addTurn();
            label3.Text = "Turns: " + plr.getTurns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plr.spendCoins(2);
            label2.Text = "Coins: " + plr.getCoins();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plr.addCoins(5);
            label2.Text = "Coins: " + plr.getCoins();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plr.useArrow();
            label1.Text = "Arrows: " + plr.getNumberOfArrows();
        }
    }
}
