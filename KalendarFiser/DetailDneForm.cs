using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DetailDneForm : Form
    {
        private readonly DateTime datum;
        private readonly List<Udalost> vsechnyUdalosti;
        private List<Udalost> pouzeUdalostiDne;
        private readonly List<Poznamka> vsechnyPoznamky;
        public DetailDneForm(DateTime datum, List<Udalost> vsechnyUdalosti, List<Poznamka> vsechnyPoznamky)
        {
            InitializeComponent();
            this.datum = datum.Date;
            this.vsechnyUdalosti = vsechnyUdalosti;
            this.vsechnyPoznamky = vsechnyPoznamky;

            ObnovSeznamUdalosti();
            NactiPoznamku();
        }

        private void NactiPoznamku()
        {
            Poznamka poznamkaDne = vsechnyPoznamky.FirstOrDefault(p => p.Datum.Date == datum.Date);

            if (poznamkaDne is null)
            {
                txtBoxPoznamkaDne.Text = string.Empty;
                return;
            }

            txtBoxPoznamkaDne.Text = poznamkaDne.Text;
        }


        private void BtnUlozitPoznamkuDne_Click(object sender, EventArgs e)
        {
            Poznamka existujiciPoznamka = vsechnyPoznamky.FirstOrDefault(p => p.Datum.Date == datum.Date);

            string textPoznamky = txtBoxPoznamkaDne.Text.Trim();
            if (string.IsNullOrWhiteSpace(textPoznamky))
            {
                if (existujiciPoznamka != null)
                {
                    vsechnyPoznamky.Remove(existujiciPoznamka);
                }

                return;
            }

            if (existujiciPoznamka is null)
            {
                vsechnyPoznamky.Add(new Poznamka(datum, textPoznamky));
            }
            else
            {
                existujiciPoznamka.Text = textPoznamky;
            }

            MessageBox.Show("Poznámka byla uložena.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: uložení do souboru 
        }

        private void ObnovSeznamUdalosti()
        {
            lblUdalostDne.Text = "Události dne " + datum.ToString("d. M. yyyy");
            this.Text = "Podrobnosti pro den " + datum.ToString("d. M. yyyy");

            pouzeUdalostiDne = vsechnyUdalosti
                .Where(u => u.DatumACas.Date == datum)
                .OrderBy(u => u.DatumACas)
                .ToList();

            listBoxUdalosti.DataSource = null;
            listBoxUdalosti.DataSource = pouzeUdalostiDne;
        }

        private void BtnPridatUdalost_Click(object sender, EventArgs e)
        {
            using (UdalostForm udalostForm = new UdalostForm("Uložit událost"))
            {
                udalostForm.PrednastavUdalost(datum);

                if (udalostForm.ShowDialog() == DialogResult.OK)
                {
                    vsechnyUdalosti.Add(udalostForm.Udalost);
                    ObnovSeznamUdalosti();
                }
            }
        }

        private void BtnUpravitUpominku_Click(object sender, EventArgs e)
        {
            Udalost vybranaUdalost = ZiskejVybranouUdalost();

            if (vybranaUdalost == null)
            {
                MessageBox.Show("Nejprve vyberte událost ze seznamu.", "Není vybraná událost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (UpominkaForm upominkaForm = new UpominkaForm(vybranaUdalost.UpominkaCas, vybranaUdalost.Nazev, vybranaUdalost.UpominkaNastavena))
            {
                if (upominkaForm.ShowDialog() == DialogResult.OK)
                {
                    vybranaUdalost.UpominkaCas = upominkaForm.UpominkaCas;
                    vybranaUdalost.UpominkaNastavena = upominkaForm.UpominkaNastavena;

                    ObnovSeznamUdalosti();
                }
            }
        }

        private void BtnUpravitUdalost_Click(object sender, EventArgs e)
        {
            Udalost vybranaUdalost = ZiskejVybranouUdalost();

            if (vybranaUdalost == null)
            {
                MessageBox.Show("Nejprve vyberte událost ze seznamu.", "Není vybraná událost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using(UdalostForm udalostForm = new UdalostForm("Upravit událost"))
            {
                udalostForm.NactiUdalost(vybranaUdalost);

                if (udalostForm.ShowDialog() == DialogResult.OK)
                {
                    ObnovSeznamUdalosti();
                }
            }
        }

        private void BtnSmazat_Click(object sender, EventArgs e)
        {
            Udalost vybranaUdalost = ZiskejVybranouUdalost();

            if (vybranaUdalost == null)
            {
                MessageBox.Show("Nejprve vyberte událost ze seznamu.", "Není vybraná událost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult vysledek = MessageBox.Show($"Opravdu chcete smazat událost '{vybranaUdalost.Nazev}'?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vysledek == DialogResult.Yes)
            {
                vsechnyUdalosti.Remove(vybranaUdalost);
                ObnovSeznamUdalosti();
            }
        }

        private Udalost ZiskejVybranouUdalost()
        {
            return listBoxUdalosti.SelectedItem as Udalost;
        }
    }
}
