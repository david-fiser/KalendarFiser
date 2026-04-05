using System;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UpominkaForm : Form
    {
        public DateTime UpominkaCas { get; private set; }
        public bool UpominkaNastavena { get; private set; }
        public UpominkaForm(DateTime vychoziCasUpominky, string nazev, bool upominkaNastavena)
        {
            InitializeComponent();

            dateTimePicker.Value = vychoziCasUpominky.Date;
            txtBoxHodiny.Text = vychoziCasUpominky.Hour.ToString("00");
            txtBoxMinuty.Text = vychoziCasUpominky.Minute.ToString("00");
            txtBoxNazev.Text = nazev;

            checkBoxUpominka.Checked = !upominkaNastavena;

            AktualizujEnabledPrvku();
        }

        private void CheckBoxUpominka_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujEnabledPrvku();
        }

        private void AktualizujEnabledPrvku()
        {
            bool enabled = !checkBoxUpominka.Checked;

            dateTimePicker.Enabled = enabled;
            txtBoxHodiny.Enabled = enabled;
            txtBoxMinuty.Enabled = enabled;
        }

        private void BtnUloz_Click(object sender, EventArgs e)
        {
            UpominkaNastavena = !checkBoxUpominka.Checked;

            if (!UpominkaNastavena)
            {
                UpominkaCas = dateTimePicker.Value.Date.AddHours(12).AddMinutes(0);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            if (!int.TryParse(txtBoxHodiny.Text, out int hodiny) || hodiny < 0 || hodiny > 23)
            {
                MessageBox.Show(
                    "Zadejte platné hodiny (0–23).",
                    "Neplatná hodnota hodin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBoxMinuty.Text, out int minuty) || minuty < 0 || minuty > 59)
            {
                MessageBox.Show(
                    "Zadejte platné minuty (0–59).",
                    "Neplatná hodnota minut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            UpominkaCas = dateTimePicker.Value.Date.AddHours(hodiny).AddMinutes(minuty);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
