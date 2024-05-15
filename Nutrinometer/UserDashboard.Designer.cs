namespace Nutrinometer
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel_inputfood = new Panel();
            btn_showstatus = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btn_deleteintake = new Button();
            btn_addintake = new Button();
            txtbox_portion = new TextBox();
            txtbox_foodinput = new TextBox();
            combo_category = new ComboBox();
            combo_meals = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            dateTimePick_intake = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel_printfoodinput = new Panel();
            label2 = new Label();
            lbl_showuserinfo = new Label();
            label4 = new Label();
            btn_signout = new Button();
            panel_inputfood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_inputfood
            // 
            panel_inputfood.BackColor = Color.White;
            panel_inputfood.Controls.Add(btn_showstatus);
            panel_inputfood.Controls.Add(label8);
            panel_inputfood.Controls.Add(label7);
            panel_inputfood.Controls.Add(label6);
            panel_inputfood.Controls.Add(label5);
            panel_inputfood.Controls.Add(btn_deleteintake);
            panel_inputfood.Controls.Add(btn_addintake);
            panel_inputfood.Controls.Add(txtbox_portion);
            panel_inputfood.Controls.Add(txtbox_foodinput);
            panel_inputfood.Controls.Add(combo_category);
            panel_inputfood.Controls.Add(combo_meals);
            panel_inputfood.Controls.Add(label3);
            panel_inputfood.Controls.Add(label1);
            panel_inputfood.Controls.Add(dateTimePick_intake);
            panel_inputfood.Controls.Add(pictureBox2);
            panel_inputfood.Location = new Point(201, 1);
            panel_inputfood.Name = "panel_inputfood";
            panel_inputfood.Size = new Size(598, 234);
            panel_inputfood.TabIndex = 0;
            // 
            // btn_showstatus
            // 
            btn_showstatus.BackColor = Color.Green;
            btn_showstatus.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_showstatus.ForeColor = Color.White;
            btn_showstatus.Location = new Point(444, 187);
            btn_showstatus.Name = "btn_showstatus";
            btn_showstatus.Size = new Size(82, 30);
            btn_showstatus.TabIndex = 15;
            btn_showstatus.Text = "RESULTS";
            btn_showstatus.UseVisualStyleBackColor = false;
            btn_showstatus.Click += btn_showstatus_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(237, 110);
            label8.Name = "label8";
            label8.Size = new Size(126, 17);
            label8.TabIndex = 14;
            label8.Text = "Number of Portion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 110);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 13;
            label7.Text = "Food/Drinks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(237, 47);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 12;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 47);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 11;
            label5.Text = "Meals";
            // 
            // btn_deleteintake
            // 
            btn_deleteintake.BackColor = Color.Green;
            btn_deleteintake.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deleteintake.ForeColor = Color.White;
            btn_deleteintake.Location = new Point(237, 187);
            btn_deleteintake.Name = "btn_deleteintake";
            btn_deleteintake.Size = new Size(82, 30);
            btn_deleteintake.TabIndex = 10;
            btn_deleteintake.Text = "DELETE";
            btn_deleteintake.UseVisualStyleBackColor = false;
            btn_deleteintake.Click += btn_deleteintake_Click;
            // 
            // btn_addintake
            // 
            btn_addintake.BackColor = Color.Green;
            btn_addintake.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addintake.ForeColor = Color.White;
            btn_addintake.Location = new Point(8, 187);
            btn_addintake.Name = "btn_addintake";
            btn_addintake.Size = new Size(82, 30);
            btn_addintake.TabIndex = 9;
            btn_addintake.Text = "ADD";
            btn_addintake.UseVisualStyleBackColor = false;
            btn_addintake.Click += btn_addintake_Click;
            // 
            // txtbox_portion
            // 
            txtbox_portion.Location = new Point(237, 130);
            txtbox_portion.Name = "txtbox_portion";
            txtbox_portion.Size = new Size(133, 23);
            txtbox_portion.TabIndex = 8;
            // 
            // txtbox_foodinput
            // 
            txtbox_foodinput.Location = new Point(8, 130);
            txtbox_foodinput.Name = "txtbox_foodinput";
            txtbox_foodinput.Size = new Size(180, 23);
            txtbox_foodinput.TabIndex = 7;
            // 
            // combo_category
            // 
            combo_category.FormattingEnabled = true;
            combo_category.Items.AddRange(new object[] { "Fruits", "Vegetables", "Meat", "Seafood", "Drinks" });
            combo_category.Location = new Point(237, 67);
            combo_category.Name = "combo_category";
            combo_category.Size = new Size(133, 23);
            combo_category.TabIndex = 6;
            // 
            // combo_meals
            // 
            combo_meals.FormattingEnabled = true;
            combo_meals.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner" });
            combo_meals.Location = new Point(8, 70);
            combo_meals.Name = "combo_meals";
            combo_meals.Size = new Size(133, 23);
            combo_meals.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(496, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 2;
            label1.Text = "Food Intake";
            // 
            // dateTimePick_intake
            // 
            dateTimePick_intake.CalendarFont = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePick_intake.CalendarMonthBackground = Color.Green;
            dateTimePick_intake.Format = DateTimePickerFormat.Custom;
            dateTimePick_intake.ImeMode = ImeMode.NoControl;
            dateTimePick_intake.Location = new Point(52, 3);
            dateTimePick_intake.Name = "dateTimePick_intake";
            dateTimePick_intake.Size = new Size(97, 23);
            dateTimePick_intake.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(505, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel_printfoodinput
            // 
            panel_printfoodinput.AutoScroll = true;
            panel_printfoodinput.BackColor = Color.LemonChiffon;
            panel_printfoodinput.BorderStyle = BorderStyle.FixedSingle;
            panel_printfoodinput.Location = new Point(201, 258);
            panel_printfoodinput.Name = "panel_printfoodinput";
            panel_printfoodinput.Size = new Size(598, 191);
            panel_printfoodinput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(429, 238);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 3;
            label2.Text = "Food Lists";
            // 
            // lbl_showuserinfo
            // 
            lbl_showuserinfo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_showuserinfo.ForeColor = Color.White;
            lbl_showuserinfo.Location = new Point(12, 101);
            lbl_showuserinfo.Name = "lbl_showuserinfo";
            lbl_showuserinfo.Size = new Size(183, 306);
            lbl_showuserinfo.TabIndex = 4;
            lbl_showuserinfo.Click += lbl_showuserinfo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 84);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 5;
            label4.Text = "User Info";
            // 
            // btn_signout
            // 
            btn_signout.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signout.Location = new Point(42, 418);
            btn_signout.Name = "btn_signout";
            btn_signout.Size = new Size(100, 31);
            btn_signout.TabIndex = 6;
            btn_signout.Text = "Sign Out";
            btn_signout.UseVisualStyleBackColor = true;
            btn_signout.Click += btn_signout_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_signout);
            Controls.Add(label4);
            Controls.Add(lbl_showuserinfo);
            Controls.Add(label2);
            Controls.Add(panel_printfoodinput);
            Controls.Add(pictureBox1);
            Controls.Add(panel_inputfood);
            MaximizeBox = false;
            Name = "UserDashboard";
            Text = "UserDashboard";
            panel_inputfood.ResumeLayout(false);
            panel_inputfood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_inputfood;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel_printfoodinput;
        private DateTimePicker dateTimePick_intake;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_showuserinfo;
        private Label label4;
        private Button btn_signout;
        private TextBox txtbox_foodinput;
        private ComboBox combo_category;
        private ComboBox combo_meals;
        private Button btn_deleteintake;
        private Button btn_addintake;
        private TextBox txtbox_portion;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_showstatus;
    }
}