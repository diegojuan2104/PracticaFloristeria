namespace PracticeFlorist
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxCourier = new System.Windows.Forms.ComboBox();
            this.cbxDestiny = new System.Windows.Forms.ComboBox();
            this.lvAvalibleOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ocasión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensajero";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Amor y amistad",
            "Día de la Madre",
            "Aniversario",
            "Cumpleaños",
            "Otro"});
            this.cbxType.Location = new System.Drawing.Point(79, 79);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 4;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxCourier
            // 
            this.cbxCourier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourier.FormattingEnabled = true;
            this.cbxCourier.Location = new System.Drawing.Point(79, 108);
            this.cbxCourier.Name = "cbxCourier";
            this.cbxCourier.Size = new System.Drawing.Size(121, 21);
            this.cbxCourier.TabIndex = 5;
            this.cbxCourier.SelectedIndexChanged += new System.EventHandler(this.cbxCourier_SelectedIndexChanged);
            // 
            // cbxDestiny
            // 
            this.cbxDestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestiny.FormattingEnabled = true;
            this.cbxDestiny.Items.AddRange(new object[] {
            "Medellin",
            "Rio Negro",
            "Santa Fe de Antioquia"});
            this.cbxDestiny.Location = new System.Drawing.Point(79, 45);
            this.cbxDestiny.Name = "cbxDestiny";
            this.cbxDestiny.Size = new System.Drawing.Size(121, 21);
            this.cbxDestiny.TabIndex = 6;
            this.cbxDestiny.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lvAvalibleOrders
            // 
            this.lvAvalibleOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAvalibleOrders.Location = new System.Drawing.Point(231, 35);
            this.lvAvalibleOrders.Name = "lvAvalibleOrders";
            this.lvAvalibleOrders.Size = new System.Drawing.Size(473, 146);
            this.lvAvalibleOrders.TabIndex = 15;
            this.lvAvalibleOrders.UseCompatibleStateImageBehavior = false;
            this.lvAvalibleOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Municipio";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ocasión";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Costo";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id Mensajero";
            this.columnHeader4.Width = 177;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(79, 173);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(121, 23);
            this.btnAddOrder.TabIndex = 16;
            this.btnAddOrder.Text = "Agregar Domicilio";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Costo :";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(79, 138);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(121, 20);
            this.txtCost.TabIndex = 18;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 246);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lvAvalibleOrders);
            this.Controls.Add(this.cbxDestiny);
            this.Controls.Add(this.cbxCourier);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxCourier;
        private System.Windows.Forms.ComboBox cbxDestiny;
        private System.Windows.Forms.ListView lvAvalibleOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
    }
}