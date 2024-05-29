
namespace BatteryChecker_v2
{
    public partial class Form1 : Form
    {
        public elements elementos = new elements();
        public battery bateria = new battery();

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(400, 300);

            bateria.events();
            label1.Text = bateria.responses_battery;
            int b1 = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);
            label3.Text = b1.ToString();
            progressBar1.Value = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //elementos.training();

            bateria.events();
            label1.Text = bateria.responses_battery;
            int b1 = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);
            label3.Text = b1.ToString();
            progressBar1.Value = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);
            elementos.recognize(b1);
            label4.Text = elementos.texto;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}