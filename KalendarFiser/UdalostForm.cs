using System;
using System.Drawing;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UdalostForm : Form
    {

        public UdalostForm()
        {
            InitializeComponent();
        }

        public void PrednastavUdalost(DateTime datum)
        {
            dateTimePicker.Value = datum;
        }

        private void UdalostForm_Load(object sender, EventArgs e)
        {
            txtBoxHodiny.Text = "13";
            txtBoxMinuty.Text = "30";
            this.Text += dateTimePicker.Text;
        }

        private void KontrolaTxtBoxHodinyMinuty(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtBoxHodiny.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Zadejte platné číslo pro hodiny.","Neplatná hodnota času", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxHodiny.Text = "13";
            }

            try
            {
                Convert.ToInt32(txtBoxMinuty.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Zadejte platné číslo pro minuty.", "Neplatná hodnota času", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxMinuty.Text = "00";
            }
        }

        private void BtnUloz_Click(object sender, EventArgs e)
        {
            string nazev = txtBoxNazev.Text.Split('\n')[0];
            Label lblUdalost = new Label();
            lblUdalost.Text = nazev;
            lblUdalost.Font =  new Font("Segoe UI", 12, FontStyle.Regular);
            lblUdalost.ForeColor = Color.FromArgb(221, 221, 255);



            // TODO: logika pro uložení upomínky události do souboru, který bude načítán při startu aplikace pro zobrazení upomínek.
        }
    }
}
