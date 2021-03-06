﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class StoreStock : Form
    {
        private Label stockLabel1 = new Label();
        private Label stockLabel2 = new Label();
        private Panel stockPanel1 = new Panel();
        private Panel stockPanel2 = new Panel();
        private Label title = new Label();
        private PictureBox stockPicture = new PictureBox();

        List<string[]> rows = File.ReadAllLines(@"..\..\Resources\testdata.csv").Select(x => x.Split(',')).ToList();
        public StoreStock()
        {
            InitializeComponent();
            this.stockPanel1.Paint += new PaintEventHandler(this.StockPanel1_Paint);
            this.stockPanel2.Paint += new PaintEventHandler(this.StockPanel2_Paint);

        }

        private void getProducts()
        {
            List<string[]> rows = File.ReadAllLines(@"..\..\Resources\testdata.csv").Select(x => x.Split(',')).ToList();
            foreach (var row in rows)
            {               
                for (int i = 0; i < row.Length; ++i)
                {            
                    //MessageBox.Show(row[i]);
                }
            }
        }

        private void StoreStock_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 750);
            this.CenterToParent();
            this.BackColor = Color.MediumAquamarine;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Font customerLabelFont = new Font("Times New Roman", 25);
            Font labelFont = new Font("Times New Roman", 15.0f);

            //title
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\", "stock.png");
            stockPicture.Image = Image.FromFile(path);
            stockPicture.SizeMode = PictureBoxSizeMode.AutoSize;

            this.title.Text = "Store Stock";
            this.title.Font = customerLabelFont;
            this.title.Size = new Size(105, 0);
            this.title.AutoSize = true;
            this.title.Location = new Point((this.Width - this.title.Width) / 2, 50);

            //image
            this.stockPicture.Location = new Point(475, 20);

            //stock label1
            this.stockLabel1.Location = new Point(75, 120);
            this.stockLabel1.Text = "Select the product: ";
            this.stockLabel1.Size = new Size(200, 20);
            this.stockLabel1.Font = labelFont;

            //stock label2
            this.stockLabel2.Location = new Point(195, 370);
            this.stockLabel2.Text = "Stored product: ";
            this.stockLabel2.Size = new Size(200, 20);
            this.stockLabel2.Font = labelFont;

            //invoicePanel1
            this.stockPanel1.Location = new Point(80, 150);
            this.stockPanel1.Size = new Size(1170, 200);

            //invoicePanel2
            this.stockPanel2.Location = new Point(200, 400);
            this.stockPanel2.Size = new Size(950, 200);


            //CONTROLS
            this.Controls.Add(title);
            this.Controls.Add(stockLabel1);
            this.Controls.Add(stockLabel2);
            this.Controls.Add(stockPicture);
            this.Controls.Add(stockPanel1);
            this.Controls.Add(stockPanel2);

            string products = String.Empty;
            DataTable dt = ConvertCSVtoDataTable(@"..\..\Resources\testdata.csv");
            if (dt.Rows.Count > 0)
            {
             
                    foreach(DataRow row in dt.Rows)
                    {
                        foreach (DataColumn column in dt.Columns)
                        {
                            products += (Convert.ToString(row[column]));
                        }
                        products+=System.Environment.NewLine;
                            
                    }

            }
            MessageBox.Show(products);
        }

        private void StockPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, stockPanel1.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Black, 1, ButtonBorderStyle.Solid, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
            stockPanel1.BackColor = Color.White;
        }
        private void StockPanel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, stockPanel2.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Black, 1, ButtonBorderStyle.Solid, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
            stockPanel2.BackColor = Color.LightGray;
        }

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                    
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        
    }
}
