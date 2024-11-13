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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox4 = new GroupBox();
            groupBox8 = new GroupBox();
            pictureBox1 = new PictureBox();
            crePassword = new TextBox();
            creUsername = new TextBox();
            createUserbtn = new Button();
            groupBox3 = new GroupBox();
            creLastname = new TextBox();
            creMidname = new TextBox();
            creFirstname = new TextBox();
            groupBox1 = new GroupBox();
            invType = new RadioButton();
            salesType = new RadioButton();
            pictureBox2 = new PictureBox();
            userGridView = new DataGridView();
            groupBox5 = new GroupBox();
            pictureBox7 = new PictureBox();
            textBox4 = new TextBox();
            button1 = new Button();
            groupBox6 = new GroupBox();
            pictureBox3 = new PictureBox();
            textBox5 = new TextBox();
            groupBox7 = new GroupBox();
            textBox8 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(createUserbtn);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Location = new Point(56, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(741, 614);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(pictureBox1);
            groupBox8.Controls.Add(pictureBox4);
            groupBox8.Controls.Add(crePassword);
            groupBox8.Controls.Add(creUsername);
            groupBox8.Font = new Font("Arial", 13F);
            groupBox8.Location = new Point(37, 27);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(372, 186);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Account Information";
            groupBox8.Enter += groupBox8_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_30;
            pictureBox1.Location = new Point(20, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // crePassword
            // 
            crePassword.BorderStyle = BorderStyle.FixedSingle;
            crePassword.Font = new Font("Arial", 13F);
            crePassword.Location = new Point(72, 117);
            crePassword.Name = "crePassword";
            crePassword.PlaceholderText = "Enter Password";
            crePassword.Size = new Size(259, 37);
            crePassword.TabIndex = 1;
            // 
            // creUsername
            // 
            creUsername.BorderStyle = BorderStyle.FixedSingle;
            creUsername.Font = new Font("Arial", 13F);
            creUsername.Location = new Point(72, 64);
            creUsername.Name = "creUsername";
            creUsername.PlaceholderText = "Enter Username";
            creUsername.Size = new Size(259, 37);
            creUsername.TabIndex = 1;
            // 
            // createUserbtn
            // 
            createUserbtn.BackColor = Color.CornflowerBlue;
            createUserbtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserbtn.ForeColor = Color.White;
            createUserbtn.Location = new Point(38, 524);
            createUserbtn.Name = "createUserbtn";
            createUserbtn.Size = new Size(348, 66);
            createUserbtn.TabIndex = 11;
            createUserbtn.Text = "CREATE";
            createUserbtn.UseVisualStyleBackColor = false;
            createUserbtn.Click += createUserbtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(creLastname);
            groupBox3.Controls.Add(creMidname);
            groupBox3.Controls.Add(creFirstname);
            groupBox3.Font = new Font("Arial", 13F);
            groupBox3.Location = new Point(37, 233);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(663, 268);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Information";
            // 
            // creLastname
            // 
            creLastname.BorderStyle = BorderStyle.FixedSingle;
            creLastname.Font = new Font("Arial", 13F);
            creLastname.Location = new Point(232, 191);
            creLastname.Name = "creLastname";
            creLastname.Size = new Size(200, 37);
            creLastname.TabIndex = 1;
            // 
            // creMidname
            // 
            creMidname.BorderStyle = BorderStyle.FixedSingle;
            creMidname.Font = new Font("Arial", 13F);
            creMidname.Location = new Point(232, 129);
            creMidname.Name = "creMidname";
            creMidname.Size = new Size(200, 37);
            creMidname.TabIndex = 1;
            // 
            // creFirstname
            // 
            creFirstname.BorderStyle = BorderStyle.FixedSingle;
            creFirstname.Font = new Font("Arial", 13F);
            creFirstname.Location = new Point(232, 65);
            creFirstname.Name = "creFirstname";
            creFirstname.Size = new Size(200, 37);
            creFirstname.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(invType);
            groupBox1.Controls.Add(salesType);
            groupBox1.Font = new Font("Arial", 13F);
            groupBox1.Location = new Point(438, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 3);
            groupBox1.Size = new Size(262, 172);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Type";
            // 
            // invType
            // 
            invType.AutoSize = true;
            invType.Font = new Font("Arial", 13F);
            invType.Location = new Point(22, 105);
            invType.Name = "invType";
            invType.Size = new Size(142, 35);
            invType.TabIndex = 5;
            invType.TabStop = true;
            invType.Text = "Inventory";
            invType.UseVisualStyleBackColor = true;
            invType.CheckedChanged += invType_CheckedChanged;
            // 
            // salesType
            // 
            salesType.AutoSize = true;
            salesType.Font = new Font("Arial", 13F);
            salesType.Location = new Point(22, 52);
            salesType.Name = "salesType";
            salesType.Size = new Size(103, 35);
            salesType.TabIndex = 5;
            salesType.TabStop = true;
            salesType.Text = "Sales";
            salesType.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_24;
            pictureBox2.Location = new Point(32, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // userGridView
            // 
            userGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            userGridView.BackgroundColor = SystemColors.Control;
            userGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 13F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userGridView.DefaultCellStyle = dataGridViewCellStyle2;
            userGridView.Location = new Point(820, 31);
            userGridView.Name = "userGridView";
            userGridView.RowHeadersWidth = 62;
            userGridView.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userGridView.Size = new Size(680, 614);
            userGridView.TabIndex = 14;
            userGridView.CellContentClick += userGridView_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(button1);
            groupBox5.Location = new Point(56, 660);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(741, 286);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_user_30;
            pictureBox7.Location = new Point(38, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 11F);
            textBox4.Location = new Point(80, 311);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "ID Number";
            textBox4.Size = new Size(179, 26);
            textBox4.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 202);
            button1.Name = "button1";
            button1.Size = new Size(348, 66);
            button1.TabIndex = 11;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Control;
            groupBox6.Controls.Add(pictureBox3);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(button3);
            groupBox6.Controls.Add(button4);
            groupBox6.Location = new Point(820, 670);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(680, 276);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_30;
            pictureBox3.Location = new Point(38, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial", 11F);
            textBox5.Location = new Point(80, 311);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "ID Number";
            textBox5.Size = new Size(179, 26);
            textBox5.TabIndex = 15;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(pictureBox2);
            groupBox7.Controls.Add(textBox8);
            groupBox7.Font = new Font("Arial", 13F);
            groupBox7.Location = new Point(38, 27);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(478, 131);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Delete";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Arial", 13F);
            textBox8.Location = new Point(192, 56);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 37);
            textBox8.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(37, 186);
            button3.Name = "button3";
            button3.Size = new Size(348, 66);
            button3.TabIndex = 11;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(324, 285);
            button4.Name = "button4";
            button4.Size = new Size(348, 66);
            button4.TabIndex = 11;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 135);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 2;
            label2.Text = "Middle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 197);
            label3.Name = "label3";
            label3.Size = new Size(145, 31);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Arial", 13F);
            groupBox2.Location = new Point(37, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 158);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 62);
            label4.Name = "label4";
            label4.Size = new Size(108, 31);
            label4.TabIndex = 2;
            label4.Text = "User ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 71);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 2;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 71);
            label6.Name = "label6";
            label6.Size = new Size(148, 31);
            label6.TabIndex = 2;
            label6.Text = "First Name:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 13F);
            textBox1.Location = new Point(463, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 37);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 13F);
            textBox2.Location = new Point(246, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 37);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Arial", 13F);
            textBox3.Location = new Point(20, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 37);
            textBox3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_password_24;
            pictureBox4.Location = new Point(20, 114);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // CreateUserWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(userGridView);
            Controls.Add(groupBox4);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateUserWindow";
            Size = new Size(1557, 972);
            Load += CreateUserWindow_Load;
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button createUserbtn;
        private GroupBox groupBox3;
        private TextBox creLastname;
        private TextBox creMidname;
        private TextBox creFirstname;
        private GroupBox groupBox1;
        private RadioButton invType;
        private RadioButton salesType;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox crePassword;
        private TextBox creUsername;
        private DataGridView userGridView;
        private GroupBox groupBox5;
        private Button button1;
        private GroupBox groupBox8;
        private PictureBox pictureBox7;
        private TextBox textBox4;
        private GroupBox groupBox6;
        private PictureBox pictureBox3;
        private TextBox textBox5;
        private GroupBox groupBox7;
        private TextBox textBox8;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
    }
}
