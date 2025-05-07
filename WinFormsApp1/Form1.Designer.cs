namespace WinFormsApp1
{
    partial class Form1
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
            panel1 = new Panel();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label1 = new Label();
            closebtn = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 483);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.FromArgb(0, 0, 64);
            Welcome.Location = new Point(9, 250);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(291, 81);
            Welcome.TabIndex = 2;
            Welcome.Text = "Welcome to the \r\nUniversity Management \r\nSystem";
            Welcome.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images1;
            pictureBox1.Location = new Point(96, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(closebtn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 483);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.LightSkyBlue;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(209, 417);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(271, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(233, 273);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(180, 230);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(185, 27);
            txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(180, 172);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(185, 27);
            txtUser.TabIndex = 5;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(46, 174);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 4;
            label3.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(46, 232);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            // 
            // closebtn
            // 
            closebtn.Cursor = Cursors.Hand;
            closebtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.LightSkyBlue;
            closebtn.Location = new Point(400, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(32, 35);
            closebtn.TabIndex = 2;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(142, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(225, 23);
            label2.TabIndex = 0;
            label2.Text = "Login to your Account";
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(732, 483);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label Welcome;
        private Label label2;
        private Button button1;
        private Button closebtn;
        private Label label3;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}
