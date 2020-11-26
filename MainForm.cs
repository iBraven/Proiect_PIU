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
    public partial class MainForm : Form
    {
        private Panel menuPanel = new Panel();
        private Panel contentPanel = new Panel();

        private Button productTypeBtn = new Button();
        private Button customersBtn = new Button();
        private Button invoiceSearchBtn = new Button();
        private Button storeStockBtn = new Button();
        private Button deleteProductBtn = new Button();

        public MainForm()
        {
            InitializeComponent();

            this.productTypeBtn.Click += new EventHandler(this.ProductTypeBtn_Click);
            this.customersBtn.Click += new EventHandler(this.CustomersBtn_Click);
            this.invoiceSearchBtn.Click += new EventHandler(this.InvoiceSearchBtn_Click);
            this.storeStockBtn.Click += new EventHandler(this.StoreStockBtn_Click);
            this.deleteProductBtn.Click += new EventHandler(this.DeleteProductBtn_Click);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Font titlesFont = new Font("Times New Roman", 16.0f);

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1500, 750);
            this.CenterToParent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ModifyContentPanel(new ProductType());

            this.menuPanel.Location = new Point(0, 0);
            this.menuPanel.Size = new Size(150, 750);
            this.menuPanel.BackColor = Color.White;

            this.contentPanel.Location = new Point(150, 0);
            this.contentPanel.Size = new Size(1350, 750);
            this.contentPanel.BackColor = Color.YellowGreen;

            this.productTypeBtn.Location = new Point(0, 0);
            this.productTypeBtn.Size = new Size(150, 140);
            this.productTypeBtn.Text = "Add to store";
            this.productTypeBtn.FlatStyle = FlatStyle.Flat;
            this.productTypeBtn.FlatAppearance.BorderColor = Color.Black;
            this.productTypeBtn.FlatAppearance.BorderSize = 1;
            this.productTypeBtn.Font = titlesFont;
            this.productTypeBtn.BackColor = Color.Olive;

            this.customersBtn.Location = new Point(0,140);
            this.customersBtn.Size = new Size(150, 140);
            this.customersBtn.Text = "Customers";
            this.customersBtn.FlatStyle = FlatStyle.Flat;
            this.customersBtn.FlatAppearance.BorderColor = Color.Black;
            this.customersBtn.FlatAppearance.BorderSize = 1;
            this.customersBtn.Font = titlesFont;
            this.customersBtn.BackColor = Color.Olive;

            this.invoiceSearchBtn.Location = new Point(0,280);
            this.invoiceSearchBtn.Size = new Size(150, 140);
            this.invoiceSearchBtn.Text = "Search invoice";
            this.invoiceSearchBtn.FlatStyle = FlatStyle.Flat;
            this.invoiceSearchBtn.FlatAppearance.BorderColor = Color.Black;
            this.invoiceSearchBtn.FlatAppearance.BorderSize = 1;
            this.invoiceSearchBtn.Font = titlesFont;
            this.invoiceSearchBtn.BackColor = Color.Olive;

            this.storeStockBtn.Location = new Point(0,420);
            this.storeStockBtn.Size = new Size(150, 140);
            this.storeStockBtn.Text = "Store stock";
            this.storeStockBtn.FlatStyle = FlatStyle.Flat;
            this.storeStockBtn.FlatAppearance.BorderColor = Color.Black;
            this.storeStockBtn.FlatAppearance.BorderSize = 1;
            this.storeStockBtn.Font = titlesFont;
            this.storeStockBtn.BackColor = Color.Olive;

            this.deleteProductBtn.Location = new Point(0,560);
            this.deleteProductBtn.Size = new Size(150, 150);
            this.deleteProductBtn.Text = "Delete product";
            this.deleteProductBtn.FlatStyle = FlatStyle.Flat;
            this.deleteProductBtn.FlatAppearance.BorderColor = Color.Black;
            this.deleteProductBtn.FlatAppearance.BorderSize = 1;
            this.deleteProductBtn.Font = titlesFont;
            this.deleteProductBtn.BackColor = Color.Olive;


            this.Controls.Add(menuPanel);
            this.Controls.Add(contentPanel);
            this.menuPanel.Controls.Add(productTypeBtn);
            this.menuPanel.Controls.Add(customersBtn);
            this.menuPanel.Controls.Add(invoiceSearchBtn);
            this.menuPanel.Controls.Add(storeStockBtn);
            this.menuPanel.Controls.Add(deleteProductBtn);
        }

        private void ProductTypeBtn_Click(object sender, EventArgs e)
        {
            ModifyContentPanel(new ProductType());
        }
        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            ModifyContentPanel(new Customers());
        }
        private void InvoiceSearchBtn_Click(object sender, EventArgs e)
        {
            ModifyContentPanel(new InvoiceSearch());
        }
        private void StoreStockBtn_Click(object sender, EventArgs e)
        {
            ModifyContentPanel(new StoreStock());
        }
        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            ModifyContentPanel(new DeleteProduct());
        }

        private void ModifyContentPanel(Form newForm)
        {
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopLevel = false;
            newForm.ControlBox = false;
            newForm.Text = String.Empty;
            contentPanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }
    }
}
