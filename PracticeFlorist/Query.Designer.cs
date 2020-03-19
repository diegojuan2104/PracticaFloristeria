namespace PracticeFlorist
{
    partial class Query
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
            this.cbxList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxList
            // 
            this.cbxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxList.FormattingEnabled = true;
            this.cbxList.Items.AddRange(new object[] {
            "Datos por mensajero",
            "Cumpleaños por municipio",
            "Valor y % por ocasión",
            "Valor obtenido por municipio"});
            this.cbxList.Location = new System.Drawing.Point(68, 55);
            this.cbxList.Name = "cbxList";
            this.cbxList.Size = new System.Drawing.Size(135, 21);
            this.cbxList.TabIndex = 0;
            this.cbxList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una opción:";
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxList);
            this.Name = "Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxList;
        private System.Windows.Forms.Label label1;
    }
}