using System;
using System.Windows.Forms;

namespace KalendarFiser
{
    public partial class UdalostForm : Form
    {
        public UdalostForm()
        {
            InitializeComponent();
        }

        public void NastavUdalost(DateTime datum)
        {
            dateTimePicker.Value = datum;
        }

        private void UdalostForm_Load(object sender, EventArgs e)
        {
            txtBoxHodiny.Text = "13";
            txtBoxMinuty.Text = "30";
        }
    }
}
