namespace Bus_Station
{
    partial class Schedule_Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Editing));
            this.bEditingBuses = new System.Windows.Forms.Button();
            this.bEditCities = new System.Windows.Forms.Button();
            this.bEditDiscount = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.binSourceBusStation = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFlight_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCityStart = new System.Windows.Forms.ComboBox();
            this.cbCityEnd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBuses = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDepartureTime = new System.Windows.Forms.TextBox();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalDateFlight = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            this.SuspendLayout();
            // 
            // bEditingBuses
            // 
            this.bEditingBuses.BackColor = System.Drawing.Color.Silver;
            this.bEditingBuses.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditingBuses.Location = new System.Drawing.Point(12, 493);
            this.bEditingBuses.Name = "bEditingBuses";
            this.bEditingBuses.Size = new System.Drawing.Size(149, 55);
            this.bEditingBuses.TabIndex = 0;
            this.bEditingBuses.Text = "Edit Buses";
            this.bEditingBuses.UseVisualStyleBackColor = false;
            this.bEditingBuses.Click += new System.EventHandler(this.bEditingBuses_Click);
            // 
            // bEditCities
            // 
            this.bEditCities.BackColor = System.Drawing.Color.Silver;
            this.bEditCities.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditCities.Location = new System.Drawing.Point(167, 493);
            this.bEditCities.Name = "bEditCities";
            this.bEditCities.Size = new System.Drawing.Size(149, 55);
            this.bEditCities.TabIndex = 1;
            this.bEditCities.Text = "Edit Cities";
            this.bEditCities.UseVisualStyleBackColor = false;
            this.bEditCities.Click += new System.EventHandler(this.bEditCities_Click);
            // 
            // bEditDiscount
            // 
            this.bEditDiscount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditDiscount.Location = new System.Drawing.Point(322, 493);
            this.bEditDiscount.Name = "bEditDiscount";
            this.bEditDiscount.Size = new System.Drawing.Size(164, 55);
            this.bEditDiscount.TabIndex = 2;
            this.bEditDiscount.Text = "Edit Discount";
            this.bEditDiscount.UseVisualStyleBackColor = true;
            this.bEditDiscount.Click += new System.EventHandler(this.bEditDiscount_Click);
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(675, 493);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(55, 55);
            this.bExit.TabIndex = 5;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSave.BackgroundImage")));
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(614, 493);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(55, 55);
            this.bSave.TabIndex = 6;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.Control;
            this.bDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDelete.BackgroundImage")));
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(553, 493);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(55, 55);
            this.bDelete.TabIndex = 7;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAdd.BackgroundImage")));
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(492, 493);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(55, 55);
            this.bAdd.TabIndex = 8;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Location = new System.Drawing.Point(12, 195);
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.Size = new System.Drawing.Size(719, 292);
            this.dgvBusStation.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Flight Number";
            // 
            // tbFlight_Number
            // 
            this.tbFlight_Number.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFlight_Number.Location = new System.Drawing.Point(143, 16);
            this.tbFlight_Number.Name = "tbFlight_Number";
            this.tbFlight_Number.Size = new System.Drawing.Size(142, 29);
            this.tbFlight_Number.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "City Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "City End";
            // 
            // cbCityStart
            // 
            this.cbCityStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCityStart.FormattingEnabled = true;
            this.cbCityStart.Location = new System.Drawing.Point(143, 51);
            this.cbCityStart.Name = "cbCityStart";
            this.cbCityStart.Size = new System.Drawing.Size(142, 30);
            this.cbCityStart.TabIndex = 14;
            // 
            // cbCityEnd
            // 
            this.cbCityEnd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCityEnd.FormattingEnabled = true;
            this.cbCityEnd.Location = new System.Drawing.Point(143, 87);
            this.cbCityEnd.Name = "cbCityEnd";
            this.cbCityEnd.Size = new System.Drawing.Size(142, 30);
            this.cbCityEnd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Buses";
            // 
            // cbBuses
            // 
            this.cbBuses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBuses.FormattingEnabled = true;
            this.cbBuses.Location = new System.Drawing.Point(143, 123);
            this.cbBuses.Name = "cbBuses";
            this.cbBuses.Size = new System.Drawing.Size(142, 30);
            this.cbBuses.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(367, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(364, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(367, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Arrival Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(364, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Arrival Time";
            // 
            // tbDepartureTime
            // 
            this.tbDepartureTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDepartureTime.Location = new System.Drawing.Point(530, 54);
            this.tbDepartureTime.Name = "tbDepartureTime";
            this.tbDepartureTime.Size = new System.Drawing.Size(200, 29);
            this.tbDepartureTime.TabIndex = 23;
            this.tbDepartureTime.Text = "00:00:00";
            this.tbDepartureTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArrivalTime.Location = new System.Drawing.Point(530, 126);
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(200, 29);
            this.tbArrivalTime.TabIndex = 25;
            this.tbArrivalTime.Text = "00:00:00";
            this.tbArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(318, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(364, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Final Date Flight";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(530, 19);
            this.dtpDepartureDate.MinDate = new System.DateTime(2015, 7, 5, 0, 0, 0, 0);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 29);
            this.dtpDepartureDate.TabIndex = 28;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(530, 91);
            this.dtpArrivalDate.MinDate = new System.DateTime(2015, 7, 5, 0, 0, 0, 0);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 29);
            this.dtpArrivalDate.TabIndex = 29;
            // 
            // dtpFinalDateFlight
            // 
            this.dtpFinalDateFlight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFinalDateFlight.Location = new System.Drawing.Point(530, 160);
            this.dtpFinalDateFlight.MinDate = new System.DateTime(2015, 7, 5, 0, 0, 0, 0);
            this.dtpFinalDateFlight.Name = "dtpFinalDateFlight";
            this.dtpFinalDateFlight.Size = new System.Drawing.Size(200, 29);
            this.dtpFinalDateFlight.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.Location = new System.Drawing.Point(143, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(142, 29);
            this.tbPrice.TabIndex = 32;
            // 
            // Schedule_Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(743, 560);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFinalDateFlight);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbArrivalTime);
            this.Controls.Add(this.tbDepartureTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBuses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCityEnd);
            this.Controls.Add(this.cbCityStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFlight_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusStation);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEditDiscount);
            this.Controls.Add(this.bEditCities);
            this.Controls.Add(this.bEditingBuses);
            this.Name = "Schedule_Editing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule_Editing";
            this.Activated += new System.EventHandler(this.Schedule_Editing_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schedule_Editing_FormClosing);
            this.Load += new System.EventHandler(this.Schedule_Editing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEditingBuses;
        private System.Windows.Forms.Button bEditCities;
        private System.Windows.Forms.Button bEditDiscount;
        protected System.Windows.Forms.Button bExit;
        protected System.Windows.Forms.Button bSave;
        protected System.Windows.Forms.Button bDelete;
        protected System.Windows.Forms.Button bAdd;
        protected System.Windows.Forms.BindingSource binSourceBusStation;
        protected System.Windows.Forms.DataGridView dgvBusStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFlight_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCityStart;
        private System.Windows.Forms.ComboBox cbCityEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBuses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDepartureTime;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.DateTimePicker dtpFinalDateFlight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPrice;
    }
}