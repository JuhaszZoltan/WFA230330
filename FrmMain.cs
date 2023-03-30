namespace WFA230330
{
    public partial class FrmMain : Form
    {
        public int Keszlet { get; set; } = 0;

        public FrmMain()
        {
            InitializeComponent();
            this.Load += OnFrmMainLoad;
            btnHozzaad.Click += OnBtnHozzaadClick;
        }

        private void OnBtnHozzaadClick(object? sender, EventArgs e)
        {
            int elkeszitett = int.Parse(txtElkeszitett.Text);
            int eladott = int.Parse(txtEladott.Text);

            if ( elkeszitett < 0 || eladott < 0)
                lblHiba.Text = "Negatív számot nem adhat meg!";
            else if (Keszlet + int.Parse(txtElkeszitett.Text) < int.Parse(txtEladott.Text))
                lblHiba.Text = "Túl sok eladott angyalka!";
            else
            {
                rtbKonyveles.Text +=
                    $"{cmbNapSzorszam.Text}. nap:\t" +
                    $"+{txtElkeszitett.Text}\t" +
                    $"-{txtEladott.Text}\t" +
                    $"=\t" +
                    $"{Keszlet}\n";

                Keszlet += elkeszitett - elkeszitett;

                lblHiba.Text = string.Empty;
                txtElkeszitett.Text = "0";
                txtEladott.Text = "0";

                for (int i = cmbNapSzorszam.SelectedIndex; i >= 0; i--)
                    cmbNapSzorszam.Items.RemoveAt(i);
                if (cmbNapSzorszam.Items.Count > 0) cmbNapSzorszam.SelectedIndex = 0;
            }

        }

        private void OnFrmMainLoad(object? sender, EventArgs e)
        {
            for (int i = 1; i <= 40; i++) cmbNapSzorszam.Items.Add(i);
            cmbNapSzorszam.SelectedIndex = 0;
        }
    }
}