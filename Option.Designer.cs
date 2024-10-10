namespace TienLenDoAn
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlyerName = new System.Windows.Forms.TextBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.odlAvatar = new System.Windows.Forms.OpenFileDialog();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name:";
            // 
            // txtPlyerName
            // 
            this.txtPlyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlyerName.Location = new System.Drawing.Point(154, 20);
            this.txtPlyerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlyerName.Name = "txtPlyerName";
            this.txtPlyerName.Size = new System.Drawing.Size(152, 23);
            this.txtPlyerName.TabIndex = 5;
            this.txtPlyerName.Text = "Player Name";
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAvatar.Location = new System.Drawing.Point(168, 82);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(93, 86);
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            this.pbxAvatar.Click += new System.EventHandler(this.pbxAvatar_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBrowse.Location = new System.Drawing.Point(40, 141);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(89, 27);
            this.cmdBrowse.TabIndex = 6;
            this.cmdBrowse.Text = "Change...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player Avatar";
            // 
            // odlAvatar
            // 
            this.odlAvatar.Filter = "JPEG files|*.jpg";
            this.odlAvatar.InitialDirectory = "avatarpath";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(208, 203);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 28);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(100, 203);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(100, 28);
            this.cmdOk.TabIndex = 8;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TienLenDoAn.Properties.Resources.bgrst;
            this.ClientSize = new System.Drawing.Size(314, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlyerName);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlyerName;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog odlAvatar;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOk;
    }
}