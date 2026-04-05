using System;
using System.Linq;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UdalostForm : Form
    {
        public Udalost Udalost { get; set; }
        public bool BylaSmazana { get; private set; }
        private Udalost editovanaUdalost;

        public UdalostForm()
        {
            InitializeComponent();
            btnSmazat.Visible = false;
        }

        public void PrednastavUdalost(DateTime datum)
        {
            dateTimePicker.Value = datum;
        }

        private void UdalostForm_Load(object sender, EventArgs e)
        {
            this.Text += dateTimePicker.Text;
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
                bool upominkaNastavena; 
                DateTime casUpominky = datum.AddMinutes(-30);

                DialogResult vysledek = MessageBox.Show(
                    $"Výchozí čas upomínky bude nastaven na {casUpominky:dd.MM.yyyy HH:mm}. Chcete ho změnit?", 
                    "Nastavení upomínky", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (vysledek == DialogResult.Yes)
                {
                    using (UpominkaForm upominkaForm = new UpominkaForm(casUpominky, nazev))
                    {
                        if (upominkaForm.ShowDialog() == DialogResult.OK)
                        {
                            casUpominky = upominkaForm.UpominkaCas;
                            upominkaNastavena = upominkaForm.UpominkaNastavena;
                        }
                    }
                }
                Udalost = new Udalost
                {
                    DatumACas = datum,
                    Nazev = nazev,
                    Popis = popis,
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
                        using (UpominkaForm upominkaForm = new UpominkaForm(editovanaUdalost.UpominkaCas, editovanaUdalost.Nazev)) 
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

            txtBoxPopis.Text = udalost.Nazev + Environment.NewLine + udalost.Popis;
            dateTimePicker.Value = udalost.DatumACas;
            txtBoxHodiny.Text = udalost.DatumACas.Hour.ToString();
            txtBoxMinuty.Text = udalost.DatumACas.Minute.ToString();

            btnSmazat.Visible = true;
        }

        private void BtnSmazat_Click(object sender, EventArgs e)
        {
            if (editovanaUdalost != null)
            {
                BylaSmazana = true;
                Close();
            }
        }
    }
}
