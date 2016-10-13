namespace Bus_Station
{
    partial class Show_Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Tickets));
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.binSourceBusStation = new System.Windows.Forms.BindingSource(this.components);
            this.bBuyTicket = new System.Windows.Forms.Button();
            this.bDeleteTicket = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Location = new System.Drawing.Point(12, 12);
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.Size = new System.Drawing.Size(1192, 389);
            this.dgvBusStation.TabIndex = 49;
            // 
            // bBuyTicket
            // 
            this.bBuyTicket.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBuyTicket.Location = new System.Drawing.Point(12, 407);
            this.bBuyTicket.Name = "bBuyTicket";
            this.bBuyTicket.Size = new System.Drawing.Size(157, 47);
            this.bBuyTicket.TabIndex = 50;
            this.bBuyTicket.Text = "Buy Ticket";
            this.bBuyTicket.UseVisualStyleBackColor = true;
            this.bBuyTicket.Click += new System.EventHandler(this.bBuyTicket_Click);
            // 
            // bDeleteTicket
            // 
            this.bDeleteTicket.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDeleteTicket.Location = new System.Drawing.Point(176, 407);
            this.bDeleteTicket.Name = "bDeleteTicket";
            this.bDeleteTicket.Size = new System.Drawing.Size(157, 47);
            this.bDeleteTicket.TabIndex = 51;
            this.bDeleteTicket.Text = "Delete Ticket";
            this.bDeleteTicket.UseVisualStyleBackColor = true;
            this.bDeleteTicket.Click += new System.EventHandler(this.bDeleteTicket_Click);
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(339, 405);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(50, 49);
            this.bExit.TabIndex = 52;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Show_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1216, 461);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDeleteTicket);
            this.Controls.Add(this.bBuyTicket);
            this.Controls.Add(this.dgvBusStation);
            this.Name = "Show_Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_Tickets_FormClosing);
            this.Load += new System.EventHandler(this.Show_Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvBusStation;
        protected System.Windows.Forms.BindingSource binSourceBusStation;
        private System.Windows.Forms.Button bBuyTicket;
        private System.Windows.Forms.Button bDeleteTicket;
        protected System.Windows.Forms.Button bExit;
    }
}