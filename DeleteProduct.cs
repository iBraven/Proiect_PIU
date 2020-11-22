using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class DeleteProduct : Form
    {
        private Label deleteProductLabel1 = new Label();
        private Label deleteProductLabel2 = new Label();
        private Panel deleteProductPanel = new Panel();
        private Label title = new Label();
        private ComboBox findBy = new ComboBox();
        private PictureBox deleteProductPicture = new PictureBox();
        public DeleteProduct()
        {
            InitializeComponent();
            this.deleteProductPanel.Paint += new PaintEventHandler(this.InvoicePanel_Paint);
        }

        //DeleteProduct
        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 750);
            this.CenterToParent();
            //this.BackColor = Color.NavajoWhite;
            this.BackColor = Color.MediumAquamarine;

            Font customerLabelFont = new Font("Times New Roman", 25);
            Font labelFont = new Font("Times New Roman", 15.0f);
            Font textboxFont = new Font("Georgia", 15.0f);

            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "delete.png");
            deleteProductPicture.Image = Image.FromFile(path);
            deleteProductPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            deleteProductPicture.Location = new Point(20, 90);

            this.title.Text = "Delete Product";
            this.title.Font = customerLabelFont;
            this.title.Size = new Size(105, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 50);

            //image
            this.deleteProductPicture.Location = new Point(475, 20);


            //invoiceSearchLabel1
            this.deleteProductLabel1.Location = new Point((this.Width - this.title.Width) / 2, 170);
            this.deleteProductLabel1.Text = "Search By: ";
            this.deleteProductLabel1.Size = new Size(200, 20);
            this.deleteProductLabel1.Font = labelFont;

            this.findBy.Location = new Point((this.Width - this.title.Width) / 2, 195);
            this.findBy.Size = new Size(250, 20);
            this.findBy.Font = textboxFont;

            //invoiceSearchLabel2
            this.deleteProductLabel2.Location = new Point(75, 270);
            this.deleteProductLabel2.Text = "Select product: ";
            this.deleteProductLabel2.Size = new Size(210, 20);
            this.deleteProductLabel2.Font = labelFont;


            //invoiceSearchPanel
            this.deleteProductPanel.Location = new Point(80, 300);
            this.deleteProductPanel.Size = new Size(1170, 350);

            //CONTROLS
            this.Controls.Add(title);
            this.Controls.Add(deleteProductPicture);
            this.Controls.Add(deleteProductLabel1);
            this.Controls.Add(deleteProductLabel2);
            this.Controls.Add(deleteProductPanel);
            this.Controls.Add(findBy);
        }


        private void InvoicePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, deleteProductPanel.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Black, 1, ButtonBorderStyle.Solid, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
            deleteProductPanel.BackColor = Color.LightYellow;
        }
    }
}
