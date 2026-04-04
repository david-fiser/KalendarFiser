using System;
using System.Drawing;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DenUserControl : UserControl
    {
        public DateTime Datum { get; private set; }
        public event Action<DateTime> DenKliknut;
        public event Action<Udalost> UdalostKliknuta;
        public DenUserControl()
        {
            InitializeComponent();
        }

        private void DenUserControl_Load(object sender, EventArgs e)
        {

        }

        public void NastavDen(int den, int mesic, int rok)
        {
            Datum = new DateTime(rok, mesic, den);
            lblDen.Text = den.ToString();
        }

        private void DenUserControl_Click(object sender, EventArgs e)
        {
            DenKliknut?.Invoke(Datum);
        }

        public void PridejUdalost(Udalost udalost)
        {
            Label lblUdalost = new Label
            {
                Text = $"{udalost.Nazev}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                BackColor = Color.FromArgb(221, 221, 255),
                Tag = udalost
            };
            lblUdalost.Click += LblUdalost_Click;

            fLPUdalosti.Controls.Add(lblUdalost);
        }

        private void LblUdalost_Click(object sender, EventArgs e)
        {
            if (sender is Label lbl && lbl.Tag is Udalost udalost)
            {
                UdalostKliknuta?.Invoke(udalost);
            }
        }

        public void VymazUdalosti()
        {
            fLPUdalosti.Controls.Clear();
        }
    }
}
