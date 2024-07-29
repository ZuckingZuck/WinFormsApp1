namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaka_no = textBox1.Text.ToUpper();
            string arac_km = textBox2.Text;
            Random random = new Random();
            int minValue = 1000;
            int maxValue = 6000;
            int sira_no = random.Next(1000, 6001);
            DateTime now = DateTime.Now;
            MessageBox.Show($"TÜVTÜRK\nAraç Muayene Ýstasyonlarý\n{sira_no}\n{plaka_no}\nAraç Kilometresi: {arac_km}\nTarih/Saat: {now.ToString()}","TÜVTÜRK");

        }
    }
}
