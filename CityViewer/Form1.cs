using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityViewer
{
    public partial class Form1 : Form
    {

        int indexCurrentImage = 0;
        CityModel selectedCity;
        private readonly string PATH = $"{Environment.CurrentDirectory}\\CitiesDataList.json";
        BindingList<CityModel> Cities;
        public Form1()
        {
            InitializeComponent();
            Cities = FileIOService.LoadData(PATH);
           cbCityes.Items.AddRange((Cities.ToArray<object>()));
        }

        private void cbCityes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cbCityes.SelectedItem != null)
            {
                selectedCity = cbCityes.SelectedItem as CityModel;
                lbNameCity.Text = selectedCity.NameCity;
                pbImageCity.Load(selectedCity.PathesToImg[indexCurrentImage]);
                pbImageCity.SizeMode = PictureBoxSizeMode.StretchImage;
                ssInfo.Items.Add(selectedCity + "," + selectedCity.CountVisited);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedCity != null)
            {
                selectedCity.CountVisited++;
                FileIOService.SaveData(Cities, PATH);
                System.Diagnostics.Process.Start("cmd", "/C start" + " " + selectedCity.PathToWiki);

            }
        }

        private void lbArrowRigth_Click(object sender, EventArgs e)
        {
            if (selectedCity == null)
                return;
            if (indexCurrentImage < selectedCity.PathesToImg.Count-1)
                ++indexCurrentImage;
            else
                indexCurrentImage = 0;
            pbImageCity.Load(selectedCity.PathesToImg[indexCurrentImage]);
            pbImageCity.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lbArrrowLeft_Click(object sender, EventArgs e)
        {
            if (selectedCity == null)
                return;
            if (indexCurrentImage > 0)
                --indexCurrentImage;
            else
                indexCurrentImage = selectedCity.PathesToImg.Count-1;
            pbImageCity.Load(selectedCity.PathesToImg[indexCurrentImage]);
            pbImageCity.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
