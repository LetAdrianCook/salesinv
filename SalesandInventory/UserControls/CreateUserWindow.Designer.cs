namespace SalesandInventory.UserControls
{
    partial class CreateUserWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            createUserbtn = new Button();
            groupBox3 = new GroupBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            creLastname = new TextBox();
            creMidname = new TextBox();
            creFirstname = new TextBox();
            pictureBox4 = new PictureBox();
            birthDate = new DateTimePicker();
            groupBox2 = new GroupBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            invType = new RadioButton();
            salesType = new RadioButton();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            crePassword = new TextBox();
            creUsername = new TextBox();
            userGridView = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(createUserbtn);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(birthDate);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(pictureBox2);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(crePassword);
            groupBox4.Controls.Add(creUsername);
            groupBox4.Location = new Point(44, 59);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(726, 278);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // createUserbtn
            // 
            createUserbtn.BackColor = Color.CornflowerBlue;
            createUserbtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserbtn.ForeColor = Color.White;
            createUserbtn.Location = new Point(344, 207);
            createUserbtn.Name = "createUserbtn";
            createUserbtn.Size = new Size(348, 39);
            createUserbtn.TabIndex = 11;
            createUserbtn.Text = "CREATE";
            createUserbtn.UseVisualStyleBackColor = false;
            createUserbtn.Click += createUserbtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel5);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(creLastname);
            groupBox3.Controls.Add(creMidname);
            groupBox3.Controls.Add(creFirstname);
            groupBox3.Location = new Point(24, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(253, 134);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Information";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(20, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 1);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(20, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 1);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(20, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 1);
            panel3.TabIndex = 3;
            // 
            // creLastname
            // 
            creLastname.BorderStyle = BorderStyle.None;
            creLastname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creLastname.Location = new Point(20, 101);
            creLastname.Name = "creLastname";
            creLastname.PlaceholderText = "Enter Last Name";
            creLastname.Size = new Size(180, 21);
            creLastname.TabIndex = 1;
            // 
            // creMidname
            // 
            creMidname.BorderStyle = BorderStyle.None;
            creMidname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creMidname.Location = new Point(20, 69);
            creMidname.Name = "creMidname";
            creMidname.PlaceholderText = "Enter Middle Name";
            creMidname.Size = new Size(180, 21);
            creMidname.TabIndex = 1;
            // 
            // creFirstname
            // 
            creFirstname.BorderStyle = BorderStyle.None;
            creFirstname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creFirstname.Location = new Point(20, 37);
            creFirstname.Name = "creFirstname";
            creFirstname.PlaceholderText = "Enter First Name";
            creFirstname.Size = new Size(180, 21);
            creFirstname.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_birthday_30;
            pictureBox4.Location = new Point(344, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // birthDate
            // 
            birthDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDate.Location = new Point(392, 32);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(300, 28);
            birthDate.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioFemale);
            groupBox2.Controls.Add(radioMale);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Location = new Point(344, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 53);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gender";
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioFemale.Location = new Point(137, 24);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(94, 25);
            radioFemale.TabIndex = 5;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioMale.Location = new Point(57, 24);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(74, 25);
            radioMale.TabIndex = 5;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_gender_30;
            pictureBox3.Location = new Point(9, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(invType);
            groupBox1.Controls.Add(salesType);
            groupBox1.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(344, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 3);
            groupBox1.Size = new Size(212, 54);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Type";
            // 
            // invType
            // 
            invType.AutoSize = true;
            invType.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invType.Location = new Point(99, 23);
            invType.Name = "invType";
            invType.Size = new Size(108, 25);
            invType.TabIndex = 5;
            invType.TabStop = true;
            invType.Text = "Inventory";
            invType.UseVisualStyleBackColor = true;
            // 
            // salesType
            // 
            salesType.AutoSize = true;
            salesType.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salesType.Location = new Point(13, 23);
            salesType.Name = "salesType";
            salesType.Size = new Size(80, 25);
            salesType.TabIndex = 5;
            salesType.TabStop = true;
            salesType.Text = "Sales";
            salesType.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(66, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 1);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(66, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_24;
            pictureBox2.Location = new Point(24, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_30;
            pictureBox1.Location = new Point(24, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // crePassword
            // 
            crePassword.BorderStyle = BorderStyle.None;
            crePassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crePassword.Location = new Point(66, 72);
            crePassword.Name = "crePassword";
            crePassword.PlaceholderText = "Enter Password";
            crePassword.Size = new Size(150, 21);
            crePassword.TabIndex = 1;
            // 
            // creUsername
            // 
            creUsername.BorderStyle = BorderStyle.None;
            creUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creUsername.Location = new Point(66, 32);
            creUsername.Name = "creUsername";
            creUsername.PlaceholderText = "Enter Username";
            creUsername.Size = new Size(150, 21);
            creUsername.TabIndex = 1;
            // 
            // userGridView
            // 
            userGridView.BackgroundColor = SystemColors.Control;
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(68, 521);
            userGridView.Name = "userGridView";
            userGridView.RowHeadersWidth = 62;
            userGridView.Size = new Size(1355, 273);
            userGridView.TabIndex = 14;
            // 
            // CreateUserWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userGridView);
            Controls.Add(groupBox4);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateUserWindow";
            Size = new Size(1557, 931);
            Load += CreateUserWindow_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button createUserbtn;
        private GroupBox groupBox3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private TextBox creLastname;
        private TextBox creMidname;
        private TextBox creFirstname;
        private PictureBox pictureBox4;
        private DateTimePicker birthDate;
        private GroupBox groupBox2;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private RadioButton invType;
        private RadioButton salesType;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox crePassword;
        private TextBox creUsername;
        private DataGridView userGridView;
    }
}
