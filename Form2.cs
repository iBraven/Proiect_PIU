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
    public partial class Form2 : Form
    {
        private Label companyLabel = new Label();
        private ComboBox companyCbx = new ComboBox();
        private Button btnSave = new Button();

        public Form2()
        {
            InitializeComponent();

            this.btnSave.Click += new EventHandler(this.btnSave_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.CenterToParent();
            this.BackColor = Color.NavajoWhite;

            Font cbxFont = new Font("Georgia", 12);
            Font labelFont = new Font("Times New Roman", 14.0f);

            this.companyLabel.Location = new Point(100, 70);
            this.companyLabel.Text = "Company: ";
            this.companyLabel.Font = labelFont;

            this.companyCbx.Location = new Point(100, 100);
            this.companyCbx.Name = "Company";
            this.companyCbx.Size = new Size(200, 50);
            this.companyCbx.Font = cbxFont;
            this.companyCbx.Items.Add("Samsung");
            this.companyCbx.Items.Add("LG");
            this.companyCbx.Items.Add("Apple");
            this.companyCbx.Items.Add("Asus");



            this.btnSave.Location = new Point(800, 500);
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 1;

            this.Controls.Add(companyLabel);
            this.Controls.Add(companyCbx);
            this.Controls.Add(btnSave);
            //ANDREI
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(companyCbx.Text);
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
