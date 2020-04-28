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
        }

        private void LoadPrekes()
        {
            StreamReader reader = new StreamReader("Duomenys.csv");
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                Preke preke = new Preke(data[0], double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]));
                VisosPrekes.Add(preke);
            }
            PrekiuKatalogas.DataSource = VisosPrekes;
            reader.Close();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Veikia",label10);
        }
    }
}
