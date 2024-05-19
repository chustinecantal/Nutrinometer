namespace CalorieTracker
{
    partial class Dashboard
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
            this.signOut = new System.Windows.Forms.PictureBox();
            this.foodList = new System.Windows.Forms.PictureBox();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.foodListBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.signOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signOut
            // 
            this.signOut.Image = global::CalorieTracker.Properties.Resources.logout_256;
            this.signOut.Location = new System.Drawing.Point(46, 432);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(56, 50);
            this.signOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signOut.TabIndex = 0;
            this.signOut.TabStop = false;
            // 
            // foodList
            // 
            this.foodList.Image = global::CalorieTracker.Properties.Resources.add_list_256;
            this.foodList.Location = new System.Drawing.Point(46, 364);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(56, 50);
            this.foodList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodList.TabIndex = 0;
            this.foodList.TabStop = false;
            // 
            // userLogo
            // 
            this.userLogo.Image = global::CalorieTracker.Properties.Resources.UserLogo;
            this.userLogo.Location = new System.Drawing.Point(101, 43);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(111, 97);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLogo.TabIndex = 1;
            this.userLogo.TabStop = false;
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.signOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.ForeColor = System.Drawing.Color.White;
            this.signOutBtn.Location = new System.Drawing.Point(126, 431);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(141, 51);
            this.signOutBtn.TabIndex = 3;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = false;
            // 
            // foodListBtn
            // 
            this.foodListBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.foodListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListBtn.ForeColor = System.Drawing.Color.White;
            this.foodListBtn.Location = new System.Drawing.Point(126, 363);
            this.foodListBtn.Name = "foodListBtn";
            this.foodListBtn.Size = new System.Drawing.Size(141, 51);
            this.foodListBtn.TabIndex = 2;
            this.foodListBtn.Text = "Food List";
            this.foodListBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.dashboardBtn.Location = new System.Drawing.Point(126, 297);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(141, 51);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.foodList);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signOutBtn);
            this.panel1.Controls.Add(this.foodListBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.userLogo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 506);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalorieTracker.Properties.Resources.dashboard_256;
            this.pictureBox1.Location = new System.Drawing.Point(46, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(344, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 153);
            this.panel2.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(987, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.signOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox signOut;
        private System.Windows.Forms.PictureBox foodList;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Button foodListBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}