using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class InvoiceSearch : Form
    {
        private Label invoiceSearchLabel1 = new Label();
        private Label invoiceSearchLabel2 = new Label();
        private Panel invoiceSearchPanel = new Panel();
        private Label title = new Label();
        private ComboBox findBy = new ComboBox();
        private PictureBox invoiceSearchPicture = new PictureBox();


        public InvoiceSearch()
        {
            InitializeComponent();
            this.invoiceSearchPanel.Paint += new PaintEventHandler(this.InvoicePanel_Paint);
        }

        private void InvoiceSearch_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 750);
            this.CenterToParent();
            this.BackColor = Color.MediumAquamarine;

            Font customerLabelFont = new Font("Times New Roman", 25);
            Font labelFont = new Font("Times New Roman", 15.0f);
            Font textboxFont = new Font("Georgia", 15.0f);

            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "find.png");
            invoiceSearchPicture.Image = Image.FromFile(path);
            invoiceSearchPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            invoiceSearchPicture.Location = new Point(20, 90);

            this.title.Text = "Invoice Search";
            this.title.Font = customerLabelFont;
            this.title.Size = new Size(105, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 50);

            //image
            this.invoiceSearchPicture.Location = new Point(475, 20);


            //invoiceSearchLabel1
            this.invoiceSearchLabel1.Location = new Point((this.Width - this.title.Width) / 2, 170);
            this.invoiceSearchLabel1.Text = "Search By: ";
            this.invoiceSearchLabel1.Size = new Size(200, 20);
            this.invoiceSearchLabel1.Font = labelFont;

            this.findBy.Location = new Point((this.Width - this.title.Width) / 2, 195);
            this.findBy.Size = new Size(250, 20);
            this.findBy.Font = textboxFont;

            //invoiceSearchLabel2
            this.invoiceSearchLabel2.Location = new Point(75, 270);
            this.invoiceSearchLabel2.Text = "Stored invoices: ";
            this.invoiceSearchLabel2.Size = new Size(200, 20);
            this.invoiceSearchLabel2.Font = labelFont;


            //invoiceSearchPanel
            this.invoiceSearchPanel.Location = new Point(80, 300);
            this.invoiceSearchPanel.Size = new Size(1170, 350);

            //CONTROLS
            this.Controls.Add(title);
            this.Controls.Add(invoiceSearchPicture);
            this.Controls.Add(invoiceSearchLabel1);
            this.Controls.Add(invoiceSearchLabel2);
            this.Controls.Add(invoiceSearchPanel);
            this.Controls.Add(findBy);
        }


        private void InvoicePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, invoiceSearchPanel.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Black, 1, ButtonBorderStyle.Solid, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
            invoiceSearchPanel.BackColor = Color.LightYellow;
        }
    }
}
