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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.port1 = new System.Windows.Forms.Button();
            this.port2 = new System.Windows.Forms.Button();
            this.port3 = new System.Windows.Forms.Button();
            this.port4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.port5 = new System.Windows.Forms.Button();
            this.port6 = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.inventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPort = new System.Windows.Forms.DataGridView();
            this.portItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(392, 83);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(99, 38);
            this.port1.TabIndex = 0;
            this.port1.Text = "Tortuga";
            this.port1.UseVisualStyleBackColor = true;
            this.port1.Click += new System.EventHandler(this.port1_Click);
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(506, 83);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(99, 38);
            this.port2.TabIndex = 3;
            this.port2.Text = "Black Water Bay";
            this.port2.UseVisualStyleBackColor = true;
            this.port2.Click += new System.EventHandler(this.port2_Click);
            // 
            // port3
            // 
            this.port3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.port3.Location = new System.Drawing.Point(392, 127);
            this.port3.Name = "port3";
            this.port3.Size = new System.Drawing.Size(99, 38);
            this.port3.TabIndex = 4;
            this.port3.Text = "Providence";
            this.port3.UseVisualStyleBackColor = true;
            this.port3.Click += new System.EventHandler(this.port3_Click);
            // 
            // port4
            // 
            this.port4.Location = new System.Drawing.Point(506, 127);
            this.port4.Name = "port4";
            this.port4.Size = new System.Drawing.Size(99, 38);
            this.port4.TabIndex = 5;
            this.port4.Text = "Isla de Muerta";
            this.port4.UseVisualStyleBackColor = true;
            this.port4.Click += new System.EventHandler(this.port4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sell";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Purchase";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // port5
            // 
            this.port5.Location = new System.Drawing.Point(392, 171);
            this.port5.Name = "port5";
            this.port5.Size = new System.Drawing.Size(99, 38);
            this.port5.TabIndex = 8;
            this.port5.Text = "Shipwreck Cove";
            this.port5.UseVisualStyleBackColor = true;
            this.port5.Click += new System.EventHandler(this.port5_Click);
            // 
            // port6
            // 
            this.port6.Location = new System.Drawing.Point(506, 171);
            this.port6.Name = "port6";
            this.port6.Size = new System.Drawing.Size(99, 38);
            this.port6.TabIndex = 9;
            this.port6.Text = "Free Port";
            this.port6.UseVisualStyleBackColor = true;
            this.port6.Click += new System.EventHandler(this.port6_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(22, 25);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(19, 25);
            this.playerName.TabIndex = 10;
            this.playerName.Text = "-";
            this.playerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(36, 70);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(48, 20);
            this.cash.TabIndex = 11;
            this.cash.Text = "Cash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryItem,
            this.inventoryValue,
            this.inventoryQuantity});
            this.dataGridViewInventory.Location = new System.Drawing.Point(28, 252);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.Size = new System.Drawing.Size(244, 215);
            this.dataGridViewInventory.TabIndex = 13;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inventoryItem
            // 
            this.inventoryItem.HeaderText = "Item";
            this.inventoryItem.Name = "inventoryItem";
            this.inventoryItem.ReadOnly = true;
            // 
            // inventoryValue
            // 
            this.inventoryValue.HeaderText = "Value";
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.ReadOnly = true;
            this.inventoryValue.Width = 50;
            // 
            // inventoryQuantity
            // 
            this.inventoryQuantity.HeaderText = "Quantity";
            this.inventoryQuantity.Name = "inventoryQuantity";
            this.inventoryQuantity.ReadOnly = true;
            this.inventoryQuantity.Width = 50;
            // 
            // dataGridViewPort
            // 
            this.dataGridViewPort.AllowUserToAddRows = false;
            this.dataGridViewPort.AllowUserToDeleteRows = false;
            this.dataGridViewPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portItem,
            this.portValue,
            this.portQuantity});
            this.dataGridViewPort.Location = new System.Drawing.Point(392, 252);
            this.dataGridViewPort.Name = "dataGridViewPort";
            this.dataGridViewPort.ReadOnly = true;
            this.dataGridViewPort.Size = new System.Drawing.Size(244, 215);
            this.dataGridViewPort.TabIndex = 13;
            this.dataGridViewPort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // portItem
            // 
            this.portItem.HeaderText = "Item";
            this.portItem.Name = "portItem";
            this.portItem.ReadOnly = true;
            // 
            // portValue
            // 
            this.portValue.HeaderText = "Value";
            this.portValue.Name = "portValue";
            this.portValue.ReadOnly = true;
            this.portValue.Width = 50;
            // 
            // portQuantity
            // 
            this.portQuantity.HeaderText = "Quantity";
            this.portQuantity.Name = "portQuantity";
            this.portQuantity.ReadOnly = true;
            this.portQuantity.Width = 50;
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravel.Location = new System.Drawing.Point(461, 40);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(78, 25);
            this.lblTravel.TabIndex = 14;
            this.lblTravel.Text = "Travel";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(37, 104);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(47, 17);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 503);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.dataGridViewPort);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.port6);
            this.Controls.Add(this.port5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.port4);
            this.Controls.Add(this.port3);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Name = "Form1";
            this.Text = "Pirate Wars ultra alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button port1;
        private System.Windows.Forms.Button port2;
        private System.Windows.Forms.Button port3;
        private System.Windows.Forms.Button port4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button port5;
        private System.Windows.Forms.Button port6;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQuantity;
        private System.Windows.Forms.DataGridView dataGridViewPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn portItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn portValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn portQuantity;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblPoints;
    }
}

