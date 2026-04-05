using System;
using System.Linq;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UdalostForm : Form
    {
        public Udalost Udalost { get; set; }
        private Udalost editovanaUdalost;

        public UdalostForm(string nazevTlacitka)
        {
            InitializeComponent();
            btnUloz.Text = nazevTlacitka;
        }

        public void PrednastavUdalost(DateTime datum)
        {
            dateTimePicker.Value = datum;
        }

        private void BtnUloz_Click(object sender, EventArgs e)
        {
            string nazev = txtBoxNazev.Text.Trim();
            string popis = txtBoxPopis.Text.Trim();

            if (string.IsNullOrWhiteSpace(nazev))
            {
                MessageBox.Show("Zadejte název události.", "Neplatná hodnota názvu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtBoxHodiny.Text, out int hodiny) || hodiny < 0 || hodiny > 23)
            {
                MessageBox.Show("Zadejte platné hodiny (0–23).", "Neplatná hodnota hodin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBoxMinuty.Text, out int minuty) || minuty < 0 || minuty > 59)
            {
                MessageBox.Show("Zadejte platné minuty (0–59).", "Neplatná hodnota minut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime datum = dateTimePicker.Value.Date.AddHours(hodiny).AddMinutes(minuty);

            if (editovanaUdalost == null)
            {
                bool upominkaNastavena = true; 
                DateTime upominkaCas = datum.AddMinutes(-30);

                DialogResult vysledek = MessageBox.Show(
                    $"Výchozí čas upomínky bude nastaven na {upominkaCas:dd.MM.yyyy HH:mm}. Chcete ho změnit?", 
                    "Nastavení upomínky", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (vysledek == DialogResult.Yes)
                {
                    using (UpominkaForm upominkaForm = new UpominkaForm(upominkaCas, nazev, true))
                    {
                        if (upominkaForm.ShowDialog() == DialogResult.OK)
                        {
                            upominkaCas = upominkaForm.UpominkaCas;
                            upominkaNastavena = upominkaForm.UpominkaNastavena;
                        }
                    }
                }
                Udalost = new Udalost
                {
                    DatumACas = datum,
                    Nazev = nazev,
                    Popis = popis,
                    UpominkaCas = upominkaCas,
                    UpominkaNastavena = upominkaNastavena,
                    UpominkaZobrazena = false
                };
            }
            else
            {
                if (editovanaUdalost.DatumACas != datum)
                {
                    editovanaUdalost.DatumACas = datum;
                    editovanaUdalost.Nazev = nazev;
                    editovanaUdalost.Popis = popis;

                    DialogResult vysledek = MessageBox.Show(
                        "Chcete upravit nastavení upomínky této události?",
                        "Úprava upomínky",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (vysledek == DialogResult.Yes)
                    {
                        using (UpominkaForm upominkaForm = new UpominkaForm(editovanaUdalost.UpominkaCas, editovanaUdalost.Nazev, editovanaUdalost.UpominkaNastavena)) 
                        {
                            if (upominkaForm.ShowDialog() == DialogResult.OK)
                            {
                                editovanaUdalost.UpominkaCas = upominkaForm.UpominkaCas;
                                editovanaUdalost.UpominkaNastavena = upominkaForm.UpominkaNastavena;
                                editovanaUdalost.UpominkaZobrazena = false;
                            }
                        }
                    }
                }
                else
                {
                    editovanaUdalost.DatumACas = datum;
                    editovanaUdalost.Nazev = nazev;
                    editovanaUdalost.Popis = popis;
                }

                Udalost = editovanaUdalost;
            }

            DialogResult = DialogResult.OK;
            Close();



            // TODO: logika pro uložení upomínky události do souboru, který bude načítán při startu aplikace pro zobrazení upomínek.
        }

        public void NactiUdalost(Udalost udalost)
        {
            editovanaUdalost = udalost;

            txtBoxNazev.Text = udalost.Nazev;
            txtBoxPopis.Text = udalost.Popis;
            dateTimePicker.Value = udalost.DatumACas;
            txtBoxHodiny.Text = udalost.DatumACas.Hour.ToString();
            txtBoxMinuty.Text = udalost.DatumACas.Minute.ToString();
        }
    }
}
