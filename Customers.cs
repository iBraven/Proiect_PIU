using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proiect_PIU
{
    public partial class Customers : Form
    {
        private TextBox name = new TextBox();
        private TextBox phoneNumber = new TextBox();
        private TextBox email = new TextBox();
        private TextBox address = new TextBox();
        private ComboBox product = new ComboBox();

        private Label nameLabel = new Label();
        private Label phoneLabel = new Label();
        private Label emailLabel = new Label();
        private Label addressLabel = new Label();
        private Label productLabel = new Label();

        private Panel invoicePanel = new Panel();

        private Label testLabel = new Label();

        private Button btnAddInvoice = new Button();
        private Button btnSaveInvoice = new Button();
        private Label title = new Label();
        private PictureBox customersPicture = new PictureBox();



        public Customers()
        {
            InitializeComponent();
            this.btnAddInvoice.Click += new EventHandler(this.BtnAddInvoice_Click);
            this.invoicePanel.Paint += new PaintEventHandler(this.InvoicePanel_Paint);
            this.btnSaveInvoice.Click += new EventHandler(this.BtnSaveInvoice_Click);
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 750);
            this.CenterToParent();
            //this.BackColor = Color.NavajoWhite;
            this.BackColor = Color.MediumAquamarine;

            System.Drawing.Font textboxFont = new System.Drawing.Font("Times New Roman", 14.0f);
            System.Drawing.Font labelFont = new System.Drawing.Font("Times New Roman", 16.0f);
            System.Drawing.Font customerLabelFont = new System.Drawing.Font("Times New Roman", 25);
            System.Drawing.Font btnFont = new System.Drawing.Font("Times New Roman", 15.0f);

            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "customer.png");
            customersPicture.Image = System.Drawing.Image.FromFile(path);
            customersPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            customersPicture.Location = new Point(20, 90);

            this.title.Text = "Customer Purchase";
            this.title.Font = customerLabelFont;
            this.title.Size = new Size(150, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 50);



            //name
            this.nameLabel.Location = new Point(60, 150);
            this.nameLabel.Text = "Name: ";
            this.nameLabel.Font = labelFont;


            this.name.Location = new Point(150, 150);
            this.name.Size = new Size(250, 20);
            this.name.Font = textboxFont;

            //phoneNumber
            this.phoneLabel.Location = new Point(60, 210);
            this.phoneLabel.Text = "Phone: ";
            this.phoneLabel.Font = labelFont;

            this.phoneNumber.Location = new Point(150, 210);
            this.phoneNumber.Size = new Size(250, 20);
            this.phoneNumber.Font = textboxFont;

            //email
            this.emailLabel.Location = new Point(60, 270);
            this.emailLabel.Text = "Email: ";
            this.emailLabel.Font = labelFont;

            this.email.Location = new Point(150, 270);
            this.email.Size = new Size(250, 20);
            this.email.Font = textboxFont;

            //address
            this.addressLabel.Location = new Point(60, 330);
            this.addressLabel.Text = "Address: ";
            this.addressLabel.Font = labelFont;

            this.address.Location = new Point(150, 330);
            this.address.Size = new Size(250, 70);
            this.address.Font = textboxFont;
            this.address.Multiline = true;

            //product
            this.productLabel.Location = new Point(60, 430);
            this.productLabel.Text = "Product: ";
            this.productLabel.Font = labelFont;

            this.product.Location = new Point(150, 430);
            this.product.Size = new Size(250, 20);
            this.product.Font = textboxFont;

            //btnAddInvoice
            this.btnAddInvoice.Location = new Point(450, 260);
            this.btnAddInvoice.Text = "Add info " + '\u2192';
            this.btnAddInvoice.AutoSize = true;
            this.btnAddInvoice.FlatStyle = FlatStyle.Flat;
            this.btnAddInvoice.FlatAppearance.BorderColor = Color.Black;
            this.btnAddInvoice.FlatAppearance.BorderSize = 1;
            this.btnAddInvoice.Font = btnFont;
            System.Drawing.Image buttonBackground = System.Drawing.Image.FromFile(@"..\..\Resources\butonBackground.jfif");
            this.btnAddInvoice.BackgroundImage = buttonBackground;


            //image
            this.customersPicture.Location = new Point(475, 20);

            //invoicePanel
            this.invoicePanel.Location = new Point(600, 140);
            this.invoicePanel.Size = new Size(650, 450);

            //antetLabel for Invoice
            this.invoicePanel.Visible = true;
            this.testLabel.Text = "INVOICE";
            this.testLabel.Location = new Point(300, 70);
            this.invoicePanel.Controls.Add(testLabel);


            //btnSaveInvoice
            this.btnSaveInvoice.Location = new Point(1125, 625);
            this.btnSaveInvoice.Size = new Size(125, 40);
            this.btnSaveInvoice.Text = "Save";
            this.btnSaveInvoice.FlatStyle = FlatStyle.Flat;
            this.btnSaveInvoice.FlatAppearance.BorderColor = Color.Black;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 1;
            this.btnSaveInvoice.Font = btnFont;
            this.btnSaveInvoice.BackgroundImage = buttonBackground;


            this.Controls.Add(name);
            this.Controls.Add(phoneNumber);
            this.Controls.Add(email);
            this.Controls.Add(address);
            this.Controls.Add(product);
            this.Controls.Add(nameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(productLabel);
            this.Controls.Add(title);
            this.Controls.Add(customersPicture);
            this.Controls.Add(btnAddInvoice);
            this.Controls.Add(invoicePanel);
            this.Controls.Add(btnSaveInvoice);
        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            // Din Tutorial

            //TXTextControl.LoadSettings ls = new TXTextControl.LoadSettings();
            //ls.ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord;

            //mailMerge1.TextComponent = textControl1;
            //textControl1.Load("invoice.docx", TXTextControl.StreamType.WordprocessingML, ls);
            //DataSet ds = new DataSet();
            //ds.ReadXml("invoice.xml");

            //mailMerge1.MergeBlocks(ds);
            //mailMerge1.Merge(ds.Tables["invoice"], false);

            MessageBox.Show("The invoice has been generated");
        }

        private void BtnSaveInvoice_Click(object sender, EventArgs e)
        {
            //generare un document PDF in folderul InvoicePDF cu factura salvata
            Document document = new Document();
            //creaza folder
            if (!Directory.Exists(@"..\..\InvoicePDF"))
            {
                Directory.CreateDirectory(@"..\..\InvoicePDF");
            }
            PdfWriter.GetInstance(document, new FileStream(@"..\..\InvoicePDF\invoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph(this.testLabel.Text);
            document.Add(p);
            document.Close();
            MessageBox.Show("Invoice saved successfully");
        }

        private void InvoicePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, invoicePanel.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Black, 1, ButtonBorderStyle.Solid, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
            invoicePanel.BackColor = Color.White;
        }


       


    }
}
