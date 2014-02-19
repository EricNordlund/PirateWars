using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace PirateWars
{
    partial class Form1 : Form
    {
        
        private string pirateName;
        Controller controller;
        ExceptionHandler eh = new ExceptionHandler();
        int cellIndex;
        int rowIndex;
        
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

            this.playerGold.Text = controller.GetPlayerStartingGold() + " Golden Coins";

            foreach (Cargo cargo in controller.GetPlayersCargoList())
            {
                dataGridViewInventory.Rows.Add(cargo.Name, cargo.Amount);
            }
            
            controller.SetView(this);
        }



        private void port1_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        private void port2_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        private void port3_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        private void port4_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        private void port5_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        private void port6_Click(object sender, EventArgs e)
        {
            updatePort(sender);
        }

        public void UpdateView()
        {
            Player player = controller.GetGame().Player;
            Port port = controller.GetGame().GetCurrentPort();

            lblPlayerName.Text = "Welcome " + pirateName + ", to " + port.GetPortName() + ".";
            lblPortsTradingGoods.Text = port.GetPortName() + "s Trading Goods";
            
            playerGold.Text = player.Gold + " Golden Coins";
            

            // remember the currently selected row and cell index
        
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
            labelTimer.Text = controller.GetGame().Turn.ToString();
            
        }


        private void updatePort(object objSender)
        {
            Button sender = objSender as Button;
            DisableCurrentButton(sender);
            controller.UpdatePrices();
            try
            {
                rowIndex = dataGridViewPort.CurrentCell.RowIndex;
                cellIndex = dataGridViewPort.CurrentCell.ColumnIndex;
            }
            catch (Exception e)
            {
                Debug.Write(e);
            }

            dataGridViewPort.Rows.Clear();

            lblPlayerName.Text = "Welcome " + pirateName + ", to " + sender.Text + ".";
            lblPortsTradingGoods.Text = sender.Text + "'s Trading Goods";

            foreach (Cargo cargo in controller.GetPortsCargoList(sender.Text))
            {
                dataGridViewPort.Rows.Add(cargo.Name, cargo.Price);
            }
            
            dataGridViewPort.CurrentCell = dataGridViewPort.Rows[rowIndex].Cells[cellIndex];
            
           
        }

        // Purchase
        private void button6_Click(object sender, EventArgs e)
        {
            // buy the cargo from the current port
            try
            {
                // Get the selected row from the port gridview and remember the name of the cargo
                String selectedCargoName = dataGridViewPort.CurrentRow.Cells[0].Value as string;

                if (controller.GetGame().PurchaseCargoFromPort(selectedCargoName).Equals(false))
                {
                    errorLabel.Text = eh.HandleException("NoGold");
                }
                else
                {
                    errorLabel.Text = "";
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"goldDrop.wav");
                    //player.Play();
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
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"\\student.local\Files\Home\sys12jli\Desktop\goldDrop.wav");
                    //player.Play();
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
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"goldDrop.wav");
                    //player.Play();
                }
                // update the view
                UpdateView();
            }
            catch (Exception er)
            {
                errorLabel.Text = eh.HandleException("SelectPort");
            }
        }

        // Save
       private void button3_Click(object sender, EventArgs e)
        {
            controller.SaveGameState();
        }

        // Load
        private void button4_Click(object sender, EventArgs e)
        {
            controller.LoadGameState();
        }

        

    }
}
