using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksDestopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStockSubmit_Click(object sender, EventArgs e)
        {
            string symbol = txtBxSymbol.Text;
            string date = txtBxDate.Text;

            List<string> stockData = Stocks.GetDailyOpenClose(symbol, date);

            Point boxPoint = new Point(13, 140);

            ListView view = new ListView();
            view.AutoSize = true;
            view.Margin = new Padding(5);
            view.Width = 200;
            view.Height = 170;

            Label labelSymbol = new Label();
            labelSymbol.Text = symbol;
            labelSymbol.Font = new Font("Ariel", 10);
            labelSymbol.Location = new Point(10, 5);
            labelSymbol.AutoSize = true;
            view.Controls.Add(labelSymbol);

            Label preMarket = new Label();
            preMarket.Text = "Pre-Market: " + stockData[0].ToString();
            preMarket.Font = new Font("Ariel", 10);
            preMarket.Location = new Point(10, 35);
            preMarket.AutoSize = true;
            view.Controls.Add(preMarket);

            Label open = new Label();
            open.Text = "Open: " + stockData[1].ToString();
            open.Font = new Font("Ariel", 10);
            open.Location = new Point(10, 55);
            open.AutoSize = true;
            view.Controls.Add(open);

            Label close = new Label();
            close.Text = "Close: " + stockData[2].ToString();
            close.Font = new Font("Ariel", 10);
            close.Location = new Point(10, 75);
            close.AutoSize = true;
            view.Controls.Add(close);

            Label afterMarket = new Label();
            afterMarket.Text = "After Market: " + stockData[3].ToString();
            afterMarket.Font = new Font("Ariel", 10);
            afterMarket.Location = new Point(10, 95);
            afterMarket.AutoSize = true;
            view.Controls.Add(afterMarket);

            Label volume = new Label();
            volume.Text = "Volumn: " + stockData[4].ToString();
            volume.Font = new Font("Ariel", 10);
            volume.Location = new Point(10, 115);
            volume.AutoSize = true;
            view.Controls.Add(volume);

            //set location for listview
            view.Location = boxPoint;
            boxPoint.Y += view.Height + 20;

            //adds listview to form
            this.Controls.Add(view);


        }

        private void btnTickerDetail_Click(object sender, EventArgs e)
        {
            string symbol = txtBxSymbol.Text;

            List<List<string>> detail = (List<List<string>>)Stocks.GetTickerDetails(symbol);

            Point boxPoint = new Point(250, 13);

            ListView view = new ListView();
            view.AutoSize = true;
            view.Margin = new Padding(5);
            view.Scrollable = true;
            view.Width = 340;
            view.Height = 200;
            

            Label labelSymbol = new Label();
            labelSymbol.Text = symbol;
            labelSymbol.Font = new Font("Ariel", 10);
            labelSymbol.Location = new Point(10, 5);
            labelSymbol.AutoSize = true;
            view.Controls.Add(labelSymbol);

            Label listDate = new Label();
            listDate.Text = "List Date: " + detail[0][0].ToString();
            listDate.Font = new Font("Ariel", 10);
            listDate.Location = new Point(10, 35);
            listDate.AutoSize = true;
            view.Controls.Add(listDate);

            Label ceo = new Label();
            ceo.Text = "CEO: " + detail[0][4].ToString();
            ceo.Font = new Font("Ariel", 10);
            ceo.Location = new Point(10, 55);
            ceo.AutoSize = true;
            view.Controls.Add(ceo);

            Label hqCountry = new Label();
            hqCountry.Text = "Headquarter Country: " + detail[0][1].ToString();
            hqCountry.Font = new Font("Ariel", 10);
            hqCountry.Location = new Point(10, 75);
            hqCountry.AutoSize = true;
            view.Controls.Add(hqCountry);

            Label industry = new Label();
            industry.Text = "Industry: " + detail[0][2].ToString();
            industry.Font = new Font("Ariel", 10);
            industry.Location = new Point(10, 95);
            industry.AutoSize = true;
            view.Controls.Add(industry);

            Label sector = new Label();
            sector.Text = "Sector: " + detail[0][3].ToString();
            sector.Font = new Font("Ariel", 10);
            sector.Location = new Point(10, 115);
            sector.AutoSize = true;
            view.Controls.Add(sector);

            Label exchange = new Label();
            exchange.Text = "Exchange: " + detail[0][5].ToString();
            exchange.Font = new Font("Ariel", 10);
            exchange.Location = new Point(10, 135);
            exchange.AutoSize = true;
            view.Controls.Add(exchange);

            //Label description = new Label();
            //description.Text = "Company Description: " + Environment.NewLine + detail[0][6].ToString();
            //description.Font = new Font("Ariel", 10);
            //description.Location = new Point(10, 155);
            //description.Dock = new DockStyle();
            //description.AutoSize = false;
            //view.Controls.Add(description);

            ListView similiarCompany = new ListView(); 
            similiarCompany.Width = 340;
            similiarCompany.Height = 200;
            similiarCompany.Scrollable = true;


            Label label = new Label();
            label.Text = "Similiar Companies";
            label.Location = new Point(5, 5);
            label.Font = new Font("Ariel", 10);
            label.AutoSize = true;
            similiarCompany.Controls.Add(label);

            Point sPoint = new Point(250, 250);
            Point lPoint = new Point(5,30);
            foreach (var s in detail[1])
            {
                
                Label similiar = new Label();
                similiar.Text = s.ToString();
                similiar.Font = new Font("Ariel", 10);
                similiar.Location = lPoint;
                similiar.AutoSize = true;
                similiarCompany.Controls.Add(similiar);

                lPoint = new Point(lPoint.X, lPoint.Y + 20);

            }
            similiarCompany.Location = sPoint;
            sPoint.Y += similiarCompany.Height + 20;
            this.Controls.Add(similiarCompany);


            //set location for listview
            view.Location = boxPoint;
            boxPoint.Y += view.Height + 20;

            //adds listview to form
            this.Controls.Add(view);
        }

        
    }
}
