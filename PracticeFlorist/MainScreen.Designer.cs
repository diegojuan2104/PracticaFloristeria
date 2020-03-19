namespace PracticeFlorist
{
    partial class MainScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCourier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCourier
            // 
            this.btnAddCourier.Location = new System.Drawing.Point(45, 27);
            this.btnAddCourier.Name = "btnAddCourier";
            this.btnAddCourier.Size = new System.Drawing.Size(121, 41);
            this.btnAddCourier.TabIndex = 0;
            this.btnAddCourier.TabStop = false;
            this.btnAddCourier.Text = "Agregar Mensajeros";
            this.btnAddCourier.UseVisualStyleBackColor = true;
            this.btnAddCourier.Click += new System.EventHandler(this.btnAddCourrier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hacer Domicilio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Consultas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(393, 166);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCourier);
            this.Name = "MainScreen";
            this.Text = "Floristeria Rosa Cattleya";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

