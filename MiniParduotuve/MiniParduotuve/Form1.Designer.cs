namespace MiniParduotuve
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KiekisTB = new System.Windows.Forms.TextBox();
            this.SumaTB = new System.Windows.Forms.TextBox();
            this.PridetiIKrepsBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GalutineSumaTB = new System.Windows.Forms.TextBox();
            this.UzsakytiBTN = new System.Windows.Forms.Button();
            this.PrekiuKatalogas = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.KainaL = new System.Windows.Forms.Label();
            this.KainaTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PavTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PirkiniuKrepselis = new System.Windows.Forms.DataGridView();
            this.Pavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiekis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dydis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiuntimoBudas = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SiuntimoIs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PirkiniuKrepselis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasirinkite preke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiekis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma:";
            // 
            // KiekisTB
            // 
            this.KiekisTB.Location = new System.Drawing.Point(393, 290);
            this.KiekisTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KiekisTB.Name = "KiekisTB";
            this.KiekisTB.Size = new System.Drawing.Size(100, 22);
            this.KiekisTB.TabIndex = 4;
            this.KiekisTB.TextChanged += new System.EventHandler(this.KiekisTB_TextChanged);
            this.KiekisTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KiekisTB_KeyPress);
            // 
            // SumaTB
            // 
            this.SumaTB.Location = new System.Drawing.Point(561, 290);
            this.SumaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SumaTB.Name = "SumaTB";
            this.SumaTB.ReadOnly = true;
            this.SumaTB.Size = new System.Drawing.Size(100, 22);
            this.SumaTB.TabIndex = 5;
            // 
            // PridetiIKrepsBTN
            // 
            this.PridetiIKrepsBTN.Location = new System.Drawing.Point(764, 260);
            this.PridetiIKrepsBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridetiIKrepsBTN.Name = "PridetiIKrepsBTN";
            this.PridetiIKrepsBTN.Size = new System.Drawing.Size(115, 55);
            this.PridetiIKrepsBTN.TabIndex = 6;
            this.PridetiIKrepsBTN.Text = "Pridėti į pirkinių krepšelį";
            this.PridetiIKrepsBTN.UseVisualStyleBackColor = true;
            this.PridetiIKrepsBTN.Click += new System.EventHandler(this.PridetiIKrepsBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pirkinių krepšelis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pasirinkite kaip atsiimsite siuntą:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Galutinė suma:";
            // 
            // GalutineSumaTB
            // 
            this.GalutineSumaTB.AcceptsReturn = true;
            this.GalutineSumaTB.Location = new System.Drawing.Point(505, 728);
            this.GalutineSumaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GalutineSumaTB.Name = "GalutineSumaTB";
            this.GalutineSumaTB.ReadOnly = true;
            this.GalutineSumaTB.Size = new System.Drawing.Size(100, 22);
            this.GalutineSumaTB.TabIndex = 12;
            this.GalutineSumaTB.Text = "0.00";
            // 
            // UzsakytiBTN
            // 
            this.UzsakytiBTN.Location = new System.Drawing.Point(764, 691);
            this.UzsakytiBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UzsakytiBTN.Name = "UzsakytiBTN";
            this.UzsakytiBTN.Size = new System.Drawing.Size(115, 59);
            this.UzsakytiBTN.TabIndex = 13;
            this.UzsakytiBTN.Text = "Užsakyti";
            this.UzsakytiBTN.UseVisualStyleBackColor = true;
            this.UzsakytiBTN.Click += new System.EventHandler(this.UzsakytiBTN_Click);
            // 
            // PrekiuKatalogas
            // 
            this.PrekiuKatalogas.AllowUserToAddRows = false;
            this.PrekiuKatalogas.AllowUserToDeleteRows = false;
            this.PrekiuKatalogas.AllowUserToResizeColumns = false;
            this.PrekiuKatalogas.AllowUserToResizeRows = false;
            this.PrekiuKatalogas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PrekiuKatalogas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrekiuKatalogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrekiuKatalogas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PrekiuKatalogas.Location = new System.Drawing.Point(15, 52);
            this.PrekiuKatalogas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrekiuKatalogas.MultiSelect = false;
            this.PrekiuKatalogas.Name = "PrekiuKatalogas";
            this.PrekiuKatalogas.RowTemplate.Height = 24;
            this.PrekiuKatalogas.Size = new System.Drawing.Size(478, 196);
            this.PrekiuKatalogas.TabIndex = 15;
            this.PrekiuKatalogas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PrekiuKatalogas_RowHeaderMouseClick);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(764, 537);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(88, 50);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "Ištrinti iš krepšelio";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // KainaL
            // 
            this.KainaL.AutoSize = true;
            this.KainaL.Location = new System.Drawing.Point(236, 254);
            this.KainaL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KainaL.Name = "KainaL";
            this.KainaL.Size = new System.Drawing.Size(44, 17);
            this.KainaL.TabIndex = 20;
            this.KainaL.Text = "Kaina";
            // 
            // KainaTB
            // 
            this.KainaTB.Location = new System.Drawing.Point(240, 290);
            this.KainaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KainaTB.Name = "KainaTB";
            this.KainaTB.ReadOnly = true;
            this.KainaTB.Size = new System.Drawing.Size(100, 22);
            this.KainaTB.TabIndex = 21;
            this.KainaTB.TextChanged += new System.EventHandler(this.KainaTB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Pavadinimas";
            // 
            // PavTB
            // 
            this.PavTB.Location = new System.Drawing.Point(13, 289);
            this.PavTB.Margin = new System.Windows.Forms.Padding(4);
            this.PavTB.Name = "PavTB";
            this.PavTB.ReadOnly = true;
            this.PavTB.Size = new System.Drawing.Size(132, 22);
            this.PavTB.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 324);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mažai prekei papildomas mokestis netaikomas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Vidutinė prekė +1 Euras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Didelė prekė +2 Eurai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(780, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 29;
            this.label10.Visible = false;
            // 
            // PirkiniuKrepselis
            // 
            this.PirkiniuKrepselis.AllowUserToAddRows = false;
            this.PirkiniuKrepselis.AllowUserToDeleteRows = false;
            this.PirkiniuKrepselis.AllowUserToResizeColumns = false;
            this.PirkiniuKrepselis.AllowUserToResizeRows = false;
            this.PirkiniuKrepselis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PirkiniuKrepselis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PirkiniuKrepselis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PirkiniuKrepselis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pavadinimas,
            this.Kaina,
            this.Kiekis,
            this.Suma,
            this.Dydis});
            this.PirkiniuKrepselis.Location = new System.Drawing.Point(12, 382);
            this.PirkiniuKrepselis.MultiSelect = false;
            this.PirkiniuKrepselis.Name = "PirkiniuKrepselis";
            this.PirkiniuKrepselis.ReadOnly = true;
            this.PirkiniuKrepselis.RowTemplate.Height = 24;
            this.PirkiniuKrepselis.Size = new System.Drawing.Size(735, 205);
            this.PirkiniuKrepselis.TabIndex = 30;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.HeaderText = "Pavadinimas";
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.ReadOnly = true;
            // 
            // Kaina
            // 
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.Name = "Kaina";
            this.Kaina.ReadOnly = true;
            // 
            // Kiekis
            // 
            this.Kiekis.HeaderText = "Kiekis";
            this.Kiekis.Name = "Kiekis";
            this.Kiekis.ReadOnly = true;
            // 
            // Suma
            // 
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            // 
            // Dydis
            // 
            this.Dydis.HeaderText = "Dydis";
            this.Dydis.Name = "Dydis";
            this.Dydis.ReadOnly = true;
            // 
            // SiuntimoBudas
            // 
            this.SiuntimoBudas.FormattingEnabled = true;
            this.SiuntimoBudas.Location = new System.Drawing.Point(12, 726);
            this.SiuntimoBudas.Name = "SiuntimoBudas";
            this.SiuntimoBudas.Size = new System.Drawing.Size(268, 24);
            this.SiuntimoBudas.TabIndex = 31;
            this.SiuntimoBudas.SelectedValueChanged += new System.EventHandler(this.SiuntimoBudas_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 663);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Siuntimo išlaidos:";
            // 
            // SiuntimoIs
            // 
            this.SiuntimoIs.Location = new System.Drawing.Point(342, 726);
            this.SiuntimoIs.Name = "SiuntimoIs";
            this.SiuntimoIs.ReadOnly = true;
            this.SiuntimoIs.Size = new System.Drawing.Size(114, 22);
            this.SiuntimoIs.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 798);
            this.Controls.Add(this.SiuntimoIs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SiuntimoBudas);
            this.Controls.Add(this.PirkiniuKrepselis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PavTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.KainaTB);
            this.Controls.Add(this.KainaL);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.PrekiuKatalogas);
            this.Controls.Add(this.UzsakytiBTN);
            this.Controls.Add(this.GalutineSumaTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PridetiIKrepsBTN);
            this.Controls.Add(this.SumaTB);
            this.Controls.Add(this.KiekisTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PirkiniuKrepselis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KiekisTB;
        private System.Windows.Forms.TextBox SumaTB;
        private System.Windows.Forms.Button PridetiIKrepsBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GalutineSumaTB;
        private System.Windows.Forms.Button UzsakytiBTN;
        private System.Windows.Forms.DataGridView PrekiuKatalogas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label KainaL;
        private System.Windows.Forms.TextBox KainaTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PavTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView PirkiniuKrepselis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavadinimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiekis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dydis;
        private System.Windows.Forms.ComboBox SiuntimoBudas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SiuntimoIs;
    }
}

