using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeeftijdControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            DateTime geboorteDag = dtpGeboorteDag.Value;
            TimeSpan leeftijInDagen = vandaag - geboorteDag;
            double leeftijd = (leeftijInDagen.Days / 365.25);
            double dagebDrinken = 18 * 365.25;
            double dagenResterend = dagebDrinken - leeftijInDagen.Days;



            if (leeftijd >= 18)
            {
                MessageBox.Show("De klant mag alcohol drinken");
            }
            else if(leeftijd >= 17)
            {
                MessageBox.Show("U mag drinken vanaf " + geboorteDag.AddYears(18) + "drinken");
            }
            else
            {
                MessageBox.Show("De klant mag  GEEN alcohol drinken");
            }
        }
    }
}
