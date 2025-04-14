namespace TouMoneyManager
{
    partial class vtnNuevoGasto
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            lblCantidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            cmbDivisa = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(142, 57);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(160, 381);
            button2.Name = "button2";
            button2.Size = new Size(142, 57);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Gasto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Origen";
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(102, 85);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 23);
            lblCantidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Periodicidad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 9;
            // 
            // cmbDivisa
            // 
            cmbDivisa.FormattingEnabled = true;
            cmbDivisa.Items.AddRange(new object[] { "Euros", "Dólares" });
            cmbDivisa.Location = new Point(196, 85);
            cmbDivisa.Name = "cmbDivisa";
            cmbDivisa.Size = new Size(106, 23);
            cmbDivisa.TabIndex = 10;
            // 
            // vtnNuevoGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 450);
            Controls.Add(cmbDivisa);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(lblCantidad);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "vtnNuevoGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vtnNuevoGasto";
            Load += vtnNuevoGasto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox lblCantidad;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox cmbDivisa;
    }
}