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
            while (lblPlayerName.Text == "" || lblPlayerName.Text == "-")
            {
                pirateName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name, Captain!", "Player setup", "");
                controller.SetPlayerName(pirateName);

                lblPlayerName.Text = pirateName;
                
            }
            this.playerGold.Text = controller.GetPlayerStartingGold() +" Golden Coins";

            

            foreach (Cargo cargo in controller.GetCargoList())
            {
                dataGridViewInventory.Rows.Add(cargo.name, cargo.amount);
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
            lblPlayerName.Text = "Welcome " + pirateName + ", to Tortuga.";
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

        //purchase
        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }

        //sell
        private void button5_Click(object sender, EventArgs e)
        {
            
            
            String temp = dataGridViewInventory.CurrentCell.OwningRow.Cells[0].Value as string; 

            foreach (Cargo cargo in controller.GetCargoList())
            {
                if (cargo.name == temp)
                {
                    controller.GetGame().GetPlayer().DecreaseAmount(cargo);
                    //Console.WriteLine(controller.GetGame().GetPlayer().GetCargoList().);
                }
            }
            
        }
    }
}
