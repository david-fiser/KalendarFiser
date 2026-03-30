using System;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DenUserControl : UserControl
    {
        public DenUserControl()
        {
            InitializeComponent();
        }

        private void DenUserControl_Load(object sender, EventArgs e)
        {

        }

        public void Dny(int cisloDne)
        {
            lblDen.Text = cisloDne.ToString();
        }

        private void DenUserControl_Click(object sender, EventArgs e)
        {
            UdalostForm udalostForm = new UdalostForm();
            udalostForm.Show();
        }
    }
}
