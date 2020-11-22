using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Customers : Form
    {
        private TextBox name = new TextBox();
        private TextBox phoneNumber = new TextBox();
        private TextBox email = new TextBox();
        private TextBox address = new TextBox();

        private Button btnInvoiceGeneration = new Button();
        private Label title = new Label();
        private PictureBox customersPicture = new PictureBox();



        public Customers()
        {
            InitializeComponent();
            this.btnInvoiceGeneration.Click += new EventHandler(this.btnInvoiceGeneration_Click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.CenterToParent();
            this.BackColor = Color.NavajoWhite;

            Font labelFont = new Font("Times New Roman", 14.0f);
            Font customerLabelFont = new Font("Times New Roman", 25);

            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "customer.png");
            customersPicture.Image = Image.FromFile(path);
            customersPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            customersPicture.Location = new Point(20, 90);

            this.title.Text = "Customer Purchase";
            this.title.Font = customerLabelFont;
            this.title.Size = new Size(150, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 30);



            Font font = new Font("Times New Roman", 14.0f);

            this.name.Location = new Point(250, 100);
            this.name.Font = font;
            this.name.Size = new Size(175, 25);

            this.phoneNumber.Location = new Point(250, 150);
            this.phoneNumber.Font = font;
            this.phoneNumber.Size = new Size(175, 25);

            //name
            this.name.Location = new Point(100, 140);
            this.name.Size = new Size(200, 20);
            this.name.Text = "Name: ";
            this.name.Font = labelFont;

            //phoneNumber
            this.phoneNumber.Location = new Point(100, 250);
            this.phoneNumber.Size = new Size(200, 20);
            this.phoneNumber.Text = "Phone Number: ";
            this.phoneNumber.Font = labelFont;

            //email
            this.email.Location = new Point(100, 360);
            this.email.Size = new Size(200, 20);
            this.email.Text = "Email: ";
            this.email.Font = labelFont;

            //email
            this.address.Location = new Point(100, 470);
            this.address.Size = new Size(200, 20);
            this.address.Text = "Address: ";
            this.address.Font = labelFont;

            //OUTPUT list


            this.Controls.Add(name);
            this.Controls.Add(phoneNumber);
            this.Controls.Add(email);
            this.Controls.Add(address);
            this.Controls.Add(btnInvoiceGeneration);
            this.Controls.Add(title);
            this.Controls.Add(customersPicture);
        }

        private void btnInvoiceGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The invoice has been generated");
        }

    }
}
