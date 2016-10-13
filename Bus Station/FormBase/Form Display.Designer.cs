namespace Bus_Station
{
    partial class Form_Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Display));
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.binSourceBusStation = new System.Windows.Forms.BindingSource(this.components);
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Location = new System.Drawing.Point(13, 13);
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.Size = new System.Drawing.Size(625, 414);
            this.dgvBusStation.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAdd.BackgroundImage")));
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(319, 434);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(76, 68);
            this.bAdd.TabIndex = 1;
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.Control;
            this.bDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDelete.BackgroundImage")));
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(401, 434);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 68);
            this.bDelete.TabIndex = 2;
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSave.BackgroundImage")));
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(482, 434);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 68);
            this.bSave.TabIndex = 3;
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(563, 434);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 68);
            this.bExit.TabIndex = 4;
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // Form_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(658, 511);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvBusStation);
            this.Name = "Form_Display";
            this.Text = "Form_Display";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSourceBusStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvBusStation;
        protected System.Windows.Forms.Button bAdd;
        protected System.Windows.Forms.Button bDelete;
        protected System.Windows.Forms.Button bSave;
        protected System.Windows.Forms.Button bExit;
        protected System.Windows.Forms.BindingSource binSourceBusStation;
    }
}