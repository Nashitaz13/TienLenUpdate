namespace TienLenDoAn
{
    partial class Multiplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplayer));
            this.btnCreateRoom = new TienLenDoAn.CustomButton();
            this.btnJoinRoom = new TienLenDoAn.CustomButton();
            this.btnStart = new TienLenDoAn.CustomButton();
            this.ServerIPAdd = new System.Windows.Forms.TextBox();
            this.CodeRoom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateRoom.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateRoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreateRoom.BorderRadius = 40;
            this.btnCreateRoom.BorderSize = 0;
            this.btnCreateRoom.FlatAppearance.BorderSize = 0;
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateRoom.ForeColor = System.Drawing.Color.White;
            this.btnCreateRoom.Location = new System.Drawing.Point(453, 155);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(176, 70);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.TextColor = System.Drawing.Color.White;
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnJoinRoom.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnJoinRoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnJoinRoom.BorderRadius = 40;
            this.btnJoinRoom.BorderSize = 0;
            this.btnJoinRoom.FlatAppearance.BorderSize = 0;
            this.btnJoinRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnJoinRoom.ForeColor = System.Drawing.Color.White;
            this.btnJoinRoom.Location = new System.Drawing.Point(787, 155);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(176, 70);
            this.btnJoinRoom.TabIndex = 1;
            this.btnJoinRoom.Text = "Join Room";
            this.btnJoinRoom.TextColor = System.Drawing.Color.White;
            this.btnJoinRoom.UseVisualStyleBackColor = false;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStart.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStart.BorderRadius = 40;
            this.btnStart.BorderSize = 0;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(613, 454);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 70);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ServerIPAdd
            // 
            this.ServerIPAdd.Location = new System.Drawing.Point(769, 316);
            this.ServerIPAdd.Name = "ServerIPAdd";
            this.ServerIPAdd.Size = new System.Drawing.Size(222, 22);
            this.ServerIPAdd.TabIndex = 3;
            // 
            // CodeRoom
            // 
            this.CodeRoom.Location = new System.Drawing.Point(769, 272);
            this.CodeRoom.Name = "CodeRoom";
            this.CodeRoom.Size = new System.Drawing.Size(222, 22);
            this.CodeRoom.TabIndex = 4;
            this.CodeRoom.Visible = false;
            this.CodeRoom.TextChanged += new System.EventHandler(this.CodeRoom_TextChanged);
            // 
            // Multiplayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::TienLenDoAn.Properties.Resources._202;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 586);
            this.Controls.Add(this.CodeRoom);
            this.Controls.Add(this.ServerIPAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnJoinRoom);
            this.Controls.Add(this.btnCreateRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            this.Load += new System.EventHandler(this.Multiplayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnCreateRoom;
        private CustomButton btnJoinRoom;
        private CustomButton btnStart;
        private System.Windows.Forms.TextBox ServerIPAdd;
        private System.Windows.Forms.TextBox CodeRoom;
    }
}