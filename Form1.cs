using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FBtn_Click(object sender, EventArgs e)
        {
            FarhenheightFormula();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            CelciusFormula();
        }

        private void KBtn_Click(object sender, EventArgs e)
        {
            KelvinFormula();
        }

        private void MPH_Btn_Click(object sender, EventArgs e)
        {
            MilesFormula();
        }

        private void KPH_Btn_Click(object sender, EventArgs e)
        {
            KilometersFormula();
        }

        private void BTU_Btn_Click(object sender, EventArgs e)
        {
            BritishThermalFormula();
        }

        private void KWH_Btn_Click(object sender, EventArgs e)
        {
            KiloWattFormula();
        }

        private void KPA_Btn_Click(object sender, EventArgs e)
        {
            KiloPascalFormula();
        }

        private void BAR_Btn_Click(object sender, EventArgs e)
        {
            BarFormula();
        }

        
        private void FarhenheightFormula()
        {
            try
            {
                float f = float.Parse(FTxtBox.Text);
                float FcConvert = 5f / 9f * (f - 32); // 5f : the f is not the variable name, its a suffix to represent the value as a float
                float FkConvert = FcConvert - 273;  // check up on suffixes in c# to understand more

                CTxtBox.Text = FcConvert.ToString();
                KTxtBox.Text = FkConvert.ToString();
            }
            catch
            {

                MessageBox.Show("you entered a wrong value");
            }

        }

        private void CelciusFormula()
        {
          

            float c = float.Parse(CTxtBox.Text);

            float CfConvert = 9f / 5f * c + 32;
            float CkConvert = CfConvert + 273;

            FTxtBox.Text = CfConvert.ToString();
            KTxtBox.Text = CkConvert.ToString();
        }

        private void KelvinFormula()
        {

            float k = float.Parse(KTxtBox.Text);

            float KcConvert = k - 273;
            float KfConvert = KcConvert * 9f / 5f + 32;

            FTxtBox.Text = KfConvert.ToString();
            CTxtBox.Text = KcConvert.ToString();
        }

        private void MilesFormula()
        {
            double m = double.Parse(MPH_txtBox.Text);

            double MPH_convert = m * 1.61d;

            KPH_txtBox.Text = MPH_convert.ToString();
        }

        private void KilometersFormula()
        {
            double km = double.Parse(KPH_txtBox.Text);

            double KPH_convert = km / 1.61d;

            MPH_txtBox.Text = KPH_convert.ToString();
        }

        private void BritishThermalFormula()
        {
            double btu = double.Parse(BTU_txtBox.Text);

            double BTU_convert = btu * 0.000293071d;

            KWH_txtBox.Text = BTU_convert.ToString();
        }

        private void KiloWattFormula()
        {
            double kw = double.Parse(KWH_txtBox.Text);

            double KWH_convert = kw / 0.000293071d;

            BTU_txtBox.Text = KWH_convert.ToString();
        }

        private void KiloPascalFormula()
        {
            float kpa = float.Parse(KPA_txtBox.Text);

            float KPA_convert = kpa / 100f;

            BAR_txtBox.Text = KPA_convert.ToString();
        }

        private void BarFormula()
        {
            float bar = float.Parse(BAR_txtBox.Text);

            float BAR_convert = bar * 100f;

            KPA_txtBox.Text = BAR_convert.ToString();
        }
            

    }
}
