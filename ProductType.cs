using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class ProductType : Form
    {
        private Label companyLabel = new Label();
        private ComboBox companyCbx = new ComboBox();
        private Label productTypeLabel = new Label();
        private ComboBox productTypeCbx = new ComboBox();
        private Label modelNameLabel = new Label();
        private ComboBox modelNameCbx = new ComboBox();
        private Label internalStorageLabel = new Label();
        private ComboBox internalStorageCbx = new ComboBox();
        private Label ramLabel = new Label();
        private ComboBox ramCbx = new ComboBox();
        private Label displayLabel = new Label();
        private ComboBox displayCbx = new ComboBox();
        private Label fingerprintLabel = new Label();
        private ComboBox fingerprintCbx = new ComboBox();
        private Label rearCameraLabel = new Label();
        private ComboBox rearCameraCbx = new ComboBox();
        private Label frontCameraLabel = new Label();
        private ComboBox frontCameraCbx = new ComboBox();
        private Label priceLabel = new Label();
        private ComboBox priceCbx = new ComboBox();
        private Button btnSave = new Button();

        private Label title = new Label();
        private PictureBox productTypePicture = new PictureBox();

        public ProductType()
        {
            InitializeComponent();

            this.btnSave.Click += new EventHandler(this.BtnSave_Click);
            this.productTypeCbx.SelectedIndexChanged += new EventHandler(this.ProductTypeCbx_SelectedIndexChanged);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 750);
            this.CenterToParent();
            this.BackColor = Color.MediumAquamarine;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            Font cbxFont = new Font("Georgia", 12);
            Font labelFont = new Font("Times New Roman", 14.0f);
            Font productTypeLabelFont = new Font("Times New Roman", 25);


            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "productType.png");
            productTypePicture.Image = Image.FromFile(path);
            productTypePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            productTypePicture.Location = new Point(20, 90);

            //image
            this.productTypePicture.Location = new Point(475, 20);

            this.title.Text = "Product Type";
            this.title.Font = productTypeLabelFont;
            this.title.Size = new Size(105, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 50);



            //product type
            this.productTypeLabel.Location = new Point(150, 100);
            this.productTypeLabel.Text = "Product type: ";
            this.productTypeLabel.Size = new Size(200, 20);
            this.productTypeLabel.Font = labelFont;

            this.productTypeCbx.Location = new Point(150, 130);
            this.productTypeCbx.Name = "Product type";
            this.productTypeCbx.Size = new Size(200, 50);
            this.productTypeCbx.Font = cbxFont;
            this.productTypeCbx.Items.Add("Laptop");
            this.productTypeCbx.Items.Add("Smartphone");
            this.productTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;


            //company
            this.companyLabel.Location = new Point(150, 250);
            this.companyLabel.Size = new Size(200, 20);
            this.companyLabel.Text = "Company: ";
            this.companyLabel.Font = labelFont;

            this.companyCbx.Location = new Point(150, 280);
            this.companyCbx.Name = "Company";
            this.companyCbx.Size = new Size(200, 50);
            this.companyCbx.Font = cbxFont;
            this.companyCbx.Items.Add("Emag");
            this.companyCbx.Items.Add("Altex");
            this.companyCbx.Items.Add("Flanco");
            this.companyCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.companyCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //model name
            this.modelNameLabel.Location = new Point(150, 350);
            this.modelNameLabel.Size = new Size(200, 20);
            this.modelNameLabel.Text = "Model name: ";
            this.modelNameLabel.Font = labelFont;

            this.modelNameCbx.Location = new Point(150, 380);
            this.modelNameCbx.Name = "Model name";
            this.modelNameCbx.Size = new Size(200, 50);
            this.modelNameCbx.Font = cbxFont;
            this.modelNameCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.modelNameCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Internal storage
            this.internalStorageLabel.Location = new Point(150, 450);
            this.internalStorageLabel.Size = new Size(200, 20);
            this.internalStorageLabel.Text = "Internal Storage: ";
            this.internalStorageLabel.Font = labelFont;

            this.internalStorageCbx.Location = new Point(150, 480);
            this.internalStorageCbx.Name = "Internal Storage ";
            this.internalStorageCbx.Size = new Size(200, 50);
            this.internalStorageCbx.Font = cbxFont;
            this.internalStorageCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.internalStorageCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //RAM
            this.ramLabel.Location = new Point(550, 250);
            this.ramLabel.Size = new Size(200, 20);
            this.ramLabel.Text = "RAM: ";
            this.ramLabel.Font = labelFont;

            this.ramCbx.Location = new Point(550, 280);
            this.ramCbx.Name = "RAM";
            this.ramCbx.Size = new Size(200, 50);
            this.ramCbx.Font = cbxFont;
            this.ramCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ramCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //display
            this.displayLabel.Location = new Point(550, 350);
            this.displayLabel.Size = new Size(200, 20);
            this.displayLabel.Text = "Display: ";
            this.displayLabel.Font = labelFont;

            this.displayCbx.Location = new Point(550, 380);
            this.displayCbx.Name = "Display";
            this.displayCbx.Size = new Size(200, 50);
            this.displayCbx.Font = cbxFont;
            this.displayCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.displayCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //fingerprint sensor
            this.fingerprintLabel.Location = new Point(550, 450);
            this.fingerprintLabel.Size = new Size(200, 20);
            this.fingerprintLabel.Text = "Fingerprint sensor: ";
            this.fingerprintLabel.Font = labelFont;

            this.fingerprintCbx.Location = new Point(550, 480);
            this.fingerprintCbx.Name = "Fingerprint sensor";
            this.fingerprintCbx.Size = new Size(200, 50);
            this.fingerprintCbx.Font = cbxFont;
            this.fingerprintCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.fingerprintCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //rear camera
            this.rearCameraLabel.Location = new Point(950, 250);
            this.rearCameraLabel.Size = new Size(200, 20);
            this.rearCameraLabel.Text = "Rear camera: ";
            this.rearCameraLabel.Font = labelFont;

            this.rearCameraCbx.Location = new Point(950, 280);
            this.rearCameraCbx.Name = "Rear camera";
            this.rearCameraCbx.Size = new Size(200, 50);
            this.rearCameraCbx.Font = cbxFont;
            this.rearCameraCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.rearCameraCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //front camera
            this.frontCameraLabel.Location = new Point(950, 350);
            this.frontCameraLabel.Size = new Size(200, 20);
            this.frontCameraLabel.Text = "Front camera: ";
            this.frontCameraLabel.Font = labelFont;

            this.frontCameraCbx.Location = new Point(950, 380);
            this.frontCameraCbx.Name = "Front camera";
            this.frontCameraCbx.Size = new Size(200, 50);
            this.frontCameraCbx.Font = cbxFont;
            this.frontCameraCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.frontCameraCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //price
            this.priceLabel.Location = new Point(950, 450);
            this.priceLabel.Size = new Size(200, 20);
            this.priceLabel.Text = "Price: ";
            this.priceLabel.Font = labelFont;

            this.priceCbx.Location = new Point(950, 480);
            this.priceCbx.Name = "Price";
            this.priceCbx.Size = new Size(200, 50);
            this.priceCbx.Font = cbxFont;
            this.priceCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.priceCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            Image buttonBackground = Image.FromFile(@"..\..\Resources\butonBackground.jfif");

            //SAVE btn
            this.btnSave.Location = new Point(1000, 600);
            this.btnSave.Size = new Size(125, 40);
            this.btnSave.Text = "Save";
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 1;
            buttonBackground = Image.FromFile(@"..\..\Resources\butonBackground.jfif");
            this.btnSave.BackgroundImage = buttonBackground;


            //CONTROLS
            this.Controls.Add(title);
            this.Controls.Add(productTypePicture);
            this.Controls.Add(productTypeLabel);
            this.Controls.Add(productTypeCbx);
            this.Controls.Add(companyLabel);
            this.Controls.Add(companyCbx);
            this.Controls.Add(modelNameLabel);
            this.Controls.Add(modelNameCbx);
            this.Controls.Add(internalStorageCbx);
            this.Controls.Add(internalStorageLabel);
            this.Controls.Add(ramLabel);
            this.Controls.Add(ramCbx);
            this.Controls.Add(displayLabel);
            this.Controls.Add(displayCbx);
            this.Controls.Add(fingerprintLabel);
            this.Controls.Add(fingerprintCbx);
            this.Controls.Add(rearCameraLabel);
            this.Controls.Add(rearCameraCbx);
            this.Controls.Add(frontCameraLabel);
            this.Controls.Add(frontCameraCbx);
            this.Controls.Add(priceLabel);
            this.Controls.Add(priceCbx);
            this.Controls.Add(btnSave);
        }

        private void BtnSpecs_Click(object sender, EventArgs e)
        {
            //
        }
        private void ProductTypeCbx_SelectedIndexChanged(Object sender, EventArgs e)
        {
            ClearCbx();
            if (this.productTypeCbx.GetItemText(this.productTypeCbx.SelectedItem)=="Smartphone")
            {
                ShowCbx();
                this.modelNameCbx.Items.Add("Samsung Galaxy S8");
                this.modelNameCbx.Items.Add("Iphone 12");

                this.internalStorageCbx.Items.Add("64GB");
                this.internalStorageCbx.Items.Add("128GB");
                this.internalStorageCbx.Items.Add("256GB");

                this.ramCbx.Items.Add("2 RAM");
                this.ramCbx.Items.Add("4 RAM");
                this.ramCbx.Items.Add("8 RAM");

                this.displayCbx.Items.Add("5.5 inch");
                this.displayCbx.Items.Add("6 inch");
                this.displayCbx.Items.Add("5 inch");
                this.displayCbx.Items.Add("5.8 inch");

                this.fingerprintCbx.Items.Add("Yes");
                this.fingerprintCbx.Items.Add("No");

                this.rearCameraCbx.Items.Add("4 MP");
                this.rearCameraCbx.Items.Add("8 MP");
                this.rearCameraCbx.Items.Add("12 MP");
                this.rearCameraCbx.Items.Add("16 MP");
                this.rearCameraCbx.Items.Add("32 MP");

                this.frontCameraCbx.Items.Add("4 MP");
                this.frontCameraCbx.Items.Add("8 MP");
                this.frontCameraCbx.Items.Add("12 MP");

                this.priceCbx.Items.Add("3250");
                this.priceCbx.Items.Add("4000");
                this.priceCbx.Items.Add("2000");
                this.priceCbx.Items.Add("2500");

            }
            else if (this.productTypeCbx.GetItemText(this.productTypeCbx.SelectedItem) == "Laptop")
            {
                ShowCbx();
                this.modelNameCbx.Items.Add("Asus VivoBook");
                this.modelNameCbx.Items.Add("Macbook 3");

                this.internalStorageCbx.Items.Add("256GB");
                this.internalStorageCbx.Items.Add("512GB");
                this.internalStorageCbx.Items.Add("1024GB");

                this.ramCbx.Items.Add("4 RAM");
                this.ramCbx.Items.Add("8 RAM");
                this.ramCbx.Items.Add("16 RAM");
                this.ramCbx.Items.Add("32 RAM");

                this.displayCbx.Items.Add("18.3 inch");
                this.displayCbx.Items.Add("15.5 inch");
                this.displayCbx.Items.Add("17 inch");

                this.fingerprintCbx.Items.Add("Yes");
                this.fingerprintCbx.Items.Add("No");

                this.priceCbx.Items.Add("3250");
                this.priceCbx.Items.Add("2800");
                this.priceCbx.Items.Add("7499");

                this.rearCameraCbx.Hide();
                this.rearCameraLabel.Hide();
                this.frontCameraCbx.Hide();
                this.frontCameraLabel.Hide();
                this.priceLabel.Location = new Point(950, 350);
                this.priceCbx.Location = new Point(950, 380);

            }
            else
            {
                HideCbx();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved product");
        }

        private void HideCbx()
        {
            foreach (Control control in this.Controls)
            {
                if ((control is ComboBox || control is Label) && control!=(productTypeCbx) && control!=(productTypeLabel))
                {
                    control.Hide();
                }
            }
        }

        private void ShowCbx()
        {
            foreach (Control control in this.Controls)
            {
                control.Show();
            }
        }

        private void ClearCbx()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox && control != productTypeCbx)
                {
                    control.Text = "";
                }
            }
            this.modelNameCbx.Items.Clear();
            this.internalStorageCbx.Items.Clear();
            this.ramCbx.Items.Clear();
            this.displayCbx.Items.Clear();
            this.fingerprintCbx.Items.Clear();
            this.rearCameraCbx.Items.Clear();
            this.frontCameraCbx.Items.Clear();
            this.priceCbx.Items.Clear();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
