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
        ExceptionHandler eh = new ExceptionHandler();
        
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

            

            foreach (Cargo cargo in controller.GetPlayersCargoList())
            {
                dataGridViewInventory.Rows.Add(cargo.Name, cargo.Amount);
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
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Tortuga.";
            lblPortsTradingGoods.Text = "Tortugas Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Tortuga"))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            
            EndTurn();
        }

        private void port2_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Black Water Bay.";
            lblPortsTradingGoods.Text = "Black Water Bay Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Black Water Bay"))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            EndTurn();
        }

        private void port3_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Providence.";
            lblPortsTradingGoods.Text = "Providence Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Providence"))
            {
                dataGridViewPort.Rows.Add(cargo.Name,cargo.Price);
            }
            EndTurn();
        }

        private void port4_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Isla de Muerta.";
            lblPortsTradingGoods.Text = "Isla de Muerta Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Isla de Muerta"))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            EndTurn();
        }

        private void port5_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Shipwreck Cove.";
            lblPortsTradingGoods.Text = "Shipwreck Cove Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Shipwreck Cove"))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            EndTurn();
        }

        private void port6_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            DisableCurrentButton(currentButton);
            controller.UpdatePrices();
            dataGridViewPort.Rows.Clear();
            lblPlayerName.Text = "Welcome " + pirateName + ", to Free Port.";
            lblPortsTradingGoods.Text = "Free Port Trading Goods";
            foreach (Cargo cargo in controller.GetPortsCargoList("Free Port"))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            EndTurn();
        }

        private void UpdateView()
        {

            Player player = controller.GetGame().Player;
            Port port = controller.GetGame().GetCurrentPort();

            lblPlayerName.Text = "Welcome " + pirateName + ", to " + port.GetPortName() + ".";
            lblPortsTradingGoods.Text = port.GetPortName() + "s Trading Goods";
            
            playerGold.Text = player.Gold + " Golden Coins";
            

            // remember the currently selected row and cell index
            int rowIndex = dataGridViewPort.CurrentCell.RowIndex;
            int cellIndex = dataGridViewPort.CurrentCell.ColumnIndex;
        
            dataGridViewPort.Rows.Clear();
            foreach (Cargo cargo in port.GetPortsCargoList())
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }

            // reselect the right cell
            dataGridViewPort.CurrentCell = dataGridViewPort.Rows[rowIndex].Cells[cellIndex];

            // remember the currently selected row and cell index
            rowIndex = dataGridViewInventory.CurrentCell.RowIndex;
            cellIndex = dataGridViewInventory.CurrentCell.ColumnIndex;

            dataGridViewInventory.Rows.Clear();
            foreach (Cargo cargo in player.GetPlayersCargoList())
            {
                dataGridViewInventory.Rows.Add(cargo.Name, cargo.Amount);
            }

            // reselect the right cell
            dataGridViewInventory.CurrentCell = dataGridViewInventory.Rows[rowIndex].Cells[cellIndex];
        }
        

        //purchase
        private void button6_Click(object sender, EventArgs e)
        {
            // buy the cargo from the current port
            try
            {
                // get the selected row from the port gridview and remember the name of the cargo
                String selectedCargoName = dataGridViewPort.CurrentRow.Cells[0].Value as string;

                if (controller.GetGame().PurchaseCargoFromPort(selectedCargoName).Equals(false))
                {
                    errorLabel.Text = eh.HandleException("NoGold");
                }
                else
                {
                    errorLabel.Text = "";
                }
                // update the view
                UpdateView();
            }
            catch(Exception er)
            {
                errorLabel.Text = eh.HandleException("SelectPort");
            }

        }

        //sell
        private void button5_Click(object sender, EventArgs e)
        {       
            // sell the cargo to the current port
            try
            {
                String selectedCargoName = dataGridViewInventory.CurrentRow.Cells[0].Value as string;

                if (controller.GetGame().SellCargoToPort(selectedCargoName).Equals(false))
                {
                    errorLabel.Text = eh.HandleException("DecreaseAmountPlayer");
                }
                else
                {
                    errorLabel.Text = "";
                }
            // update the view
            UpdateView();
            }
            catch (Exception er)
            {
                errorLabel.Text = eh.HandleException("SelectPort");
            }
        }

        private void EndTurn()
        {
            labelTimer.Text = controller.GetGame().EndTurn();
        }

        private void DisableCurrentButton(Button sender)
        {
            port1.Enabled = true;
            port2.Enabled = true;
            port3.Enabled = true;
            port4.Enabled = true;
            port5.Enabled = true;
            port6.Enabled = true;
            sender.Enabled = false;

            if (errorLabel.Text == eh.HandleException("SelectPort"))
            {
                errorLabel.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        //buyall
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedCargoName = dataGridViewPort.CurrentRow.Cells[0].Value as string;

                if (controller.GetGame().PurchaseCargoFromPortAll(selectedCargoName).Equals(false))
                {
                    errorLabel.Text = eh.HandleException("NoGold");
                }
                else
                {
                    errorLabel.Text = "";
                }
                // update the view
                UpdateView();
            }
            catch (Exception er)
            {
                errorLabel.Text = eh.HandleException("SelectPort");
            }
        }
        //sellall
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedCargoName = dataGridViewInventory.CurrentRow.Cells[0].Value as string;

                if (controller.GetGame().SellCargoToPortAll(selectedCargoName).Equals(false))
                {
                    errorLabel.Text = eh.HandleException("DecreaseAmountPlayer");
                }
                else
                {
                    errorLabel.Text = "";
                }
                // update the view
                UpdateView();
            }
            catch (Exception er)
            {
                errorLabel.Text = eh.HandleException("SelectPort");
            }
        }
    }
}
