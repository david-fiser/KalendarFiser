using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace KalendarFiser
{
    public partial class KalendarForm : Form
    {

        private Mesic Mesic { get; set; }
        private int Rok { get; set; }

        private readonly Dictionary<DateTime, DenUserControl> slovnikDatumUserControl = new Dictionary<DateTime, DenUserControl>();
        private List<Udalost> udalosti = new List<Udalost>();
        private List<Poznamka> poznamky = new List<Poznamka>();
        private readonly string cestaKSouboru = Path.Combine(Application.StartupPath, "data.json");

        public KalendarForm()
        {
            InitializeComponent();
        }

        private void KalendarForm_Load(object sender, EventArgs e)
        {
            NactiData();
            NactiAktualniMesic();
            InicializujTimerUpominek();
            InicializujNotifikaciUpominek();
        }

        private void NactiData()
        {
            try
            {
                if (!File.Exists(cestaKSouboru))
                {
                    udalosti = new List<Udalost>();
                    poznamky = new List<Poznamka>();
                    return;
                }

                string json = File.ReadAllText(cestaKSouboru);

                if (string.IsNullOrWhiteSpace(json))
                {
                    udalosti = new List<Udalost>();
                    poznamky = new List<Poznamka>();
                    return;
                }

                DataModel data = JsonSerializer.Deserialize<DataModel>(json);

                udalosti = data?.Udalosti ?? new List<Udalost>();
                poznamky = data?.Poznamky ?? new List<Poznamka>();
            }
            catch (Exception ex)
            {
                udalosti = new List<Udalost>();
                poznamky = new List<Poznamka>();

                MessageBox.Show(
                    "Nepodařilo se načíst data. Zobrazí se prázdný kalendář.\n\nChyba: " + ex.Message,
                    "Chyba načítání dat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void UlozData()
        {
            try
            {
                DataModel data = new DataModel
                {
                    Udalosti = udalosti,
                    Poznamky = poznamky
                };

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(cestaKSouboru, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Nepodařilo se uložit data. Zobrazí se prázdný kalendář.\n\nChyba: " + ex.Message,
                    "Chyba ukládání dat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void InicializujTimerUpominek()
        {
            timer.Start();
        }

        private void InicializujNotifikaciUpominek()
        {
            notifyIcon.Icon = SystemIcons.Information;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ZkontrolujUpominky();
        }

        private void ZkontrolujUpominky()
        {
            DateTime ted = DateTime.Now;

            List<Udalost> udalostiKUpozorneni = udalosti
                .Where(u =>
                    u.UpominkaNastavena &&
                    !u.UpominkaZobrazena &&
                    u.UpominkaCas <= ted)
                .OrderBy(u => u.UpominkaCas)
                .ToList();

            if (udalostiKUpozorneni.Count > 1)
            {
                string text = string.Join("\n", udalostiKUpozorneni.Select(u => u.Nazev));

                ZobrazNotifikaci("Upomínky pro události", text);

                foreach (var u in udalostiKUpozorneni)
                {
                    u.UpominkaZobrazena = true;
                }
                UlozData();
            }
            else if (udalostiKUpozorneni.Count == 1)
            {
                Udalost u = udalostiKUpozorneni[0];

                ZobrazNotifikaci("Upomínka pro událost", $"{u.Nazev}\n\n{u.DatumACas:dd.MM.yyyy HH:mm}");

                u.UpominkaZobrazena = true;
                UlozData();
            }
            else if (udalostiKUpozorneni.Count <= 0)
            {
                return;
            }
        }
        private void ZobrazNotifikaci(string title, string text)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = text;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(5000);
        }

        private void NactiDny(Mesic mesic, int rok)
        {
            slovnikDatumUserControl.Clear();
            lblMesicRok.Text = $"{mesic} {rok}";
            DateTime zacatekMesice = new DateTime(rok, mesic, 1);

            int dny = DateTime.DaysInMonth(rok, mesic);

            int zacatekMesiceDenVTydnu = (int)zacatekMesice.DayOfWeek;

            // Přepočet na český formát data
            if (zacatekMesiceDenVTydnu == 0)
            {
                zacatekMesiceDenVTydnu = 6; // Neděle je poslední den v týdnu, takže se posune na index 6
            }
            else
            {
                zacatekMesiceDenVTydnu -= 1; // Zbytek dní se posune o jeden index zpět, protože pondělí je první den v týdnu
            }

            for (int i = 0; i < zacatekMesiceDenVTydnu; i++)
            {
                PrazdnyUserControl prazdnyUC = new PrazdnyUserControl();
                flowLayoutPanel.Controls.Add(prazdnyUC);
            }

            for (int i = 1; i <= dny; i++)
            {
                DenUserControl denUC = new DenUserControl();
                denUC.NastavDen(i, mesic, rok);
                denUC.DenKliknut += OtevriDetailDneForm;
                denUC.MaPoznamku = poznamky.Any(p => p.Datum.Date == denUC.Datum.Date);

                flowLayoutPanel.Controls.Add(denUC);
                slovnikDatumUserControl.Add(denUC.Datum.Date, denUC);

                if (denUC.Datum.Date == DateTime.Today)
                {
                    denUC.BackColor = Color.SeaShell;
                    denUC.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        private void OtevriDetailDneForm(DateTime datum)
        {
            using (DetailDneForm detailDneForm = new DetailDneForm(datum, udalosti, poznamky))
            {
                detailDneForm.ShowDialog();
                UlozData();
                ObnovZobrazeniMesice();
            }
        }

        public void ObnovZobrazeniMesice()
        {
            flowLayoutPanel.Controls.Clear();
            slovnikDatumUserControl.Clear();

            NactiDny(Mesic, Rok);

            foreach (Udalost udalost in udalosti.OrderBy(u => u.DatumACas))
            {
                if (slovnikDatumUserControl.TryGetValue(udalost.DatumACas.Date, out DenUserControl shodnyDenUC))
                {
                    shodnyDenUC.PridejUdalost(udalost);
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
            Mesic++;

            if (Mesic == 1)
            {
                Rok++; 
            }

            ObnovZobrazeniMesice();
        }

        private void BtnPredchozi_Click(object sender, EventArgs e)
        {
            Mesic--;

            if (Mesic == 12)
            {
                Rok--;
            }

            ObnovZobrazeniMesice();
        }
    }
}
