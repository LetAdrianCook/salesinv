namespace SalesandInventory
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            loginBtn = new Button();
            userInput = new TextBox();
            passInput = new TextBox();
            label2 = new Label();
            exitApp = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(152, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(138, 162);
            label1.Name = "label1";
            label1.Size = new Size(181, 33);
            label1.TabIndex = 1;
            label1.Text = "USER LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(70, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(70, 271);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pass;
            pictureBox3.Location = new Point(70, 307);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(70, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.CornflowerBlue;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.White;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(70, 393);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(300, 50);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // userInput
            // 
            userInput.BorderStyle = BorderStyle.None;
            userInput.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userInput.Location = new Point(138, 236);
            userInput.Multiline = true;
            userInput.Name = "userInput";
            userInput.PlaceholderText = "Enter Username";
            userInput.Size = new Size(234, 29);
            userInput.TabIndex = 5;
            // 
            // passInput
            // 
            passInput.BorderStyle = BorderStyle.None;
            passInput.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passInput.Location = new Point(136, 318);
            passInput.Multiline = true;
            passInput.Name = "passInput";
            passInput.PasswordChar = '*';
            passInput.PlaceholderText = "Enter Password";
            passInput.Size = new Size(234, 29);
            passInput.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 188);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 7;
            // 
            // exitApp
            // 
            exitApp.AutoSize = true;
            exitApp.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitApp.Location = new Point(165, 451);
            exitApp.Name = "exitApp";
            exitApp.Size = new Size(115, 18);
            exitApp.TabIndex = 8;
            exitApp.TabStop = true;
            exitApp.Text = "Exit Application";
            exitApp.LinkClicked += exitApp_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 516);
            Controls.Add(exitApp);
            Controls.Add(label2);
            Controls.Add(passInput);
            Controls.Add(userInput);
            Controls.Add(loginBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button loginBtn;
        private TextBox userInput;
        private TextBox passInput;
        private Label label2;
        private LinkLabel exitApp;
    }
}
