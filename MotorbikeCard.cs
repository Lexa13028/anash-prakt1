using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using anash_prakt1.Models;

namespace anash_prakt1

{
    public partial class MotorbikeCard : UserControl
    {
        public MotorbikeCard()
        {
            InitializeComponent();
        }
       
        public void Fill (Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.Id.ToString();
            labelModelData.Text = Motorbike.Name;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"pictures\{Motorbike.Image}");
        }

        private void l_Click(object sender, EventArgs e)
        {

        }
    }
}
