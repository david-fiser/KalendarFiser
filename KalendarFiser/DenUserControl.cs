using System;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DenUserControl : UserControl
    {
        private DateTime datum;
        public DenUserControl()
        {
            InitializeComponent();
        }

        private void DenUserControl_Load(object sender, EventArgs e)
        {

        }

        public void NastavDen(int den, int mesic, int rok)
        {
            datum = new DateTime(rok, mesic, den);
            lblDen.Text = den.ToString();
        }

        private void DenUserControl_Click(object sender, EventArgs e)
        {
            UdalostForm udalostForm = new UdalostForm();
            udalostForm.NastavUdalost(datum);
            udalostForm.Show();
        }
    }
}
