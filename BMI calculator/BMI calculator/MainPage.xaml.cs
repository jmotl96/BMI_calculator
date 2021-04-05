using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Double bmi;
        private Double weight;
        private Double hight;
        private Double bottom;

        private void CalulateBMI(object sender, EventArgs e)
        {
            

            if (heightft.Text != null && Weightin.Text != null)
            {
                Debug.WriteLine("if Passed");
                if (heightin.Text != null)
                {
                    Debug.WriteLine("in not null" + heightin.Text);
                    hight = Double.Parse(heightin.Text) + ( Double.Parse(heightft.Text)*12);
                    Debug.WriteLine("in parse passed");
                }
                else
                {
                    Debug.WriteLine("nothing in heightin: " + heightin.Text);
                    hight = Double.Parse(heightft.Text) * 12;
                    Debug.WriteLine("heightft parse passes");
                }

                weight = Double.Parse(Weightin.Text);
                Debug.WriteLine("Weightin parse passed");
                
                bottom = hight * hight;
                bmi = (703 * weight / bottom);
                output.Text = "your BMI: " + bmi;
            }
            else
            {
                output.Text = "please enter info";
                Debug.WriteLine("if failed");
            }
        }
    }
}