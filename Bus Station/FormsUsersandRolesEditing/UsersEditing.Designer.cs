namespace Bus_Station
{
    partial class UsersEditing
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
            this.tabCUserAndRoles = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.bUserEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bUserDelete = new System.Windows.Forms.Button();
            this.bUserCreate = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabPageRoles = new System.Windows.Forms.TabPage();
            this.bRoleEdit = new System.Windows.Forms.Button();
            this.bRoleExit = new System.Windows.Forms.Button();
            this.bRoleDelete = new System.Windows.Forms.Button();
            this.bRoleCreate = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.tabPageUserinRoles = new System.Windows.Forms.TabPage();
            this.bExit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.dgvUserinRoles = new System.Windows.Forms.DataGridView();
            this.bindingSourceUserinRoles = new System.Windows.Forms.BindingSource(this.components);
            this.tabCUserAndRoles.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPageRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.tabPageUserinRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUserinRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCUserAndRoles
            // 
            this.tabCUserAndRoles.Controls.Add(this.tabPageUsers);
            this.tabCUserAndRoles.Controls.Add(this.tabPageRoles);
            this.tabCUserAndRoles.Controls.Add(this.tabPageUserinRoles);
            this.tabCUserAndRoles.Location = new System.Drawing.Point(12, 12);
            this.tabCUserAndRoles.Name = "tabCUserAndRoles";
            this.tabCUserAndRoles.SelectedIndex = 0;
            this.tabCUserAndRoles.Size = new System.Drawing.Size(744, 447);
            this.tabCUserAndRoles.TabIndex = 0;
            this.tabCUserAndRoles.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCUserAndRoles_Selected);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.bUserEdit);
            this.tabPageUsers.Controls.Add(this.button2);
            this.tabPageUsers.Controls.Add(this.bUserDelete);
            this.tabPageUsers.Controls.Add(this.bUserCreate);
            this.tabPageUsers.Controls.Add(this.dgvUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(736, 421);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // bUserEdit
            // 
            this.bUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUserEdit.Location = new System.Drawing.Point(122, 383);
            this.bUserEdit.Name = "bUserEdit";
            this.bUserEdit.Size = new System.Drawing.Size(108, 32);
            this.bUserEdit.TabIndex = 17;
            this.bUserEdit.Text = "Edit";
            this.bUserEdit.UseVisualStyleBackColor = true;
            this.bUserEdit.Click += new System.EventHandler(this.bUserEdit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(632, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bUserDelete
            // 
            this.bUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUserDelete.Location = new System.Drawing.Point(236, 383);
            this.bUserDelete.Name = "bUserDelete";
            this.bUserDelete.Size = new System.Drawing.Size(108, 32);
            this.bUserDelete.TabIndex = 15;
            this.bUserDelete.Text = "Delete";
            this.bUserDelete.UseVisualStyleBackColor = true;
            this.bUserDelete.Click += new System.EventHandler(this.bUserDelete_Click);
            // 
            // bUserCreate
            // 
            this.bUserCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUserCreate.Location = new System.Drawing.Point(8, 383);
            this.bUserCreate.Name = "bUserCreate";
            this.bUserCreate.Size = new System.Drawing.Size(108, 32);
            this.bUserCreate.TabIndex = 14;
            this.bUserCreate.Text = "Create";
            this.bUserCreate.UseVisualStyleBackColor = true;
            this.bUserCreate.Click += new System.EventHandler(this.bUserCreate_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(7, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(723, 372);
            this.dgvUsers.TabIndex = 0;
            // 
            // tabPageRoles
            // 
            this.tabPageRoles.Controls.Add(this.bRoleEdit);
            this.tabPageRoles.Controls.Add(this.bRoleExit);
            this.tabPageRoles.Controls.Add(this.bRoleDelete);
            this.tabPageRoles.Controls.Add(this.bRoleCreate);
            this.tabPageRoles.Controls.Add(this.dgvRoles);
            this.tabPageRoles.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoles.Name = "tabPageRoles";
            this.tabPageRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoles.Size = new System.Drawing.Size(736, 421);
            this.tabPageRoles.TabIndex = 1;
            this.tabPageRoles.Text = "Roles";
            this.tabPageRoles.UseVisualStyleBackColor = true;
            // 
            // bRoleEdit
            // 
            this.bRoleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRoleEdit.Location = new System.Drawing.Point(120, 383);
            this.bRoleEdit.Name = "bRoleEdit";
            this.bRoleEdit.Size = new System.Drawing.Size(108, 32);
            this.bRoleEdit.TabIndex = 13;
            this.bRoleEdit.Text = "Edit";
            this.bRoleEdit.UseVisualStyleBackColor = true;
            this.bRoleEdit.Click += new System.EventHandler(this.bRoleEdit_Click);
            // 
            // bRoleExit
            // 
            this.bRoleExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRoleExit.Location = new System.Drawing.Point(630, 384);
            this.bRoleExit.Name = "bRoleExit";
            this.bRoleExit.Size = new System.Drawing.Size(96, 32);
            this.bRoleExit.TabIndex = 12;
            this.bRoleExit.Text = "Exit";
            this.bRoleExit.UseVisualStyleBackColor = true;
            this.bRoleExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bRoleDelete
            // 
            this.bRoleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRoleDelete.Location = new System.Drawing.Point(234, 383);
            this.bRoleDelete.Name = "bRoleDelete";
            this.bRoleDelete.Size = new System.Drawing.Size(108, 32);
            this.bRoleDelete.TabIndex = 11;
            this.bRoleDelete.Text = "Delete";
            this.bRoleDelete.UseVisualStyleBackColor = true;
            this.bRoleDelete.Click += new System.EventHandler(this.bRoleDelete_Click);
            // 
            // bRoleCreate
            // 
            this.bRoleCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRoleCreate.Location = new System.Drawing.Point(6, 383);
            this.bRoleCreate.Name = "bRoleCreate";
            this.bRoleCreate.Size = new System.Drawing.Size(108, 32);
            this.bRoleCreate.TabIndex = 10;
            this.bRoleCreate.Text = "Create";
            this.bRoleCreate.UseVisualStyleBackColor = true;
            this.bRoleCreate.Click += new System.EventHandler(this.bRoleCreate_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(7, 6);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(723, 371);
            this.dgvRoles.TabIndex = 1;
            // 
            // tabPageUserinRoles
            // 
            this.tabPageUserinRoles.Controls.Add(this.bExit);
            this.tabPageUserinRoles.Controls.Add(this.bDelete);
            this.tabPageUserinRoles.Controls.Add(this.bCreate);
            this.tabPageUserinRoles.Controls.Add(this.label1);
            this.tabPageUserinRoles.Controls.Add(this.cbUsers);
            this.tabPageUserinRoles.Controls.Add(this.dgvUserinRoles);
            this.tabPageUserinRoles.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserinRoles.Name = "tabPageUserinRoles";
            this.tabPageUserinRoles.Size = new System.Drawing.Size(736, 421);
            this.tabPageUserinRoles.TabIndex = 2;
            this.tabPageUserinRoles.Text = "UserinRoles";
            this.tabPageUserinRoles.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(634, 378);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(96, 32);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(124, 377);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(108, 32);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(10, 377);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(108, 32);
            this.bCreate.TabIndex = 6;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // cbUsers
            // 
            this.cbUsers.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(61, 12);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(121, 30);
            this.cbUsers.TabIndex = 3;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // dgvUserinRoles
            // 
            this.dgvUserinRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserinRoles.Location = new System.Drawing.Point(7, 48);
            this.dgvUserinRoles.Name = "dgvUserinRoles";
            this.dgvUserinRoles.Size = new System.Drawing.Size(723, 323);
            this.dgvUserinRoles.TabIndex = 1;
            // 
            // UsersEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(765, 471);
            this.Controls.Add(this.tabCUserAndRoles);
            this.Name = "UsersEditing";
            this.Text = "UsersEditing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersEditing_FormClosing);
            this.tabCUserAndRoles.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPageRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.tabPageUserinRoles.ResumeLayout(false);
            this.tabPageUserinRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUserinRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCUserAndRoles;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageRoles;
        private System.Windows.Forms.TabPage tabPageUserinRoles;
        private System.Windows.Forms.BindingSource bindingSourceUserinRoles;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridView dgvUserinRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bRoleEdit;
        private System.Windows.Forms.Button bRoleExit;
        private System.Windows.Forms.Button bRoleDelete;
        private System.Windows.Forms.Button bRoleCreate;
        private System.Windows.Forms.Button bUserEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bUserDelete;
        private System.Windows.Forms.Button bUserCreate;
    }
}