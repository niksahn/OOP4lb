using OOP1lb.Data;
using OOP1lb.Data.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1lb
{
    public partial class Form3 : Form
    {
        Facade facade;
        public Form3(Zheck zheck)
        {
            facade = new Facade(new Data.Services.ElectricityService(), new Data.Services.WaterService(), zheck);
            InitializeComponent();
            Text = zheck.Name1;
            ServiceInfo Info = facade.GetInfo();
            electricity.Text = Info.electricityPrice.ToString();
            water.Text = Info.waterPrice.ToString();
        }

        private void water_Click(object sender, EventArgs e)
        {

        }

        private void electricity_Click(object sender, EventArgs e)
        {

        }
    }
}
