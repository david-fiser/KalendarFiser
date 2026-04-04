using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.IO;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class KalendarForm : Form
    {

        public Mesic Mesic { get; set; }
        public int Rok { get; set; }

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
            lblMesicRok.Text = $"{mesic} {rok}";
            DateTime zacatekMesice = new DateTime(rok, mesic, 1);

            int dny = DateTime.DaysInMonth(rok, mesic);

            int denVTydnu = (int)zacatekMesice.DayOfWeek;

            // Přepočet na český týden (Pondělí = 0, Neděle = 6)
            if (denVTydnu == 0)
            {
                denVTydnu = 6; // Neděle se posune na konec týdne
            }
            else
            {
                denVTydnu -= 1; // Ostatní dny se posunou o jeden den zpět
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
                flowLayoutPanel.Controls.Add(denUC);
            }
        }

        private void NactiAktualniMesic()
        {
            DateTime now = DateTime.Now;
            Mesic = now.Month;
            Rok = now.Year;

            NactiDny(Mesic, Rok);            
        }

        private void BtnNadchazejici_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            Mesic++;

            NactiDny(Mesic, Rok);
        }

        private void BtnPredchozi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            Mesic--;

            NactiDny(Mesic, Rok);
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
