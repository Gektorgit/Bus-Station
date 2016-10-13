namespace Bus_Station
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.label2 = new System.Windows.Forms.Label();
            this.cbCityStart = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCityEnd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSeats = new System.Windows.Forms.ComboBox();
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.binSourceBusStation = new System.Windows.Forms.BindingSource(this.components);
            this.bExit = new System.Windows.Forms.Button();
            this.bBuyTicket = new System.Windows.Forms.Button();
            this.bShowFlights = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.bShowTickets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "City Start";
            // 
            // cbCityStart
            // 
            this.cbCityStart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCityStart.FormattingEnabled = true;
            this.cbCityStart.Location = new System.Drawing.Point(186, 9);
            this.cbCityStart.Name = "cbCityStart";
            this.cbCityStart.Size = new System.Drawing.Size(219, 34);
            this.cbCityStart.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "City End";
            // 
            // cbCityEnd
            // 
            this.cbCityEnd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCityEnd.FormattingEnabled = true;
            this.cbCityEnd.Location = new System.Drawing.Point(555, 9);
            this.cbCityEnd.Name = "cbCityEnd";
            this.cbCityEnd.Size = new System.Drawing.Size(176, 34);
            this.cbCityEnd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Departure Date";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(186, 58);
            this.dtpDepartureDate.MinDate = new System.DateTime(2015, 7, 5, 0, 0, 0, 0);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(219, 35);
            this.dtpDepartureDate.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(433, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 26);
            this.label9.TabIndex = 42;
            this.label9.Text = "Seats";
            // 
            // cbSeats
            // 
            this.cbSeats.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSeats.FormattingEnabled = true;
            this.cbSeats.Location = new System.Drawing.Point(555, 55);
            this.cbSeats.Name = "cbSeats";
            this.cbSeats.Size = new System.Drawing.Size(176, 34);
            this.cbSeats.TabIndex = 43;
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Location = new System.Drawing.Point(12, 142);
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.Size = new System.Drawing.Size(719, 345);
            this.dgvBusStation.TabIndex = 48;
            this.dgvBusStation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBusStation_MouseDoubleClick);
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(676, 493);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(55, 55);
            this.bExit.TabIndex = 49;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bBuyTicket
            // 
            this.bBuyTicket.BackColor = System.Drawing.Color.Silver;
            this.bBuyTicket.Enabled = false;
            this.bBuyTicket.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBuyTicket.Location = new System.Drawing.Point(12, 493);
            this.bBuyTicket.Name = "bBuyTicket";
            this.bBuyTicket.Size = new System.Drawing.Size(149, 55);
            this.bBuyTicket.TabIndex = 50;
            this.bBuyTicket.Text = "Buy Ticket";
            this.bBuyTicket.UseVisualStyleBackColor = false;
            this.bBuyTicket.Click += new System.EventHandler(this.bBuyTicket_Click);
            // 
            // bShowFlights
            // 
            this.bShowFlights.BackColor = System.Drawing.Color.Silver;
            this.bShowFlights.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowFlights.Location = new System.Drawing.Point(338, 493);
            this.bShowFlights.Name = "bShowFlights";
            this.bShowFlights.Size = new System.Drawing.Size(160, 55);
            this.bShowFlights.TabIndex = 51;
            this.bShowFlights.Text = "Show Flights";
            this.bShowFlights.UseVisualStyleBackColor = false;
            this.bShowFlights.Click += new System.EventHandler(this.bShowFlights_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Discount";
            // 
            // cbDiscount
            // 
            this.cbDiscount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(186, 102);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(219, 34);
            this.cbDiscount.TabIndex = 53;
            // 
            // bShowTickets
            // 
            this.bShowTickets.BackColor = System.Drawing.Color.Silver;
            this.bShowTickets.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowTickets.Location = new System.Drawing.Point(167, 493);
            this.bShowTickets.Name = "bShowTickets";
            this.bShowTickets.Size = new System.Drawing.Size(160, 55);
            this.bShowTickets.TabIndex = 54;
            this.bShowTickets.Text = "Show Tickets";
            this.bShowTickets.UseVisualStyleBackColor = false;
            this.bShowTickets.Click += new System.EventHandler(this.bShowTickets_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(743, 560);
            this.Controls.Add(this.bShowTickets);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bShowFlights);
            this.Controls.Add(this.bBuyTicket);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.dgvBusStation);
            this.Controls.Add(this.cbSeats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCityEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCityStart);
            this.Controls.Add(this.label2);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCityStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCityEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSeats;
        protected System.Windows.Forms.DataGridView dgvBusStation;
        protected System.Windows.Forms.BindingSource binSourceBusStation;
        protected System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bBuyTicket;
        private System.Windows.Forms.Button bShowFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Button bShowTickets;
    }
}