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
    partial class Form1 : Form
    {
        
        string pirateName;
        Controller controller;
        
        
        public Form1(ref Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (playerName.Text == "" || playerName.Text == "-")
            {
                pirateName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name, Captain!", "Player setup", "");
                controller.SetPlayerName(pirateName);

                playerName.Text = pirateName;
                
            }
            this.playerGold.Text = controller.GetPlayerStartingGold() +" Golden Coins";
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
