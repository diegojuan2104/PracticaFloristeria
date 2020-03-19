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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            switch (Query.option)
            {
                case 0:
                    txtResult.Text = Query.stbId.ToString();
                    break;
                case 2:
                    StringBuilder stb = new StringBuilder();

                    stb.AppendLine("Amor y amistad: " + MainScreen.TSV + " Porcentaje: " + string.Format("{0:n2}", (((MainScreen.TSV * 100) / MainScreen.totalMoney))) + "%");
                    stb.AppendLine("Dia de la madre: " + MainScreen.TMD + " Porcentaje: " + string.Format("{0:n2}", (((MainScreen.TMD * 100) / MainScreen.totalMoney))) + "%");
                    stb.AppendLine("Aniversario: " + MainScreen.TANY + " Porcentaje: " + string.Format("{0:n2}", (((MainScreen.TANY * 100) / MainScreen.totalMoney))) + "%");
                    stb.AppendLine("Cumpleaños: " + MainScreen.TBD + " Porcentaje: " + string.Format("{0:n2}", (((MainScreen.TBD * 100) / MainScreen.totalMoney))) + "%");
                    stb.AppendLine("Otros: " + MainScreen.TO + " Porcentaje: " + string.Format("{0:n2}", (((MainScreen.TO * 100) / MainScreen.totalMoney))) + "%");


                    txtResult.Text = stb.ToString();
                    break;
                case 3:
                    StringBuilder stb1 = new StringBuilder();
                    stb1.AppendLine("Medellín: " + MainScreen.TMed);
                    stb1.AppendLine("Rio Negro: " + MainScreen.TRN);
                    stb1.AppendLine("Santa Fe de Antioquia: " + MainScreen.TSFA);

                    txtResult.Text = stb1.ToString();
                    break;
            }
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
