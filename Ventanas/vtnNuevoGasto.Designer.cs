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
            btnCargar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            tbConcepto = new TextBox();
            tbCategoria = new TextBox();
            label2 = new Label();
            tbCantidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbPeriodicidad = new ComboBox();
            cmbDivisa = new ComboBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCargar.BackColor = Color.FromArgb(164, 186, 114);
            btnCargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCargar.Location = new Point(12, 182);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(142, 57);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar/Cambiar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(164, 186, 114);
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(160, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 57);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Gasto";
            // 
            // tbConcepto
            // 
            tbConcepto.BackColor = Color.FromArgb(105, 122, 105);
            tbConcepto.Location = new Point(106, 27);
            tbConcepto.Name = "tbConcepto";
            tbConcepto.Size = new Size(196, 23);
            tbConcepto.TabIndex = 3;
            // 
            // tbCategoria
            // 
            tbCategoria.BackColor = Color.FromArgb(105, 122, 105);
            tbCategoria.Location = new Point(106, 56);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(196, 23);
            tbCategoria.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoría";
            // 
            // tbCantidad
            // 
            tbCantidad.BackColor = Color.FromArgb(105, 122, 105);
            tbCantidad.Location = new Point(106, 85);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(101, 23);
            tbCantidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Periodicidad";
            // 
            // cmbPeriodicidad
            // 
            cmbPeriodicidad.BackColor = Color.FromArgb(105, 122, 105);
            cmbPeriodicidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodicidad.FormattingEnabled = true;
            cmbPeriodicidad.Items.AddRange(new object[] { "Semanal", "Mensual", "Anual" });
            cmbPeriodicidad.Location = new Point(106, 114);
            cmbPeriodicidad.Name = "cmbPeriodicidad";
            cmbPeriodicidad.Size = new Size(196, 23);
            cmbPeriodicidad.TabIndex = 9;
            // 
            // cmbDivisa
            // 
            cmbDivisa.BackColor = Color.FromArgb(105, 122, 105);
            cmbDivisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDivisa.FormattingEnabled = true;
            cmbDivisa.Items.AddRange(new object[] { "Euros", "Dólares" });
            cmbDivisa.Location = new Point(213, 85);
            cmbDivisa.Name = "cmbDivisa";
            cmbDivisa.Size = new Size(89, 23);
            cmbDivisa.TabIndex = 10;
            // 
            // vtnNuevoGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 186, 160);
            ClientSize = new Size(314, 251);
            ControlBox = false;
            Controls.Add(cmbDivisa);
            Controls.Add(cmbPeriodicidad);
            Controls.Add(label4);
            Controls.Add(tbCantidad);
            Controls.Add(label3);
            Controls.Add(tbCategoria);
            Controls.Add(label2);
            Controls.Add(tbConcepto);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            MaximumSize = new Size(330, 290);
            MinimumSize = new Size(330, 290);
            Name = "vtnNuevoGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Editar un gasto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private Button btnCancelar;
        private Label label1;
        private TextBox tbConcepto;
        private TextBox tbCategoria;
        private Label label2;
        private TextBox tbCantidad;
        private Label label3;
        private Label label4;
        private ComboBox cmbPeriodicidad;
        private ComboBox cmbDivisa;
    }
}