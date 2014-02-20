namespace PirateWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.port1 = new System.Windows.Forms.Button();
            this.port2 = new System.Windows.Forms.Button();
            this.port3 = new System.Windows.Forms.Button();
            this.port4 = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.port5 = new System.Windows.Forms.Button();
            this.port6 = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.playerGold = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewPort = new System.Windows.Forms.DataGridView();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblPlayerInventory = new System.Windows.Forms.Label();
            this.lblPortsTradingGoods = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPort)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(326, 52);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(108, 38);
            this.port1.TabIndex = 0;
            this.port1.Text = "Tortuga";
            this.port1.UseVisualStyleBackColor = true;
            this.port1.Click += new System.EventHandler(this.port1_Click);
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(443, 52);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(108, 38);
            this.port2.TabIndex = 3;
            this.port2.Text = "Black Water Bay";
            this.port2.UseVisualStyleBackColor = true;
            this.port2.Click += new System.EventHandler(this.port2_Click);
            // 
            // port3
            // 
            this.port3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.port3.Location = new System.Drawing.Point(326, 96);
            this.port3.Name = "port3";
            this.port3.Size = new System.Drawing.Size(108, 38);
            this.port3.TabIndex = 4;
            this.port3.Text = "Providence";
            this.port3.UseVisualStyleBackColor = true;
            this.port3.Click += new System.EventHandler(this.port3_Click);
            // 
            // port4
            // 
            this.port4.Location = new System.Drawing.Point(443, 96);
            this.port4.Name = "port4";
            this.port4.Size = new System.Drawing.Size(108, 38);
            this.port4.TabIndex = 5;
            this.port4.Text = "Isla de Muerta";
            this.port4.UseVisualStyleBackColor = true;
            this.port4.Click += new System.EventHandler(this.port4_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(243, 329);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(77, 23);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(243, 204);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(77, 23);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "Buy";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.button6_Click);
            // 
            // port5
            // 
            this.port5.Location = new System.Drawing.Point(326, 140);
            this.port5.Name = "port5";
            this.port5.Size = new System.Drawing.Size(108, 38);
            this.port5.TabIndex = 8;
            this.port5.Text = "Shipwreck Cove";
            this.port5.UseVisualStyleBackColor = true;
            this.port5.Click += new System.EventHandler(this.port5_Click);
            // 
            // port6
            // 
            this.port6.Location = new System.Drawing.Point(443, 140);
            this.port6.Name = "port6";
            this.port6.Size = new System.Drawing.Size(108, 38);
            this.port6.TabIndex = 9;
            this.port6.Text = "Free Port";
            this.port6.UseVisualStyleBackColor = true;
            this.port6.Click += new System.EventHandler(this.port6_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPlayerName.Location = new System.Drawing.Point(8, 29);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(16, 22);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "-";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerGold
            // 
            this.playerGold.AutoSize = true;
            this.playerGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerGold.Location = new System.Drawing.Point(8, 52);
            this.playerGold.Name = "playerGold";
            this.playerGold.Size = new System.Drawing.Size(48, 20);
            this.playerGold.TabIndex = 11;
            this.playerGold.Text = "Cash";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryItem,
            this.inventoryQuantity});
            this.dataGridViewInventory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cargoBindingSource, "name", true));
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewInventory.Size = new System.Drawing.Size(225, 177);
            this.dataGridViewInventory.TabIndex = 13;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewPort
            // 
            this.dataGridViewPort.AllowUserToAddRows = false;
            this.dataGridViewPort.AllowUserToDeleteRows = false;
            this.dataGridViewPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portItem,
            this.portValue});
            this.dataGridViewPort.Location = new System.Drawing.Point(326, 204);
            this.dataGridViewPort.Name = "dataGridViewPort";
            this.dataGridViewPort.ReadOnly = true;
            this.dataGridViewPort.RowHeadersVisible = false;
            this.dataGridViewPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewPort.Size = new System.Drawing.Size(225, 177);
            this.dataGridViewPort.TabIndex = 13;
            this.dataGridViewPort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravel.Location = new System.Drawing.Point(411, 26);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(52, 25);
            this.lblTravel.TabIndex = 14;
            this.lblTravel.Text = "Sail";
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.Location = new System.Drawing.Point(9, 188);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(60, 13);
            this.lblPlayerInventory.TabIndex = 16;
            this.lblPlayerInventory.Text = "Your Cargo";
            // 
            // lblPortsTradingGoods
            // 
            this.lblPortsTradingGoods.AutoSize = true;
            this.lblPortsTradingGoods.Location = new System.Drawing.Point(323, 188);
            this.lblPortsTradingGoods.Name = "lblPortsTradingGoods";
            this.lblPortsTradingGoods.Size = new System.Drawing.Size(106, 13);
            this.lblPortsTradingGoods.TabIndex = 17;
            this.lblPortsTradingGoods.Text = "Port\'s Trading Goods";
            this.lblPortsTradingGoods.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(16, 140);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 18;
           
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelTimer.Location = new System.Drawing.Point(85, 72);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(27, 20);
            this.labelTimer.TabIndex = 19;
            this.labelTimer.Text = "30";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buy Max";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sell Max";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Days left:";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(PirateWars.Cargo);
            // 
            // inventoryItem
            // 
            this.inventoryItem.Frozen = true;
            this.inventoryItem.HeaderText = "Item";
            this.inventoryItem.Name = "inventoryItem";
            this.inventoryItem.ReadOnly = true;
            this.inventoryItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryItem.Width = 140;
            // 
            // inventoryQuantity
            // 
            this.inventoryQuantity.Frozen = true;
            this.inventoryQuantity.HeaderText = "Quantity";
            this.inventoryQuantity.Name = "inventoryQuantity";
            this.inventoryQuantity.ReadOnly = true;
            this.inventoryQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryQuantity.Width = 85;
            // 
            // portItem
            // 
            this.portItem.HeaderText = "Item";
            this.portItem.Name = "portItem";
            this.portItem.ReadOnly = true;
            this.portItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.portItem.Width = 140;
            // 
            // portValue
            // 
            this.portValue.HeaderText = "Value";
            this.portValue.Name = "portValue";
            this.portValue.ReadOnly = true;
            this.portValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.portValue.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.lblPortsTradingGoods);
            this.Controls.Add(this.lblPlayerInventory);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.dataGridViewPort);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.playerGold);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.port6);
            this.Controls.Add(this.port5);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.port4);
            this.Controls.Add(this.port3);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pirate Wars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPort)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button port1;
        private System.Windows.Forms.Button port2;
        private System.Windows.Forms.Button port3;
        private System.Windows.Forms.Button port4;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button port5;
        private System.Windows.Forms.Button port6;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label playerGold;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewPort;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblPlayerInventory;
        private System.Windows.Forms.Label lblPortsTradingGoods;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn portItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn portValue;
    }
}
