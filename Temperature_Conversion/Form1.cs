/*
Celsius to Fahrenheit	° F = 9/5 ( ° C) + 32
Kelvin to Fahrenheit	° F = 9/5 (K - 273) + 32
Fahrenheit to Celsius	° C = 5/9 (° F - 32)
Celsius to Kelvin	K = ° C + 273
Kelvin to Celsius	° C = K - 273
 */

using System;
using System.Windows.Forms;

namespace Temperature_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            ConvertFromFahrenheit();
        }
        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            ConvertFromCelsius();
        }
        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            ConvertFromKelvin();
        }


        private void ConvertFromFahrenheit()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_Fahrenheit.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Try only numbers.");
            }
            
            
            float c = 5f / 9f * (f - 32);
            float k = c - 273;
            
            txt_Celsius.Text = c.ToString();
            txt_Kelvin.Text = k.ToString();
        }
        private void ConvertFromCelsius()
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_Celsius.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Try only numbers.");
            }
            
            
            float f = (c*9) / 5f +32;
            float k = c + 273;
            
            txt_Fahrenheit.Text = f.ToString();
            txt_Kelvin.Text = k.ToString();
        }
        private void ConvertFromKelvin()
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_Kelvin.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Try only numbers.");
            }
            
            
            float f = 9f / 5f * (k - 273) + 32;
            float c = k - 273;
            
            txt_Fahrenheit.Text = f.ToString();
            txt_Celsius.Text = c.ToString();
        }
    }
}