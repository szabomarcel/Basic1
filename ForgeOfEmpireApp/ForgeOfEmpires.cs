using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeOfEmpireApp
{
    public partial class FOE : Form
    {
        private double szorzo = 1.9;
        public FOE()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        } 

        private void btnFphelyfoglalas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TBHely.Text, out double szam1))
            {
                double eredmeny = Math.Ceiling(szam1 * szorzo);
                TBHely.Text = $"Eredmény: {eredmeny}";
            }
            else
            {
                MessageBox.Show("Hibás adatbevitel! Kérlek, számot adj meg.");
            }
        }

        private double osszegzettEredmeny = 0;

        private void btnKivonas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TBNevifp.Text, out double fp))
            {
                double teljesEredmeny = fp - osszegzettEredmeny;
                TBVegkiszamolt.Text = $"Őnerő amit BE kell rakj a nevidbe: {teljesEredmeny}";
            }
            else
            {
                MessageBox.Show("Hibás adatbevitel! Kérlek, számokat adj meg.");
            }
        }

        private void btnOsszead_Click(object sender, EventArgs e)
        {
            try
            {
                double elso = Math.Ceiling(ExtractNumber(TB6.Text));
                double masodik = Math.Ceiling(ExtractNumber(TB7.Text));
                double harmadik = Math.Ceiling(ExtractNumber(TB8.Text));
                double negyedik = Math.Ceiling(ExtractNumber(TB9.Text));
                double otodik = Math.Ceiling(ExtractNumber(TB10.Text));

                osszegzettEredmeny = elso + masodik + harmadik + negyedik + otodik;
                TB11.Text = $"Összeadot nevik helye: {osszegzettEredmeny}";
            }
            catch
            {
                MessageBox.Show("Hibás adatbevitel! Kérlek, számokat adj meg.");
            }
        }

        private double ExtractNumber(string input)
        {
            // Ellenőrzi, hogy tartalmaz-e számot a szöveg
            string szam = new string(input.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());

            if (double.TryParse(szam, out double eredmeny))
            {
                return eredmeny;
            }
            else
            {
                throw new FormatException("Nem sikerült számot kinyerni a szövegből.");
            }
        }

        private void btnSajat_Click(object sender, EventArgs e)
        {
            bool validInput = false;
            if (double.TryParse(TB1.Text, out double szam1))
            {
                double eredmeny = szam1 * szorzo;
                TB6.Text = $"Eredmény: {eredmeny}";
                validInput = true;
            }

            if (double.TryParse(TB2.Text, out double szam2))
            {
                double eredmeny = szam2 * szorzo;
                TB7.Text = $"Eredmény: {eredmeny}";
                validInput = true;
            }

            if (double.TryParse(TB3.Text, out double szam3))
            {
                double eredmeny = szam3 * szorzo;
                TB8.Text = $"Eredmény: {eredmeny}";
                validInput = true;
            }

            if (double.TryParse(TB4.Text, out double szam4))
            {
                double eredmeny = szam4 * szorzo;
                TB9.Text = $"Eredmény: {eredmeny}";
                validInput = true;
            }
    
            if (double.TryParse(TB5.Text, out double szam5))
            {
                double eredmeny = szam5 * szorzo;
                TB10.Text = $"Eredmény: {eredmeny}";
                validInput = true;
            }
            if(!validInput)
            {
                MessageBox.Show("Hibás adatbevitel! Kérlek, számot adj meg.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TBHely.Clear();
            TBNevifp.Clear();
            TBVegkiszamolt.Clear();
            TB1.Clear();
            TB2.Clear();
            TB3.Clear();
            TB4.Clear();
            TB5.Clear();
            TB6.Clear();
            TB7.Clear();
            TB8.Clear();
            TB9.Clear();
            TB10.Clear();
            TB11.Clear();
            osszegzettEredmeny = 0;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                btnSajat_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Add)
            {
                btnOsszead_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btnKivonas_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnReset_Click(sender, e);
            }
        }
    }
}
