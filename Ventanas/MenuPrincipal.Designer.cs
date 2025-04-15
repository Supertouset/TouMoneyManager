namespace TouMoneyManager
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvGastosRecurrentes = new ListView();
            Concepto = new ColumnHeader();
            btnAddGasto = new Button();
            label1 = new Label();
            btnEditarGasto = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Cantidad = new ColumnHeader();
            SuspendLayout();
            // 
            // lvGastosRecurrentes
            // 
            lvGastosRecurrentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvGastosRecurrentes.BackColor = Color.FromArgb(98, 102, 88);
            lvGastosRecurrentes.Columns.AddRange(new ColumnHeader[] { Concepto, Cantidad });
            lvGastosRecurrentes.Location = new Point(12, 29);
            lvGastosRecurrentes.MultiSelect = false;
            lvGastosRecurrentes.Name = "lvGastosRecurrentes";
            lvGastosRecurrentes.Size = new Size(177, 330);
            lvGastosRecurrentes.TabIndex = 0;
            lvGastosRecurrentes.UseCompatibleStateImageBehavior = false;
            lvGastosRecurrentes.View = View.Details;
            // 
            // Concepto
            // 
            Concepto.Text = "Concepto";
            Concepto.Width = 100;
            // 
            // btnAddGasto
            // 
            btnAddGasto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddGasto.BackColor = Color.FromArgb(164, 186, 114);
            btnAddGasto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddGasto.Location = new Point(12, 365);
            btnAddGasto.Name = "btnAddGasto";
            btnAddGasto.Size = new Size(177, 34);
            btnAddGasto.TabIndex = 1;
            btnAddGasto.Text = "Agregar nuevo gasto";
            btnAddGasto.UseVisualStyleBackColor = false;
            btnAddGasto.Click += btnAddGasto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 17);
            label1.TabIndex = 2;
            label1.Text = "Lista de Gastos Recurrentes";
            // 
            // btnEditarGasto
            // 
            btnEditarGasto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditarGasto.BackColor = Color.FromArgb(164, 186, 114);
            btnEditarGasto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarGasto.Location = new Point(12, 405);
            btnEditarGasto.Name = "btnEditarGasto";
            btnEditarGasto.Size = new Size(177, 34);
            btnEditarGasto.TabIndex = 3;
            btnEditarGasto.Text = "Editar un gasto";
            btnEditarGasto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(97, 101, 87);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(582, 320);
            label2.Name = "label2";
            label2.Size = new Size(210, 39);
            label2.TabIndex = 4;
            label2.Text = "TOTAL GASTOS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(582, 394);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 5;
            label3.Text = "Mensualmente";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(582, 419);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 6;
            label4.Text = "Anualmente";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(582, 369);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 7;
            label5.Text = "Semanalmente";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(743, 371);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 8;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(743, 396);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(743, 421);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 10;
            label8.Text = "0";
            // 
            // Cantidad
            // 
            Cantidad.Width = 70;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 186, 160);
            ClientSize = new Size(804, 451);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditarGasto);
            Controls.Add(label1);
            Controls.Add(btnAddGasto);
            Controls.Add(lvGastosRecurrentes);
            MinimumSize = new Size(600, 300);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TouMoneyManager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvGastosRecurrentes;
        private Button btnAddGasto;
        private Label label1;
        private Button btnEditarGasto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ColumnHeader Concepto;
        private ColumnHeader Cantidad;
    }
}
