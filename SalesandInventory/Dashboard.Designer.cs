namespace SalesandInventory
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
            panel1 = new Panel();
            createSupplier = new Button();
            logoutBtn = new Button();
            createBtn = new Button();
            salesBtn = new Button();
            inventoryBtn = new Button();
            panelLogo = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            exitBtn = new Button();
            sessionType = new Label();
            sessionName = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dashPanel = new Panel();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(createSupplier);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(salesBtn);
            panel1.Controls.Add(inventoryBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 1024);
            panel1.TabIndex = 0;
            // 
            // createSupplier
            // 
            createSupplier.Dock = DockStyle.Top;
            createSupplier.FlatAppearance.BorderSize = 0;
            createSupplier.FlatStyle = FlatStyle.Flat;
            createSupplier.Font = new Font("Arial", 13F);
            createSupplier.Image = Properties.Resources.icons8_add_administrator_30;
            createSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            createSupplier.Location = new Point(0, 374);
            createSupplier.Name = "createSupplier";
            createSupplier.Padding = new Padding(20, 0, 0, 0);
            createSupplier.Size = new Size(363, 63);
            createSupplier.TabIndex = 5;
            createSupplier.Text = "Add Suppliers";
            createSupplier.TextAlign = ContentAlignment.MiddleLeft;
            createSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            createSupplier.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial", 13F);
            logoutBtn.Image = Properties.Resources.icons8_logout_30;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 961);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(20, 0, 0, 0);
            logoutBtn.Size = new Size(363, 63);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Dock = DockStyle.Top;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Arial", 13F);
            createBtn.Image = Properties.Resources.icons8_add_administrator_30;
            createBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createBtn.Location = new Point(0, 311);
            createBtn.Name = "createBtn";
            createBtn.Padding = new Padding(20, 0, 0, 0);
            createBtn.Size = new Size(363, 63);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create Users";
            createBtn.TextAlign = ContentAlignment.MiddleLeft;
            createBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // salesBtn
            // 
            salesBtn.Dock = DockStyle.Top;
            salesBtn.FlatAppearance.BorderSize = 0;
            salesBtn.FlatStyle = FlatStyle.Flat;
            salesBtn.Font = new Font("Arial", 13F);
            salesBtn.Image = Properties.Resources.icons8_sales_30;
            salesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            salesBtn.Location = new Point(0, 248);
            salesBtn.Name = "salesBtn";
            salesBtn.Padding = new Padding(20, 0, 0, 0);
            salesBtn.Size = new Size(363, 63);
            salesBtn.TabIndex = 2;
            salesBtn.Text = "Sales";
            salesBtn.TextAlign = ContentAlignment.MiddleLeft;
            salesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            salesBtn.UseVisualStyleBackColor = true;
            salesBtn.Click += salesBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.Dock = DockStyle.Top;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryBtn.Image = Properties.Resources.icons8_inventory_30;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 185);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(20, 0, 0, 0);
            inventoryBtn.Size = new Size(363, 63);
            inventoryBtn.TabIndex = 1;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.AutoSize = true;
            panelLogo.BackColor = Color.LightSteelBlue;
            panelLogo.Controls.Add(label3);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(363, 185);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(193, 104);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 0;
            label3.Text = "need for Tech!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(193, 70);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(159, 23);
            label1.TabIndex = 0;
            label1.Text = "We got what you";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(sessionType);
            panel3.Controls.Add(sessionName);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(363, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1557, 93);
            panel3.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = SystemColors.Control;
            exitBtn.Image = Properties.Resources.icons8_power_off_button_50;
            exitBtn.Location = new Point(1484, 15);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(68, 60);
            exitBtn.TabIndex = 3;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // sessionType
            // 
            sessionType.AutoSize = true;
            sessionType.Location = new Point(1324, 46);
            sessionType.Name = "sessionType";
            sessionType.Size = new Size(65, 25);
            sessionType.TabIndex = 2;
            sessionType.Text = "Admin";
            // 
            // sessionName
            // 
            sessionName.AutoSize = true;
            sessionName.Location = new Point(1324, 21);
            sessionName.Name = "sessionName";
            sessionName.Size = new Size(84, 25);
            sessionName.TabIndex = 2;
            sessionName.Text = "Jane Doe";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(1414, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // dashPanel
            // 
            dashPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashPanel.Dock = DockStyle.Fill;
            dashPanel.Location = new Point(363, 93);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(1557, 931);
            dashPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1920, 1024);
            Controls.Add(dashPanel);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button inventoryBtn;
        private Panel panelLogo;
        private Button logoutBtn;
        private Button createBtn;
        private Button salesBtn;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Panel dashPanel;
        private Label sessionName;
        private PictureBox pictureBox2;
        private Label sessionType;
        private Button exitBtn;
        private Button createSupplier;
        private Label label3;
        private Label label1;
    }
}