using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeFlorist
{
    public partial class CityBirthDay : Form
    {
        public static StringBuilder stbBDY = new StringBuilder();
        public CityBirthDay()
        {
            InitializeComponent();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCity.SelectedIndex) {
                case 0:

                    textBox1.Text = MainScreen.stbBirthDayOrdersMed.ToString();
                    lblTotal.Text = "Total: "+ MainScreen.bdoTMed;
                    break;

                case 1:
                    textBox1.Text = MainScreen.stbBirthDayOrdersRN.ToString();
                    lblTotal.Text = "Total: " + MainScreen.bdoTRN;
                    break;
                case 2:
                    textBox1.Text = MainScreen.stbBirthDayOrdersSFA.ToString();
                    lblTotal.Text = "Total: " + MainScreen.bdoTSFA;
                    break;
            }
        }

        private void CityBirthDay_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
