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
    public partial class Query : Form
    {
        public static StringBuilder stbId = new StringBuilder();
        public static string idCourier = "";
        public static int option;
        public Query()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbxList.SelectedIndex)
            {

                case 0:
                    option = 0;
                    cbxList.SelectedItem = null;
                    stbId.Clear();
                    IdCourier idc = new IdCourier();
                    idc.Show();
                    break;

                case 1:
                    option = 1;
                    cbxList.SelectedItem = null;
                    CityBirthDay cbd = new CityBirthDay();
                    cbd.Show();
                    break;
                case 2:
                    option = 2;
                    cbxList.SelectedItem = null;
                    Result rs = new Result();
                    rs.Show();
                    break;
                case 3:
                    option = 3;
                    cbxList.SelectedItem = null;
                    Result rst = new Result();
                    rst.Show();
                    break;
            }


        }
        public static void idCourierFind(StringBuilder stb1)
        {
            bool found = false;
            string prc;
            foreach (Courier courier in MainScreen.avalibleCouriers)
            {
                if (idCourier.Equals(courier.Id))
                {
                    prc = string.Format("{0:n2}", (courier.TotalMoney * 100) / (MainScreen.totalMoney));

                    stb1.AppendLine("MENSAJERO: " + courier.Name);
                    stb1.AppendLine("ID: " + courier.Id);
                    stb1.AppendLine("MUNICIPIO: " + courier.City);
                    stb1.AppendLine("PEDIDOS ATENDIDOS:" + courier.AttendedOrders);
                    stb1.AppendLine("TOTAL VALOR RECIBIDO: " + courier.TotalMoney);
                    stb1.AppendLine("PORCENTAJE REPRESENTADO: " + prc + " %");
                    Result rs = new Result();
                    rs.Show();
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("El mensajero con ese Id no ha sido encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Query_Load(object sender, EventArgs e)
        {

        }
    }
}
