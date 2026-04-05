using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class DetailDneForm : Form
    {
        private DateTime datum;
        private List<Udalost> vsechnyUdalosti;
        private List<Udalost> pouzeUdalostiDne;
        public DetailDneForm(DateTime datum, List<Udalost> vsechnyUdalosti)
        {
            InitializeComponent();
            this.datum = datum.Date;
            this.vsechnyUdalosti = vsechnyUdalosti;

            NactiDataDne();
        }

        private void NactiDataDne()
        {
            lblUdalostDne.Text += datum.ToString("d. M. yyyy");
            this.Text += datum.ToString("d. M. yyyy");

            pouzeUdalostiDne = vsechnyUdalosti
                .Where(u => u.DatumACas.Date == datum)
                .OrderBy(u => u.DatumACas)
                .ToList();

            listBoxUdalosti.DataSource = null;
            listBoxUdalosti.DataSource = pouzeUdalostiDne;
        }

        private void BtnPridatUdalost_Click(object sender, EventArgs e)
        {
            using (UdalostForm udalostForm = new UdalostForm())
            {
                udalostForm.PrednastavUdalost(datum);

                if (udalostForm.ShowDialog() == DialogResult.OK)
                {
                    vsechnyUdalosti.Add(udalostForm.Udalost);
                    NactiDataDne();
                }
            }
        }
    }
}
