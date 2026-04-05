using System;
using System.Drawing;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DenUserControl : UserControl
    {
        public DateTime Datum { get; private set; }
        public event Action<DateTime> DenKliknut;
        public bool MaPoznamku { get; set; }
        public DenUserControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (MaPoznamku)
            {
                int prumer = 10;
                int odsazeni = 6;
                int x = this.Width - prumer - odsazeni;
                int y = odsazeni;

                e.Graphics.FillEllipse(Brushes.SteelBlue, x, y, prumer, prumer);
            }
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
            DenKliknut?.Invoke(Datum);         
        }

        public void VymazUdalosti()
        {
            fLPUdalosti.Controls.Clear();
        }
    }
}
