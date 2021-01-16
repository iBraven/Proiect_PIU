using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace Proiect_PIU
{
    public partial class LoginForm : Form
    {
        private TextBox usernameBox = new TextBox();
        private TextBox passwordBox = new TextBox();
        private Button btnLogin = new Button();
        private Label welcomeLabel = new Label();
        private Label usernameLabel = new Label();
        private Label passwordLabel = new Label();
        private PictureBox loginPicture = new PictureBox();



        public LoginForm()
        {
            InitializeComponent();
            this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.BackColor = Color.NavajoWhite;
            this.BackColor = Color.Lavender;
            this.Size = new Size(500, 350);
            this.Text = "Login";
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


            Font font = new Font("Times New Roman", 14.0f);
            Font font2 = new Font("Times New Roman", 15.0f);
            Font welcomeFont = new Font("Times New Roman", 25);

            this.usernameBox.Location = new Point(250, 100);
            this.usernameBox.Font = font;
            this.usernameBox.Size = new Size(175, 25);

            this.passwordBox.Location = new Point(250, 150);
            this.passwordBox.Font = font;
            this.passwordBox.Size = new Size(175, 25);
            this.passwordBox.PasswordChar = '*';


            this.btnLogin.Size = new Size(125, 40);
            this.btnLogin.Location = new Point((this.Width - this.btnLogin.Width) / 2, 220);
            this.btnLogin.BackColor = Color.AntiqueWhite;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderColor = Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 1;
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = font2;
            Image buttonBackground = Image.FromFile(@"..\..\Resources\butonBackground.jfif");
            this.btnLogin.BackgroundImage = buttonBackground;
            this.AcceptButton = this.btnLogin;

            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Font = welcomeFont;
            this.welcomeLabel.Size = new Size(150, 0);
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new Point((this.Width - this.welcomeLabel.Width) / 2, 30);

            this.usernameLabel.Text = "Username: ";
            this.usernameLabel.Font = font2;
            this.usernameLabel.Location = new Point(150, 105);

            this.passwordLabel.Text = "Password: ";
            this.passwordLabel.Font = font2;
            this.passwordLabel.Location = new Point(150, 155);


            loginPicture.Image = Image.FromFile(@"..\..\Resources\login2.png");
            loginPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            loginPicture.Location = new Point(20, 90);

            
            this.Controls.Add(usernameBox);
            this.Controls.Add(passwordBox);
            this.Controls.Add(btnLogin);
            this.Controls.Add(welcomeLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(loginPicture);
        }

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

            MainForm c = new MainForm();
            StreamReader reader = new StreamReader(@"..\..\Resources\adminData.csv");
            List<string> data = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                data.Add(values[0]);
            }
            if(usernameBox.Text == data[1].Split(',')[0] && passwordBox.Text == data[1].Split(',')[1])
            {
                this.Hide();
                c.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user and/or password!");
            }
        }


    }
}
