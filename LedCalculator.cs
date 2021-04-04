using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class LedCalculator : Form
    {
        public LedCalculator()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double Iled = Convert.ToDouble(I_led.Text) / 1000;
            double Uled = Convert.ToDouble(U_led.Text);
            double Usourse = Convert.ToDouble(U_sourse.Text);
            double Kres = Convert.ToDouble(K_res.Text);
            double Rres = (Usourse - Uled) / (Iled * (Kres / 100));
            double Pres = (Usourse - Uled) * (Usourse - Uled) / Rres;

            R_res.Text = Rres.ToString();
            P_res.Text = Pres.ToString();
        }

        private void LedCalculator_Load(object sender, EventArgs e)
        {
            this.Text += " - Alex";
        }
    }
}
