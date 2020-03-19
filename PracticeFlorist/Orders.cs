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
    public partial class Orders : Form
    {
        public static List<Order> OrderList = new List<Order>();
        List<Courier> cbxOrderList = new List<Courier>();

        public Orders()
        {
            InitializeComponent();
            startListView();
        }

        public void addOrder()
        {
            try
            {
                if (cbxCourier.Text != "" && cbxType.Text != "" && cbxDestiny.Text != "" && txtCost.Text != "")
                {


                    Order order = new Order(cbxCourier.Text, cbxDestiny.Text, cbxType.Text, int.Parse(txtCost.Text));
                    OrderList.Add(order);
                    addOrderToListView();
                    sumOfTypes(cbxType.Text, int.Parse(txtCost.Text));
                    addPayment(cbxCourier.Text, int.Parse(txtCost.Text));
                    sumOfCities(cbxDestiny.Text, int.Parse(txtCost.Text));
                    addOrderCourier();                
                    if (cbxType.Text.Equals("Cumpleaños"))
                    {
                        addCityBirthDay(cbxDestiny.Text, int.Parse(txtCost.Text), cbxCourier.Text);

                    }
                    MessageBox.Show("Orden agregada Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCourier.SelectedItem = null;
                    cbxType.SelectedItem = null;
                    cbxDestiny.SelectedItem = null;
                    txtCost.Text = "";

                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El costo debe ser un Número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost.Text = "";
            }
        }

        public void addPayment(string id, double cost)
        {
            foreach (Courier courier in MainScreen.avalibleCouriers)
            {
                if (id.Equals(courier.Id))
                {
                    courier.TotalMoney += cost;
                    MainScreen.totalMoney += cost;
                }
            }

        }
        public void addOrderToListView()
        {
            foreach (Order order in OrderList)
            {
                if (!(MainScreen.orderListview.Contains(order)))
                {
                    ListViewItem list = new ListViewItem();
                    list = lvAvalibleOrders.Items.Add(order.Destiny);
                    list.SubItems.Add(order.Type);
                    list.SubItems.Add(order.Cost.ToString());
                    list.SubItems.Add(order.IdCourier);
                    list.SubItems.Add(order.Cost.ToString());
                    MainScreen.orderListview.Add(order);
                }
            }
        }

        public void startListView()
        {
            foreach (Order order in OrderList)
            {
                ListViewItem list = new ListViewItem();
                list = lvAvalibleOrders.Items.Add(order.Destiny);
                list.SubItems.Add(order.Type);
                list.SubItems.Add(order.Cost.ToString());
                list.SubItems.Add(order.IdCourier);
                MainScreen.orderListview.Add(order);

            }
        }

        public void sumOfTypes(string type, int cost)
        {
            switch (type)
            {
                case "Amor y amistad":
                    MainScreen.TSV+=cost;
                    break;
                case "Día de la Madre":
                    MainScreen.TMD+=cost;
                    break;
                case "Aniversario":
                    MainScreen.TANY+=cost;
                    break;
                case "Cumpleaños":
                    MainScreen.TBD+=cost;
                    break;
                case "Otro":
                    MainScreen.TO+=cost;
                    break;
            }

        }
        public void addCourierCbx()
        {
            foreach (Courier courier in MainScreen.avalibleCouriers)
            {
                if (!cbxOrderList.Contains(courier) && cbxDestiny.Text.Equals(courier.City) && courier.Avalible == "Disponible")
                {
                    cbxCourier.Items.Add(courier.Id);
                    cbxOrderList.Add(courier);
                }
            }
        }

        public void addCityBirthDay(string city, int cost, string id)
        {
            switch (city)
            {
                case "Medellin":
                    MainScreen.bdoMed++;
                    MainScreen.stbBirthDayOrdersMed.AppendLine(MainScreen.bdoMed + "- " + "Valor: " + cost + " y Atendido por: " + id);
                    MainScreen.bdoTMed += cost;
                    break;
                case "Rio Negro":
                    MainScreen.bdoRN++;
                    MainScreen.stbBirthDayOrdersRN.AppendLine(MainScreen.bdoRN + "- " + "Valor: " + cost + " y Atendido por: " + id);
                    MainScreen.bdoTRN += cost;
                    break;
                case "Santa Fe de Antioquia":
                    MainScreen.bdoSFA++;
                    MainScreen.stbBirthDayOrdersSFA.AppendLine(MainScreen.bdoSFA + "- " + "Valor: " + cost + " y Atendido por: " + id);
                    MainScreen.bdoTSFA += cost;
                    break;
            }
        }


        public void addOrderCourier()
        {
            foreach (Courier courier in MainScreen.avalibleCouriers)
            {
                if (cbxCourier.Text.Equals(courier.Id))
                {
                    if (courier.MaxOrders < courier.AttendedOrders)
                    {
                        courier.Avalible = "No disponible";
                    }
                    else
                    {
                        courier.AttendedOrders++;
                        if (courier.AttendedOrders == courier.MaxOrders)
                        {
                            courier.Avalible = "No disponible";
                        }
                    }
                }
            }
        }

        public void sumOfCities(string city,int cost) {
            switch (city) {
                case "Medellin":
                    MainScreen.TMed += cost;
                    break;
                case "Rio Negro":
                    MainScreen.TRN += cost;
                    break;
                case "Santa Fe de Antioquia":
                    MainScreen.TSFA += cost;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxOrderList.Clear();
            cbxCourier.Items.Clear();
            addCourierCbx();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void cbxCourier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
