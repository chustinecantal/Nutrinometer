namespace Nutrinometer
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btn_signup = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtbox_username = new TextBox();
            txtbox_pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            check_pass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_signup);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 448);
            panel1.TabIndex = 0;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.PaleGreen;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signup.Location = new Point(97, 373);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(95, 35);
            btn_signup.TabIndex = 8;
            btn_signup.Text = "SignUp";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 339);
            label4.Name = "label4";
            label4.Size = new Size(160, 18);
            label4.TabIndex = 8;
            label4.Text = "Register Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(340, 149);
            txtbox_username.Multiline = true;
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(367, 30);
            txtbox_username.TabIndex = 2;
            txtbox_username.TextChanged += txtbox_username_TextChanged;
            // 
            // txtbox_pass
            // 
            txtbox_pass.Location = new Point(340, 227);
            txtbox_pass.Multiline = true;
            txtbox_pass.Name = "txtbox_pass";
            txtbox_pass.Size = new Size(367, 30);
            txtbox_pass.TabIndex = 3;
            txtbox_pass.TextChanged += txtbox_pass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 128);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 206);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.PaleGreen;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(476, 340);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(100, 40);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // check_pass
            // 
            check_pass.AutoSize = true;
            check_pass.Location = new Point(599, 263);
            check_pass.Name = "check_pass";
            check_pass.Size = new Size(108, 19);
            check_pass.TabIndex = 7;
            check_pass.Text = "Show Password";
            check_pass.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(check_pass);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbox_pass);
            Controls.Add(txtbox_username);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Login";
            Text = "Portal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtbox_username;
        private TextBox txtbox_pass;
        private Label label2;
        private Label label3;
        private Button btn_login;
        private CheckBox check_pass;
        private Button btn_signup;
        private Label label4;
    }
}
