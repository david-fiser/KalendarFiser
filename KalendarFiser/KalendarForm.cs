using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class KalendarForm : Form
    {

        public Mesic Mesic { get; set; }
        public int Rok { get; set; }

        private readonly Dictionary<DateTime, DenUserControl> slovnikDatumUserControl = new Dictionary<DateTime, DenUserControl>();
        private readonly List<Udalost> udalosti = new List<Udalost>();

        public KalendarForm()
        {
            InitializeComponent();
        }

        private void KalendarForm_Load(object sender, EventArgs e)
        {
            NactiAktualniMesic();
        }

        private void NactiDny(Mesic mesic, int rok)
        {
            slovnikDatumUserControl.Clear();
            lblMesicRok.Text = $"{mesic} {rok}";
            DateTime zacatekMesice = new DateTime(rok, mesic, 1);

            int dny = DateTime.DaysInMonth(rok, mesic);

            int denVTydnu = (int)zacatekMesice.DayOfWeek;

            // Přepočet na český formát data
            if (denVTydnu == 0)
            {
                denVTydnu = 6; // Neděle je poslední den v týdnu, takže se posune na index 6
            }
            else
            {
                denVTydnu -= 1; // Zbytek dní se posune o jeden index zpět, protože pondělí je první den v týdnu
            }

            for (int i = 0; i < denVTydnu; i++)
            {
                PrazdnyUserControl prazdnyUC = new PrazdnyUserControl();
                flowLayoutPanel.Controls.Add(prazdnyUC);
            }

            for (int i = 1; i <= dny; i++)
            {
                DenUserControl denUC = new DenUserControl();
                denUC.NastavDen(i, mesic, rok);
                denUC.DenKliknut += OtevriUdalostForm;
                denUC.UdalostKliknuta += OtevriSpravuUdalostiForm;

                flowLayoutPanel.Controls.Add(denUC);
                slovnikDatumUserControl.Add(denUC.Datum.Date, denUC);

                if (denUC.Datum.Date == DateTime.Today)
                {
                    denUC.BackColor = Color.SeaShell;
                    denUC.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        private void OtevriSpravuUdalostiForm(Udalost udalost)
        {
            using (UdalostForm udalostForm = new UdalostForm())
            {
                udalostForm.NactiUdalost(udalost);

                if (udalostForm.ShowDialog() == DialogResult.OK)
                {
                    ObnovZobrazeniMesice();
                }
                else if (udalostForm.BylaSmazana)
                {
                    udalosti.Remove(udalost);
                    ObnovZobrazeniMesice();
                }
            }
        }

        private void OtevriUdalostForm(DateTime datum)
        {
            using (UdalostForm udalostForm = new UdalostForm())
            {
                udalostForm.PrednastavUdalost(datum);

                if (udalostForm.ShowDialog() == DialogResult.OK)
                {
                    Udalost novaUdalost = udalostForm.Udalost;
                    udalosti.Add(novaUdalost);

                    if (slovnikDatumUserControl.TryGetValue(novaUdalost.DatumACas.Date, out DenUserControl shodnyDenUC))
                    {
                        shodnyDenUC.PridejUdalost(novaUdalost);
                    }
                }
            }
        }

        private void ObnovZobrazeniMesice()
        {
            flowLayoutPanel.Controls.Clear();
            slovnikDatumUserControl.Clear();

            NactiDny(Mesic, Rok);

            foreach (Udalost udalost in udalosti)
            {
                if (slovnikDatumUserControl.TryGetValue(udalost.DatumACas.Date, out DenUserControl dayControl))
                {
                    dayControl.PridejUdalost(udalost);
                }
            }
        }

        private void NactiAktualniMesic()
        {
            DateTime now = DateTime.Now;
            Mesic = now.Month;
            Rok = now.Year;

            ObnovZobrazeniMesice();
        }

        private void BtnNadchazejici_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            Mesic++;

            if (Mesic == 1)
            {
                Rok++; 
            }

            ObnovZobrazeniMesice();
        }

        private void BtnPredchozi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            Mesic--;

            if (Mesic == 12)
            {
                Rok--;
            }

            ObnovZobrazeniMesice();
        }

        private void ZobrazUpominku()
        {
            // TODO: Zobrazení upomínky na událost ve zvoleném čase. Kontrola ze souboru upomínek po nastartování aplikace.
            string tempImagePath = Path.Combine(Path.GetTempPath(), "KalendarIcon.png");

            if (!File.Exists(tempImagePath))
            {
                Properties.Resources.calendar.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);
            }

            new ToastContentBuilder()
                .AddText($"Upomínka v čase xx:xx")
                .AddText($"Popis upomínky.")
                .AddAppLogoOverride(new Uri("file:///" + tempImagePath), ToastGenericAppLogoCrop.Default)
                .Show();
        }
    }
}
