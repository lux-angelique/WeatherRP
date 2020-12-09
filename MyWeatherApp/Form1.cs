using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace MyWeatherApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        
        public void info()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Moscow&appid=b84317f5648a45ffd98987aa8452d409&units=metric";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            weatherResponse wr = JsonConvert.DeserializeObject<weatherResponse>(response);
            lTemp.Text = wr.main.Temp.ToString();
            Lciti.Text = wr.name;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            info();

        }

       

        

    }
}
