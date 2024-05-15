namespace Nutrinometer
{
    partial class SignUp
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
            label1 = new Label();
            txtbox_fname = new TextBox();
            txtbox_Lname = new TextBox();
            txtbox_username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtbox_age = new TextBox();
            txtbox_height = new TextBox();
            txtbox_weight = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbox_sex = new ComboBox();
            cmbox_actlevel = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 0;
            label1.Text = "SignUp Form";
            // 
            // txtbox_fname
            // 
            txtbox_fname.Location = new Point(13, 92);
            txtbox_fname.Multiline = true;
            txtbox_fname.Name = "txtbox_fname";
            txtbox_fname.Size = new Size(230, 32);
            txtbox_fname.TabIndex = 1;
            txtbox_fname.TextChanged += txtbox_fname_TextChanged;
            // 
            // txtbox_Lname
            // 
            txtbox_Lname.Location = new Point(291, 92);
            txtbox_Lname.Multiline = true;
            txtbox_Lname.Name = "txtbox_Lname";
            txtbox_Lname.Size = new Size(230, 32);
            txtbox_Lname.TabIndex = 2;
            txtbox_Lname.TextChanged += txtbox_Lname_TextChanged;
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(558, 92);
            txtbox_username.Multiline = true;
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(230, 32);
            txtbox_username.TabIndex = 3;
            txtbox_username.TextChanged += txtbox_username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 70);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(558, 70);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // txtbox_age
            // 
            txtbox_age.Location = new Point(291, 194);
            txtbox_age.Multiline = true;
            txtbox_age.Name = "txtbox_age";
            txtbox_age.Size = new Size(123, 32);
            txtbox_age.TabIndex = 8;
            txtbox_age.TextChanged += txtbox_age_TextChanged;
            // 
            // txtbox_height
            // 
            txtbox_height.Location = new Point(558, 194);
            txtbox_height.Multiline = true;
            txtbox_height.Name = "txtbox_height";
            txtbox_height.Size = new Size(123, 32);
            txtbox_height.TabIndex = 9;
            txtbox_height.TextChanged += txtbox_height_TextChanged;
            // 
            // txtbox_weight
            // 
            txtbox_weight.Location = new Point(13, 295);
            txtbox_weight.Multiline = true;
            txtbox_weight.Name = "txtbox_weight";
            txtbox_weight.Size = new Size(123, 32);
            txtbox_weight.TabIndex = 10;
            txtbox_weight.TextChanged += txtbox_weight_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 172);
            label5.Name = "label5";
            label5.Size = new Size(34, 19);
            label5.TabIndex = 11;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(558, 172);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 12;
            label6.Text = "Height (cm)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 273);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 13;
            label7.Text = "Weight (kg)";
            // 
            // cmbox_sex
            // 
            cmbox_sex.FormattingEnabled = true;
            cmbox_sex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbox_sex.Location = new Point(19, 205);
            cmbox_sex.Name = "cmbox_sex";
            cmbox_sex.Size = new Size(138, 23);
            cmbox_sex.TabIndex = 14;
            cmbox_sex.SelectedIndexChanged += cmbox_sex_SelectedIndexChanged;
            // 
            // cmbox_actlevel
            // 
            cmbox_actlevel.FormattingEnabled = true;
            cmbox_actlevel.Items.AddRange(new object[] { "Sedentary", "Lightly Active", "Moderately Active", "Very Active" });
            cmbox_actlevel.Location = new Point(291, 304);
            cmbox_actlevel.Name = "cmbox_actlevel";
            cmbox_actlevel.Size = new Size(157, 23);
            cmbox_actlevel.TabIndex = 15;
            cmbox_actlevel.SelectedIndexChanged += cmbox_actlevel_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 172);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(32, 19);
            label8.TabIndex = 16;
            label8.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(291, 273);
            label9.Name = "label9";
            label9.Size = new Size(92, 19);
            label9.TabIndex = 17;
            label9.Text = "Activity Level";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.ForestGreen;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(558, 391);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(135, 36);
            btn_register.TabIndex = 18;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_register);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cmbox_actlevel);
            Controls.Add(cmbox_sex);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtbox_weight);
            Controls.Add(txtbox_height);
            Controls.Add(txtbox_age);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbox_username);
            Controls.Add(txtbox_Lname);
            Controls.Add(txtbox_fname);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbox_fname;
        private TextBox txtbox_Lname;
        private TextBox txtbox_username;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbox_age;
        private TextBox txtbox_height;
        private TextBox txtbox_weight;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbox_sex;
        private ComboBox cmbox_actlevel;
        private Label label8;
        private Label label9;
        private Button btn_register;
    }
}