using System;
using System.Linq;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UdalostForm : Form
    {
        public Udalost Udalost { get; set; }
        public Udalost VytvorenaUdalost { get; private set; }
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

            string[] radky = txtBoxNazev.Text
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            string nazev = radky[0];
            string popis = radky.Length > 1 ? string.Join(Environment.NewLine, radky.Skip(1)) : "";

            DateTime datum = dateTimePicker.Value.Date
                .AddHours(hodiny)
                .AddMinutes(minuty);

            if (editovanaUdalost == null)
            {
                Udalost = new Udalost
                {
                    DatumACas = datum,
                    Nazev = nazev,
                    Popis = popis
                };
            }
            else
            {
                editovanaUdalost.DatumACas = datum;
                editovanaUdalost.Nazev = nazev;
                editovanaUdalost.Popis = popis;
            }

            DialogResult = DialogResult.OK;
            Close();



            // TODO: logika pro uložení upomínky události do souboru, který bude načítán při startu aplikace pro zobrazení upomínek.
        }

        public void NactiUdalost(Udalost udalost)
        {
            editovanaUdalost = udalost;

            txtBoxNazev.Text = udalost.Nazev + Environment.NewLine + udalost.Popis;
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
