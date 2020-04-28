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
            this.PirkiniuKrepselisView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.SiuntimoBudas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GalutineSumaTB = new System.Windows.Forms.TextBox();
            this.UzsakytiBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PrekiuKatalogas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasirinkite preke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiekis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma:";
            // 
            // KiekisTB
            // 
            this.KiekisTB.Location = new System.Drawing.Point(15, 366);
            this.KiekisTB.Name = "KiekisTB";
            this.KiekisTB.Size = new System.Drawing.Size(100, 22);
            this.KiekisTB.TabIndex = 4;
            // 
            // SumaTB
            // 
            this.SumaTB.Location = new System.Drawing.Point(192, 366);
            this.SumaTB.Name = "SumaTB";
            this.SumaTB.Size = new System.Drawing.Size(100, 22);
            this.SumaTB.TabIndex = 5;
            // 
            // PridetiIKrepsBTN
            // 
            this.PridetiIKrepsBTN.Location = new System.Drawing.Point(511, 333);
            this.PridetiIKrepsBTN.Name = "PridetiIKrepsBTN";
            this.PridetiIKrepsBTN.Size = new System.Drawing.Size(115, 55);
            this.PridetiIKrepsBTN.TabIndex = 6;
            this.PridetiIKrepsBTN.Text = "Pridėti į pirkinių krepšelį";
            this.PridetiIKrepsBTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pirkinių krepšelis:";
            // 
            // PirkiniuKrepselisView
            // 
            this.PirkiniuKrepselisView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.PirkiniuKrepselisView.HideSelection = false;
            this.PirkiniuKrepselisView.Location = new System.Drawing.Point(15, 449);
            this.PirkiniuKrepselisView.Name = "PirkiniuKrepselisView";
            this.PirkiniuKrepselisView.Size = new System.Drawing.Size(611, 196);
            this.PirkiniuKrepselisView.TabIndex = 8;
            this.PirkiniuKrepselisView.UseCompatibleStateImageBehavior = false;
            this.PirkiniuKrepselisView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pavadinimas";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kaina";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiekis";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Suma";
            this.columnHeader4.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pasirinkite kaip atsiimsite siuntą:";
            // 
            // SiuntimoBudas
            // 
            this.SiuntimoBudas.FormattingEnabled = true;
            this.SiuntimoBudas.Location = new System.Drawing.Point(15, 702);
            this.SiuntimoBudas.Name = "SiuntimoBudas";
            this.SiuntimoBudas.Size = new System.Drawing.Size(290, 24);
            this.SiuntimoBudas.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 664);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Galutinė suma:";
            // 
            // GalutineSumaTB
            // 
            this.GalutineSumaTB.Location = new System.Drawing.Point(336, 702);
            this.GalutineSumaTB.Name = "GalutineSumaTB";
            this.GalutineSumaTB.Size = new System.Drawing.Size(100, 22);
            this.GalutineSumaTB.TabIndex = 12;
            // 
            // UzsakytiBTN
            // 
            this.UzsakytiBTN.Location = new System.Drawing.Point(511, 667);
            this.UzsakytiBTN.Name = "UzsakytiBTN";
            this.UzsakytiBTN.Size = new System.Drawing.Size(115, 59);
            this.UzsakytiBTN.TabIndex = 13;
            this.UzsakytiBTN.Text = "Užsakyti";
            this.UzsakytiBTN.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maža prekė: papildomas mokestis netaikomas";
            // 
            // PrekiuKatalogas
            // 
            this.PrekiuKatalogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrekiuKatalogas.Location = new System.Drawing.Point(15, 121);
            this.PrekiuKatalogas.Name = "PrekiuKatalogas";
            this.PrekiuKatalogas.RowTemplate.Height = 24;
            this.PrekiuKatalogas.Size = new System.Drawing.Size(662, 196);
            this.PrekiuKatalogas.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vidutinė prekė: +1Euras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Didelė prekė:  +2Eurai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dydžiai:";
            this.label10.MouseHover += new System.EventHandler(this.label10_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 762);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrekiuKatalogas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UzsakytiBTN);
            this.Controls.Add(this.GalutineSumaTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SiuntimoBudas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PirkiniuKrepselisView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PridetiIKrepsBTN);
            this.Controls.Add(this.SumaTB);
            this.Controls.Add(this.KiekisTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).EndInit();
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
        private System.Windows.Forms.ListView PirkiniuKrepselisView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SiuntimoBudas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GalutineSumaTB;
        private System.Windows.Forms.Button UzsakytiBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView PrekiuKatalogas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

