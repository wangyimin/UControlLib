using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UForm
{
    public partial class UForm : Form
    {
        public UForm()
        {
            InitializeComponent();
            uc.NeedBlankOption = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            uc.SelectedValue = "01";
        }

        private void uc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trace.WriteLine($"Selected Value: {uc.SelectedValue}");
        }
    }
}
