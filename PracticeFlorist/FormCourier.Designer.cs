namespace PracticeFlorist
{
    partial class FormCourier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCourier2 = new System.Windows.Forms.Button();
            this.lblEmployedToAdd = new System.Windows.Forms.Label();
            this.lblTotalCouriers = new System.Windows.Forms.Label();
            this.lblCouriersAddDB = new System.Windows.Forms.Label();
            this.lvAvalibleCouriers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(87, 84);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(100, 20);
            this.txtOrders.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Pedidos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Municipio :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agregar Mensajero";
            // 
            // btnAddCourier2
            // 
            this.btnAddCourier2.Location = new System.Drawing.Point(87, 149);
            this.btnAddCourier2.Name = "btnAddCourier2";
            this.btnAddCourier2.Size = new System.Drawing.Size(107, 23);
            this.btnAddCourier2.TabIndex = 9;
            this.btnAddCourier2.Text = "Agregar Mensajero";
            this.btnAddCourier2.UseVisualStyleBackColor = true;
            this.btnAddCourier2.Click += new System.EventHandler(this.btnAddCorrier2_Click);
            // 
            // lblEmployedToAdd
            // 
            this.lblEmployedToAdd.AutoSize = true;
            this.lblEmployedToAdd.Location = new System.Drawing.Point(3, 193);
            this.lblEmployedToAdd.Name = "lblEmployedToAdd";
            this.lblEmployedToAdd.Size = new System.Drawing.Size(0, 13);
            this.lblEmployedToAdd.TabIndex = 10;
            // 
            // lblTotalCouriers
            // 
            this.lblTotalCouriers.AutoSize = true;
            this.lblTotalCouriers.Location = new System.Drawing.Point(3, 219);
            this.lblTotalCouriers.Name = "lblTotalCouriers";
            this.lblTotalCouriers.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCouriers.TabIndex = 11;
            // 
            // lblCouriersAddDB
            // 
            this.lblCouriersAddDB.AutoSize = true;
            this.lblCouriersAddDB.Location = new System.Drawing.Point(3, 193);
            this.lblCouriersAddDB.Name = "lblCouriersAddDB";
            this.lblCouriersAddDB.Size = new System.Drawing.Size(0, 13);
            this.lblCouriersAddDB.TabIndex = 13;
            this.lblCouriersAddDB.Click += new System.EventHandler(this.lblCouriersAddDB_Click);
            // 
            // lvAvalibleCouriers
            // 
            this.lvAvalibleCouriers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAvalibleCouriers.Location = new System.Drawing.Point(204, 32);
            this.lvAvalibleCouriers.Name = "lvAvalibleCouriers";
            this.lvAvalibleCouriers.Size = new System.Drawing.Size(489, 146);
            this.lvAvalibleCouriers.TabIndex = 14;
            this.lvAvalibleCouriers.UseCompatibleStateImageBehavior = false;
            this.lvAvalibleCouriers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Municipio";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Max Domicilios";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DomAtendidos";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Estado";
            this.columnHeader6.Width = 85;
            // 
            // txtCity
            // 
            this.txtCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Items.AddRange(new object[] {
            "Medellin",
            "Rio Negro",
            "Santa Fe de Antioquia"});
            this.txtCity.Location = new System.Drawing.Point(87, 115);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 15;
            // 
            // FormCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 246);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lvAvalibleCouriers);
            this.Controls.Add(this.lblCouriersAddDB);
            this.Controls.Add(this.lblTotalCouriers);
            this.Controls.Add(this.lblEmployedToAdd);
            this.Controls.Add(this.btnAddCourier2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "FormCourier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensajero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCourier_FormClosing);
            this.Load += new System.EventHandler(this.FormCourier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCourier2;
        private System.Windows.Forms.Label lblEmployedToAdd;
        private System.Windows.Forms.Label lblTotalCouriers;
        private System.Windows.Forms.Label lblCouriersAddDB;
        private System.Windows.Forms.ListView lvAvalibleCouriers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox txtCity;
    }
}