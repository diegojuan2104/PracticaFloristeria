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
    public partial class FormCourier : Form
    {


        bool EqualId = false;


        public FormCourier()
        {
            InitializeComponent();
            startText();
            startListView();
        }

        private void btnAddCorrier2_Click(object sender, EventArgs e)
        {
            addCouriers();
            addToListView();
        }

        public void addCouriers()
        {
            try
            {
                if (txtName.Text != "" && txtOrders.Text != "" && txtId.Text != "" && txtCity.Text != "")
                {
                    if (MainScreen.couriersList.Count < MainScreen.totalCouriers)
                    {

                        foreach (Courier courier in MainScreen.couriersList)
                        {
                            if (courier.Id.Equals(txtId.Text))
                            {
                                EqualId = true;
                            }
                            else
                            {
                                EqualId = false;
                            }
                        }
                        if (EqualId == false)
                        {
                            if (int.Parse(txtOrders.Text) > 0)
                            {
                                Courier newCourier = new Courier(txtId.Text, txtName.Text, txtCity.Text, int.Parse(txtOrders.Text), 0, "Disponible",0);
                                MainScreen.couriersList.Add(newCourier);


                                MessageBox.Show("El Mensajero ha sido agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                lblCouriersAddDB.Text = "Total Mensajeros añadidos a la DB: " + MainScreen.couriersList.Count;

                                txtName.Text = "";
                                txtOrders.Text = "";
                                txtCity.SelectedItem = null;
                                txtId.Text = "";
                                
                            }
                            else {

                                MessageBox.Show("El máximo de domicilios debe ser mayor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            txtId.Text = "";
                            MessageBox.Show("El Id ingresado ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Todos los mensajeros actuales ya han sido registrados,¿Desea contratar un mensajero nuevo?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MainScreen.totalCouriers++;
                            lblTotalCouriers.Text = "Total de Mensajeros contratados: " + MainScreen.totalCouriers;
                            MessageBox.Show("El Mensajero ha sido contratado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Recuerde que solo podrá agregar la informacioón a la DB de los mensajeros registrados ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La cantidad de domicilios debe ser un entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrders.Text = "";
            }
        }

        public void startText()
        {
            lblTotalCouriers.Text = "Total de Mensajeros contratados: " + MainScreen.totalCouriers;
            lblCouriersAddDB.Text = "Total Mensajeros añadidos a la DB: " + MainScreen.couriersList.Count;

        }
        private void btnEmployCourier_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro/a de querer contratar un nuevo mensajero?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                MainScreen.totalCouriers++;
                lblTotalCouriers.Text = "Total de Mensajeros contratados: " + MainScreen.totalCouriers;
            }
        }
        public void addToListView()
        {
            foreach (Courier courier in MainScreen.couriersList)
            {
                if (!(MainScreen.avalibleCouriers.Contains(courier)))
                {
                    ListViewItem list = new ListViewItem();
                    list = lvAvalibleCouriers.Items.Add(courier.Id);
                    list.SubItems.Add(courier.Name);
                    list.SubItems.Add(courier.City);
                    list.SubItems.Add(courier.MaxOrders.ToString());
                    list.SubItems.Add(courier.AttendedOrders.ToString());
                    list.SubItems.Add(courier.Avalible);
                    MainScreen.avalibleCouriers.Add(courier);
                }
            }
        }

        public void startListView()
        {
            foreach (Courier courier in MainScreen.couriersList)
            {

                ListViewItem list = new ListViewItem();
                list = lvAvalibleCouriers.Items.Add(courier.Id);
                list.SubItems.Add(courier.Name);
                list.SubItems.Add(courier.City);
                list.SubItems.Add(courier.MaxOrders.ToString());
                list.SubItems.Add(courier.AttendedOrders.ToString());
                list.SubItems.Add(courier.Avalible);
                MainScreen.avalibleCouriers.Add(courier);
            }
        }



        private void FormCourier_Load(object sender, EventArgs e)
        {

        }

      private void FormCourier_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show("¿Está seguro/a de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
            */
        }

        private void lblCouriersAddDB_Click(object sender, EventArgs e)
        {

        }
    }
}
