using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniParduotuve
{
    public partial class Form1 : Form
    {
        private List<Preke> VisosPrekes;

        public Form1()
        {
            InitializeComponent();
            VisosPrekes = new List<Preke>();
            LoadPrekes();
            SiuntimoIslaidos();
            
        }

        private void LoadPrekes()
        {
            StreamReader reader = new StreamReader("Duomenys.csv");
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                Preke preke = new Preke { Pavadinimas = data[0], Kaina = double.Parse(data[1]), Dydis = data[2] };
                VisosPrekes.Add(preke);
            }
            PrekiuKatalogas.DataSource = VisosPrekes;
            reader.Close();

        }

        private void PrekiuKatalogas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var eilute = ((DataGridView)sender).SelectedRows[0];
            PavTB.Text = eilute.Cells["Pavadinimas"].Value.ToString();
            KainaTB.Text = eilute.Cells["Kaina"].Value.ToString();
            label10.Text = eilute.Cells["Dydis"].Value.ToString();
        }

        private void KiekisTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsNumber(chr) && !char.IsControl(chr))
            {
                e.Handled = true;
            }
        }

        private void KiekisTB_TextChanged(object sender, EventArgs e)
        {
            if (KainaTB.Text != "")
            {
                if (KiekisTB.Text != "")
                {
                    double kaina = Convert.ToDouble(KainaTB.Text);
                    double kiekis = Convert.ToDouble(KiekisTB.Text);
                    string dydis = PrekiuKatalogas.SelectedRows[0].Cells["Dydis"].Value.ToString();
                    double suma = kiekis * kaina;
                    if (dydis == "M")
                    {
                        suma += kiekis * 1;
                    }
                    else if (dydis == "L")
                    {
                        suma += kiekis * 2;
                    }
                    SumaTB.Text = suma.ToString();
                }
            }
            else
            {
                KiekisTB.Clear();
                label11.Text = "Pasirinkite prekę";
                label11.ForeColor = Color.Red;
            }
            label13.Text = "";
        }

        private void KainaTB_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void PridetiIKrepsBTN_Click(object sender, EventArgs e)
        {
            
            if (KiekisTB.Text != "" && PavTB.Text != "")
            {
                string pavadinimas = PavTB.Text;
                string kaina = KainaTB.Text;
                string kiekis = KiekisTB.Text;
                string suma = SumaTB.Text;
                string dydis = label10.Text;
                string[] eile = { pavadinimas, kaina, kiekis, suma, dydis };
                PirkiniuKrepselis.Rows.Add(eile);

                Siuntos();

                PavTB.Text = string.Empty;
                KainaTB.Text = string.Empty;
                KiekisTB.Text = string.Empty;
                SumaTB.Text = string.Empty;
                label11.Text = "";
            }
            else if (KiekisTB.Text == "")
            {
                label13.Text = "Pasirinkite kiekį";
                label13.ForeColor = Color.Red;
                if (PavTB.Text == "")
                {
                    label11.Text = "Pasirinkite prekę";
                    label11.ForeColor = Color.Red;
                }
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (PirkiniuKrepselis.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Ar tikrai norite ištrinti?", "Trinti", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    double suma = Convert.ToDouble(PirkiniuKrepselis.SelectedRows[0].Cells["Suma"].Value.ToString());
                    string dydis = PirkiniuKrepselis.SelectedRows[0].Cells["Dydis"].Value.ToString();
                    double kiekis = Convert.ToDouble(PirkiniuKrepselis.SelectedRows[0].Cells["Kiekis"].Value.ToString());
                    double galSum = Convert.ToDouble(GalutineSumaTB.Text);

                    if (dydis == "M")
                    {
                        galSum -= kiekis * 1;
                    }
                    else if (dydis == "L")
                    {
                        galSum -= kiekis * 2;
                    }
                    galSum -= suma;
                    GalutineSumaTB.Text = galSum.ToString();

                    foreach (DataGridViewRow row in PirkiniuKrepselis.SelectedRows)
                    {
                        PirkiniuKrepselis.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else if (PirkiniuKrepselis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite prekę kurią norite ištrinti");
            }
        }

        public void SiuntimoIslaidos()
        { 
            SiuntimoBudas.Items.Add("Pristatymas į namus per paštą : 1.99");
            SiuntimoBudas.Items.Add("Pristatymas į namus per kurjerių tarnybą: 3.49");
            SiuntimoBudas.Items.Add("Atsiėmimas paštomate : 2.99");
            SiuntimoBudas.Items.Add("Tarptautinis siuntimas : 15.99");
        }

        private string Siuntos()
        {
            GalutineSumaTB.Text = (Convert.ToDouble(GalutineSumaTB.Text) + Convert.ToDouble(SumaTB.Text)).ToString();
            double galutineSuma = Convert.ToDouble(GalutineSumaTB.Text);
            GalutineSumaTB.Text = galutineSuma.ToString();
            return GalutineSumaTB.Text;
        }

        private void SiuntimoBudas_SelectedValueChanged(object sender, EventArgs e)
        {
            double siuntimo = 0.0;

            if (SiuntimoBudas.SelectedItem == "Pristatymas į namus per paštą : 1.99")
            {
                siuntimo += 1.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Pristatymas į namus per kurjerių tarnybą: 3.49")
            {
                siuntimo = 0;
                siuntimo += 3.49;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Atsiėmimas paštomate : 2.99")
            {
                siuntimo = 0;
                siuntimo += 2.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Tarptautinis siuntimas : 15.99")
            {
                siuntimo = 0;
                siuntimo += 15.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
        }

        private void UzsakytiBTN_Click(object sender, EventArgs e)
        {

            if (GalutineSumaTB.Text != "0.00" && SiuntimoIs.Text != "")
            {
                double galutineSuma = Convert.ToDouble(GalutineSumaTB.Text);
                double siuntosIs = Convert.ToDouble(SiuntimoIs.Text);

                double uzsakymas = galutineSuma + siuntosIs;

                SiuntimoIs.Text = "";
                GalutineSumaTB.Text = "0.00";

                PirkiniuKrepselis.Rows.Clear();
                SiuntimoBudas.SelectedItem = null;


                MessageBox.Show("Jūsų galutinė užsakymo kaina yra: " + uzsakymas.ToString());
            }
            else if(GalutineSumaTB.Text != "0.00" && SiuntimoIs.Text == "")
            {
                MessageBox.Show("Pasirinkite siuntimo būdą");
            }
            else if (GalutineSumaTB.Text == "0.00" && SiuntimoIs.Text != "")
            {
                MessageBox.Show("Pasirinkite norimas užsisakyti prekes");
            }
            else
            {
                MessageBox.Show("Tuščias užsakymas");
            }
        }
    }
}
