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
    public partial class MainScreen : Form
    {
        public static List<Courier> cbxOrderList = new List<Courier>();
        public static List<Courier> couriersList = new List<Courier>();
        public static List<Courier> avalibleCouriers = new List<Courier>();
        public static List<Order> orderListview = new List<Order>();
        public static int totalCouriers = 10;
        public static double totalMoney = 0;

        public static StringBuilder stbBirthDayOrdersMed = new StringBuilder();
        public static StringBuilder stbBirthDayOrdersRN = new StringBuilder();
        public static StringBuilder stbBirthDayOrdersSFA = new StringBuilder();

        public static int bdoContMed;
        public static int bdoContRN;
        public static int bdoCont;

        public static int bdoMed,bdoTMed;
        public static int bdoRN,bdoTRN;
        public static int bdoSFA,bdoTSFA;

        public static double TBD, TMD, TANY, TSV,TO;

        public static double TMed, TRN, TSFA;

        


        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnAddCourrier_Click(object sender, EventArgs e)
        {
            FormCourier ms = new FormCourier();
            ms.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void lvAvalibleCouriers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateListC_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addOrder();
        }

        public void addOrder()
        {
            if (couriersList.Count > 0)
            {
                Orders orders = new Orders();
                orders.Show();
            }
            else
            {

                MessageBox.Show("No hay mensajeros registrados actualmente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query qr = new Query();
            qr.Show();
        }
    }
}

