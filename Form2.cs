using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Form2 : Form
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
        private Button btnSpecs = new Button();

        public Form2()
        {
            InitializeComponent();

            this.btnSave.Click += new EventHandler(this.BtnSave_Click);
            this.btnSpecs.Click += new EventHandler(this.BtnSpecs_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1300, 750);
            this.CenterToParent();
            this.BackColor = Color.NavajoWhite;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //titlu la form AddItem
            //de pus titlu si imagine la pagina/
            //resize la tot 

            Font cbxFont = new Font("Georgia", 12);
            Font labelFont = new Font("Times New Roman", 14.0f);

            //product type
            this.productTypeLabel.Location = new Point((this.Width-productTypeLabel.Width*2)/2, 40);
            this.productTypeLabel.Text = "Product type: ";
            this.productTypeLabel.Size = new Size(200, 20);
            this.productTypeLabel.Font = labelFont;

            this.productTypeCbx.Location = new Point((this.Width - productTypeLabel.Width) / 2, 70);
            this.productTypeCbx.Name = "Product type";
            this.productTypeCbx.Size = new Size(200, 50);
            this.productTypeCbx.Font = cbxFont;
            this.productTypeCbx.Items.Add("Laptop");
            this.productTypeCbx.Items.Add("Smartphone");
            this.productTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;


            //company
            this.companyLabel.Location = new Point(100, 140);
            this.companyLabel.Size = new Size(200, 20);
            this.companyLabel.Text = "Company: ";
            this.companyLabel.Font = labelFont;

            this.companyCbx.Location = new Point(100, 170);
            this.companyCbx.Name = "Company";
            this.companyCbx.Size = new Size(200, 50);
            this.companyCbx.Font = cbxFont;
            this.companyCbx.Items.Add("Emag");
            this.companyCbx.Items.Add("Altex");
            this.companyCbx.Items.Add("Flanco");
            this.companyCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.companyCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //model name
            this.modelNameLabel.Location = new Point(100, 250);
            this.modelNameLabel.Size = new Size(200, 20);
            this.modelNameLabel.Text = "Model name: ";
            this.modelNameLabel.Font = labelFont;

            this.modelNameCbx.Location = new Point(100, 280);
            this.modelNameCbx.Name = "Model name";
            this.modelNameCbx.Size = new Size(200, 50);
            this.modelNameCbx.Font = cbxFont;
            this.modelNameCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.modelNameCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Internal storage
            this.internalStorageLabel.Location = new Point(100, 360);
            this.internalStorageLabel.Size = new Size(200, 20);
            this.internalStorageLabel.Text = "Internal Storage: ";
            this.internalStorageLabel.Font = labelFont;

            this.internalStorageCbx.Location = new Point(100, 390);
            this.internalStorageCbx.Name = "Internal Storage ";
            this.internalStorageCbx.Size = new Size(200, 50);
            this.internalStorageCbx.Font = cbxFont;
            this.internalStorageCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.internalStorageCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //RAM
            this.ramLabel.Location = new Point(400, 140);
            this.ramLabel.Size = new Size(200, 20);
            this.ramLabel.Text = "RAM: ";
            this.ramLabel.Font = labelFont;

            this.ramCbx.Location = new Point(400, 170);
            this.ramCbx.Name = "RAM";
            this.ramCbx.Size = new Size(200, 50);
            this.ramCbx.Font = cbxFont;
            this.ramCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ramCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //display
            this.displayLabel.Location = new Point(400, 250);
            this.displayLabel.Size = new Size(200, 20);
            this.displayLabel.Text = "Display: ";
            this.displayLabel.Font = labelFont;

            this.displayCbx.Location = new Point(400, 280);
            this.displayCbx.Name = "Display";
            this.displayCbx.Size = new Size(200, 50);
            this.displayCbx.Font = cbxFont;
            this.displayCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.displayCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //fingerprint sensor
            this.fingerprintLabel.Location = new Point(400, 360);
            this.fingerprintLabel.Size = new Size(200, 20);
            this.fingerprintLabel.Text = "Fingerprint sensor: ";
            this.fingerprintLabel.Font = labelFont;

            this.fingerprintCbx.Location = new Point(400, 390);
            this.fingerprintCbx.Name = "Fingerprint sensor";
            this.fingerprintCbx.Size = new Size(200, 50);
            this.fingerprintCbx.Font = cbxFont;
            this.fingerprintCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.fingerprintCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //rear camera
            this.rearCameraLabel.Location = new Point(700, 140);
            this.rearCameraLabel.Size = new Size(200, 20);
            this.rearCameraLabel.Text = "Rear camera: ";
            this.rearCameraLabel.Font = labelFont;

            this.rearCameraCbx.Location = new Point(700, 170);
            this.rearCameraCbx.Name = "Rear camera";
            this.rearCameraCbx.Size = new Size(200, 50);
            this.rearCameraCbx.Font = cbxFont;
            this.rearCameraCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.rearCameraCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //front camera
            this.frontCameraLabel.Location = new Point(700, 250);
            this.frontCameraLabel.Size = new Size(200, 20);
            this.frontCameraLabel.Text = "Front camera: ";
            this.frontCameraLabel.Font = labelFont;

            this.frontCameraCbx.Location = new Point(700, 280);
            this.frontCameraCbx.Name = "Front camera";
            this.frontCameraCbx.Size = new Size(200, 50);
            this.frontCameraCbx.Font = cbxFont;
            this.frontCameraCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.frontCameraCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //price
            this.priceLabel.Location = new Point(700, 360);
            this.priceLabel.Size = new Size(200, 20);
            this.priceLabel.Text = "Price: ";
            this.priceLabel.Font = labelFont;

            this.priceCbx.Location = new Point(700, 390);
            this.priceCbx.Name = "Price";
            this.priceCbx.Size = new Size(200, 50);
            this.priceCbx.Font = cbxFont;
            this.priceCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.priceCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.btnSpecs.Location = new Point((this.Width - btnSpecs.Width) / 2, 100);
            this.btnSpecs.Text = "Select specs";
            this.btnSpecs.Size = new Size(80, 25);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 1;

            this.btnSave.Location = new Point(800, 500);
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 1;

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
            this.Controls.Add(btnSpecs);
        }

        private void BtnSpecs_Click(object sender, EventArgs e)
        {
            ClearCbx();
            
            if (this.productTypeCbx.Text == "Smartphone")
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
            else if (this.productTypeCbx.Text == "Laptop")
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
            }
            else
            {
                HideCbx();
                MessageBox.Show("You forgot to select a product type.");
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
