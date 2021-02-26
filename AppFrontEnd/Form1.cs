using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            VehicleData vd= null;
            VehicleData.vehicalType type = (VehicleData.vehicalType) vType.SelectedIndex;
            switch (type)
            {
                case VehicleData.vehicalType.Car:
                    vd = new VehicleData(make.Text.ToString(), modle.Text.ToString(), (Int32)year.Value, (Int32)ListPrice.Value, lName.Text.ToString(), fName.Text.ToString(), email.Text.ToString());
                    vd.vehType = "Car";
                    break;
                case VehicleData.vehicalType.SportsCar:
                    vd = new VehicleData(make.Text.ToString(), modle.Text.ToString(), (Int32)year.Value, (Int32)ListPrice.Value, lName.Text.ToString(), fName.Text.ToString(), email.Text.ToString());
                    vd.vehType = "SportsCar";
                    break;
                case VehicleData.vehicalType.Truck:
                    vd = new VehicleData(make.Text.ToString(), modle.Text.ToString(), (Int32)year.Value, (Int32)ListPrice.Value, lName.Text.ToString(), fName.Text.ToString(), email.Text.ToString());
                    vd.vehType = "Truck";
                    break;
                case VehicleData.vehicalType.Motorcycle:
                    vd = new VehicleData(make.Text.ToString(), modle.Text.ToString(), (Int32)year.Value, (Int32)ListPrice.Value, lName.Text.ToString(), fName.Text.ToString(), email.Text.ToString());
                    vd.vehType = "Motorcycle";
                    break;
                case VehicleData.vehicalType.MotorHome:
                    vd = new VehicleData(make.Text.ToString(), modle.Text.ToString(), (Int32)year.Value, (Int32)ListPrice.Value, lName.Text.ToString(), fName.Text.ToString(), email.Text.ToString());
                    vd.vehType = "MotorHome";
                    break;
                default:
                    MessageBox.Show("select a Vehical Type");
                    break;
            }
            string url = "https://vehiclevannahomeworkhenryboyd.azurewebsites.net/api/BuyerData?code=PJ4rPU9NhVdSlViWUjXAy7GulbkkmMusVIa3Dt7ItJAQKqo30INKUA==";
            var client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url, vd);

            responseLable.Text = response.Content.ReadAsStringAsync().Result.ToString();
            responseLable.Visible = true;
            
        }
    }
}
