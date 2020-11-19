using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Form1 : Form
    {
        private TextBox usernameBox = new TextBox();
        private TextBox passwordBox = new TextBox();
        private Button btnLogin = new Button();
        private Label welcomeLabel = new Label();
        private Label usernameLabel = new Label();
        private Label passwordLabel = new Label();
        private PictureBox loginPicture = new PictureBox();



        public Form1()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.NavajoWhite;
            this.Size = new System.Drawing.Size(500, 350);
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


            this.btnLogin.Size = new Size(125, 40);
            this.btnLogin.Location = new Point((this.Width - this.btnLogin.Width) / 2, 220);
            this.btnLogin.BackColor = Color.AntiqueWhite;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderColor = Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 1;
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = font2;

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


            loginPicture.Image = Image.FromFile(@"D:\Facultate\Facultate\An4\SEM1\PIU\proiect\WindowsFormsApp1\login.jpg");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("logged");
        }

    }
}
