namespace Bus_Station
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bTicket = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bScheduleEditing = new System.Windows.Forms.Button();
            this.bUsersEditing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bTicket
            // 
            this.bTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTicket.BackgroundImage")));
            this.bTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTicket.Location = new System.Drawing.Point(431, 101);
            this.bTicket.Name = "bTicket";
            this.bTicket.Size = new System.Drawing.Size(317, 93);
            this.bTicket.TabIndex = 2;
            this.bTicket.UseVisualStyleBackColor = true;
            this.bTicket.Click += new System.EventHandler(this.bTicket_Click);
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(431, 202);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(316, 82);
            this.bExit.TabIndex = 3;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bScheduleEditing
            // 
            this.bScheduleEditing.AutoEllipsis = true;
            this.bScheduleEditing.BackColor = System.Drawing.Color.RoyalBlue;
            this.bScheduleEditing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bScheduleEditing.ForeColor = System.Drawing.Color.Maroon;
            this.bScheduleEditing.Location = new System.Drawing.Point(432, 13);
            this.bScheduleEditing.Name = "bScheduleEditing";
            this.bScheduleEditing.Size = new System.Drawing.Size(149, 82);
            this.bScheduleEditing.TabIndex = 1;
            this.bScheduleEditing.Text = "Составление расписания";
            this.bScheduleEditing.UseVisualStyleBackColor = false;
            this.bScheduleEditing.Click += new System.EventHandler(this.bScheduleEditing_Click);
            // 
            // bUsersEditing
            // 
            this.bUsersEditing.AutoEllipsis = true;
            this.bUsersEditing.BackColor = System.Drawing.Color.RoyalBlue;
            this.bUsersEditing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUsersEditing.ForeColor = System.Drawing.Color.Maroon;
            this.bUsersEditing.Location = new System.Drawing.Point(587, 12);
            this.bUsersEditing.Name = "bUsersEditing";
            this.bUsersEditing.Size = new System.Drawing.Size(163, 82);
            this.bUsersEditing.TabIndex = 4;
            this.bUsersEditing.Text = "Редактирование пользователей";
            this.bUsersEditing.UseVisualStyleBackColor = false;
            this.bUsersEditing.Click += new System.EventHandler(this.bUsersEditing_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 295);
            this.Controls.Add(this.bUsersEditing);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bTicket);
            this.Controls.Add(this.bScheduleEditing);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button bTicket;
        public System.Windows.Forms.Button bScheduleEditing;
        public System.Windows.Forms.Button bUsersEditing;
        public System.Windows.Forms.Button bExit;
    }
}

