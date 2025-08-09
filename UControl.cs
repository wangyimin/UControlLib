using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UControlLib
{
    public partial class UControl: UserControl
    {
        public string LableText { get; set; } = "Area";
        public bool NeedBlankOption { get; set; } = false;
        public string SelectedValue 
        { 
            get { return cboChiku.SelectedValue?.ToString(); } 
            set { if (cboChiku.DataSource != null) cboChiku.SelectedValue = value;}
        }

        public event EventHandler SelectedIndexChanged;

        public UControl()
        {
            InitializeComponent();
        }

        private void cboChiku_SelectedIndexChanged(object sender, EventArgs e) => SelectedIndexChanged?.Invoke(this, e);
        
        private void UControl_Load(object sender, EventArgs e)
        {
            lblChiku.Text = LableText;

            Task<DataTable> t = Task.Run(() =>
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("K", typeof(string));
                dt.Columns.Add("V", typeof(string));

                if (NeedBlankOption)
                {
                    dt.Rows.Add("", "");
                }
                dt.Rows.Add("01", "East");
                dt.Rows.Add("02", "West");

                return dt;
            });

            t.ContinueWith((cont) =>
            {
                if (cont.IsFaulted)
                {
                    MessageBox.Show("Initialization error: " + cont.Exception?.GetBaseException().Message);
                    return;
                }
                cboChiku.SelectedIndexChanged -= cboChiku_SelectedIndexChanged;
                cboChiku.DataSource = cont.Result;
                cboChiku.DisplayMember = "V";
                cboChiku.ValueMember = "K";
                cboChiku.SelectedIndexChanged += cboChiku_SelectedIndexChanged;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
