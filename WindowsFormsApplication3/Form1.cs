using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PirateWars
{
    public partial class Form1 : Form
    {

        public string pirateName { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (this.playerName.Text == "-")
            {
                pirateName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name, Captain!", "Player setup", "");
                Player player = new Player(pirateName);
                
                this.playerName.Text = pirateName;
                this.cash.Text = player.gold + " Golden Coins";


                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void port1_Click(object sender, EventArgs e)
        {

        }

        private void port2_Click(object sender, EventArgs e)
        {

        }

        private void port3_Click(object sender, EventArgs e)
        {

        }

        private void port4_Click(object sender, EventArgs e)
        {

        }

        private void port5_Click(object sender, EventArgs e)
        {

        }

        private void port6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
